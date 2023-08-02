import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib/q";

export interface CatMerchandisingRow {
    LocalSap?: string;
    TipoSenalizacion?: number;
    ScreenDisplay?: number;
    TramosLisos?: number;
    TamanoMiniheders?: number;
    TamanoHeader?: number;
    Checkout?: number;
    MedidaCabecera?: number;
    EndCap?: number;
    MedidaGrafico?: number;
    BusStop?: number;
    Aretes?: number;
    ExhibidorRetail?: number;
    ExhibidorGloblaBrands?: number;
    ExhibidorWellBeginnings?: number;
    ExhibidorInstitucional?: number;
    ExhibidorMascarillas?: number;
    ExhibidorGenerico?: number;
    CabecerasInstitucionales?: number;
    TramosFarma?: number;
    PortaposterCanceleria?: number;
    MedidasPecheras?: number;
    MedidaCopete?: number;
    MedidasCanceleria?: string;
    M2Calc?: number;
    RutaDli?: string;
    TipoSucursal?: number;
    NombreTipoSenalizacion?: string;
    NombreScreenDisplay?: string;
    NombreTramosLisos?: string;
    NombreTamanoMiniHeader?: string;
    NombreTamanoHeader?: string;
    NombreCheckout?: string;
    NombreMedidaCabecera?: string;
    NombreEndCap?: string;
    NombreMedidaGrafico?: string;
    NombreBusStop?: string;
    NombreAretes?: string;
    NombreExhibidorRetail?: string;
    NombreExhibidorGloblaBrands?: string;
    NombreExhibidorWellBeginnings?: string;
    NombreExhibidorInstitucional?: string;
    NombreExhibidorMascarillas?: string;
    NombreExhibidorGenerico?: string;
    NombreCabecerasInstitucionales?: string;
    NombreTramosFarma?: string;
    NombrePortaposterCanceleria?: string;
    NombreMedidasPecheras?: string;
    NombreMedidasCanceleria?: string;
    NombreM2Calc?: string;
    NombreTipoSucursal?: string;
}

export abstract class CatMerchandisingRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Merchandising.CatMerchandising';
    static readonly lookupKey = 'SCatMerchaLookup';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CatMerchandisingRow>('SCatMerchaLookup') }
    static async getLookupAsync() { return getLookupAsync<CatMerchandisingRow>('SCatMerchaLookup') }

    static readonly deletePermission = 'Merchadising:CatMerchandising';
    static readonly insertPermission = 'Merchadising:CatMerchandising';
    static readonly readPermission = 'Merchadising:CatMerchandising';
    static readonly updatePermission = 'Merchadising:CatMerchandising';

    static readonly Fields = fieldsProxy<CatMerchandisingRow>();
}