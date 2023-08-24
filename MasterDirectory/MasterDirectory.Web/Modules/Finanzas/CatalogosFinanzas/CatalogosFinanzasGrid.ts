import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosFinanzasColumns, CatalogosFinanzasRow, CatalogosFinanzasService } from '../../ServerTypes/Finanzas';
import { CatalogosFinanzasDialog } from './CatalogosFinanzasDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Finanzas.CatalogosFinanzasGrid')
export class CatalogosFinanzasGrid extends EntityGrid<CatalogosFinanzasRow, any> {
    protected getColumnsKey() { return CatalogosFinanzasColumns.columnsKey; }
    protected getDialogType() { return CatalogosFinanzasDialog; }
    protected getRowDefinition() { return CatalogosFinanzasRow; }
    protected getService() { return CatalogosFinanzasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosFinanzasService.baseUrl + '/ListExcel',
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