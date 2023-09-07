import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaMerchandisingRow {
    LocalSap?: string;
    TipoSenalizacion?: string;
    ScreenDisplay?: string;
    TramosLisos?: string;
    TamanoMiniheders?: string;
    TamanoHeader?: string;
    Checkout?: string;
    MedidaCabecera?: string;
    EndCap?: string;
    MedidaGrafico?: string;
    BusStop?: string;
    Aretes?: string;
    ExhibidorRetail?: string;
    ExhibidorGloblaBrands?: string;
    ExhibidorWellBeginnings?: string;
    ExhibidorInstitucional?: string;
    ExhibidorMascarillas?: string;
    ExhibidorGenerico?: string;
    CabecerasInstitucionales?: string;
    TramosFarma?: string;
    PortaposterCanceleria?: string;
    MedidasPecheras?: string;
    MedidaCopete?: string;
    MedidasCanceleria?: string;
    M2Calc?: string;
    RutaDli?: string;
    TipoSucursal?: string;
    RampaDiscapa?: string;
}

export abstract class CategoriaMerchandisingRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Merchandising.CategoriaMerchandising';
    static readonly deletePermission = 'Merchandising:Delete';
    static readonly insertPermission = 'Merchandising:Modify';
    static readonly readPermission = 'Merchandising:View';
    static readonly updatePermission = 'Merchandising:Modify';

    static readonly Fields = fieldsProxy<CategoriaMerchandisingRow>();
}