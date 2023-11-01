import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaOperacionesColumns, CategoriaOperacionesRow, CategoriaOperacionesService } from '../../ServerTypes/Operaciones';
import { CategoriaOperacionesDialog } from './CategoriaOperacionesDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";
import { ImportExcelDialog } from '../../ImportExcel/ImportExcelDialog';

@Decorators.registerClass('MasterDirectory.Operaciones.CategoriaOperacionesGrid')
export class CategoriaOperacionesGrid extends EntityGrid<CategoriaOperacionesRow, any> {
    protected getColumnsKey() { return CategoriaOperacionesColumns.columnsKey; }
    protected getDialogType() { return CategoriaOperacionesDialog; }
    protected getRowDefinition() { return CategoriaOperacionesRow; }
    protected getService() { return CategoriaOperacionesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }


    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaOperacionesService.baseUrl + '/ListExcel',
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
                dialog.Categoria = 'Operaciones'
                dialog.dialogOpen();
            }
        });

        return buttons;
    }

}