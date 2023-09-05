import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosTIGrid } from './CatalogosTIGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosTIGrid($('#GridDiv')).element);
}