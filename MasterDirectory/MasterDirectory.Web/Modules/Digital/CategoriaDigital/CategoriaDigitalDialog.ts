import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaDigitalForm, CategoriaDigitalRow, CategoriaDigitalService } from '../../ServerTypes/Digital';

@Decorators.panel()
@Decorators.registerClass('MasterDirectory.Digital.CategoriaDigitalDialog')
export class CategoriaDigitalDialog extends EntityDialog<CategoriaDigitalRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaDigitalForm.formKey; }
    protected getRowDefinition() { return CategoriaDigitalRow; }
    protected getService() { return CategoriaDigitalService.baseUrl; }

    protected form = new CategoriaDigitalForm(this.idPrefix);

    constructor() {
        super();
    }

}