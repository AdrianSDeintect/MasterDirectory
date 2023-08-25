import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaExpansionColumns, CategoriaExpansionRow, CategoriaExpansionService } from '../../ServerTypes/Expansion';
import { CategoriaExpansionDialog } from './CategoriaExpansionDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Expansion.CategoriaExpansionGrid')
export class CategoriaExpansionGrid extends EntityGrid<CategoriaExpansionRow, any> {
    protected getColumnsKey() { return CategoriaExpansionColumns.columnsKey; }
    protected getDialogType() { return CategoriaExpansionDialog; }
    protected getRowDefinition() { return CategoriaExpansionRow; }
    protected getService() { return CategoriaExpansionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaExpansionService.baseUrl + '/ListExcel',
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