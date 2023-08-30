import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaRHRow {
    LocalSap?: string;
    Plantilla?: string;
    Vacantes?: string;
}

export abstract class CategoriaRHRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'RecursosHumanos.CategoriaRH';
    static readonly deletePermission = 'RecursosHumanos:Delete';
    static readonly insertPermission = 'RecursosHumanos:Modify';
    static readonly readPermission = 'RecursosHumanos:View';
    static readonly updatePermission = 'RecursosHumanos:Modify';

    static readonly Fields = fieldsProxy<CategoriaRHRow>();
}