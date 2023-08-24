import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosUltimaMillaRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosUltimaMillaRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'UltimaMilla.CatalogosUltimaMilla';
    static readonly deletePermission = 'UltimaMilla:Delete';
    static readonly insertPermission = 'UltimaMilla:Modify';
    static readonly readPermission = 'UltimaMilla:View';
    static readonly updatePermission = 'UltimaMilla:Modify';

    static readonly Fields = fieldsProxy<CatalogosUltimaMillaRow>();
}