import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosOperacionesForm, CatalogosOperacionesRow, CatalogosOperacionesService } from '../../ServerTypes/Operaciones';

@Decorators.registerClass('MasterDirectory.Operaciones.CatalogosOperacionesDialog')
export class CatalogosOperacionesDialog extends EntityDialog<CatalogosOperacionesRow, any> {
    protected getFormKey() { return CatalogosOperacionesForm.formKey; }
    protected getRowDefinition() { return CatalogosOperacionesRow; }
    protected getService() { return CatalogosOperacionesService.baseUrl; }

    protected form = new CatalogosOperacionesForm(this.idPrefix);
}