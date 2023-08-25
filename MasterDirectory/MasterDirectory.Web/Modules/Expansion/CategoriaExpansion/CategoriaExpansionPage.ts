import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaExpansionGrid } from './CategoriaExpansionGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaExpansionGrid($('#GridDiv')).element);
}