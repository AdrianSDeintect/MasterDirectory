import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosDigitalColumns, CatalogosDigitalRow, CatalogosDigitalService } from '../../ServerTypes/Digital';
import { CatalogosDigitalDialog } from './CatalogosDigitalDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Digital.CatalogosDigitalGrid')
export class CatalogosDigitalGrid extends EntityGrid<CatalogosDigitalRow, any> {
    protected getColumnsKey() { return CatalogosDigitalColumns.columnsKey; }
    protected getDialogType() { return CatalogosDigitalDialog; }
    protected getRowDefinition() { return CatalogosDigitalRow; }
    protected getService() { return CatalogosDigitalService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosDigitalService.baseUrl + '/ListExcel',
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