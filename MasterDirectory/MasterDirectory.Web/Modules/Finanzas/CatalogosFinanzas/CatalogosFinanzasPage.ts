import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosFinanzasGrid } from './CatalogosFinanzasGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosFinanzasGrid($('#GridDiv')).element);
}