using MasterDirectory.Web.Modules.Catalogos;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Catalogos;

[LookupScript(Expiration = -1)]
[ConnectionKey("Default"), Module("Catalogos"), TableName("Tipo_Categorias")]
[DisplayName("Tipo Categorias"), InstanceName("Tipo Categorias")]
[ReadPermission(CatalogosPermissionKeys.ViewTipoCategorias)]
[ModifyPermission(CatalogosPermissionKeys.ModifyTipoCategorias)]
[DeletePermission(CatalogosPermissionKeys.DeleteTipoCategorias)]
public sealed class TipoCategoriasRow : Row<TipoCategoriasRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Idtipo Categoria"), Column("idtipoCategoria"), PrimaryKey, NotNull, IdProperty]
    public int? IdtipoCategoria
    {
        get => fields.IdtipoCategoria[this];
        set => fields.IdtipoCategoria[this] = value;
    }

    [DisplayName("Tipo Categoria"), Column("tipoCategoria"), Size(250), PrimaryKey, NotNull, QuickSearch, NameProperty]
    public string TipoCategoria
    {
        get => fields.TipoCategoria[this];
        set => fields.TipoCategoria[this] = value;
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

    public class RowFields : RowFieldsBase
    {
        public Int32Field IdtipoCategoria;
        public StringField TipoCategoria;
        public Int32Field Activo;
        //public DateTimeField DtRegistro;

    }
}