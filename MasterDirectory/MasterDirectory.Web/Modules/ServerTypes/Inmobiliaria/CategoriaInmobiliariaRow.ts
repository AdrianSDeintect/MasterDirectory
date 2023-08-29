import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaInmobiliariaRow {
    LocalSap?: string;
    Farmacia?: string;
    Colonia?: string;
    FechaApertura?: string;
    Accesos?: string;
    Ubicacion?: string;
}

export abstract class CategoriaInmobiliariaRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Inmobiliaria.CategoriaInmobiliaria';
    static readonly deletePermission = 'Inmobiliaria:Delete';
    static readonly insertPermission = 'Inmobiliaria:Modify';
    static readonly readPermission = 'Inmobiliaria:View';
    static readonly updatePermission = 'Inmobiliaria:Modify';

    static readonly Fields = fieldsProxy<CategoriaInmobiliariaRow>();
}