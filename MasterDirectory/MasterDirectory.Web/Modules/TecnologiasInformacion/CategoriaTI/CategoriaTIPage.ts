import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaTIGrid } from './CategoriaTIGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaTIGrid($('#GridDiv')).element);
}