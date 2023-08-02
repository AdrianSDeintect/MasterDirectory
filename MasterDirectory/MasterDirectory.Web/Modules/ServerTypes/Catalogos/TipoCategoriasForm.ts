import { StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TipoCategoriasForm {
    TipoCategoria: StringEditor;
    Activo: BooleanEditor;
}

export class TipoCategoriasForm extends PrefixedContext {
    static formKey = 'Catalogos.TipoCategorias';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TipoCategoriasForm.init)  {
            TipoCategoriasForm.init = true;

            var w0 = StringEditor;
            var w1 = BooleanEditor;

            initFormType(TipoCategoriasForm, [
                'TipoCategoria', w0,
                'Activo', w1
            ]);
        }
    }
}