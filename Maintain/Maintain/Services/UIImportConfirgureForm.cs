using System;
using System.Windows.Forms;

namespace Maintain.Services
{
    class ImportDataFormUI
    {
        private ImportDataForm form;
        private DataSource dataSource;
        public ImportDataFormUI(ImportDataForm form)
        {
            this.form = form;
            dataSource = form.ImportDataSource;
            setupInputs();
        }

        private void setupInputs()
        {
            form.SheetComboBox.SelectedValueChanged += new System.EventHandler(this.onSheetComboBoxSelect);
            //form.DataSourceAddButton.Click += new EventHandler(this.onDataSourceAddClick);
            //form.QuitButton.Click += new EventHandler(this.onQuitButtonClick);
            if(dataSource != null && dataSource.Sheets != null && dataSource.Sheets.Length > 0)
            {
                form.SheetComboBox.DataSource = dataSource.Sheets;
            }
            else
            {

            }
        }


        private void onSheetComboBoxSelect(Object sender, EventArgs e)
        {
            MessageBox.Show("stuff");
        }
    }
}
