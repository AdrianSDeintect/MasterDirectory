import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosMerchandisingRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
    DescripcionClave?: string;
}

export abstract class CatalogosMerchandisingRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'DescripcionClave';
    static readonly localTextPrefix = 'Merchandising.CatalogosMerchandising';
    static readonly lookupKey = 'Merchandising.CatalogosMerchandising';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CatalogosMerchandisingRow>('Merchandising.CatalogosMerchandising') }
    static async getLookupAsync() { return getLookupAsync<CatalogosMerchandisingRow>('Merchandising.CatalogosMerchandising') }

    static readonly deletePermission = 'Catalogos:TipoCatalogos:Delete';
    static readonly insertPermission = 'Catalogos:TipoCatalogos:Modify';
    static readonly readPermission = 'Catalogos:TipoCatalogos:View';
    static readonly updatePermission = 'Catalogos:TipoCatalogos:Modify';

    static readonly Fields = fieldsProxy<CatalogosMerchandisingRow>();
}