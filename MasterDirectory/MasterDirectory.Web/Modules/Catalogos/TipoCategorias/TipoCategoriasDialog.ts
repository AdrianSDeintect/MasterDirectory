import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TipoCategoriasForm, TipoCategoriasRow, TipoCategoriasService } from '../../ServerTypes/Catalogos';

@Decorators.registerClass('MasterDirectory.Catalogos.TipoCategoriasDialog')
export class TipoCategoriasDialog extends EntityDialog<TipoCategoriasRow, any> {
    protected getFormKey() { return TipoCategoriasForm.formKey; }
    protected getRowDefinition() { return TipoCategoriasRow; }
    protected getService() { return TipoCategoriasService.baseUrl; }

    protected form = new TipoCategoriasForm(this.idPrefix);
}