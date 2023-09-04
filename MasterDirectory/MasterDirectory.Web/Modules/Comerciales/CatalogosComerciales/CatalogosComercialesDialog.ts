import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosComercialesForm, CatalogosComercialesRow, CatalogosComercialesService } from '../../ServerTypes/Comerciales';

@Decorators.registerClass('MasterDirectory.Comerciales.CatalogosComercialesDialog')
export class CatalogosComercialesDialog extends EntityDialog<CatalogosComercialesRow, any> {
    protected getFormKey() { return CatalogosComercialesForm.formKey; }
    protected getRowDefinition() { return CatalogosComercialesRow; }
    protected getService() { return CatalogosComercialesService.baseUrl; }

    protected form = new CatalogosComercialesForm(this.idPrefix);
}