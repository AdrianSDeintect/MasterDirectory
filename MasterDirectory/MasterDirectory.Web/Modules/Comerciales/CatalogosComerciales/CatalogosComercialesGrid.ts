import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosComercialesColumns, CatalogosComercialesRow, CatalogosComercialesService } from '../../ServerTypes/Comerciales';
import { CatalogosComercialesDialog } from './CatalogosComercialesDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Comerciales.CatalogosComercialesGrid')
export class CatalogosComercialesGrid extends EntityGrid<CatalogosComercialesRow, any> {
    protected getColumnsKey() { return CatalogosComercialesColumns.columnsKey; }
    protected getDialogType() { return CatalogosComercialesDialog; }
    protected getRowDefinition() { return CatalogosComercialesRow; }
    protected getService() { return CatalogosComercialesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosComercialesService.baseUrl + '/ListExcel',
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