import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosConsultoriosRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosConsultoriosRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'Consultorios.CatalogosConsultorios';
    static readonly deletePermission = 'Consultorios:Delete';
    static readonly insertPermission = 'Consultorios:Modify';
    static readonly readPermission = 'Consultorios:View';
    static readonly updatePermission = 'Consultorios:Modify';

    static readonly Fields = fieldsProxy<CatalogosConsultoriosRow>();
}