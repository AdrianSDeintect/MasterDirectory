import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TipoCategoriasRow {
    IdtipoCategoria?: number;
    TipoCategoria?: string;
    Activo?: number;
}

export abstract class TipoCategoriasRow {
    static readonly idProperty = 'IdtipoCategoria';
    static readonly nameProperty = 'TipoCategoria';
    static readonly localTextPrefix = 'Catalogos.TipoCategorias';
    static readonly lookupKey = 'Catalogos.TipoCategorias';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TipoCategoriasRow>('Catalogos.TipoCategorias') }
    static async getLookupAsync() { return getLookupAsync<TipoCategoriasRow>('Catalogos.TipoCategorias') }

    static readonly deletePermission = 'Catalogos:TipoCategorias:Delete';
    static readonly insertPermission = 'Catalogos:TipoCategorias:Modify';
    static readonly readPermission = 'Catalogos:TipoCategorias:View';
    static readonly updatePermission = 'Catalogos:TipoCategorias:Modify';

    static readonly Fields = fieldsProxy<TipoCategoriasRow>();
}