import { CatalogosMerchandisingColumns, CatalogosMerchandisingRow, CatalogosMerchandisingService } from '../../ServerTypes/Merchandising';
import { CatalogosMerchandisingDialog } from './CatalogosMerchandisingDialog';
import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.filterable()
@Decorators.registerClass('MasterDirectory.Merchandising.CatalogosMerchandisingGrid')
export class CatalogosMerchandisingGrid extends EntityGrid<CatalogosMerchandisingRow, any> {
    protected getColumnsKey() { return CatalogosMerchandisingColumns.columnsKey; }
    protected getDialogType() { return CatalogosMerchandisingDialog; }
    protected getRowDefinition() { return CatalogosMerchandisingRow; }
    protected getService() { return CatalogosMerchandisingService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosMerchandisingService.baseUrl + '/ListExcel',
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