import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaMerchandisingForm, CategoriaMerchandisingRow, CategoriaMerchandisingService } from '../../ServerTypes/Merchandising';

@Decorators.registerClass('MasterDirectory.Merchandising.CategoriaMerchandisingDialog')
@Decorators.panel()
export class CategoriaMerchandisingDialog extends EntityDialog<CategoriaMerchandisingRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaMerchandisingForm.formKey; }
    protected getRowDefinition() { return CategoriaMerchandisingRow; }
    protected getService() { return CategoriaMerchandisingService.baseUrl; }

    protected form = new CategoriaMerchandisingForm(this.idPrefix);


    constructor() {
        super();
    }
}