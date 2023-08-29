import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { CategoriaInmobiliariaGrid } from './CategoriaInmobiliariaGrid';

export default function pageInit() {
    initFullHeightGridPage(new CategoriaInmobiliariaGrid($('#GridDiv')).element);
}