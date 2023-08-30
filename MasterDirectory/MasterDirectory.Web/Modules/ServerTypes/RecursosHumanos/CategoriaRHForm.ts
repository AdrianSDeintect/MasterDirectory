import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaRHForm {
    LocalSap: StringEditor;
    Plantilla: StringEditor;
    Vacantes: StringEditor;
}

export class CategoriaRHForm extends PrefixedContext {
    static formKey = 'RecursosHumanos.CategoriaRH';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaRHForm.init)  {
            CategoriaRHForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoriaRHForm, [
                'LocalSap', w0,
                'Plantilla', w0,
                'Vacantes', w0
            ]);
        }
    }
}