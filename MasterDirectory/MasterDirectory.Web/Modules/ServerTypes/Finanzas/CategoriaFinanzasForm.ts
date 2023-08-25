import { StringEditor, DateEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaFinanzasForm {
    LocalSap: StringEditor;
    Mercado: StringEditor;
    FechaCierre: DateEditor;
    EstatusFarmacia: LookupEditor;
    RegionCluster: StringEditor;
    KeyState: LookupEditor;
    Top360: LookupEditor;
    TopMkt: LookupEditor;
    Top550: LookupEditor;
    CecoFarmacias: StringEditor;
    CecoConsultorio: StringEditor;
    CecoEcommerce: StringEditor;
    MarketCluster: StringEditor;
    MarketDaily: LookupEditor;
    DailyMarketOrder: StringEditor;
}

export class CategoriaFinanzasForm extends PrefixedContext {
    static formKey = 'Finanzas.CategoriaFinanzas';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaFinanzasForm.init)  {
            CategoriaFinanzasForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = LookupEditor;

            initFormType(CategoriaFinanzasForm, [
                'LocalSap', w0,
                'Mercado', w0,
                'FechaCierre', w1,
                'EstatusFarmacia', w2,
                'RegionCluster', w0,
                'KeyState', w2,
                'Top360', w2,
                'TopMkt', w2,
                'Top550', w2,
                'CecoFarmacias', w0,
                'CecoConsultorio', w0,
                'CecoEcommerce', w0,
                'MarketCluster', w0,
                'MarketDaily', w2,
                'DailyMarketOrder', w0
            ]);
        }
    }
}