import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { CatalogosInmobiliariaColumns, CatalogosInmobiliariaRow, CatalogosInmobiliariaService } from '../../ServerTypes/Inmobiliaria';
import { CatalogosInmobiliariaDialog } from './CatalogosInmobiliariaDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('MasterDirectory.Inmobiliaria.CatalogosInmobiliariaGrid')
export class CatalogosInmobiliariaGrid extends EntityGrid<CatalogosInmobiliariaRow, any> {
    protected getColumnsKey() { return CatalogosInmobiliariaColumns.columnsKey; }
    protected getDialogType() { return CatalogosInmobiliariaDialog; }
    protected getRowDefinition() { return CatalogosInmobiliariaRow; }
    protected getService() { return CatalogosInmobiliariaService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: CatalogosInmobiliariaService.baseUrl + '/ListExcel',
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