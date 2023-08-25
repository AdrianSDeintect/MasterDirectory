import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaConsultoriosForm {
    LocalSap: StringEditor;
    ConsulOperacion: LookupEditor;
    Benamedic: LookupEditor;
    RampaDiscapa: LookupEditor;
    HorarioLv: StringEditor;
    HorarioS: StringEditor;
    HorarioD: StringEditor;
}

export class CategoriaConsultoriosForm extends PrefixedContext {
    static formKey = 'Consultorios.CategoriaConsultorios';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaConsultoriosForm.init)  {
            CategoriaConsultoriosForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CategoriaConsultoriosForm, [
                'LocalSap', w0,
                'ConsulOperacion', w1,
                'Benamedic', w1,
                'RampaDiscapa', w1,
                'HorarioLv', w0,
                'HorarioS', w0,
                'HorarioD', w0
            ]);
        }
    }
}