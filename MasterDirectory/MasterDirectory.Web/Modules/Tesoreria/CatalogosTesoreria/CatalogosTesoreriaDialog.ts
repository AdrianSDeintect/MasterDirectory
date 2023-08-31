import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosTesoreriaForm, CatalogosTesoreriaRow, CatalogosTesoreriaService } from '../../ServerTypes/Tesoreria';

@Decorators.registerClass('MasterDirectory.Tesoreria.CatalogosTesoreriaDialog')
export class CatalogosTesoreriaDialog extends EntityDialog<CatalogosTesoreriaRow, any> {
    protected getFormKey() { return CatalogosTesoreriaForm.formKey; }
    protected getRowDefinition() { return CatalogosTesoreriaRow; }
    protected getService() { return CatalogosTesoreriaService.baseUrl; }

    protected form = new CatalogosTesoreriaForm(this.idPrefix);
}