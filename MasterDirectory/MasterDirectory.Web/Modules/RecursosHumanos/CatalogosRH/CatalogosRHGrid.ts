import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosRHColumns, CatalogosRHRow, CatalogosRHService } from '../../ServerTypes/RecursosHumanos';
import { CatalogosRHDialog } from './CatalogosRHDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.RecursosHumanos.CatalogosRHGrid')
export class CatalogosRHGrid extends EntityGrid<CatalogosRHRow, any> {
    protected getColumnsKey() { return CatalogosRHColumns.columnsKey; }
    protected getDialogType() { return CatalogosRHDialog; }
    protected getRowDefinition() { return CatalogosRHRow; }
    protected getService() { return CatalogosRHService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosRHService.baseUrl + '/ListExcel',
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