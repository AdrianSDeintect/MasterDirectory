import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaUltimaMillaRow {
    LocalSap?: string;
    Estado?: string;
    Prov99Min?: string;
    ProvMu?: string;
    ProvCid?: string;
    ProvRappiCargo?: string;
    VentaTelf99Min?: string;
    VentaTelfMu?: string;
    VentaTelfCid?: string;
    VentaTelfRappiCargo?: string;
    Garantizado99Min?: string;
    GarantizadoMu?: string;
    GarantizadoCid?: string;
    ECommerceDelivery?: string;
    ECommerceClickCollect?: string;
    ECommerceTipo?: string;
    Fijo99Min?: string;
    FijoMu?: string;
    FijoCid?: string;
    OnDemandMu?: string;
    OnDemandRappiCargo?: string;
    CanalesDigitalesRappi?: string;
    CanalesDigitalesUber?: string;
    ServicioEfectivo1?: string;
    ServicioEfectivo2?: string;
    ServicioEfectivo3?: string;
    ServicioEfectivo4?: string;
    ServicioEfectivo5?: string;
    ServicioEfectivo6?: string;
    ServicioEfectivo7?: string;
    ServicioEfectivo8?: string;
    ServicioTarjeta9?: string;
    ServicioTarjeta10?: string;
    ServicioTarjeta11?: string;
    ServicioTarjeta12?: string;
    InicioServicio?: string;
    CierreServicio?: string;
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