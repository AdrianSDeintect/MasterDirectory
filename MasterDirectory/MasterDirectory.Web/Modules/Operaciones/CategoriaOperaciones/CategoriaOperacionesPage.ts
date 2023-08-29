import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaOperacionesGrid } from './CategoriaOperacionesGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaOperacionesGrid($('#GridDiv')).element);
}