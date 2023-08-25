import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosExpansionForm, CatalogosExpansionRow, CatalogosExpansionService } from '../../ServerTypes/Expansion';

@Decorators.registerClass('MasterDirectory.Expansion.CatalogosExpansionDialog')
export class CatalogosExpansionDialog extends EntityDialog<CatalogosExpansionRow, any> {
    protected getFormKey() { return CatalogosExpansionForm.formKey; }
    protected getRowDefinition() { return CatalogosExpansionRow; }
    protected getService() { return CatalogosExpansionService.baseUrl; }

    protected form = new CatalogosExpansionForm(this.idPrefix);
}