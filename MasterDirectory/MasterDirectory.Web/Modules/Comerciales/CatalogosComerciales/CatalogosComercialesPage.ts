import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosComercialesGrid } from './CatalogosComercialesGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosComercialesGrid($('#GridDiv')).element);
}