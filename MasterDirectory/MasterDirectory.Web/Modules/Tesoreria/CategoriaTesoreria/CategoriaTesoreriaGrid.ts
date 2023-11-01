import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaTesoreriaColumns, CategoriaTesoreriaRow, CategoriaTesoreriaService } from '../../ServerTypes/Tesoreria';
import { CategoriaTesoreriaDialog } from './CategoriaTesoreriaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
//import { Column } from '@serenity-is/sleekgrid';

@Decorators.registerClass('MasterDirectory.Tesoreria.CategoriaTesoreriaGrid')
export class CategoriaTesoreriaGrid extends EntityGrid<CategoriaTesoreriaRow, any> {
    protected getColumnsKey() { return CategoriaTesoreriaColumns.columnsKey; }
    protected getDialogType() { return CategoriaTesoreriaDialog; }
    protected getRowDefinition() { return CategoriaTesoreriaRow; }
    protected getService() { return CategoriaTesoreriaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaTesoreriaService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            title: "Exportar Excel",
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            title: "Exportar PDF",
            onViewSubmit: () => this.onViewSubmit()
        }));

        return buttons;
    }

    //protected getColumns(): Column[] {
    //    var columns = super.getColumns();

    //    var fld = CategoriaTesoreriaRow;

    //     //adding a specific css class to UnitPrice column, 
    //     //to be able to format cell with a different background
    //    Q.first(columns, x => x.field == fld.Fields.DtRegistro).cssClass += " col-unit-price";

    //    return columns;
    //}

    //protected getItemCssClass(item: CategoriaTesoreriaRow, index: number): string {
    //    let klass: string = "";
    //    const dateReg = new Date(item.DtRegistro);
    //    var fechaVal = new Date();
    //    fechaVal.setDate(fechaVal.getDate() + 7)
    //    if (dateReg <= fechaVal)
    //        klass += " apertura";
    //    //DateTime myDate = DateTime.ParseExact("2009-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
    //    //    System.Globalization.CultureInfo.InvariantCulture);
    //    //if (item.Discontinued == true)
    //    //    klass += " discontinued";
    //    //else if (item.UnitsInStock <= 0)
    //    //    klass += " out-of-stock";
    //    //else if (item.UnitsInStock < 20)
    //    //    klass += " critical-stock";
    //    //else if (item.UnitsInStock > 50)
    //    //    klass += " needs-reorder";

    //    //if (item.UnitPrice >= 50)
    //    //    klass += " high-price";
    //    //else if (item.UnitPrice >= 20)
    //    //    klass += " medium-price";
    //    //else
    //    //    klass += " low-price";

    //    return Q.trimToNull(klass);
    //}

}