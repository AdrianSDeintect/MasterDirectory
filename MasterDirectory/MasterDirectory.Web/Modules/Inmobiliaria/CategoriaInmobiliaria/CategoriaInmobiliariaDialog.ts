import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaInmobiliariaForm, CategoriaInmobiliariaRow, CategoriaInmobiliariaService } from '../../ServerTypes/Inmobiliaria';

@Decorators.registerClass('MasterDirectory.Inmobiliaria.CategoriaInmobiliariaDialog')
@Decorators.panel()
export class CategoriaInmobiliariaDialog extends EntityDialog<CategoriaInmobiliariaRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaInmobiliariaForm.formKey; }
    protected getRowDefinition() { return CategoriaInmobiliariaRow; }
    protected getService() { return CategoriaInmobiliariaService.baseUrl; }

    protected form = new CategoriaInmobiliariaForm(this.idPrefix);

    constructor() {
        super();
    }

}