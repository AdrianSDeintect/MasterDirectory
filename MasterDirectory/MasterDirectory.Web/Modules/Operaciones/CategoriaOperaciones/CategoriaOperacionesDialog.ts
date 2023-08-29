import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaOperacionesForm, CategoriaOperacionesRow, CategoriaOperacionesService } from '../../ServerTypes/Operaciones';

@Decorators.registerClass('MasterDirectory.Operaciones.CategoriaOperacionesDialog')
@Decorators.panel()
export class CategoriaOperacionesDialog extends EntityDialog<CategoriaOperacionesRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaOperacionesForm.formKey; }
    protected getRowDefinition() { return CategoriaOperacionesRow; }
    protected getService() { return CategoriaOperacionesService.baseUrl; }

    protected form = new CategoriaOperacionesForm(this.idPrefix);

    constructor() {
        super();
    }

}