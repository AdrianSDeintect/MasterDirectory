import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CatalogosMerchandisingGrid } from './CatalogosMerchandisingGrid';

export default function pageInit() {
    initFullHeightGridPage(new CatalogosMerchandisingGrid($('#GridDiv')).element);
}