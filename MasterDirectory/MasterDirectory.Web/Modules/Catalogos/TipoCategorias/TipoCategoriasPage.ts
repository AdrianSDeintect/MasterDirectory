import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TipoCategoriasGrid } from './TipoCategoriasGrid';

export default function pageInit() {
    initFullHeightGridPage(new TipoCategoriasGrid($('#GridDiv')).element);
}