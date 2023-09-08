import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaRHColumns, CategoriaRHRow, CategoriaRHService } from '../../ServerTypes/RecursosHumanos';
import { CategoriaRHDialog } from './CategoriaRHDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
import { ImportExcelDialog } from '../../ImportExcel/ImportExcelDialog';

@Decorators.registerClass('MasterDirectory.RecursosHumanos.CategoriaRHGrid')
export class CategoriaRHGrid extends EntityGrid<CategoriaRHRow, any> {
    protected getColumnsKey() { return CategoriaRHColumns.columnsKey; }
    protected getDialogType() { return CategoriaRHDialog; }
    protected getRowDefinition() { return CategoriaRHRow; }
    protected getService() { return CategoriaRHService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaRHService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            title: "Exportar Excel",
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            title: "Exportar PDF",
            onViewSubmit: () => this.onViewSubmit()
        }));

        // add our import button
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
                dialog.Categoria = 'RH'
                dialog.dialogOpen();
            }
        });

        return buttons;
    }

}