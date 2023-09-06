import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaTIRow {
    LocalSap?: string;
    UsuarioGeo?: string;
    Emaillocal?: string;
    Extension?: string;
    Telefono?: string;
}

export abstract class CategoriaTIRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'TecnologiasInformacion.CategoriaTI';
    static readonly deletePermission = 'TecnologiasInformacion:Delete';
    static readonly insertPermission = 'TecnologiasInformacion:Modify';
    static readonly readPermission = 'TecnologiasInformacion:View';
    static readonly updatePermission = 'TecnologiasInformacion:Modify';

    static readonly Fields = fieldsProxy<CategoriaTIRow>();
}