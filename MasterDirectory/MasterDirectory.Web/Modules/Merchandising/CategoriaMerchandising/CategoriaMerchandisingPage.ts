import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaMerchandisingGrid } from './CategoriaMerchandisingGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaMerchandisingGrid($('#GridDiv')).element);
}