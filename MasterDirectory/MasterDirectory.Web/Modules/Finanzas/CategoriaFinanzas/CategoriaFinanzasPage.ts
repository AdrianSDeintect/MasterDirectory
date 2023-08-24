import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaFinanzasGrid } from './CategoriaFinanzasGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaFinanzasGrid($('#GridDiv')).element);
}