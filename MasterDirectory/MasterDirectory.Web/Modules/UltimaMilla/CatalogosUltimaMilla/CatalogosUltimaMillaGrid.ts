import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosUltimaMillaColumns, CatalogosUltimaMillaRow, CatalogosUltimaMillaService } from '../../ServerTypes/UltimaMilla';
import { CatalogosUltimaMillaDialog } from './CatalogosUltimaMillaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.UltimaMilla.CatalogosUltimaMillaGrid')
export class CatalogosUltimaMillaGrid extends EntityGrid<CatalogosUltimaMillaRow, any> {
    protected getColumnsKey() { return CatalogosUltimaMillaColumns.columnsKey; }
    protected getDialogType() { return CatalogosUltimaMillaDialog; }
    protected getRowDefinition() { return CatalogosUltimaMillaRow; }
    protected getService() { return CatalogosUltimaMillaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosUltimaMillaService.baseUrl + '/ListExcel',
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