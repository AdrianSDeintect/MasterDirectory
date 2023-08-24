import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaFinanzasForm, CategoriaFinanzasRow, CategoriaFinanzasService } from '../../ServerTypes/Finanzas';

@Decorators.registerClass('MasterDirectory.Finanzas.CategoriaFinanzasDialog')
@Decorators.panel()
export class CategoriaFinanzasDialog extends EntityDialog<CategoriaFinanzasRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaFinanzasForm.formKey; }
    protected getRowDefinition() { return CategoriaFinanzasRow; }
    protected getService() { return CategoriaFinanzasService.baseUrl; }

    protected form = new CategoriaFinanzasForm(this.idPrefix);

    constructor() {
        super();
    }
}