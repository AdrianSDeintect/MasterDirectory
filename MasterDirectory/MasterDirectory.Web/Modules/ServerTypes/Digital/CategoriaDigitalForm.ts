import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaDigitalForm {
    LocalSap: StringEditor;
    DirGoogle: StringEditor;
    Latitud: StringEditor;
    Longitud: StringEditor;
}

export class CategoriaDigitalForm extends PrefixedContext {
    static formKey = 'Digital.CategoriaDigital';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaDigitalForm.init)  {
            CategoriaDigitalForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoriaDigitalForm, [
                'LocalSap', w0,
                'DirGoogle', w0,
                'Latitud', w0,
                'Longitud', w0
            ]);
        }
    }
}