﻿import { LookupEditor, IntegerEditor, StringEditor, BooleanEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CatalogosMerchandisingForm {
    IdtipoCatalogo: LookupEditor;
    IdClave: IntegerEditor;
    Descripcion: StringEditor;
    Activo: BooleanEditor;
}

export class CatalogosMerchandisingForm extends PrefixedContext {
    static formKey = 'Merchandising.CatalogosMerchandising';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CatalogosMerchandisingForm.init)  {
            CatalogosMerchandisingForm.init = true;

            var w0 = LookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;
            var w3 = BooleanEditor;

            initFormType(CatalogosMerchandisingForm, [
                'IdtipoCatalogo', w0,
                'IdClave', w1,
                'Descripcion', w2,
                'Activo', w3
            ]);
        }
    }
}