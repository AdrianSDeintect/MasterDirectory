import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosUltimaMillaGrid } from './CatalogosUltimaMillaGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosUltimaMillaGrid($('#GridDiv')).element);
}