import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategoriaMarketIntelligenceForm } from '../../ServerTypes/MarketIntelligence/CategoriaMarketIntelligenceForm';
import { CategoriaMarketIntelligenceRow } from '../../ServerTypes/MarketIntelligence/CategoriaMarketIntelligenceRow';
import { CategoriaMarketIntelligenceService } from '../../ServerTypes/MarketIntelligence/CategoriaMarketIntelligenceService';

@Decorators.panel()
@Decorators.registerClass('MasterDirectory.MarketIntelligence.CategoriaMarketIntelligenceDialog')
export class CategoriaMarketIntelligenceDialog extends EntityDialog<CategoriaMarketIntelligenceRow, any> {

    public dialogOpen(asPanel?: boolean): void {
        super.dialogOpen(asPanel);
    }

    protected getFormKey() { return CategoriaMarketIntelligenceForm.formKey; }
    protected getRowDefinition() { return CategoriaMarketIntelligenceRow; }
    protected getService() { return CategoriaMarketIntelligenceService.baseUrl; }

    protected form = new CategoriaMarketIntelligenceForm(this.idPrefix);

    constructor() {
        super();
    }

}