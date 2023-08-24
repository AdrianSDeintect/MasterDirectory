import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosConsultoriosForm, CatalogosConsultoriosRow, CatalogosConsultoriosService } from '../../ServerTypes/Consultorios';

@Decorators.registerClass('MasterDirectory.Consultorios.CatalogosConsultoriosDialog')
export class CatalogosConsultoriosDialog extends EntityDialog<CatalogosConsultoriosRow, any> {
    protected getFormKey() { return CatalogosConsultoriosForm.formKey; }
    protected getRowDefinition() { return CatalogosConsultoriosRow; }
    protected getService() { return CatalogosConsultoriosService.baseUrl; }

    protected form = new CatalogosConsultoriosForm(this.idPrefix);
}