import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosOperacionesColumns, CatalogosOperacionesRow, CatalogosOperacionesService } from '../../ServerTypes/Operaciones';
import { CatalogosOperacionesDialog } from './CatalogosOperacionesDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Operaciones.CatalogosOperacionesGrid')
export class CatalogosOperacionesGrid extends EntityGrid<CatalogosOperacionesRow, any> {
    protected getColumnsKey() { return CatalogosOperacionesColumns.columnsKey; }
    protected getDialogType() { return CatalogosOperacionesDialog; }
    protected getRowDefinition() { return CatalogosOperacionesRow; }
    protected getService() { return CatalogosOperacionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosOperacionesService.baseUrl + '/ListExcel',
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