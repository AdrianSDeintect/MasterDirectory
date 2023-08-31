import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosTesoreriaColumns, CatalogosTesoreriaRow, CatalogosTesoreriaService } from '../../ServerTypes/Tesoreria';
import { CatalogosTesoreriaDialog } from './CatalogosTesoreriaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Tesoreria.CatalogosTesoreriaGrid')
export class CatalogosTesoreriaGrid extends EntityGrid<CatalogosTesoreriaRow, any> {
    protected getColumnsKey() { return CatalogosTesoreriaColumns.columnsKey; }
    protected getDialogType() { return CatalogosTesoreriaDialog; }
    protected getRowDefinition() { return CatalogosTesoreriaRow; }
    protected getService() { return CatalogosTesoreriaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosTesoreriaService.baseUrl + '/ListExcel',
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