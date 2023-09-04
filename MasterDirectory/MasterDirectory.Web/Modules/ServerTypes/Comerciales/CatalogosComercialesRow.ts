import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosComercialesRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosComercialesRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Comerciales.CatalogosComerciales';
    static readonly deletePermission = 'Comerciales:Delete';
    static readonly insertPermission = 'Comerciales:Modify';
    static readonly readPermission = 'Comerciales:View';
    static readonly updatePermission = 'Comerciales:Modify';

    static readonly Fields = fieldsProxy<CatalogosComercialesRow>();
}