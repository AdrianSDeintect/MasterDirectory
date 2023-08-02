import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaMerchandisingColumns, CategoriaMerchandisingRow, CategoriaMerchandisingService } from '../../ServerTypes/Merchandising';
import { CategoriaMerchandisingDialog } from './CategoriaMerchandisingDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Merchandising.CategoriaMerchandisingGrid')
export class CategoriaMerchandisingGrid extends EntityGrid<CategoriaMerchandisingRow, any> {
    protected getColumnsKey() { return CategoriaMerchandisingColumns.columnsKey; }
    protected getDialogType() { return CategoriaMerchandisingDialog; }
    protected getRowDefinition() { return CategoriaMerchandisingRow; }
    protected getService() { return CategoriaMerchandisingService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaMerchandisingService.baseUrl + '/ListExcel',
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