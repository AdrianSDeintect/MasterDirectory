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

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TipoCatalogosRow>();
}