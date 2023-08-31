import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaTesoreriaForm {
    LocalSap: StringEditor;
    Cajero: LookupEditor;
}

export class CategoriaTesoreriaForm extends PrefixedContext {
    static formKey = 'Tesoreria.CategoriaTesoreria';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaTesoreriaForm.init)  {
            CategoriaTesoreriaForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CategoriaTesoreriaForm, [
                'LocalSap', w0,
                'Cajero', w1
            ]);
        }
    }
}