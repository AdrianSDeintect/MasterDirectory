import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosDigitalRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosDigitalRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Digital.CatalogosDigital';
    static readonly deletePermission = 'Digital:Delete';
    static readonly insertPermission = 'Digital:Modify';
    static readonly readPermission = 'Digital:View';
    static readonly updatePermission = 'Digital:Modify';

    static readonly Fields = fieldsProxy<CatalogosDigitalRow>();
}