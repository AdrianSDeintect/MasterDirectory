import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosRHGrid } from './CatalogosRHGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosRHGrid($('#GridDiv')).element);
}