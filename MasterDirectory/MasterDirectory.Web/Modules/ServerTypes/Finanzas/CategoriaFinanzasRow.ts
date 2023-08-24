import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaFinanzasRow {
    LocalSap?: string;
    Mercado?: string;
    FechaCierre?: string;
    EstatusFarmacia?: string;
    Top360?: string;
    MarketCluster?: string;
    TopMkt?: string;
    MarketDaily?: string;
    DailyMarketOrder?: string;
    RegionCluster?: string;
    Top550?: string;
    KeyState?: string;
    CecoFarmacias?: string;
    CecoConsultorio?: string;
    CecoEcommerce?: string;
}

export abstract class CategoriaFinanzasRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Finanzas.CategoriaFinanzas';
    static readonly deletePermission = 'Finanzas:Delete';
    static readonly insertPermission = 'Finanzas:Modify';
    static readonly readPermission = 'Finanzas:View';
    static readonly updatePermission = 'Finanzas:Modify';

    static readonly Fields = fieldsProxy<CategoriaFinanzasRow>();
}