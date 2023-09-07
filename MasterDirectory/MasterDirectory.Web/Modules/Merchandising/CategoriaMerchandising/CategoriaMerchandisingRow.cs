using MasterDirectory.Web.Modules.Finanzas;
using MasterDirectory.Web.Modules.Merchandising;
using MasterDirectory.Web.Scripts;
using Microsoft.Data.SqlClient;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Repositories;
using Serenity.Web;
using System;
using System.ComponentModel;
using System.Security.Policy;


namespace MasterDirectory.Merchandising;

[ConnectionKey("Default"), Module("Merchandising"), TableName("CatMerchandising")]
[DisplayName("Categoria Merchandising"), InstanceName("Categoria Merchandising")]

[ReadPermission(MerchandisingPermissionKeys.View)]
[ModifyPermission(MerchandisingPermissionKeys.Modify)]
[DeletePermission(MerchandisingPermissionKeys.Delete)]

public sealed class CategoriaMerchandisingRow : Row<CategoriaMerchandisingRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Tipo Señalización"), Column("TipoSenalizacion"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 3), LookupInclude]
    public string TipoSenalizacion
    {
        get => fields.TipoSenalizacion[this];
        set => fields.TipoSenalizacion[this] = value;
    }
    [DisplayName("Screen Display (Caja de luz)"), Column("ScreenDisplay"),QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 4), LookupInclude]
    public string ScreenDisplay
    {
        get => fields.ScreenDisplay[this];
        set => fields.ScreenDisplay[this] = value;
    }

    [DisplayName("Tramos Lisos(Mostrador Farmacia)"), Column("TramosLisos"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 5), LookupInclude]
    public string TramosLisos
    {
        get => fields.TramosLisos[this];
        set => fields.TramosLisos[this] = value;
    }

    [DisplayName("Tamaño Miniheders"), Column("TamanoMiniheders"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 6), LookupInclude]
    public string TamanoMiniheders
    {
        get => fields.TamanoMiniheders[this];
        set => fields.TamanoMiniheders[this] = value;
    }

    [DisplayName("Tamaño de header"), Column("TamanoHeader"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 7), LookupInclude]
    public string TamanoHeader
    {
        get => fields.TamanoHeader[this];
        set => fields.TamanoHeader[this] = value;
    }

    [DisplayName("Checkout tipo  \"L\""), Column("Checkout"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 8), LookupInclude]
    public string Checkout
    {
        get => fields.Checkout[this];
        set => fields.Checkout[this] = value;
    }

    [DisplayName("Medida Cabecera"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 9), LookupInclude]
    public string MedidaCabecera
    {
        get => fields.MedidaCabecera[this];
        set => fields.MedidaCabecera[this] = value;
    }

    [DisplayName("End Cap"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 10), LookupInclude]
    public string EndCap
    {
        get => fields.EndCap[this];
        set => fields.EndCap[this] = value;
    }

    [DisplayName("Medida Gráfico"), Column("MedidaGrafico"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 11), LookupInclude]
    public string MedidaGrafico
    {
        get => fields.MedidaGrafico[this];
        set => fields.MedidaGrafico[this] = value;
    }

    [DisplayName("Bus Stop"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 12), LookupInclude]
    public string BusStop
    {
        get => fields.BusStop[this];
        set => fields.BusStop[this] = value;
    }

    [DisplayName("Aretes"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 13), LookupInclude]
    public string Aretes
    {
        get => fields.Aretes[this];
        set => fields.Aretes[this] = value;
    }

    [DisplayName("Exhibidor Retail"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 14), LookupInclude]
    public string ExhibidorRetail
    {
        get => fields.ExhibidorRetail[this];
        set => fields.ExhibidorRetail[this] = value;
    }

    [DisplayName("Exhibidor Globla Brands"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 15), LookupInclude]
    public string ExhibidorGloblaBrands
    {
        get => fields.ExhibidorGloblaBrands[this];
        set => fields.ExhibidorGloblaBrands[this] = value;
    }

    [DisplayName("Exhibidor Well Beginnings"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 16), LookupInclude]
    public string ExhibidorWellBeginnings
    {
        get => fields.ExhibidorWellBeginnings[this];
        set => fields.ExhibidorWellBeginnings[this] = value;
    }

    [DisplayName("Exhibidor Institucional"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 17), LookupInclude]
    public string ExhibidorInstitucional
    {
        get => fields.ExhibidorInstitucional[this];
        set => fields.ExhibidorInstitucional[this] = value;
    }

    [DisplayName("Exhibidor Mascarillas"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 18), LookupInclude]
    public string ExhibidorMascarillas
    {
        get => fields.ExhibidorMascarillas[this];
        set => fields.ExhibidorMascarillas[this] = value;
    }

    [DisplayName("Exhibidor Genérico"), Column("ExhibidorGenerico"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 19), LookupInclude]
    public string ExhibidorGenerico
    {
        get => fields.ExhibidorGenerico[this];
        set => fields.ExhibidorGenerico[this] = value;
    }

    [DisplayName("Cabeceras Institucionales"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 24), LookupInclude]
    public string CabecerasInstitucionales
    {
        get => fields.CabecerasInstitucionales[this];
        set => fields.CabecerasInstitucionales[this] = value;
    }

    [DisplayName("Tramos Farma"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 20), LookupInclude]
    public string TramosFarma
    {
        get => fields.TramosFarma[this];
        set => fields.TramosFarma[this] = value;
    }

    [DisplayName("Portaposter Cancelería"), Column("PortaposterCanceleria"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 21), LookupInclude]
    public string PortaposterCanceleria
    {
        get => fields.PortaposterCanceleria[this];
        set => fields.PortaposterCanceleria[this] = value;
    }

    [DisplayName("Medidas Pecheras"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 22), LookupInclude]
    public string MedidasPecheras
    {
        get => fields.MedidasPecheras[this];
        set => fields.MedidasPecheras[this] = value;
    }

    [DisplayName("Medida Copete"), Size(250)]
    public string MedidaCopete
    {
        get => fields.MedidaCopete[this];
        set => fields.MedidaCopete[this] = value;
    }

    [DisplayName("Medidas Cancelería"), Column("MedidasCanceleria"), QuickSearch, Size(250)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 23), LookupInclude]
    public string MedidasCanceleria
    {
        get => fields.MedidasCanceleria[this];
        set => fields.MedidasCanceleria[this] = value;
    }

    [DisplayName("M2 Calc"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 2), LookupInclude]
    public string M2Calc
    {
        get => fields.M2Calc[this];
        set => fields.M2Calc[this] = value;
    }

    [DisplayName("Ruta Dli"), Column("RutaDLI"), Size(50), Required]
    public string RutaDli
    {
        get => fields.RutaDli[this];
        set => fields.RutaDli[this] = value;
    }

    [DisplayName("Tipo Sucursal (Mercha)"), Column("TipoSucursal"), QuickSearch, Size(250), Required]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 1), LookupInclude]
    public string TipoSucursal
    {
        get => fields.TipoSucursal[this];
        set => fields.TipoSucursal[this] = value;
    }

    [DisplayName("Rampa Discapacitados"), Column("RampaDiscapa"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 42), LookupInclude]
    public string RampaDiscapa
    {
        get => fields.RampaDiscapa[this];
        set => fields.RampaDiscapa[this] = value;
    }

    //[DisplayName("Dt Registro"), Column("dtRegistro"), NotNull]
    //public DateTime? DtRegistro
    //{
    //    get => fields.DtRegistro[this];
    //    set => fields.DtRegistro[this] = value;
    //}

    public class RowFields : RowFieldsBase
    {
        public StringField LocalSap;
        public StringField TipoSenalizacion;
        public StringField ScreenDisplay;
        public StringField TramosLisos;
        public StringField TamanoMiniheders;
        public StringField TamanoHeader;
        public StringField Checkout;
        public StringField MedidaCabecera;
        public StringField EndCap;
        public StringField MedidaGrafico;
        public StringField BusStop;
        public StringField Aretes;
        public StringField ExhibidorRetail;
        public StringField ExhibidorGloblaBrands;
        public StringField ExhibidorWellBeginnings;
        public StringField ExhibidorInstitucional;
        public StringField ExhibidorMascarillas;
        public StringField ExhibidorGenerico;
        public StringField CabecerasInstitucionales;
        public StringField TramosFarma;
        public StringField PortaposterCanceleria;
        public StringField MedidasPecheras;
        public StringField MedidaCopete;
        public StringField MedidasCanceleria;
        public StringField M2Calc;
        public StringField RutaDli;
        public StringField TipoSucursal;
        public StringField RampaDiscapa;
        //public DateTimeField DtRegistro;

    }
}