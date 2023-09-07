import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
/*import { CategoriaMarketIntelligenceColumns, CategoriaMarketIntelligenceRow, CategoriaMarketIntelligenceService } from '../../ServerTypes/MarketIntelligence';*/
import { CategoriaMarketIntelligenceColumns } from '../../ServerTypes/MarketIntelligence/CategoriaMarketIntelligenceColumns';
import { CategoriaMarketIntelligenceRow } from '../../ServerTypes/MarketIntelligence/CategoriaMarketIntelligenceRow';
import { CategoriaMarketIntelligenceService } from '../../ServerTypes/MarketIntelligence/CategoriaMarketIntelligenceService';
import { CategoriaMarketIntelligenceDialog } from './CategoriaMarketIntelligenceDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceGrid')
export class CategoriaMarketIntelligenceGrid extends EntityGrid<CategoriaMarketIntelligenceRow, any> {
    protected getColumnsKey() { return CategoriaMarketIntelligenceColumns.columnsKey; }
    protected getDialogType() { return CategoriaMarketIntelligenceDialog; }
    protected getRowDefinition() { return CategoriaMarketIntelligenceRow; }
    protected getService() { return CategoriaMarketIntelligenceService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaMarketIntelligenceService.baseUrl + '/ListExcel',
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