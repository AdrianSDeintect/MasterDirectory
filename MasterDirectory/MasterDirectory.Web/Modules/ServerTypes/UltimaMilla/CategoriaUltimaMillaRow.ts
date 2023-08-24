import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaUltimaMillaRow {
    LocalSap?: string;
    VentaTelefonica?: string;
    Garantizado?: string;
    Hub?: string;
    ECommerce?: string;
    TipoEComm?: string;
    Rappi?: string;
    Tablet?: string;
    NSerie?: string;
    EstatusTablet?: string;
    Qr?: string;
    ServicioDomicilio?: string;
    PruebaUber?: string;
}

export abstract class CategoriaUltimaMillaRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'UltimaMilla.CategoriaUltimaMilla';
    static readonly deletePermission = 'UltimaMilla:Delete';
    static readonly insertPermission = 'UltimaMilla:Modify';
    static readonly readPermission = 'UltimaMilla:View';
    static readonly updatePermission = 'UltimaMilla:Modify';

    static readonly Fields = fieldsProxy<CategoriaUltimaMillaRow>();
}