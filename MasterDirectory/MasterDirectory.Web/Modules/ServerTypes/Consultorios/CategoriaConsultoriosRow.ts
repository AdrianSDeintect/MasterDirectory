import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaConsultoriosRow {
    LocalSap?: string;
    ConsulOperacion?: string;
    Benamedic?: string;
    HorarioLv?: string;
    HorarioS?: string;
    HorarioD?: string;
}

export abstract class CategoriaConsultoriosRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Consultorios.CategoriaConsultorios';
    static readonly deletePermission = 'Consultorios:Delete';
    static readonly insertPermission = 'Consultorios:Modify';
    static readonly readPermission = 'Consultorios:View';
    static readonly updatePermission = 'Consultorios:Modify';

    static readonly Fields = fieldsProxy<CategoriaConsultoriosRow>();
}