import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaTesoreriaColumns, CategoriaTesoreriaRow, CategoriaTesoreriaService } from '../../ServerTypes/Tesoreria';
import { CategoriaTesoreriaDialog } from './CategoriaTesoreriaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Tesoreria.CategoriaTesoreriaGrid')
export class CategoriaTesoreriaGrid extends EntityGrid<CategoriaTesoreriaRow, any> {
    protected getColumnsKey() { return CategoriaTesoreriaColumns.columnsKey; }
    protected getDialogType() { return CategoriaTesoreriaDialog; }
    protected getRowDefinition() { return CategoriaTesoreriaRow; }
    protected getService() { return CategoriaTesoreriaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaTesoreriaService.baseUrl + '/ListExcel',
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