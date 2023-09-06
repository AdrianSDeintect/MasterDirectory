import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaTIForm {
    LocalSap: StringEditor;
    UsuarioGeo: StringEditor;
    Emaillocal: StringEditor;
    Extension: StringEditor;
    Telefono: StringEditor;
}

export class CategoriaTIForm extends PrefixedContext {
    static formKey = 'TecnologiasInformacion.CategoriaTI';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaTIForm.init)  {
            CategoriaTIForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoriaTIForm, [
                'LocalSap', w0,
                'UsuarioGeo', w0,
                'Emaillocal', w0,
                'Extension', w0,
                'Telefono', w0
            ]);
        }
    }
}