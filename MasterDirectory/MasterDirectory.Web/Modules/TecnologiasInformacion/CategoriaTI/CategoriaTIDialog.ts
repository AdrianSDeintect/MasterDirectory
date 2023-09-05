import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaTIForm, CategoriaTIRow, CategoriaTIService } from '../../ServerTypes/TecnologiasInformacion';

@Decorators.panel()
@Decorators.registerClass('MasterDirectory.TecnologiasInformacion.CategoriaTIDialog')
export class CategoriaTIDialog extends EntityDialog<CategoriaTIRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaTIForm.formKey; }
    protected getRowDefinition() { return CategoriaTIRow; }
    protected getService() { return CategoriaTIService.baseUrl; }

    protected form = new CategoriaTIForm(this.idPrefix);
    constructor() {
        super();
    }

}