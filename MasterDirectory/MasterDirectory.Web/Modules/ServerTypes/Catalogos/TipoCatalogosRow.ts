import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface TipoCatalogosRow {
    IdCons?: number;
    IdtipoCategoria?: number;
    IdtipoCatalogo?: number;
    TipoCatalogo?: string;
    Activo?: number;
    NombreTipoCategoria?: string;
}

export abstract class TipoCatalogosRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'TipoCatalogo';
    static readonly localTextPrefix = 'Catalogos.TipoCatalogos';
    static readonly lookupKey = 'Catalogos.TipoCatalogos';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TipoCatalogosRow>('Catalogos.TipoCatalogos') }
    static async getLookupAsync() { return getLookupAsync<TipoCatalogosRow>('Catalogos.TipoCatalogos') }

    static readonly deletePermission = 'Catalogos:TipoCatalogos:Delete';
    static readonly insertPermission = 'Catalogos:TipoCatalogos:Modify';
    static readonly readPermission = 'Catalogos:TipoCatalogos:View';
    static readonly updatePermission = 'Catalogos:TipoCatalogos:Modify';

    static readonly Fields = fieldsProxy<TipoCatalogosRow>();
}