import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosDigitalGrid } from './CatalogosDigitalGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosDigitalGrid($('#GridDiv')).element);
}