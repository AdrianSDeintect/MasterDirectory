import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosMerchandisingForm, CatalogosMerchandisingRow, CatalogosMerchandisingService } from '../../ServerTypes/Merchandising';

@Decorators.registerClass('MasterDirectory.Merchandising.CatalogosMerchandisingDialog')
export class CatalogosMerchandisingDialog extends EntityDialog<CatalogosMerchandisingRow, any> {
    protected getFormKey() { return CatalogosMerchandisingForm.formKey; }
    protected getRowDefinition() { return CatalogosMerchandisingRow; }
    protected getService() { return CatalogosMerchandisingService.baseUrl; }

    protected form = new CatalogosMerchandisingForm(this.idPrefix);
}