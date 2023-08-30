import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaRHColumns, CategoriaRHRow, CategoriaRHService } from '../../ServerTypes/RecursosHumanos';
import { CategoriaRHDialog } from './CategoriaRHDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.RecursosHumanos.CategoriaRHGrid')
export class CategoriaRHGrid extends EntityGrid<CategoriaRHRow, any> {
    protected getColumnsKey() { return CategoriaRHColumns.columnsKey; }
    protected getDialogType() { return CategoriaRHDialog; }
    protected getRowDefinition() { return CategoriaRHRow; }
    protected getService() { return CategoriaRHService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaRHService.baseUrl + '/ListExcel',
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