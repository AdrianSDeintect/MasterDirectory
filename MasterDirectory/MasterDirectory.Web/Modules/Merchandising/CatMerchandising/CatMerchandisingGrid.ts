import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatMerchandisingColumns, CatMerchandisingRow, CatMerchandisingService } from '../../ServerTypes/Merchandising';
import { CatMerchandisingDialog } from './CatMerchandisingDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Merchandising.CatMerchandisingGrid')
export class CatMerchandisingGrid extends EntityGrid<CatMerchandisingRow, any> {
    protected getColumnsKey() { return CatMerchandisingColumns.columnsKey; }
    protected getDialogType() { return CatMerchandisingDialog; }
    protected getRowDefinition() { return CatMerchandisingRow; }
    protected getService() { return CatMerchandisingService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    getButtons() {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            onViewSubmit: () => this.onViewSubmit(),
            service: '/ListExcel',
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