import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatMerchandisingForm, CatMerchandisingRow, CatMerchandisingService } from '../../ServerTypes/Merchandising';

/*@Serenity.Decorators.panel()*/
@Decorators.registerClass('MasterDirectory.Merchandising.CatMerchandisingDialog')
@Decorators.panel()
export class CatMerchandisingDialog extends EntityDialog<CatMerchandisingRow, any> {


    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
       /* this.form.VchDesPlanograma.element.focus();*/
    }


    protected getFormKey() { return CatMerchandisingForm.formKey; }
    protected getRowDefinition() { return CatMerchandisingRow; }
    protected getService() { return CatMerchandisingService.baseUrl; }

    protected form = new CatMerchandisingForm(this.idPrefix);

    //public onDialogOpen() {
    //    super.onDialogOpen();

    //}
    constructor() {
        super();
        this.form.LocalSap.element.css('height', '50px');
        this.form.LocalSap.element.css('font-size', 'medium')
        this.form.TipoSucursal.element.css('font-size', 'medium')
        this.form.TipoSucursal.element.css('height', '50px')
    }
}
