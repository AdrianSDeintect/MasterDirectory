import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaOperacionesRow {
    LocalSap?: string;
    Region?: string;
    EdoLocal?: string;
    Zona?: string;
    Geo?: string;
    MailGeo?: string;
    DirectorRegional?: string;
    HorarioLv?: string;
    HorarioS?: string;
    HorarioDyF?: string;
}

export abstract class CategoriaOperacionesRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Operaciones.CategoriaOperaciones';
    static readonly deletePermission = 'Operaciones:Delete';
    static readonly insertPermission = 'Operaciones:Modify';
    static readonly readPermission = 'Operaciones:View';
    static readonly updatePermission = 'Operaciones:Modify';

    static readonly Fields = fieldsProxy<CategoriaOperacionesRow>();
}