import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosTesoreriaRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosTesoreriaRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Tesoreria.CatalogosTesoreria';
    static readonly deletePermission = 'Tesoreria:Delete';
    static readonly insertPermission = 'Tesoreria:Modify';
    static readonly readPermission = 'Tesoreria:View';
    static readonly updatePermission = 'Tesoreria:Modify';

    static readonly Fields = fieldsProxy<CatalogosTesoreriaRow>();
}