import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaTesoreriaRow {
    LocalSap?: string;
    Cajero?: string;
}

export abstract class CategoriaTesoreriaRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Tesoreria.CategoriaTesoreria';
    static readonly deletePermission = 'Tesoreria:Delete';
    static readonly insertPermission = 'Tesoreria:Modify';
    static readonly readPermission = 'Tesoreria:View';
    static readonly updatePermission = 'Tesoreria:Modify';

    static readonly Fields = fieldsProxy<CategoriaTesoreriaRow>();
}