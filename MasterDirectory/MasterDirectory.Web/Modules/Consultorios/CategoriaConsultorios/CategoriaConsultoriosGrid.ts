import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaConsultoriosColumns, CategoriaConsultoriosRow, CategoriaConsultoriosService } from '../../ServerTypes/Consultorios';
import { CategoriaConsultoriosDialog } from './CategoriaConsultoriosDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Consultorios.CategoriaConsultoriosGrid')
export class CategoriaConsultoriosGrid extends EntityGrid<CategoriaConsultoriosRow, any> {
    protected getColumnsKey() { return CategoriaConsultoriosColumns.columnsKey; }
    protected getDialogType() { return CategoriaConsultoriosDialog; }
    protected getRowDefinition() { return CategoriaConsultoriosRow; }
    protected getService() { return CategoriaConsultoriosService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaConsultoriosService.baseUrl + '/ListExcel',
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