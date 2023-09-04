import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaComercialesForm, CategoriaComercialesRow, CategoriaComercialesService } from '../../ServerTypes/Comerciales';

@Decorators.panel()
@Decorators.registerClass('MasterDirectory.Comerciales.CategoriaComercialesDialog')
export class CategoriaComercialesDialog extends EntityDialog<CategoriaComercialesRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaComercialesForm.formKey; }
    protected getRowDefinition() { return CategoriaComercialesRow; }
    protected getService() { return CategoriaComercialesService.baseUrl; }

    protected form = new CategoriaComercialesForm(this.idPrefix);

    constructor() {
        super();
    }

}