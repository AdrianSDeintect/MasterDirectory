using Serenity.ComponentModel;
using System;

namespace MasterDirectory.UltimaMilla.Forms;

[FormScript("UltimaMilla.CategoriaUltimaMilla")]
[BasedOnRow(typeof(CategoriaUltimaMillaRow), CheckNames = true)]
public class CategoriaUltimaMillaForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string VentaTelefonica { get; set; }
    public string Garantizado { get; set; }
    public string Hub { get; set; }

    [Tab("ECommerce")]
    public string ECommerce { get; set; }
    public string TipoEComm { get; set; }
    public string Tablet { get; set; }
    public string NSerie { get; set; }
    public string EstatusTablet { get; set; }

    [Tab("MarketPlace")]
    public string Rappi { get; set; }
    public string Qr { get; set; }
    public string ServicioDomicilio { get; set; }
    public string PruebaUber { get; set; }
    //public DateTime DtRegistro { get; set; }
}