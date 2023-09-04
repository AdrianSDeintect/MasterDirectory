import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaComercialesForm {
    LocalSap: StringEditor;
    TotEspacioExhibFarm: StringEditor;
    TirasImpulso: StringEditor;
    Hp1: StringEditor;
    Hp2: StringEditor;
    Hp3: StringEditor;
    Tabaquera: StringEditor;
    TabletasFujiFilm: StringEditor;
    Kioscos: StringEditor;
    No7: LookupEditor;
    ExhibMostrador: StringEditor;
    Islas: StringEditor;
    M2Pdv: StringEditor;
    M2Local: StringEditor;
    MedidaCabecera: LookupEditor;
    RefriMostradorFarma: LookupEditor;
    Refri4puertas: LookupEditor;
    Cajonera: StringEditor;
    TramosCajonera: StringEditor;
    MuebleGenericos: StringEditor;
    SoapYGlory: LookupEditor;
    TramosDermo: LookupEditor;
    TempoFarma: LookupEditor;
}

export class CategoriaComercialesForm extends PrefixedContext {
    static formKey = 'Comerciales.CategoriaComerciales';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaComercialesForm.init)  {
            CategoriaComercialesForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(CategoriaComercialesForm, [
                'LocalSap', w0,
                'TotEspacioExhibFarm', w0,
                'TirasImpulso', w0,
                'Hp1', w0,
                'Hp2', w0,
                'Hp3', w0,
                'Tabaquera', w0,
                'TabletasFujiFilm', w0,
                'Kioscos', w0,
                'No7', w1,
                'ExhibMostrador', w0,
                'Islas', w0,
                'M2Pdv', w0,
                'M2Local', w0,
                'MedidaCabecera', w1,
                'RefriMostradorFarma', w1,
                'Refri4puertas', w1,
                'Cajonera', w0,
                'TramosCajonera', w0,
                'MuebleGenericos', w0,
                'SoapYGlory', w1,
                'TramosDermo', w1,
                'TempoFarma', w1
            ]);
        }
    }
}