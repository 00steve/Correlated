using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Maintain.Services
{
    class ImportExcel : Import
    {
        private string file;
        private DataTable data;
        private List<string> sheets;
        String connectionString;
        String currentSheet;

        public override bool Load()
        {
            string ext = Path.GetExtension(file);
            string provider = string.Empty;
            string excelVersion = string.Empty;
            RegistryKey rkACDBKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Classes");
            if (rkACDBKey != null)
            {
                //int lnSubKeyCount = 0;
                //lnSubKeyCount =rkACDBKey.SubKeyCount; 
                foreach (string subKeyName in rkACDBKey.GetSubKeyNames())
                {
                    if (subKeyName.Contains("Microsoft.ACE.OLEDB."))
                    {
                        // do something what you want do
                        if(ext == ".xls" && subKeyName.Contains("12"))
                        {
                            provider = subKeyName;
                            excelVersion = "12.0";
                        }
                    }
                }
            }
           
            String name = "Items";
            connectionString = "Provider=" + provider + "; Data Source=" + file + ";Extended Properties='Excel " + excelVersion + ";HDR=NO;';";

            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();
            DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            if (dt == null)
            {
                return false;
            }

            sheets = new List<string>();
            // Add the sheet name to the string array.
            foreach (DataRow row in dt.Rows)
            {
                sheets.Add(row["TABLE_NAME"].ToString());
 
            }
           
            if(dt.Rows.Count > 0)
            {
                return LoadTable(sheets[0]);
            }
            else
            {
                return false;
            }
            
        }

        public override bool LoadTable(string table)
        {
            if (!sheets.Contains(table)) return false;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + table + "]", con);
            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            data = new DataTable();
            sda.Fill(data);
            currentSheet = table;
            return true;
        }

        public override void SetDataSource(string file)
        {
            this.file = file;
        }

        public override DataTable Data()
        {
            return data;
        }
        public override List<string> Tables()
        {
            return sheets;
        }
    }
}
