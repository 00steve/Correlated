using Maintain.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Maintain.Services
{
    class UI
    {
        private MainForm form;


        public UI(MainForm form)
        {
            this.form = form;


            setupInputs();

        }

        private void setupInputs()
        {
            form.DataSourceAddButton.Click += new EventHandler(this.onDataSourceAddClick);
            form.QuitButton.Click += new EventHandler(this.onQuitButtonClick);
        }

        private void onDataSourceAddClick(Object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog addSourceOpenFileDialog = new OpenFileDialog();
            
            addSourceOpenFileDialog.Filter = "All files|*.*|Old excel files |*.xls|Newschool excel files|*.xlsm";// "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            addSourceOpenFileDialog.FilterIndex = 1;
            addSourceOpenFileDialog.RestoreDirectory = true;

            if (addSourceOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(addSourceOpenFileDialog.FileName);
                if(ext == ".xls" || ext == ".xlsm"){
                    //MessageBox.Show("Load excel file : " + addSourceOpenFileDialog.FileName);
                    DataSource ds = Database.GetDataSource(addSourceOpenFileDialog.FileName);
                    ImportExcelForm form = new ImportExcelForm();

                }
                else{
                    MessageBox.Show("Unrecognized format. This can't be loaded, bro!");
                }
            }
        }

        private void onQuitButtonClick(Object sender, EventArgs e)
        {
            form.Quit();
        }
    }
}
