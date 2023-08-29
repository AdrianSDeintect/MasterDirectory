import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaExpansionForm, CategoriaExpansionRow, CategoriaExpansionService } from '../../ServerTypes/Expansion';

@Decorators.registerClass('MasterDirectory.Expansion.CategoriaExpansionDialog')
@Decorators.panel()
export class CategoriaExpansionDialog extends EntityDialog<CategoriaExpansionRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaExpansionForm.formKey; }
    protected getRowDefinition() { return CategoriaExpansionRow; }
    protected getService() { return CategoriaExpansionService.baseUrl; }

    protected form = new CategoriaExpansionForm(this.idPrefix);

    constructor() {
        super();
    }

}