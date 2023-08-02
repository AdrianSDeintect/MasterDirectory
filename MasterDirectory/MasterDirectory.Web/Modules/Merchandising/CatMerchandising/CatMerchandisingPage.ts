import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatMerchandisingGrid } from './CatMerchandisingGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatMerchandisingGrid($('#GridDiv')).element);
}