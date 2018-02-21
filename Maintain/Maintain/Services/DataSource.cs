using Maintain.Objects.Correlated;

using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Maintain.Services
{
    public class DataSource
    {
        private Source source;
        private string[] sheets;
        private DataTable data;
        public bool Load(string fileName)
        {
            source = Database.GetSource(fileName);
            string ext = Path.GetExtension(fileName);
            Import import = null;
            if (ext == ".xls" || ext == ".xlsm") {
                import = new ImportExcel();
            }
            else {
                MessageBox.Show("Unrecognized format. This can't be loaded, bro!");
                return false;
            }
            import.SetDataSource(fileName);
            import.Load();
            data = import.Data();
            sheets = import.Sheets();
            return true;
        }

        public string[] Sheets { get { return sheets; } }
        
    }
}
