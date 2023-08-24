using MasterDirectory.Web.Modules.Consultorios;
using MasterDirectory.Web.Scripts;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MasterDirectory.Consultorios;

[ConnectionKey("Default"), Module("Consultorios"), TableName("CatConsultorios")]
[DisplayName("Categoria Consultorios"), InstanceName("Categoria Consultorios")]
[ReadPermission(ConsultoriosPermissionKeys.View)]
[ModifyPermission(ConsultoriosPermissionKeys.Modify)]
[DeletePermission(ConsultoriosPermissionKeys.Delete)]
public sealed class CategoriaConsultoriosRow : Row<CategoriaConsultoriosRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Local Sap"), Size(5), PrimaryKey, NotNull, IdProperty, QuickSearch, NameProperty]
    public string LocalSap
    {
        get => fields.LocalSap[this];
        set => fields.LocalSap[this] = value;
    }

    [DisplayName("Consultorio en Operación"), Column("ConsulOperacion"), QuickSearch, Size(15)]
    [LookupEditor(typeof(CatConsultoriosLookup), FilterField = "IdtipoCatalogo", FilterValue = 40), LookupInclude]
    public string ConsulOperacion
    {
        get => fields.ConsulOperacion[this];
        set => fields.ConsulOperacion[this] = value;
    }

    [DisplayName("Benamedic"), QuickSearch, Size(10)]
    [LookupEditor(typeof(CatConsultoriosLookup), FilterField = "IdtipoCatalogo", FilterValue = 41), LookupInclude]
    public string Benamedic
    {
        get => fields.Benamedic[this];
        set => fields.Benamedic[this] = value;
    }

    [DisplayName("Horario L-V"), Column("HorarioLV"), Size(50)]
    public string HorarioLv
    {
        get => fields.HorarioLv[this];
        set => fields.HorarioLv[this] = value;
    }

    [DisplayName("Horario Sabado"), Column("HorarioS"), Size(50)]
    public string HorarioS
    {
        get => fields.HorarioS[this];
        set => fields.HorarioS[this] = value;
    }

    [DisplayName("Horario Domingo"), Column("HorarioD"), Size(50)]
    public string HorarioD
    {
        get => fields.HorarioD[this];
        set => fields.HorarioD[this] = value;
    }

    [DisplayName("Rampa Discapacitados"), Column("RampaDiscapa"), QuickSearch, Size(50)]
    [LookupEditor(typeof(CatConsultoriosLookup), FilterField = "IdtipoCatalogo", FilterValue = 42), LookupInclude]
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
        public StringField ConsulOperacion;
        public StringField Benamedic;
        public StringField HorarioLv;
        public StringField HorarioS;
        public StringField HorarioD;
        public StringField RampaDiscapa;
        //public DateTimeField DtRegistro;

    }
}