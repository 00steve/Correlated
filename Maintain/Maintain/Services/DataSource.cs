using Maintain.Objects.Correlated;

using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Maintain.Services
{
    class DataSource
    {
        private Source source;
        private DataTable data;
        public bool Load(string fileName)
        {
            source = Database.GetSource(fileName);
            string ext = Path.GetExtension(fileName);

            if (ext == ".xls" || ext == ".xlsm"){
                Import import = new ImportExcel();
                data = import.Load(fileName);
                return true;
            }
            else{
                MessageBox.Show("Unrecognized format. This can't be loaded, bro!");
                return false;
            }
        }
    }
}
