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

//[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Merchandising"), TableName("CatMerchandising")]
[DisplayName("Merchandising"), InstanceName("Cat Merchandising")]
[ReadPermission(MerchandisingPermissionKeys.Merchadising)]
[ModifyPermission(MerchandisingPermissionKeys.Merchadising)]
[LookupScript("SCatMerchaLookup")]
public sealed class CatMerchandisingRow : Row<CatMerchandisingRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Tipo Señalización"), Column("TipoSenalizacion"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 3), LookupInclude]
    public int? TipoSenalizacion
    {
        get => fields.TipoSenalizacion[this];
        set => fields.TipoSenalizacion[this] = value;
    }
    [DisplayName("Tipo de Señalización"), Expression("ljCatalogosMercha.[descripcion]"), QuickSearch]
    public string NombreTipoSenalizacion
    {
        get => fields.NombreTipoSenalizacion[this];
        set => fields.NombreTipoSenalizacion[this] = value;
    }
    [DisplayName("Screen Display"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha1"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 4), LookupInclude]
    public int? ScreenDisplay
    {
        get => fields.ScreenDisplay[this];
        set => fields.ScreenDisplay[this] = value;
    }
    [DisplayName("Screen Display (Caja de luz)"), Expression("ljCatalogosMercha1.[descripcion]"), QuickSearch]
    public string NombreScreenDisplay
    {
        get => fields.NombreScreenDisplay[this];
        set => fields.NombreScreenDisplay[this] = value;
    }
    [DisplayName("Tramos Lisos"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha2"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 5), LookupInclude]
    public int? TramosLisos
    {
        get => fields.TramosLisos[this];
        set => fields.TramosLisos[this] = value;
    }
    [DisplayName("Tramos Lisos(Mostrador Farmacia)"), Expression("ljCatalogosMercha2.[descripcion]"), QuickSearch]
    public string NombreTramosLisos
    {
        get => fields.NombreTramosLisos[this];
        set => fields.NombreTramosLisos[this] = value;
    }
    [DisplayName("Tamano Miniheders"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha3"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 6), LookupInclude]
    public int? TamanoMiniheders
    {
        get => fields.TamanoMiniheders[this];
        set => fields.TamanoMiniheders[this] = value;
    }
    [DisplayName("Tamaño Miniheders"), Expression("ljCatalogosMercha3.[descripcion]"), QuickSearch]
    public string NombreTamanoMiniHeader
    {
        get => fields.NombreTamanoMiniHeader[this];
        set => fields.NombreTamanoMiniHeader[this] = value;
    }
    [DisplayName("Tamano Header"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha4"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 7), LookupInclude]
    public int? TamanoHeader
    {
        get => fields.TamanoHeader[this];
        set => fields.TamanoHeader[this] = value;
    }
    [DisplayName("Tamaño de header"), Expression("ljCatalogosMercha4.[descripcion]"), QuickSearch]
    public string NombreTamanoHeader
    {
        get => fields.NombreTamanoHeader[this];
        set => fields.NombreTamanoHeader[this] = value;
    }
    [DisplayName("Checkout"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha5"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 8), LookupInclude]
    public int? Checkout
    {
        get => fields.Checkout[this];
        set => fields.Checkout[this] = value;
    }
    [DisplayName("Checkout tipo  \"L\""), Expression("ljCatalogosMercha5.[descripcion]"), QuickSearch]
    public string NombreCheckout
    {
        get => fields.NombreCheckout[this];
        set => fields.NombreCheckout[this] = value;
    }
    [DisplayName("Medida Cabecera"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha6"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 9), LookupInclude]
    public int? MedidaCabecera
    {
        get => fields.MedidaCabecera[this];
        set => fields.MedidaCabecera[this] = value;
    }
    [DisplayName("Medida Cabecera"), Expression("ljCatalogosMercha6.[descripcion]"), QuickSearch]
    public string NombreMedidaCabecera
    {
        get => fields.NombreMedidaCabecera[this];
        set => fields.NombreMedidaCabecera[this] = value;
    }
    [DisplayName("End Cap"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha7"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 10), LookupInclude]
    public int? EndCap
    {
        get => fields.EndCap[this];
        set => fields.EndCap[this] = value;
    }
    [DisplayName("End Cap"), Expression("ljCatalogosMercha7.[descripcion]"), QuickSearch]
    public string NombreEndCap
    {
        get => fields.NombreEndCap[this];
        set => fields.NombreEndCap[this] = value;
    }
    //[DisplayName("")]
    [DisplayName("Medida Grafico"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha8"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 11), LookupInclude]
    public int? MedidaGrafico
    {
        get => fields.MedidaGrafico[this];
        set => fields.MedidaGrafico[this] = value;
    }
    [DisplayName("Medida Gráfico"), Expression("ljCatalogosMercha8.[descripcion]"), QuickSearch]
    public string NombreMedidaGrafico
    {
        get => fields.NombreMedidaGrafico[this];
        set => fields.NombreMedidaGrafico[this] = value;
    }
    [DisplayName("Bus Stop"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha9"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 12), LookupInclude]
    public int? BusStop
    {
        get => fields.BusStop[this];
        set => fields.BusStop[this] = value;
    }
    [DisplayName("Bus Stop"), Expression("ljCatalogosMercha9.[descripcion]"), QuickSearch]
    public string NombreBusStop
    {
        get => fields.NombreBusStop[this];
        set => fields.NombreBusStop[this] = value;
    }
    [DisplayName("Aretes"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha10"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 13), LookupInclude]
    public int? Aretes
    {
        get => fields.Aretes[this];
        set => fields.Aretes[this] = value;
    }
    [DisplayName("Aretes"), Expression("ljCatalogosMercha10.[descripcion]"), QuickSearch]
    public string NombreAretes
    {
        get => fields.NombreAretes[this];
        set => fields.NombreAretes[this] = value;
    }
    [DisplayName("Exhibidor Retail"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha11"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 14), LookupInclude]
    public int? ExhibidorRetail
    {
        get => fields.ExhibidorRetail[this];
        set => fields.ExhibidorRetail[this] = value;
    }
    [DisplayName("Exhibidor Retail"), Expression("ljCatalogosMercha11.[descripcion]"), QuickSearch]
    public string NombreExhibidorRetail
    {
        get => fields.NombreExhibidorRetail[this];
        set => fields.NombreExhibidorRetail[this] = value;
    }
    [DisplayName("Exhibidor Globla Brands"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha12"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 15), LookupInclude]
    public int? ExhibidorGloblaBrands
    {
        get => fields.ExhibidorGloblaBrands[this];
        set => fields.ExhibidorGloblaBrands[this] = value;
    }
    [DisplayName("Exhibidor Globla Brands"), Expression("ljCatalogosMercha12.[descripcion]"), QuickSearch]
    public string NombreExhibidorGloblaBrands
    {
        get => fields.NombreExhibidorGloblaBrands[this];
        set => fields.NombreExhibidorGloblaBrands[this] = value;
    }
    [DisplayName("Exhibidor Well Beginnings"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha13"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 16), LookupInclude]
    public int? ExhibidorWellBeginnings
    {
        get => fields.ExhibidorWellBeginnings[this];
        set => fields.ExhibidorWellBeginnings[this] = value;
    }
    [DisplayName("Exhibidor Well Beginnings"), Expression("ljCatalogosMercha13.[descripcion]"), QuickSearch]
    public string NombreExhibidorWellBeginnings
    {
        get => fields.NombreExhibidorWellBeginnings[this];
        set => fields.NombreExhibidorWellBeginnings[this] = value;
    }    
    [DisplayName("Exhibidor Institucional"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha14"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 17), LookupInclude]
    public int? ExhibidorInstitucional
    {
        get => fields.ExhibidorInstitucional[this];
        set => fields.ExhibidorInstitucional[this] = value;
    }
    [DisplayName("Exhibidor Institucional"), Expression("ljCatalogosMercha14.[descripcion]"), QuickSearch]
    public string NombreExhibidorInstitucional
    {
        get => fields.NombreExhibidorInstitucional[this];
        set => fields.NombreExhibidorInstitucional[this] = value;
    }
    [DisplayName("Exhibidor Mascarillas"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha15"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 18), LookupInclude]
    public int? ExhibidorMascarillas
    {
        get => fields.ExhibidorMascarillas[this];
        set => fields.ExhibidorMascarillas[this] = value;
    }
    [DisplayName("Exhibidor Mascarillas"), Expression("ljCatalogosMercha15.[descripcion]"), QuickSearch]
    public string NombreExhibidorMascarillas
    {
        get => fields.NombreExhibidorMascarillas[this];
        set => fields.NombreExhibidorMascarillas[this] = value;
    }
    [DisplayName("Exhibidor Generico"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha16"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 19), LookupInclude]
    public int? ExhibidorGenerico
    {
        get => fields.ExhibidorGenerico[this];
        set => fields.ExhibidorGenerico[this] = value;
    }
    [DisplayName("Exhibidor Genérico"), Expression("ljCatalogosMercha16.[descripcion]"), QuickSearch]
    public string NombreExhibidorGenerico
    {
        get => fields.NombreExhibidorGenerico[this];
        set => fields.NombreExhibidorGenerico[this] = value;
    }
    [DisplayName("Cabeceras Institucionales"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha17"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 24), LookupInclude]
    public int? CabecerasInstitucionales
    {
        get => fields.CabecerasInstitucionales[this];
        set => fields.CabecerasInstitucionales[this] = value;
    }
    [DisplayName("Cabeceras Institucionales"), Expression("ljCatalogosMercha17.[descripcion]"), QuickSearch]
    public string NombreCabecerasInstitucionales
    {
        get => fields.NombreCabecerasInstitucionales[this];
        set => fields.NombreCabecerasInstitucionales[this] = value;
    }
    [DisplayName("Tramos Farma"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha18"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 20), LookupInclude]
    public int? TramosFarma
    {
        get => fields.TramosFarma[this];
        set => fields.TramosFarma[this] = value;
    }
    [DisplayName("Tramos Farma"), Expression("ljCatalogosMercha18.[descripcion]"), QuickSearch]
    public string NombreTramosFarma
    {
        get => fields.NombreTramosFarma[this];
        set => fields.NombreTramosFarma[this] = value;
    }
    [DisplayName("Portaposter Canceleria"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha19"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 21), LookupInclude]
    public int? PortaposterCanceleria
    {
        get => fields.PortaposterCanceleria[this];
        set => fields.PortaposterCanceleria[this] = value;
    }
    [DisplayName("Portaposter Cancelería"), Expression("ljCatalogosMercha19.[descripcion]"), QuickSearch]
    public string NombrePortaposterCanceleria
    {
        get => fields.NombrePortaposterCanceleria[this];
        set => fields.NombrePortaposterCanceleria[this] = value;
    }
    [DisplayName("Medidas Pecheras"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha20"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 22), LookupInclude]
    public int? MedidasPecheras
    {
        get => fields.MedidasPecheras[this];
        set => fields.MedidasPecheras[this] = value;
    }
    [DisplayName("Medidas Pecheras"), Expression("ljCatalogosMercha20.[descripcion]"), QuickSearch]
    public string NombreMedidasPecheras
    {
        get => fields.NombreMedidasPecheras[this];
        set => fields.NombreMedidasPecheras[this] = value;
    }
    [DisplayName("Medida Copete")]
    public int? MedidaCopete
    {
        get => fields.MedidaCopete[this];
        set => fields.MedidaCopete[this] = value;
    }
    [DisplayName("Medidas Canceleria"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha21"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 23), LookupInclude]
    public string MedidasCanceleria
    {
        get => fields.MedidasCanceleria[this];
        set => fields.MedidasCanceleria[this] = value;
    }
    [DisplayName("Medidas Cancelería"), Expression("ljCatalogosMercha21.[descripcion]"), QuickSearch]
    public string NombreMedidasCanceleria
    {
        get => fields.NombreMedidasCanceleria[this];
        set => fields.NombreMedidasCanceleria[this] = value;
    }
    [DisplayName("M2 Calc"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha22"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 2), LookupInclude]
    public int? M2Calc
    {
        get => fields.M2Calc[this];
        set => fields.M2Calc[this] = value;
    }
    [DisplayName("M2 Calc"), Expression("ljCatalogosMercha22.[descripcion]"), QuickSearch]
    public string NombreM2Calc
    {
        get => fields.NombreM2Calc[this];
        set => fields.NombreM2Calc[this] = value;
    }
    [DisplayName("Ruta Dli"), Column("RutaDLI"), Size(50)]
    public string RutaDli
    {
        get => fields.RutaDli[this];
        set => fields.RutaDli[this] = value;
    }
    [DisplayName("Tipo Sucursal"), ForeignKey("[dbo].[Catalogos_Merchandising]", "idCons"), LeftJoin("ljCatalogosMercha23"), TextualField("idCons"), QuickSearch]
    [LookupEditor(typeof(CatMerchaLookup), FilterField = "IdtipoCatalogo", FilterValue = 1), LookupInclude]
    public int? TipoSucursal
    {
        get => fields.TipoSucursal[this];
        set => fields.TipoSucursal[this] = value;
    }
    [DisplayName("Tipo Sucursal (Mercha)"), Expression("ljCatalogosMercha23.[descripcion]"), QuickSearch]
    public string NombreTipoSucursal
    {
        get => fields.NombreTipoSucursal[this];
        set => fields.NombreTipoSucursal[this] = value;
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
        public Int32Field TipoSenalizacion;
        public Int32Field ScreenDisplay;
        public Int32Field TramosLisos;
        public Int32Field TamanoMiniheders;
        public Int32Field TamanoHeader;
        public Int32Field Checkout;
        public Int32Field MedidaCabecera;
        public Int32Field EndCap;
        public Int32Field MedidaGrafico;
        public Int32Field BusStop;
        public Int32Field Aretes;
        public Int32Field ExhibidorRetail;
        public Int32Field ExhibidorGloblaBrands;
        public Int32Field ExhibidorWellBeginnings;
        public Int32Field ExhibidorInstitucional;
        public Int32Field ExhibidorMascarillas;
        public Int32Field ExhibidorGenerico;
        public Int32Field CabecerasInstitucionales;
        public Int32Field TramosFarma;
        public Int32Field PortaposterCanceleria;
        public Int32Field MedidasPecheras;
        public Int32Field MedidaCopete;
        public StringField MedidasCanceleria;
        public Int32Field M2Calc;
        public StringField RutaDli;
        public Int32Field TipoSucursal;
        //public DateTimeField DtRegistro;
        public StringField NombreTipoSenalizacion;
        public StringField NombreScreenDisplay;
        public StringField NombreTramosLisos;
        public StringField NombreTamanoMiniHeader;
        public StringField NombreTamanoHeader;
        public StringField NombreCheckout;
        public StringField NombreMedidaCabecera;
        public StringField NombreEndCap;
        public StringField NombreMedidaGrafico;
        public StringField NombreBusStop;
        public StringField NombreAretes;
        public StringField NombreExhibidorRetail;
        public StringField NombreExhibidorGloblaBrands;
        public StringField NombreExhibidorWellBeginnings;
        public StringField NombreExhibidorInstitucional;
        public StringField NombreExhibidorMascarillas;
        public StringField NombreExhibidorGenerico;
        public StringField NombreCabecerasInstitucionales;
        public StringField NombreTramosFarma;
        public StringField NombrePortaposterCanceleria;
        public StringField NombreMedidasPecheras;
        public StringField NombreMedidasCanceleria;
        public StringField NombreM2Calc;
        public StringField NombreTipoSucursal;
    }
}