import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosDigitalForm, CatalogosDigitalRow, CatalogosDigitalService } from '../../ServerTypes/Digital';

@Decorators.registerClass('MasterDirectory.Digital.CatalogosDigitalDialog')
export class CatalogosDigitalDialog extends EntityDialog<CatalogosDigitalRow, any> {
    protected getFormKey() { return CatalogosDigitalForm.formKey; }
    protected getRowDefinition() { return CatalogosDigitalRow; }
    protected getService() { return CatalogosDigitalService.baseUrl; }

    protected form = new CatalogosDigitalForm(this.idPrefix);
}