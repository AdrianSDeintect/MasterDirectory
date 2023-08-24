using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MasterDirectory.UltimaMilla.Columns;

[ColumnsScript("UltimaMilla.CategoriaUltimaMilla")]
[BasedOnRow(typeof(CategoriaUltimaMillaRow), CheckNames = true)]
public class CategoriaUltimaMillaColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public string LocalSap { get; set; }
    public string VentaTelefonica { get; set; }
    public string Garantizado { get; set; }
    public string Hub { get; set; }
    public string ECommerce { get; set; }
    public string TipoEComm { get; set; }
    public string Rappi { get; set; }
    public string Tablet { get; set; }
    public string NSerie { get; set; }
    public string EstatusTablet { get; set; }
    public string Qr { get; set; }
    public string ServicioDomicilio { get; set; }
    public string PruebaUber { get; set; }
    //public DateTime DtRegistro { get; set; }
}