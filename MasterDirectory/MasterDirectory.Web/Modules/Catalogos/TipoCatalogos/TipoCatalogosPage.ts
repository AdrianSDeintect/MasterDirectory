import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TipoCatalogosGrid } from './TipoCatalogosGrid';

export default function pageInit() {
    initFullHeightGridPage(new TipoCatalogosGrid($('#GridDiv')).element);
}