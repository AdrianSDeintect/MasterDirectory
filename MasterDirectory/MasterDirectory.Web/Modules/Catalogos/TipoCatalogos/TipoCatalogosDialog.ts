import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TipoCatalogosForm, TipoCatalogosRow, TipoCatalogosService } from '../../ServerTypes/Catalogos';

@Decorators.registerClass('MasterDirectory.Catalogos.TipoCatalogosDialog')
export class TipoCatalogosDialog extends EntityDialog<TipoCatalogosRow, any> {
    protected getFormKey() { return TipoCatalogosForm.formKey; }
    protected getRowDefinition() { return TipoCatalogosRow; }
    protected getService() { return TipoCatalogosService.baseUrl; }

    protected form = new TipoCatalogosForm(this.idPrefix);
}