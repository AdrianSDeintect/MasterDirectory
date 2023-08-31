import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosTesoreriaGrid } from './CatalogosTesoreriaGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosTesoreriaGrid($('#GridDiv')).element);
}