using Microsoft.Win32;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Maintain.Services
{
    class ImportExcel : Import
    {

        public override DataTable Load(string file)
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
            String constr = "Provider=" + provider + "; Data Source=" +
                            file +
                            ";Extended Properties='Excel " + excelVersion+ ";HDR=NO;';";
            DataTable data;

            OleDbConnection con = new OleDbConnection(constr);

            OleDbCommand oconn = new OleDbCommand("Select * From [0]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            data = new DataTable();
            sda.Fill(data);
            return data;
        }

    }
}
