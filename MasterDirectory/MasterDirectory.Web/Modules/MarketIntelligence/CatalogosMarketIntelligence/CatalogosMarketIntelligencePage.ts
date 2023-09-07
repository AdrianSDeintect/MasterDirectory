import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosMarketIntelligenceGrid } from './CatalogosMarketIntelligenceGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosMarketIntelligenceGrid($('#GridDiv')).element);
}