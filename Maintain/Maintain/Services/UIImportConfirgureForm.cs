using Maintain.Objects.UI;
using System;
using System.Windows.Forms;

namespace Maintain.Services
{
    class ImportDataFormUI
    {
        private ImportDataForm form;
        private DataSource dataSource;
        private DataGridViewSelectedCellCollection selection;

        private bool newSelection;

        public ImportDataFormUI(ImportDataForm form)
        {
            newSelection = false;
            this.form = form;
            dataSource = form.ImportDataSource;
            setupInputs();
        }



        private void setupInputs()
        {
            form.SheetComboBox.SelectedValueChanged += new EventHandler(this.onSheetComboBoxSelect);
            //form.DataGrid.SelectionChanged += new EventHandler(this.onDataGridSelectionChanged);
            form.DataGrid.MouseUp += new MouseEventHandler(this.onDataGridMouseUp);
            //form.DataSourceAddButton.Click += new EventHandler(this.onDataSourceAddClick);
            //form.QuitButton.Click += new EventHandler(this.onQuitButtonClick);
            if (dataSource != null && dataSource.Tables != null && dataSource.Tables.Count > 0)
            {
                form.SheetComboBox.DataSource = dataSource.Tables;
            }
            else
            {

            }
        }

        //private void onDataGridSelectionChanged(Object sender,EventArgs e)
        //{
        //    newSelection = true;
        //}

        private void onDataGridMouseUp(Object sender,EventArgs e)
        {
            MessageBox.Show("new selection : " + newSelection.ToString());
            selection = form.DataGrid.SelectedCells;
        }

        private void onSheetComboBoxSelect(Object sender, EventArgs e)
        {
            string sheet = form.SheetComboBox.SelectedValue.ToString();
            if (dataSource == null || dataSource.Tables == null || !dataSource.Tables.Contains(sheet)) return;
            dataSource.SetTable(sheet);
            form.DataGrid.DataSource = dataSource.Data;
        }
    }
}
