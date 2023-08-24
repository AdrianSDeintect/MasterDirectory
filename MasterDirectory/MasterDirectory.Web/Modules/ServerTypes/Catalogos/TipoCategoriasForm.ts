import { IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TipoCategoriasForm {
    IdtipoCategoria: IntegerEditor;
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

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = BooleanEditor;

            initFormType(TipoCategoriasForm, [
                'IdtipoCategoria', w0,
                'TipoCategoria', w1,
                'Activo', w2
            ]);
        }
    }
}