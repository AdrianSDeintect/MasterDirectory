import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosConsultoriosColumns, CatalogosConsultoriosRow, CatalogosConsultoriosService } from '../../ServerTypes/Consultorios';
import { CatalogosConsultoriosDialog } from './CatalogosConsultoriosDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Consultorios.CatalogosConsultoriosGrid')
export class CatalogosConsultoriosGrid extends EntityGrid<CatalogosConsultoriosRow, any> {
    protected getColumnsKey() { return CatalogosConsultoriosColumns.columnsKey; }
    protected getDialogType() { return CatalogosConsultoriosDialog; }
    protected getRowDefinition() { return CatalogosConsultoriosRow; }
    protected getService() { return CatalogosConsultoriosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosConsultoriosService.baseUrl + '/ListExcel',
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