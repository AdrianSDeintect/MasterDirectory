using MasterDirectory.UltimaMilla;
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
using MyRow = MasterDirectory.Expansion.CategoriaExpansionRow;

namespace MasterDirectory.Expansion.Endpoints;

[Route("Services/Expansion/CategoriaExpansion/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class CategoriaExpansionEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ICategoriaExpansionSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ICategoriaExpansionSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] ICategoriaExpansionDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] ICategoriaExpansionRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] ICategoriaExpansionListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] ICategoriaExpansionListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.CategoriaExpansionColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "CategoriaExpansionList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }


    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request, [FromServices] IUploadStorage uploadStorage, [FromServices] ICategoriaExpansionSaveHandler handler)
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
                    Farmacia = Convert.ToString(worksheet.Cells[row, 2].Value ?? ""),
                    FechaApertura = Convert.ToDateTime(worksheet.Cells[row, 3].Value ?? ""),
                    LocationType = Convert.ToString(worksheet.Cells[row, 4].Value ?? ""),
                    Reapertura = worksheet.Cells[row, 5].Value == null ? null : Convert.ToDateTime(worksheet.Cells[row, 5].Value),
                    Comsuc = Convert.ToString(worksheet.Cells[row, 6].Value ?? ""),
                    TipoEstaciona = Convert.ToString(worksheet.Cells[row, 7].Value ?? ""),
                    NCajonesEstaciona = Convert.ToString(worksheet.Cells[row, 8].Value ?? ""),
                    Ciudad = Convert.ToString(worksheet.Cells[row, 9].Value ?? ""),
                    Estado = Convert.ToString(worksheet.Cells[row, 10].Value ?? ""),
                    Direccion = Convert.ToString(worksheet.Cells[row, 11].Value ?? ""),
                    NExterior = Convert.ToString(worksheet.Cells[row, 12].Value ?? ""),
                    Colonia = Convert.ToString(worksheet.Cells[row, 13].Value ?? ""),
                    Cp = Convert.ToString(worksheet.Cells[row, 14].Value ?? ""),
                    Latitud = Convert.ToString(worksheet.Cells[row, 15].Value ?? ""),
                    Longuitud = Convert.ToString(worksheet.Cells[row, 16].Value ?? ""),
                    FormatoFarmAlcance = Convert.ToString(worksheet.Cells[row, 17].Value ?? ""),
                    Pantallas = Convert.ToString(worksheet.Cells[row, 18].Value ?? ""),
                    ProvMobiliario = Convert.ToString(worksheet.Cells[row, 19].Value ?? ""),
                    ColorMob = Convert.ToString(worksheet.Cells[row, 20].Value ?? ""),
                    Dermo = Convert.ToString(worksheet.Cells[row, 21].Value ?? "")
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