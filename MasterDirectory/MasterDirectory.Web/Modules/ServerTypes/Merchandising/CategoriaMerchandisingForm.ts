import { StringEditor, LookupEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaMerchandisingForm {
    LocalSap: StringEditor;
    TipoSucursal: LookupEditor;
    RutaDli: StringEditor;
    TipoSenalizacion: LookupEditor;
    ScreenDisplay: LookupEditor;
    TramosLisos: LookupEditor;
    Checkout: LookupEditor;
    M2Calc: LookupEditor;
    MedidaCabecera: LookupEditor;
    EndCap: LookupEditor;
    MedidaGrafico: LookupEditor;
    BusStop: LookupEditor;
    Aretes: LookupEditor;
    CabecerasInstitucionales: LookupEditor;
    ExhibidorRetail: LookupEditor;
    ExhibidorGloblaBrands: LookupEditor;
    ExhibidorWellBeginnings: LookupEditor;
    ExhibidorInstitucional: LookupEditor;
    ExhibidorMascarillas: LookupEditor;
    ExhibidorGenerico: LookupEditor;
    TamanoMiniheders: LookupEditor;
    TamanoHeader: LookupEditor;
    MedidasPecheras: LookupEditor;
    MedidaCopete: IntegerEditor;
    MedidasCanceleria: LookupEditor;
    TramosFarma: LookupEditor;
    PortaposterCanceleria: LookupEditor;
}

export class CategoriaMerchandisingForm extends PrefixedContext {
    static formKey = 'Merchandising.CategoriaMerchandising';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaMerchandisingForm.init)  {
            CategoriaMerchandisingForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = IntegerEditor;

            initFormType(CategoriaMerchandisingForm, [
                'LocalSap', w0,
                'TipoSucursal', w1,
                'RutaDli', w0,
                'TipoSenalizacion', w1,
                'ScreenDisplay', w1,
                'TramosLisos', w1,
                'Checkout', w1,
                'M2Calc', w1,
                'MedidaCabecera', w1,
                'EndCap', w1,
                'MedidaGrafico', w1,
                'BusStop', w1,
                'Aretes', w1,
                'CabecerasInstitucionales', w1,
                'ExhibidorRetail', w1,
                'ExhibidorGloblaBrands', w1,
                'ExhibidorWellBeginnings', w1,
                'ExhibidorInstitucional', w1,
                'ExhibidorMascarillas', w1,
                'ExhibidorGenerico', w1,
                'TamanoMiniheders', w1,
                'TamanoHeader', w1,
                'MedidasPecheras', w1,
                'MedidaCopete', w2,
                'MedidasCanceleria', w1,
                'TramosFarma', w1,
                'PortaposterCanceleria', w1
            ]);
        }
    }
}