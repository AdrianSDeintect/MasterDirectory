import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaOperacionesColumns, CategoriaOperacionesRow, CategoriaOperacionesService } from '../../ServerTypes/Operaciones';
import { CategoriaOperacionesDialog } from './CategoriaOperacionesDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Operaciones.CategoriaOperacionesGrid')
export class CategoriaOperacionesGrid extends EntityGrid<CategoriaOperacionesRow, any> {
    protected getColumnsKey() { return CategoriaOperacionesColumns.columnsKey; }
    protected getDialogType() { return CategoriaOperacionesDialog; }
    protected getRowDefinition() { return CategoriaOperacionesRow; }
    protected getService() { return CategoriaOperacionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }


    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaOperacionesService.baseUrl + '/ListExcel',
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

}