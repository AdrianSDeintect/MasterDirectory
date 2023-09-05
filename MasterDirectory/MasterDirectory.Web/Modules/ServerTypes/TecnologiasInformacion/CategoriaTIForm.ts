import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaTIForm {
    LocalSap: StringEditor;
    Nse: LookupEditor;
    Cluster: LookupEditor;
    Brick: StringEditor;
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
            var w1 = LookupEditor;

            initFormType(CategoriaTIForm, [
                'LocalSap', w0,
                'Nse', w1,
                'Cluster', w1,
                'Brick', w0,
                'UsuarioGeo', w0,
                'Emaillocal', w0,
                'Extension', w0,
                'Telefono', w0
            ]);
        }
    }
}