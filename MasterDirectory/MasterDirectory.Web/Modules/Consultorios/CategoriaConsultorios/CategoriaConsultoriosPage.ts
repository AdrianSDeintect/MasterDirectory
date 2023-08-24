import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaConsultoriosGrid } from './CategoriaConsultoriosGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaConsultoriosGrid($('#GridDiv')).element);
}