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
    public string Estado { get; set; }
    public string Prov99Min { get; set; }
    public string ProvMu { get; set; }
    public string ProvCid { get; set; }
    public string ProvRappiCargo { get; set; }
    public string VentaTelf99Min { get; set; }
    public string VentaTelfMu { get; set; }
    public string VentaTelfCid { get; set; }
    public string VentaTelfRappiCargo { get; set; }
    public string Garantizado99Min { get; set; }
    public string GarantizadoMu { get; set; }
    public string GarantizadoCid { get; set; }
    public string ECommerceDelivery { get; set; }
    public string ECommerceClickCollect { get; set; }
    public string ECommerceTipo { get; set; }
    public string Fijo99Min { get; set; }
    public string FijoMu { get; set; }
    public string FijoCid { get; set; }
    public string OnDemandMu { get; set; }
    public string OnDemandRappiCargo { get; set; }
    public string CanalesDigitalesRappi { get; set; }
    public string CanalesDigitalesUber { get; set; }
    public string ServicioEfectivo1 { get; set; }
    public string ServicioEfectivo2 { get; set; }
    public string ServicioEfectivo3 { get; set; }
    public string ServicioEfectivo4 { get; set; }
    public string ServicioEfectivo5 { get; set; }
    public string ServicioEfectivo6 { get; set; }
    public string ServicioEfectivo7 { get; set; }
    public string ServicioEfectivo8 { get; set; }
    public string ServicioTarjeta9 { get; set; }
    public string ServicioTarjeta10 { get; set; }
    public string ServicioTarjeta11 { get; set; }
    public string ServicioTarjeta12 { get; set; }
    public string InicioServicio { get; set; }
    public string CierreServicio { get; set; }
    //public DateTime DtRegistro { get; set; }
}