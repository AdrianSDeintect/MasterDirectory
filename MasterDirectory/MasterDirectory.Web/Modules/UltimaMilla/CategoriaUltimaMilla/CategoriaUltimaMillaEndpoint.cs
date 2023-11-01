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

                var LocalSap = Convert.ToString(worksheet.Cells[row, 1].Value ?? "");
                if (LocalSap.IsTrimmedEmpty())
                    continue;

                var RowExcel = new MyRow { };
                var RowExist = uow.Connection.TryFirst<MyRow>(q => q.Select(p.LocalSap).Where(p.LocalSap == LocalSap));
                if (RowExist == null) { Exits = false; } else { Exits = true; }

                RowExcel = new MyRow
                {
                    LocalSap = Convert.ToString(worksheet.Cells[row, 1].Value ?? ""),
                    Estado = Convert.ToString(worksheet.Cells[row, 2].Value ?? ""),
                    Prov99Min = Convert.ToString(worksheet.Cells[row, 3].Value ?? ""),
                    ProvMu = Convert.ToString(worksheet.Cells[row, 4].Value ?? ""),
                    ProvCid = Convert.ToString(worksheet.Cells[row, 5].Value ?? ""),
                    ProvRappiCargo = Convert.ToString(worksheet.Cells[row, 6].Value ?? ""),
                    VentaTelf99Min = Convert.ToString(worksheet.Cells[row, 7].Value ?? ""),
                    VentaTelfMu = Convert.ToString(worksheet.Cells[row, 8].Value ?? ""),
                    VentaTelfCid = Convert.ToString(worksheet.Cells[row, 9].Value ?? ""),
                    VentaTelfRappiCargo = Convert.ToString(worksheet.Cells[row, 10].Value ?? ""),
                    Garantizado99Min = Convert.ToString(worksheet.Cells[row, 11].Value ?? ""),
                    GarantizadoMu = Convert.ToString(worksheet.Cells[row, 12].Value ?? ""),
                    GarantizadoCid = Convert.ToString(worksheet.Cells[row, 13].Value ?? ""),
                    ECommerceDelivery = Convert.ToString(worksheet.Cells[row, 14].Value ?? ""),
                    ECommerceClickCollect = Convert.ToString(worksheet.Cells[row, 15].Value ?? ""),
                    ECommerceTipo = Convert.ToString(worksheet.Cells[row, 16].Value ?? ""),
                    Fijo99Min = Convert.ToString(worksheet.Cells[row, 17].Value ?? ""),
                    FijoMu = Convert.ToString(worksheet.Cells[row, 18].Value ?? ""),
                    FijoCid = Convert.ToString(worksheet.Cells[row, 19].Value ?? ""),
                    OnDemandMu = Convert.ToString(worksheet.Cells[row, 20].Value ?? ""),
                    OnDemandRappiCargo = Convert.ToString(worksheet.Cells[row, 21].Value ?? ""),
                    CanalesDigitalesRappi = Convert.ToString(worksheet.Cells[row, 22].Value ?? ""),
                    CanalesDigitalesUber = Convert.ToString(worksheet.Cells[row, 23].Value ?? ""),
                    ServicioEfectivo1 = Convert.ToString(worksheet.Cells[row, 24].Value ?? ""),
                    ServicioEfectivo2 = Convert.ToString(worksheet.Cells[row, 25].Value ?? ""),
                    ServicioEfectivo3 = Convert.ToString(worksheet.Cells[row, 26].Value ?? ""),
                    ServicioEfectivo4 = Convert.ToString(worksheet.Cells[row, 27].Value ?? ""),
                    ServicioEfectivo5 = Convert.ToString(worksheet.Cells[row, 28].Value ?? ""),
                    ServicioEfectivo6 = Convert.ToString(worksheet.Cells[row, 29].Value ?? ""),
                    ServicioEfectivo7 = Convert.ToString(worksheet.Cells[row, 30].Value ?? ""),
                    ServicioEfectivo8 = Convert.ToString(worksheet.Cells[row, 31].Value ?? ""),
                    ServicioTarjeta9 = Convert.ToString(worksheet.Cells[row, 32].Value ?? ""),
                    ServicioTarjeta10 = Convert.ToString(worksheet.Cells[row, 33].Value ?? ""),
                    ServicioTarjeta11 = Convert.ToString(worksheet.Cells[row, 34].Value ?? ""),
                    ServicioTarjeta12 = Convert.ToString(worksheet.Cells[row, 35].Value ?? ""),
                    InicioServicio = Convert.ToString(worksheet.Cells[row, 36].Value ?? ""),
                    CierreServicio = Convert.ToString(worksheet.Cells[row, 37].Value ?? "")
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