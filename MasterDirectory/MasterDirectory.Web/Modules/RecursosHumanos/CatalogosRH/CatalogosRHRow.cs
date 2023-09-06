using MasterDirectory.Web.Modules.RecursosHumanos;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.RecursosHumanos;

[ConnectionKey("Default"), Module("RecursosHumanos"), TableName("Catalogos_RH")]
[DisplayName("Catalogos RH"), InstanceName("Catalogos RH")]
[ReadPermission(RecursosHumanosPermissionKeys.View)]
[ModifyPermission(RecursosHumanosPermissionKeys.Modify)]
[DeletePermission(RecursosHumanosPermissionKeys.Delete)]
public sealed class CatalogosRHRow : Row<CatalogosRHRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Cons"), Column("idCons"), Identity, IdProperty]
    public int? IdCons
    {
        get => fields.IdCons[this];
        set => fields.IdCons[this] = value;
    }

    [DisplayName("Tipo Catalogo"), Column("idtipoCatalogo"), NotNull, ForeignKey("[dbo].[Tipo_Catalogos]", "idtipoCatalogo"), LeftJoin("ljTpoCatalogos"), TextualField("tipoCatalogo"), DefaultValue(1)]
    [LookupEditor(typeof(TiposCatRHLookup)), LookupInclude]
    public int? IdtipoCatalogo
    {
        get => fields.IdtipoCatalogo[this];
        set => fields.IdtipoCatalogo[this] = value;
    }

    [DisplayName("Id Clave"), Column("idClave"), NotNull]
    public int? IdClave
    {
        get => fields.IdClave[this];
        set => fields.IdClave[this] = value;
    }

    [DisplayName("Descripcion"), Column("descripcion"), Size(250), QuickSearch, NameProperty]
    public string Descripcion
    {
        get => fields.Descripcion[this];
        set => fields.Descripcion[this] = value;
    }

    [DisplayName("Activo"), Column("activo"), NotNull, CheckboxFormatter, AlignCenter]
    public int? Activo
    {
        get => fields.Activo[this];
        set => fields.Activo[this] = value;
    }

    [DisplayName("Tipo Catalogo"), Expression("ljTpoCatalogos.[tipoCatalogo]"), QuickSearch]
    public string NombreTipoCatalogo
    {
        get => fields.NombreTipoCatalogo[this];
        set => fields.NombreTipoCatalogo[this] = value;
    }

    //[DisplayName("Dt Registro"), Column("dtRegistro"), NotNull]
    //public DateTime? DtRegistro
    //{
    //    get => fields.DtRegistro[this];
    //    set => fields.DtRegistro[this] = value;
    //}

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdCons;
        public Int32Field IdtipoCatalogo;
        public Int32Field IdClave;
        public StringField Descripcion;
        public Int32Field Activo;
        public StringField NombreTipoCatalogo;
        //public DateTimeField DtRegistro;

    }
}