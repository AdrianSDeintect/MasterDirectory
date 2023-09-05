import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosTIColumns, CatalogosTIRow, CatalogosTIService } from '../../ServerTypes/TecnologiasInformacion';
import { CatalogosTIDialog } from './CatalogosTIDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.TecnologiasInformacion.CatalogosTIGrid')
export class CatalogosTIGrid extends EntityGrid<CatalogosTIRow, any> {
    protected getColumnsKey() { return CatalogosTIColumns.columnsKey; }
    protected getDialogType() { return CatalogosTIDialog; }
    protected getRowDefinition() { return CatalogosTIRow; }
    protected getService() { return CatalogosTIService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosTIService.baseUrl + '/ListExcel',
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