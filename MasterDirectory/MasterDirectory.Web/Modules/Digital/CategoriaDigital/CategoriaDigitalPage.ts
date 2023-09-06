import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaDigitalGrid } from './CategoriaDigitalGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaDigitalGrid($('#GridDiv')).element);
}