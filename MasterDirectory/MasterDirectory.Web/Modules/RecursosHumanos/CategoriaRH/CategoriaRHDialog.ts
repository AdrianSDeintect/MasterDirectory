import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaRHForm, CategoriaRHRow, CategoriaRHService } from '../../ServerTypes/RecursosHumanos';
@Decorators.panel()

@Decorators.registerClass('MasterDirectory.RecursosHumanos.CategoriaRHDialog')
export class CategoriaRHDialog extends EntityDialog<CategoriaRHRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaRHForm.formKey; }
    protected getRowDefinition() { return CategoriaRHRow; }
    protected getService() { return CategoriaRHService.baseUrl; }

    protected form = new CategoriaRHForm(this.idPrefix);

    constructor() {
        super();
    }

}