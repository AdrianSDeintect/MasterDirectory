import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosMarketIntelligenceRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosMarketIntelligenceRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'MarketIntelligence.CatalogosMarketIntelligence';
    static readonly deletePermission = 'MarketIntelligence:Delete';
    static readonly insertPermission = 'MarketIntelligence:Modify';
    static readonly readPermission = 'MarketIntelligence:View';
    static readonly updatePermission = 'MarketIntelligence:Modify';

    static readonly Fields = fieldsProxy<CatalogosMarketIntelligenceRow>();
}