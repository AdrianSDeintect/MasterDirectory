import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaTesoreriaForm, CategoriaTesoreriaRow, CategoriaTesoreriaService } from '../../ServerTypes/Tesoreria';
@Decorators.panel()

@Decorators.registerClass('MasterDirectory.Tesoreria.CategoriaTesoreriaDialog')
export class CategoriaTesoreriaDialog extends EntityDialog<CategoriaTesoreriaRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }
    protected getFormKey() { return CategoriaTesoreriaForm.formKey; }
    protected getRowDefinition() { return CategoriaTesoreriaRow; }
    protected getService() { return CategoriaTesoreriaService.baseUrl; }

    protected form = new CategoriaTesoreriaForm(this.idPrefix);

    constructor() {
        super();
    }

}