import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosRHForm, CatalogosRHRow, CatalogosRHService } from '../../ServerTypes/RecursosHumanos';

@Decorators.registerClass('MasterDirectory.RecursosHumanos.CatalogosRHDialog')
export class CatalogosRHDialog extends EntityDialog<CatalogosRHRow, any> {
    protected getFormKey() { return CatalogosRHForm.formKey; }
    protected getRowDefinition() { return CatalogosRHRow; }
    protected getService() { return CatalogosRHService.baseUrl; }

    protected form = new CatalogosRHForm(this.idPrefix);
}