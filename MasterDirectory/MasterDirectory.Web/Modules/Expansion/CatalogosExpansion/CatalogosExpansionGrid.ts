import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosExpansionColumns, CatalogosExpansionRow, CatalogosExpansionService } from '../../ServerTypes/Expansion';
import { CatalogosExpansionDialog } from './CatalogosExpansionDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
@Decorators.registerClass('MasterDirectory.Expansion.CatalogosExpansionGrid')
export class CatalogosExpansionGrid extends EntityGrid<CatalogosExpansionRow, any> {
    protected getColumnsKey() { return CatalogosExpansionColumns.columnsKey; }
    protected getDialogType() { return CatalogosExpansionDialog; }
    protected getRowDefinition() { return CatalogosExpansionRow; }
    protected getService() { return CatalogosExpansionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }


    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosExpansionService.baseUrl + '/ListExcel',
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