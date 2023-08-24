using Serenity.ComponentModel;
using System;

namespace MasterDirectory.Consultorios.Forms;

[FormScript("Consultorios.CategoriaConsultorios")]
[BasedOnRow(typeof(CategoriaConsultoriosRow), CheckNames = true)]
public class CategoriaConsultoriosForm
{

    [Tab("General")]
    public string LocalSap { get; set; }
    public string ConsulOperacion { get; set; }
    public string Benamedic { get; set; }
    public string RampaDiscapa { get; set; }

    [Tab("Horarios")]
    public string HorarioLv { get; set; }
    public string HorarioS { get; set; }
    public string HorarioD { get; set; }
    
    //public DateTime DtRegistro { get; set; }
}