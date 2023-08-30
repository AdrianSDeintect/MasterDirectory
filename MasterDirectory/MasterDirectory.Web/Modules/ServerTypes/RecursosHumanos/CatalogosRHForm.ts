import { LookupEditor, IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CatalogosRHForm {
    IdtipoCatalogo: LookupEditor;
    IdClave: IntegerEditor;
    Descripcion: StringEditor;
    Activo: BooleanEditor;
}

export class CatalogosRHForm extends PrefixedContext {
    static formKey = 'RecursosHumanos.CatalogosRH';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CatalogosRHForm.init)  {
            CatalogosRHForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = BooleanEditor;

            initFormType(CatalogosRHForm, [
                'IdtipoCatalogo', w0,
                'IdClave', w1,
                'Descripcion', w2,
                'Activo', w3
            ]);
        }
    }
}