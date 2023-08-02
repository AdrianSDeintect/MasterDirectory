using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Catalogos;

[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Catalogos"), TableName("Tipo_Catalogos")]
[DisplayName("Tipo Catalogos"), InstanceName("Tipo Catalogos")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class TipoCatalogosRow : Row<TipoCatalogosRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id Cons"), Column("idCons"), Identity, IdProperty]
    public int? IdCons
    {
        get => fields.IdCons[this];
        set => fields.IdCons[this] = value;
    }

    [DisplayName("Tipo Categoria"), Column("idtipoCategoria"), NotNull, ForeignKey("[dbo].[Tipo_Categorias]", "idtipoCategoria"), LeftJoin("ljTpoCategorias"), TextualField("tipoCategoria")]
    [LookupEditor(typeof(TipoCategoriasRow)), LookupInclude]
    public int? IdtipoCategoria
    {
        get => fields.IdtipoCategoria[this];
        set => fields.IdtipoCategoria[this] = value;
    }

    [DisplayName("Idtipo Catalogo"), Column("idtipoCatalogo"), NotNull]
    public int? IdtipoCatalogo
    {
        get => fields.IdtipoCatalogo[this];
        set => fields.IdtipoCatalogo[this] = value;
    }

    [DisplayName("Tipo Catalogo"), Column("tipoCatalogo"), Size(250), NotNull, QuickSearch, NameProperty]
    public string TipoCatalogo
    {
        get => fields.TipoCatalogo[this];
        set => fields.TipoCatalogo[this] = value;
    }

    [DisplayName("Activo"), Column("activo"), NotNull, CheckboxFormatter, AlignCenter]
    public int? Activo
    {
        get => fields.Activo[this];
        set => fields.Activo[this] = value;
    }

    //[DisplayName("Dt Registro"), Column("dtRegistro"), NotNull]
    //public DateTime? DtRegistro
    //{
    //    get => fields.DtRegistro[this];
    //    set => fields.DtRegistro[this] = value;
    //}

    [DisplayName("Tipo Categoria"), Expression("ljTpoCategorias.[tipoCategoria]"), QuickSearch]
    public string NombreTipoCategoria
    {
        get => fields.NombreTipoCategoria[this];
        set => fields.NombreTipoCategoria[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdCons;
        public Int32Field IdtipoCategoria;
        public Int32Field IdtipoCatalogo;
        public StringField TipoCatalogo;
        public Int32Field Activo;
        //public DateTimeField DtRegistro;
        public StringField NombreTipoCategoria;
    }
}