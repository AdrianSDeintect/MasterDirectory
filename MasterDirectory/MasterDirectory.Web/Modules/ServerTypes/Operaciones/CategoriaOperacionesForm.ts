import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaOperacionesForm {
    LocalSap: StringEditor;
    Region: LookupEditor;
    EdoLocal: LookupEditor;
    Zona: LookupEditor;
    Geo: LookupEditor;
    MailGeo: StringEditor;
    DirectorRegional: LookupEditor;
    HorarioLv: StringEditor;
    HorarioS: StringEditor;
    HorarioDyF: StringEditor;
}

export class CategoriaOperacionesForm extends PrefixedContext {
    static formKey = 'Operaciones.CategoriaOperaciones';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaOperacionesForm.init)  {
            CategoriaOperacionesForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CategoriaOperacionesForm, [
                'LocalSap', w0,
                'Region', w1,
                'EdoLocal', w1,
                'Zona', w1,
                'Geo', w1,
                'MailGeo', w0,
                'DirectorRegional', w1,
                'HorarioLv', w0,
                'HorarioS', w0,
                'HorarioDyF', w0
            ]);
        }
    }
}