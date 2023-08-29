import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosInmobiliariaForm, CatalogosInmobiliariaRow, CatalogosInmobiliariaService } from '../../ServerTypes/Inmobiliaria';

@Decorators.registerClass('MasterDirectory.Inmobiliaria.CatalogosInmobiliariaDialog')
export class CatalogosInmobiliariaDialog extends EntityDialog<CatalogosInmobiliariaRow, any> {
    protected getFormKey() { return CatalogosInmobiliariaForm.formKey; }
    protected getRowDefinition() { return CatalogosInmobiliariaRow; }
    protected getService() { return CatalogosInmobiliariaService.baseUrl; }

    protected form = new CatalogosInmobiliariaForm(this.idPrefix);
}