import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TipoCatalogosColumns, TipoCatalogosRow, TipoCatalogosService } from '../../ServerTypes/Catalogos';
import { TipoCatalogosDialog } from './TipoCatalogosDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Catalogos.TipoCatalogosGrid')
export class TipoCatalogosGrid extends EntityGrid<TipoCatalogosRow, any> {
    protected getColumnsKey() { return TipoCatalogosColumns.columnsKey; }
    protected getDialogType() { return TipoCatalogosDialog; }
    protected getRowDefinition() { return TipoCatalogosRow; }
    protected getService() { return TipoCatalogosService.baseUrl; }

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