import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosInmobiliariaGrid } from './CatalogosInmobiliariaGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosInmobiliariaGrid($('#GridDiv')).element);
}