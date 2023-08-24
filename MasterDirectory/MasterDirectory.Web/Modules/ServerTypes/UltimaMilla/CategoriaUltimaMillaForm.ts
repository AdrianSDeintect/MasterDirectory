import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaUltimaMillaForm {
    LocalSap: StringEditor;
    VentaTelefonica: LookupEditor;
    Garantizado: LookupEditor;
    Hub: LookupEditor;
    ECommerce: StringEditor;
    TipoEComm: LookupEditor;
    Tablet: LookupEditor;
    NSerie: StringEditor;
    EstatusTablet: LookupEditor;
    Rappi: LookupEditor;
    Qr: StringEditor;
    ServicioDomicilio: LookupEditor;
    PruebaUber: LookupEditor;
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
                'VentaTelefonica', w1,
                'Garantizado', w1,
                'Hub', w1,
                'ECommerce', w0,
                'TipoEComm', w1,
                'Tablet', w1,
                'NSerie', w0,
                'EstatusTablet', w1,
                'Rappi', w1,
                'Qr', w0,
                'ServicioDomicilio', w1,
                'PruebaUber', w1
            ]);
        }
    }
}