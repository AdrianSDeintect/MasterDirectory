import { StringEditor, DateEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaInmobiliariaForm {
    LocalSap: StringEditor;
    Farmacia: StringEditor;
    FechaApertura: DateEditor;
    Colonia: StringEditor;
    Accesos: LookupEditor;
    Ubicacion: LookupEditor;
}

export class CategoriaInmobiliariaForm extends PrefixedContext {
    static formKey = 'Inmobiliaria.CategoriaInmobiliaria';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaInmobiliariaForm.init)  {
            CategoriaInmobiliariaForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;
            var w2 = LookupEditor;

            initFormType(CategoriaInmobiliariaForm, [
                'LocalSap', w0,
                'Farmacia', w0,
                'FechaApertura', w1,
                'Colonia', w0,
                'Accesos', w2,
                'Ubicacion', w2
            ]);
        }
    }
}