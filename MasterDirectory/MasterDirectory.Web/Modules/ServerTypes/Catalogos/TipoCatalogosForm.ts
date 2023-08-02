import { LookupEditor, IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TipoCatalogosForm {
    IdtipoCategoria: LookupEditor;
    IdtipoCatalogo: IntegerEditor;
    TipoCatalogo: StringEditor;
    Activo: BooleanEditor;
}

export class TipoCatalogosForm extends PrefixedContext {
    static formKey = 'Catalogos.TipoCatalogos';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TipoCatalogosForm.init)  {
            TipoCatalogosForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = BooleanEditor;

            initFormType(TipoCatalogosForm, [
                'IdtipoCategoria', w0,
                'IdtipoCatalogo', w1,
                'TipoCatalogo', w2,
                'Activo', w3
            ]);
        }
    }
}