import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaExpansionColumns, CategoriaExpansionRow, CategoriaExpansionService } from '../../ServerTypes/Expansion';
import { CategoriaExpansionDialog } from './CategoriaExpansionDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
import { ImportExcelDialog } from '../../ImportExcel/ImportExcelDialog';

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
            title: "Exportar",
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            title: "Exportar PDF",
            onViewSubmit: () => this.onViewSubmit()
        }));

        buttons.push({
            title: 'Importar Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new ImportExcelDialog({
                });
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.Categoria = 'Expansion'
                dialog.dialogOpen();
            }
        });

        return buttons;
    }

}