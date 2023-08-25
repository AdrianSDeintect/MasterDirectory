import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaExpansionRow {
    LocalSap?: string;
    TipoFarmacia?: string;
    LocationType?: string;
    Reapertura?: string;
    Comsuc?: string;
    TipoEstaciona?: string;
    NCajonesEstaciona?: string;
    Ciudad?: string;
    Estado?: string;
    Direccion?: string;
    NExterior?: string;
    Colonia?: string;
    Cp?: string;
    Latitud?: string;
    Longuitud?: string;
    FormatoFarmAlcance?: string;
    Pantallas?: string;
    ProvMobiliario?: string;
    ColorMob?: string;
    Dermo?: string;
}

export abstract class CategoriaExpansionRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Expansion.CategoriaExpansion';
    static readonly deletePermission = 'Expansion:Delete';
    static readonly insertPermission = 'Expansion:Modify';
    static readonly readPermission = 'Expansion:View';
    static readonly updatePermission = 'Expansion:Modify';

    static readonly Fields = fieldsProxy<CategoriaExpansionRow>();
}