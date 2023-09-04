import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaComercialesColumns, CategoriaComercialesRow, CategoriaComercialesService } from '../../ServerTypes/Comerciales';
import { CategoriaComercialesDialog } from './CategoriaComercialesDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Comerciales.CategoriaComercialesGrid')
export class CategoriaComercialesGrid extends EntityGrid<CategoriaComercialesRow, any> {
    protected getColumnsKey() { return CategoriaComercialesColumns.columnsKey; }
    protected getDialogType() { return CategoriaComercialesDialog; }
    protected getRowDefinition() { return CategoriaComercialesRow; }
    protected getService() { return CategoriaComercialesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }


    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaComercialesService.baseUrl + '/ListExcel',
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