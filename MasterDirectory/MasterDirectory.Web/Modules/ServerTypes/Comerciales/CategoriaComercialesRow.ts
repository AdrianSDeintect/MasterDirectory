import { fieldsProxy } from "@serenity-is/corelib/q";

export interface CategoriaComercialesRow {
    LocalSap?: string;
    M2Pdv?: string;
    M2Local?: string;
    TotEspacioExhibFarm?: string;
    TirasImpulso?: string;
    Islas?: string;
    ExhibMostrador?: string;
    Hp1?: string;
    Hp2?: string;
    Hp3?: string;
    MedidaCabecera?: string;
    Cajonera?: string;
    TramosCajonera?: string;
    MuebleGenericos?: string;
    RefriMostradorFarma?: string;
    Refri4puertas?: string;
    Tabaquera?: string;
    TabletasFujiFilm?: string;
    Kioscos?: string;
    No7?: string;
    SoapYGlory?: string;
    TramosDermo?: string;
    TempoFarma?: string;
}

export abstract class CategoriaComercialesRow {
    static readonly idProperty = 'LocalSap';
    static readonly nameProperty = 'LocalSap';
    static readonly localTextPrefix = 'Comerciales.CategoriaComerciales';
    static readonly deletePermission = 'Comerciales:Delete';
    static readonly insertPermission = 'Comerciales:Modify';
    static readonly readPermission = 'Comerciales:View';
    static readonly updatePermission = 'Comerciales:Modify';

    static readonly Fields = fieldsProxy<CategoriaComercialesRow>();
}