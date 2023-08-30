import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaRHGrid } from './CategoriaRHGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaRHGrid($('#GridDiv')).element);
}