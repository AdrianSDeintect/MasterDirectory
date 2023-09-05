import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosTIForm, CatalogosTIRow, CatalogosTIService } from '../../ServerTypes/TecnologiasInformacion';

@Decorators.registerClass('MasterDirectory.TecnologiasInformacion.CatalogosTIDialog')
export class CatalogosTIDialog extends EntityDialog<CatalogosTIRow, any> {
    protected getFormKey() { return CatalogosTIForm.formKey; }
    protected getRowDefinition() { return CatalogosTIRow; }
    protected getService() { return CatalogosTIService.baseUrl; }

    protected form = new CatalogosTIForm(this.idPrefix);
}