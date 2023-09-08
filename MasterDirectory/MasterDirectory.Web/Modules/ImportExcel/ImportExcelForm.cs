using Serenity.ComponentModel;

namespace MasterDirectory.Web.Modules.ImportExcel
{
    [FormScript("Modules.ImportExcel")]
    public class ImportExcelForm
    {        
        [FileUploadEditor, Required]
        public string FileName { get; set; }
    }
}
