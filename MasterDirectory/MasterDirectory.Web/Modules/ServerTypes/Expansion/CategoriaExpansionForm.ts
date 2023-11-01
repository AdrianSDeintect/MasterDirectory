import { StringEditor, LookupEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaExpansionForm {
    LocalSap: StringEditor;
    LocationType: LookupEditor;
    Farmacia: StringEditor;
    FechaApertura: DateEditor;
    Reapertura: DateEditor;
    Comsuc: StringEditor;
    TipoEstaciona: LookupEditor;
    NCajonesEstaciona: StringEditor;
    Ciudad: StringEditor;
    Estado: StringEditor;
    Direccion: StringEditor;
    NExterior: StringEditor;
    Colonia: StringEditor;
    Cp: StringEditor;
    Latitud: StringEditor;
    Longuitud: StringEditor;
    FormatoFarmAlcance: LookupEditor;
    Pantallas: StringEditor;
    ProvMobiliario: LookupEditor;
    ColorMob: StringEditor;
    Dermo: StringEditor;
}

export class CategoriaExpansionForm extends PrefixedContext {
    static formKey = 'Expansion.CategoriaExpansion';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriaExpansionForm.init)  {
            CategoriaExpansionForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(CategoriaExpansionForm, [
                'LocalSap', w0,
                'LocationType', w1,
                'Farmacia', w0,
                'FechaApertura', w2,
                'Reapertura', w2,
                'Comsuc', w0,
                'TipoEstaciona', w1,
                'NCajonesEstaciona', w0,
                'Ciudad', w0,
                'Estado', w0,
                'Direccion', w0,
                'NExterior', w0,
                'Colonia', w0,
                'Cp', w0,
                'Latitud', w0,
                'Longuitud', w0,
                'FormatoFarmAlcance', w1,
                'Pantallas', w0,
                'ProvMobiliario', w1,
                'ColorMob', w0,
                'Dermo', w0
            ]);
        }
    }
}