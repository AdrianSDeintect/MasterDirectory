import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CatalogosTIRow {
    IdCons?: number;
    IdtipoCatalogo?: number;
    IdClave?: number;
    Descripcion?: string;
    Activo?: number;
    NombreTipoCatalogo?: string;
}

export abstract class CatalogosTIRow {
    static readonly idProperty = 'IdCons';
    static readonly nameProperty = 'Descripcion';
    static readonly localTextPrefix = 'TecnologiasInformacion.CatalogosTI';
    static readonly deletePermission = 'TecnologiasInformacion:Delete';
    static readonly insertPermission = 'TecnologiasInformacion:Modify';
    static readonly readPermission = 'TecnologiasInformacion:View';
    static readonly updatePermission = 'TecnologiasInformacion:Modify';

    static readonly Fields = fieldsProxy<CatalogosTIRow>();
}