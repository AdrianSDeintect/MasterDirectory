import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaComercialesGrid } from './CategoriaComercialesGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaComercialesGrid($('#GridDiv')).element);
}