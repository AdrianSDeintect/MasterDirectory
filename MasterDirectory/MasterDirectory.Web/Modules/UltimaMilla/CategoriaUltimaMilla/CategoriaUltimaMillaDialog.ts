import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaUltimaMillaForm, CategoriaUltimaMillaRow, CategoriaUltimaMillaService } from '../../ServerTypes/UltimaMilla';

@Decorators.registerClass('MasterDirectory.UltimaMilla.CategoriaUltimaMillaDialog')
@Decorators.panel()
export class CategoriaUltimaMillaDialog extends EntityDialog<CategoriaUltimaMillaRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaUltimaMillaForm.formKey; }
    protected getRowDefinition() { return CategoriaUltimaMillaRow; }
    protected getService() { return CategoriaUltimaMillaService.baseUrl; }

    protected form = new CategoriaUltimaMillaForm(this.idPrefix);

    constructor() {
        super();
    }

}