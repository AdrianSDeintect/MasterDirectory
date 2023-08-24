import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaConsultoriosForm, CategoriaConsultoriosRow, CategoriaConsultoriosService } from '../../ServerTypes/Consultorios';

@Decorators.registerClass('MasterDirectory.Consultorios.CategoriaConsultoriosDialog')
@Decorators.panel()
export class CategoriaConsultoriosDialog extends EntityDialog<CategoriaConsultoriosRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaConsultoriosForm.formKey; }
    protected getRowDefinition() { return CategoriaConsultoriosRow; }
    protected getService() { return CategoriaConsultoriosService.baseUrl; }

    protected form = new CategoriaConsultoriosForm(this.idPrefix);

    constructor() {
        super();
    }

}