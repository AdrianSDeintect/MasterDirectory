import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaFinanzasColumns, CategoriaFinanzasRow, CategoriaFinanzasService } from '../../ServerTypes/Finanzas';
import { CategoriaFinanzasDialog } from './CategoriaFinanzasDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Finanzas.CategoriaFinanzasGrid')
export class CategoriaFinanzasGrid extends EntityGrid<CategoriaFinanzasRow, any> {
    protected getColumnsKey() { return CategoriaFinanzasColumns.columnsKey; }
    protected getDialogType() { return CategoriaFinanzasDialog; }
    protected getRowDefinition() { return CategoriaFinanzasRow; }
    protected getService() { return CategoriaFinanzasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }


    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaFinanzasService.baseUrl + '/ListExcel',
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