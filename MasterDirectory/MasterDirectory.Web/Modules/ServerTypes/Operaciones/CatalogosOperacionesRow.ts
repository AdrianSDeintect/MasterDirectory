import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosOperacionesRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosOperacionesRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Operaciones.CatalogosOperaciones';
    static readonly deletePermission = 'Operaciones:Delete';
    static readonly insertPermission = 'Operaciones:Modify';
    static readonly readPermission = 'Operaciones:View';
    static readonly updatePermission = 'Operaciones:Modify';

    static readonly Fields = fieldsProxy<CatalogosOperacionesRow>();
}