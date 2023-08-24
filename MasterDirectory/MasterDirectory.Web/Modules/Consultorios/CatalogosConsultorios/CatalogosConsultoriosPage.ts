import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosConsultoriosGrid } from './CatalogosConsultoriosGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosConsultoriosGrid($('#GridDiv')).element);
}