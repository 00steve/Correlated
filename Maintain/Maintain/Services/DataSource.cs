using Maintain.Objects.Correlated;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Maintain.Services
{
    public class DataSource
    {
        private Source source;
        private List<string> tables;
        private DataTable data;
        Import import;
        public bool Load(string fileName)
        {
            source = Database.GetSource(fileName);
            string ext = Path.GetExtension(fileName);
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
            tables = import.Tables();
            return true;
        }

        public List<string> Tables { get { return tables; } }

        public DataTable Data { get { return data; } }

        public bool SetTable(string table)
        {
            if (!tables.Contains(table)) return false;
            if (!import.LoadTable(table)) return false;
            data = import.Data();
            return true;
        }
    }
}
