import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaDigitalRow {
    LocalSap?: string;
    DirGoogle?: string;
    Latitud?: string;
    Longitud?: string;
}

export abstract class CategoriaDigitalRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Digital.CategoriaDigital';
    static readonly deletePermission = 'Digital:Delete';
    static readonly insertPermission = 'Digital:Modify';
    static readonly readPermission = 'Digital:View';
    static readonly updatePermission = 'Digital:Modify';

    static readonly Fields = fieldsProxy<CategoriaDigitalRow>();
}