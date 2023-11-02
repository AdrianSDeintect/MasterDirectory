using MasterDirectory.Operaciones;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = MasterDirectory.UltimaMilla.CategoriaUltimaMillaRow;

namespace MasterDirectory.UltimaMilla.Endpoints;

[Route("Services/UltimaMilla/CategoriaUltimaMilla/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class CategoriaUltimaMillaEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ICategoriaUltimaMillaSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ICategoriaUltimaMillaSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] ICategoriaUltimaMillaDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] ICategoriaUltimaMillaRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] ICategoriaUltimaMillaListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] ICategoriaUltimaMillaListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.CategoriaUltimaMillaColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "CategoriaUltimaMillaList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request, [FromServices] IUploadStorage uploadStorage, [FromServices] ICategoriaUltimaMillaSaveHandler handler)
    {
        List<int> lstExcel = new List<int>();
        string StrConnectionAct = Convert.ToString(((Serenity.Data.WrappedConnection)((Serenity.Data.UnitOfWork)uow).Connection).ConnectionString);
        if (request == null) throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.FileName)) throw new ArgumentNullException(nameof(request.FileName));
        if (uploadStorage is null) throw new ArgumentNullException(nameof(uploadStorage));
        UploadPathHelper.CheckFileNameSecurity(request.FileName);

        if (!request.FileName.StartsWith("temporary/"))
            throw new ArgumentOutOfRangeException("filename");

        ExcelPackage ep = new ExcelPackage();
        using (var fs = uploadStorage.OpenFile(request.FileName))
            ep.Load(fs);

        var p = MyRow.Fields;

        var response = new ExcelImportResponse();
        response.ErrorList = new List<string>();

        var worksheet = ep.Workbook.Worksheets[0];


        List<string> wsHeaders = new List<string>();
        foreach (var cell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
        {
            wsHeaders.Add(cell.Value.ToString());
        }

        for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
        {
            try
            {
                var Exits = true;

                var LocalSap = (worksheet.Cells[row, 1].Value.ToString().Trim() ?? "");
                if (LocalSap.IsTrimmedEmpty())
                    continue;

                var RowExcel = new MyRow { };
                var RowExist = uow.Connection.TryFirst<MyRow>(q => q.Select(p.LocalSap).Where(p.LocalSap == LocalSap));
                if (RowExist == null) { Exits = false; } else { Exits = true; }

                RowExcel = new MyRow
                {
                    LocalSap = (worksheet.Cells[row, 1].Value.ToString().Trim() ?? ""),
                    Estado = (worksheet.Cells[row, 2].Value.ToString().Trim() ?? ""),
                    Prov99Min = (worksheet.Cells[row, 3].Value.ToString().Trim() ?? ""),
                    ProvMu = (worksheet.Cells[row, 4].Value.ToString().Trim() ?? ""),
                    ProvCid = (worksheet.Cells[row, 5].Value.ToString().Trim() ?? ""),
                    ProvRappiCargo = (worksheet.Cells[row, 6].Value.ToString().Trim() ?? ""),
                    VentaTelf99Min = (worksheet.Cells[row, 7].Value.ToString().Trim() ?? ""),
                    VentaTelfMu = (worksheet.Cells[row, 8].Value.ToString().Trim() ?? ""),
                    VentaTelfCid = (worksheet.Cells[row, 9].Value.ToString().Trim() ?? ""),
                    VentaTelfRappiCargo = (worksheet.Cells[row, 10].Value.ToString().Trim() ?? ""),
                    Garantizado99Min = (worksheet.Cells[row, 11].Value.ToString().Trim() ?? ""),
                    GarantizadoMu = (worksheet.Cells[row, 12].Value.ToString().Trim() ?? ""),
                    GarantizadoCid = (worksheet.Cells[row, 13].Value.ToString().Trim() ?? ""),
                    ECommerceDelivery = (worksheet.Cells[row, 14].Value.ToString().Trim() ?? ""),
                    ECommerceClickCollect = (worksheet.Cells[row, 15].Value.ToString().Trim() ?? ""),
                    ECommerceTipo = (worksheet.Cells[row, 16].Value.ToString().Trim() ?? ""),
                    Fijo99Min = (worksheet.Cells[row, 17].Value.ToString().Trim() ?? ""),
                    FijoMu = (worksheet.Cells[row, 18].Value.ToString().Trim() ?? ""),
                    FijoCid = (worksheet.Cells[row, 19].Value.ToString().Trim() ?? ""),
                    OnDemandMu = (worksheet.Cells[row, 20].Value.ToString().Trim() ?? ""),
                    OnDemandRappiCargo = (worksheet.Cells[row, 21].Value.ToString().Trim() ?? ""),
                    CanalesDigitalesRappi = (worksheet.Cells[row, 22].Value.ToString().Trim() ?? ""),
                    CanalesDigitalesUber = (worksheet.Cells[row, 23].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo1 = (worksheet.Cells[row, 24].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo2 = (worksheet.Cells[row, 25].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo3 = (worksheet.Cells[row, 26].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo4 = (worksheet.Cells[row, 27].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo5 = (worksheet.Cells[row, 28].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo6 = (worksheet.Cells[row, 29].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo7 = (worksheet.Cells[row, 30].Value.ToString().Trim() ?? ""),
                    ServicioEfectivo8 = (worksheet.Cells[row, 31].Value.ToString().Trim() ?? ""),
                    ServicioTarjeta9 = (worksheet.Cells[row, 32].Value.ToString().Trim() ?? ""),
                    ServicioTarjeta10 = (worksheet.Cells[row, 33].Value.ToString().Trim() ?? ""),
                    ServicioTarjeta11 = (worksheet.Cells[row, 34].Value.ToString().Trim() ?? ""),
                    ServicioTarjeta12 = (worksheet.Cells[row, 35].Value.ToString().Trim() ?? ""),
                    InicioServicio = (worksheet.Cells[row, 36].Value.ToString().Trim() ?? ""),
                    CierreServicio = (worksheet.Cells[row, 37].Value.ToString().Trim() ?? "")
                };

                if (Exits == false)
                {

                    handler.Create(uow, new SaveWithLocalizationRequest<MyRow>
                    {
                        Entity = RowExcel,
                    });

                    response.Inserted = response.Inserted + 1;
                }
                else
                {
                    handler.Update(uow, new SaveWithLocalizationRequest<MyRow>
                    {
                        Entity = RowExcel,
                        EntityId = RowExcel.LocalSap.Trim()
                    });

                    response.Updated = response.Updated + 1;
                }

            }
            catch (Exception ex)
            {
                response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
            }
        }
        return response;
    }
}