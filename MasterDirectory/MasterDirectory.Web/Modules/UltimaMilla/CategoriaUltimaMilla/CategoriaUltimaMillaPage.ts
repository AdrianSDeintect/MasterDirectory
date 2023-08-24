import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaUltimaMillaGrid } from './CategoriaUltimaMillaGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaUltimaMillaGrid($('#GridDiv')).element);
}