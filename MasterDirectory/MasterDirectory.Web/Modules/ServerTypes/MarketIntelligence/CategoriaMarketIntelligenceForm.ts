import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaMarketIntelligenceForm {
    LocalSap: StringEditor;
    Nse: LookupEditor;
    Cluster: LookupEditor;
    Brick: StringEditor;
}

export class CategoriaMarketIntelligenceForm extends PrefixedContext {
    static formKey = 'MarketIntelligence.CategoriaMarketIntelligence';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaMarketIntelligenceForm.init)  {
            CategoriaMarketIntelligenceForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CategoriaMarketIntelligenceForm, [
                'LocalSap', w0,
                'Nse', w1,
                'Cluster', w1,
                'Brick', w0
            ]);
        }
    }
}