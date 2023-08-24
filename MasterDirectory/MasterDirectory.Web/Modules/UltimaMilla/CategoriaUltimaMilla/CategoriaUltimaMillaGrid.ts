import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaUltimaMillaColumns, CategoriaUltimaMillaRow, CategoriaUltimaMillaService } from '../../ServerTypes/UltimaMilla';
import { CategoriaUltimaMillaDialog } from './CategoriaUltimaMillaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.UltimaMilla.CategoriaUltimaMillaGrid')
export class CategoriaUltimaMillaGrid extends EntityGrid<CategoriaUltimaMillaRow, any> {
    protected getColumnsKey() { return CategoriaUltimaMillaColumns.columnsKey; }
    protected getDialogType() { return CategoriaUltimaMillaDialog; }
    protected getRowDefinition() { return CategoriaUltimaMillaRow; }
    protected getService() { return CategoriaUltimaMillaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaUltimaMillaService.baseUrl + '/ListExcel',
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