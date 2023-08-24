import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosFinanzasRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosFinanzasRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Finanzas.CatalogosFinanzas';
    static readonly deletePermission = 'Finanzas:Delete';
    static readonly insertPermission = 'Finanzas:Modify';
    static readonly readPermission = 'Finanzas:View';
    static readonly updatePermission = 'Finanzas:Modify';

    static readonly Fields = fieldsProxy<CatalogosFinanzasRow>();
}