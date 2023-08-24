import { LookupEditor, IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CatalogosUltimaMillaForm {
    IdtipoCatalogo: LookupEditor;
    IdClave: IntegerEditor;
    Descripcion: StringEditor;
    Activo: BooleanEditor;
}

export class CatalogosUltimaMillaForm extends PrefixedContext {
    static formKey = 'UltimaMilla.CatalogosUltimaMilla';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CatalogosUltimaMillaForm.init)  {
            CatalogosUltimaMillaForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = BooleanEditor;

            initFormType(CatalogosUltimaMillaForm, [
                'IdtipoCatalogo', w0,
                'IdClave', w1,
                'Descripcion', w2,
                'Activo', w3
            ]);
        }
    }
}