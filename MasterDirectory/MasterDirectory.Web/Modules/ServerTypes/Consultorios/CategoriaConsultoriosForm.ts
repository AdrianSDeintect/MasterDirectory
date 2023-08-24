import { LookupEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaConsultoriosForm {
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

            var w0 = LookupEditor;
            var w1 = StringEditor;

            initFormType(CategoriaConsultoriosForm, [
                'ConsulOperacion', w0,
                'Benamedic', w0,
                'RampaDiscapa', w0,
                'HorarioLv', w1,
                'HorarioS', w1,
                'HorarioD', w1
            ]);
        }
    }
}