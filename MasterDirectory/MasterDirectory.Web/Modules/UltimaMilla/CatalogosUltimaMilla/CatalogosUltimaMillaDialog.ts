import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosUltimaMillaForm, CatalogosUltimaMillaRow, CatalogosUltimaMillaService } from '../../ServerTypes/UltimaMilla';

@Decorators.registerClass('MasterDirectory.UltimaMilla.CatalogosUltimaMillaDialog')
export class CatalogosUltimaMillaDialog extends EntityDialog<CatalogosUltimaMillaRow, any> {
    protected getFormKey() { return CatalogosUltimaMillaForm.formKey; }
    protected getRowDefinition() { return CatalogosUltimaMillaRow; }
    protected getService() { return CatalogosUltimaMillaService.baseUrl; }

    protected form = new CatalogosUltimaMillaForm(this.idPrefix);
}