using Serenity.ComponentModel;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MasterDirectory.UltimaMilla.Forms;

[FormScript("UltimaMilla.CategoriaUltimaMilla")]
[BasedOnRow(typeof(CategoriaUltimaMillaRow), CheckNames = true)]
public class CategoriaUltimaMillaForm
{
    [Tab("General")]
    public string LocalSap { get; set; }
    public string Estado { get; set; }
    [Tab("Proveedores")]

    [DisplayName("99Min")]
    public string Prov99Min { get; set; }
    [DisplayName("MU")]
    public string ProvMu { get; set; }
    [DisplayName("CID")]
    public string ProvCid { get; set; }
    [DisplayName("Rappi Cargo")]
    public string ProvRappiCargo { get; set; }
    [Tab("Venta Telefónica")]
    [DisplayName("99Min")]
    public string VentaTelf99Min { get; set; }
    [DisplayName("MU")]
    public string VentaTelfMu { get; set; }
    [DisplayName("CID")]
    public string VentaTelfCid { get; set; }
    [DisplayName("Rappi Cargo")]
    public string VentaTelfRappiCargo { get; set; }
    [Tab("Garantizado")]
    [DisplayName("99Min")]
    public string Garantizado99Min { get; set; }
    [DisplayName("MU")]
    public string GarantizadoMu { get; set; }
    [DisplayName("CID")]
    public string GarantizadoCid { get; set; }
    [Tab("E-Commerce")]
    [DisplayName("Delivery")]
    public string ECommerceDelivery { get; set; }
    [DisplayName("Click&Collect")]
    public string ECommerceClickCollect { get; set; }
    [DisplayName("Tipo")]
    public string ECommerceTipo { get; set; }
    [Tab("Fijo")]
    [DisplayName("99Min")]
    public string Fijo99Min { get; set; }
    [DisplayName("MU")]
    public string FijoMu { get; set; }
    [DisplayName("CID")]
    public string FijoCid { get; set; }
    [Tab("On Demand")]
    [DisplayName("MU")]
    public string OnDemandMu { get; set; }
    [DisplayName("Rappi Cargo")]
    public string OnDemandRappiCargo { get; set; }
    [Tab("Canales Digitales")]
    [DisplayName("Rappi")]
    public string CanalesDigitalesRappi { get; set; }
    [DisplayName("Uber")]
    public string CanalesDigitalesUber { get; set; }
    [Tab("Tipo de Servicio - Efectivo")]
    [DisplayName("1")]
    public string ServicioEfectivo1 { get; set; }
    [DisplayName("2")]
    public string ServicioEfectivo2 { get; set; }
    [DisplayName("3")]
    public string ServicioEfectivo3 { get; set; }
    [DisplayName("4")]
    public string ServicioEfectivo4 { get; set; }
    [DisplayName("5")]
    public string ServicioEfectivo5 { get; set; }
    [DisplayName("6")]
    public string ServicioEfectivo6 { get; set; }
    [DisplayName("7")]
    public string ServicioEfectivo7 { get; set; }
    [DisplayName("8")]
    public string ServicioEfectivo8 { get; set; }
    [Tab("Tipo de Servicio - Tarjeta")]
    [DisplayName("9")]
    public string ServicioTarjeta9 { get; set; }
    [DisplayName("10")]
    public string ServicioTarjeta10 { get; set; }
    [DisplayName("11")]
    public string ServicioTarjeta11 { get; set; }
    [DisplayName("12")]
    public string ServicioTarjeta12 { get; set; }
    [Tab("Horario")]
    public string InicioServicio { get; set; }
    public string CierreServicio { get; set; }
    //public DateTime DtRegistro { get; set; }
}