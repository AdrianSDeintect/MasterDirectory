import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosFinanzasForm, CatalogosFinanzasRow, CatalogosFinanzasService } from '../../ServerTypes/Finanzas';

@Decorators.registerClass('MasterDirectory.Finanzas.CatalogosFinanzasDialog')
export class CatalogosFinanzasDialog extends EntityDialog<CatalogosFinanzasRow, any> {
    protected getFormKey() { return CatalogosFinanzasForm.formKey; }
    protected getRowDefinition() { return CatalogosFinanzasRow; }
    protected getService() { return CatalogosFinanzasService.baseUrl; }

    protected form = new CatalogosFinanzasForm(this.idPrefix);
}