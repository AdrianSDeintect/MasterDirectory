import { StringEditor, LookupEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface CategoriaExpansionForm {
    LocalSap: StringEditor;
    TipoFarmacia: LookupEditor;
    LocationType: LookupEditor;
    Reapertura: StringEditor;
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

            initFormType(CategoriaExpansionForm, [
                'LocalSap', w0,
                'TipoFarmacia', w1,
                'LocationType', w1,
                'Reapertura', w0,
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