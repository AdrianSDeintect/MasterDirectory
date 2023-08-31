import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaTesoreriaGrid } from './CategoriaTesoreriaGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaTesoreriaGrid($('#GridDiv')).element);
}