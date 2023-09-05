import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaTIColumns, CategoriaTIRow, CategoriaTIService } from '../../ServerTypes/TecnologiasInformacion';
import { CategoriaTIDialog } from './CategoriaTIDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.TecnologiasInformacion.CategoriaTIGrid')
export class CategoriaTIGrid extends EntityGrid<CategoriaTIRow, any> {
    protected getColumnsKey() { return CategoriaTIColumns.columnsKey; }
    protected getDialogType() { return CategoriaTIDialog; }
    protected getRowDefinition() { return CategoriaTIRow; }
    protected getService() { return CategoriaTIService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaTIService.baseUrl + '/ListExcel',
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