import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TipoCategoriasColumns, TipoCategoriasRow, TipoCategoriasService } from '../../ServerTypes/Catalogos';
import { TipoCategoriasDialog } from './TipoCategoriasDialog';

@Decorators.registerClass('MasterDirectory.Catalogos.TipoCategoriasGrid')
export class TipoCategoriasGrid extends EntityGrid<TipoCategoriasRow, any> {
    protected getColumnsKey() { return TipoCategoriasColumns.columnsKey; }
    protected getDialogType() { return TipoCategoriasDialog; }
    protected getRowDefinition() { return TipoCategoriasRow; }
    protected getService() { return TipoCategoriasService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}