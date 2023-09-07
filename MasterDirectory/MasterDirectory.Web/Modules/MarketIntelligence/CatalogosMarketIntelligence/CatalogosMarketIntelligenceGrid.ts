import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosMarketIntelligenceColumns, CatalogosMarketIntelligenceRow, CatalogosMarketIntelligenceService } from '../../ServerTypes/MarketIntelligence';
import { CatalogosMarketIntelligenceDialog } from './CatalogosMarketIntelligenceDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceGrid')
export class CatalogosMarketIntelligenceGrid extends EntityGrid<CatalogosMarketIntelligenceRow, any> {
    protected getColumnsKey() { return CatalogosMarketIntelligenceColumns.columnsKey; }
    protected getDialogType() { return CatalogosMarketIntelligenceDialog; }
    protected getRowDefinition() { return CatalogosMarketIntelligenceRow; }
    protected getService() { return CatalogosMarketIntelligenceService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosMarketIntelligenceService.baseUrl + '/ListExcel',
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