import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaMarketIntelligenceGrid } from './CategoriaMarketIntelligenceGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaMarketIntelligenceGrid($('#GridDiv')).element);
}