import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaDigitalColumns, CategoriaDigitalRow, CategoriaDigitalService } from '../../ServerTypes/Digital';
import { CategoriaDigitalDialog } from './CategoriaDigitalDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Digital.CategoriaDigitalGrid')
export class CategoriaDigitalGrid extends EntityGrid<CategoriaDigitalRow, any> {
    protected getColumnsKey() { return CategoriaDigitalColumns.columnsKey; }
    protected getDialogType() { return CategoriaDigitalDialog; }
    protected getRowDefinition() { return CategoriaDigitalRow; }
    protected getService() { return CategoriaDigitalService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaDigitalService.baseUrl + '/ListExcel',
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