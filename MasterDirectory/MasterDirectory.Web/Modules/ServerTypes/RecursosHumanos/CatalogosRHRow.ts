import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosRHRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosRHRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'RecursosHumanos.CatalogosRH';
    static readonly deletePermission = 'RecursosHumanos:Delete';
    static readonly insertPermission = 'RecursosHumanos:Modify';
    static readonly readPermission = 'RecursosHumanos:View';
    static readonly updatePermission = 'RecursosHumanos:Modify';

    static readonly Fields = fieldsProxy<CatalogosRHRow>();
}