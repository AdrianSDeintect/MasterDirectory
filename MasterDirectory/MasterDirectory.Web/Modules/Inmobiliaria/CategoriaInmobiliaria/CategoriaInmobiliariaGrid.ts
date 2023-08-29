import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CategoriaInmobiliariaColumns, CategoriaInmobiliariaRow, CategoriaInmobiliariaService } from '../../ServerTypes/Inmobiliaria';
import { CategoriaInmobiliariaDialog } from './CategoriaInmobiliariaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Inmobiliaria.CategoriaInmobiliariaGrid')
export class CategoriaInmobiliariaGrid extends EntityGrid<CategoriaInmobiliariaRow, any> {
    protected getColumnsKey() { return CategoriaInmobiliariaColumns.columnsKey; }
    protected getDialogType() { return CategoriaInmobiliariaDialog; }
    protected getRowDefinition() { return CategoriaInmobiliariaRow; }
    protected getService() { return CategoriaInmobiliariaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CategoriaInmobiliariaService.baseUrl + '/ListExcel',
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