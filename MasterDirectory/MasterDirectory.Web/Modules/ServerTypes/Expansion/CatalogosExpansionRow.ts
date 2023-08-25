import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosExpansionRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosExpansionRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Expansion.CatalogosExpansion';
    static readonly deletePermission = 'Expansion:Delete';
    static readonly insertPermission = 'Expansion:Modify';
    static readonly readPermission = 'Expansion:View';
    static readonly updatePermission = 'Expansion:Modify';

    static readonly Fields = fieldsProxy<CatalogosExpansionRow>();
}