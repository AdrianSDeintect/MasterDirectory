import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosExpansionGrid } from './CatalogosExpansionGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosExpansionGrid($('#GridDiv')).element);
}