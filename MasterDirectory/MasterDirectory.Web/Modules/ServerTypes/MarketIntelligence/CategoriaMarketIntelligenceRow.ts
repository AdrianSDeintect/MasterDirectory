import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaMarketIntelligenceRow {
    LocalSap?: string;
    Nse?: string;
    Cluster?: string;
    Brick?: string;
}

export abstract class CategoriaMarketIntelligenceRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'MarketIntelligence.CategoriaMarketIntelligence';
    static readonly deletePermission = 'MarketIntelligence:Delete';
    static readonly insertPermission = 'MarketIntelligence:Modify';
    static readonly readPermission = 'MarketIntelligence:View';
    static readonly updatePermission = 'MarketIntelligence:Modify';

    static readonly Fields = fieldsProxy<CategoriaMarketIntelligenceRow>();
}