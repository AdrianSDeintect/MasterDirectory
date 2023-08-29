import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosOperacionesGrid } from './CatalogosOperacionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosOperacionesGrid($('#GridDiv')).element);
}