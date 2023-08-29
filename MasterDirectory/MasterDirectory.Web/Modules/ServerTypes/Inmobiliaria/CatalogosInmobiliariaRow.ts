import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosInmobiliariaRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosInmobiliariaRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Inmobiliaria.CatalogosInmobiliaria';
    static readonly deletePermission = 'Inmobiliaria:Delete';
    static readonly insertPermission = 'Inmobiliaria:Modify';
    static readonly readPermission = 'Inmobiliaria:View';
    static readonly updatePermission = 'Inmobiliaria:Modify';

    static readonly Fields = fieldsProxy<CatalogosInmobiliariaRow>();
}