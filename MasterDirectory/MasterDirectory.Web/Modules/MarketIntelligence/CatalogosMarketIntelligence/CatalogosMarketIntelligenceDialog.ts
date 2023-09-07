import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CatalogosMarketIntelligenceForm, CatalogosMarketIntelligenceRow, CatalogosMarketIntelligenceService } from '../../ServerTypes/MarketIntelligence';

@Decorators.registerClass('MasterDirectory.MarketIntelligence.CatalogosMarketIntelligenceDialog')
export class CatalogosMarketIntelligenceDialog extends EntityDialog<CatalogosMarketIntelligenceRow, any> {
    protected getFormKey() { return CatalogosMarketIntelligenceForm.formKey; }
    protected getRowDefinition() { return CatalogosMarketIntelligenceRow; }
    protected getService() { return CatalogosMarketIntelligenceService.baseUrl; }

    protected form = new CatalogosMarketIntelligenceForm(this.idPrefix);
}