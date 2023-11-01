import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaUltimaMillaForm {
    LocalSap: StringEditor;
    Estado: LookupEditor;
    Prov99Min: LookupEditor;
    ProvMu: LookupEditor;
    ProvCid: LookupEditor;
    ProvRappiCargo: LookupEditor;
    VentaTelf99Min: LookupEditor;
    VentaTelfMu: LookupEditor;
    VentaTelfCid: LookupEditor;
    VentaTelfRappiCargo: LookupEditor;
    Garantizado99Min: LookupEditor;
    GarantizadoMu: LookupEditor;
    GarantizadoCid: LookupEditor;
    ECommerceDelivery: LookupEditor;
    ECommerceClickCollect: LookupEditor;
    ECommerceTipo: LookupEditor;
    Fijo99Min: LookupEditor;
    FijoMu: LookupEditor;
    FijoCid: LookupEditor;
    OnDemandMu: LookupEditor;
    OnDemandRappiCargo: LookupEditor;
    CanalesDigitalesRappi: LookupEditor;
    CanalesDigitalesUber: LookupEditor;
    ServicioEfectivo1: LookupEditor;
    ServicioEfectivo2: LookupEditor;
    ServicioEfectivo3: LookupEditor;
    ServicioEfectivo4: LookupEditor;
    ServicioEfectivo5: LookupEditor;
    ServicioEfectivo6: LookupEditor;
    ServicioEfectivo7: LookupEditor;
    ServicioEfectivo8: LookupEditor;
    ServicioTarjeta9: LookupEditor;
    ServicioTarjeta10: LookupEditor;
    ServicioTarjeta11: LookupEditor;
    ServicioTarjeta12: LookupEditor;
    InicioServicio: StringEditor;
    CierreServicio: StringEditor;
}

export class CategoriaUltimaMillaForm extends PrefixedContext {
    static formKey = 'UltimaMilla.CategoriaUltimaMilla';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaUltimaMillaForm.init)  {
            CategoriaUltimaMillaForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CategoriaUltimaMillaForm, [
                'LocalSap', w0,
                'Estado', w1,
                'Prov99Min', w1,
                'ProvMu', w1,
                'ProvCid', w1,
                'ProvRappiCargo', w1,
                'VentaTelf99Min', w1,
                'VentaTelfMu', w1,
                'VentaTelfCid', w1,
                'VentaTelfRappiCargo', w1,
                'Garantizado99Min', w1,
                'GarantizadoMu', w1,
                'GarantizadoCid', w1,
                'ECommerceDelivery', w1,
                'ECommerceClickCollect', w1,
                'ECommerceTipo', w1,
                'Fijo99Min', w1,
                'FijoMu', w1,
                'FijoCid', w1,
                'OnDemandMu', w1,
                'OnDemandRappiCargo', w1,
                'CanalesDigitalesRappi', w1,
                'CanalesDigitalesUber', w1,
                'ServicioEfectivo1', w1,
                'ServicioEfectivo2', w1,
                'ServicioEfectivo3', w1,
                'ServicioEfectivo4', w1,
                'ServicioEfectivo5', w1,
                'ServicioEfectivo6', w1,
                'ServicioEfectivo7', w1,
                'ServicioEfectivo8', w1,
                'ServicioTarjeta9', w1,
                'ServicioTarjeta10', w1,
                'ServicioTarjeta11', w1,
                'ServicioTarjeta12', w1,
                'InicioServicio', w0,
                'CierreServicio', w0
            ]);
        }
    }
}