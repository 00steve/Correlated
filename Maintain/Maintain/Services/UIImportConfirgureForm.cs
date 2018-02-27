
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Maintain.Services
{
    class ImportDataFormUI
    {
        private ImportDataForm form;
        private DataSource dataSource;
        private DataGridViewSelectedCellCollection selection;
       

        private bool isSelectSingleDimension()
        {
            int i = selection.Count;
            if (i < 1) return false;//it can't be a single dimension if it has no entries
            DataGridViewCell[] d = new DataGridViewCell[selection.Count];
            int maxC = -999999999;
            int maxR = -999999999;
            int minC = 999999999;
            int minR = 999999999;
            selection.CopyTo(d, 0);
            while(i --> 0)
            {
                if (d[i].ColumnIndex > maxC) maxC = d[i].ColumnIndex;
                if (d[i].ColumnIndex < minC) minC = d[i].ColumnIndex;
                if (d[i].RowIndex > maxR) maxR = d[i].RowIndex;
                if (d[i].RowIndex < minR) minR = d[i].RowIndex;
            }
            if (maxC == minC || maxR == minR) return true;

            return false;
        }


        public ImportDataFormUI(ImportDataForm form)
        {
            this.form = form;
            dataSource = form.ImportDataSource;
            setupInputs();
        }



        private void setupInputs()
        {
            form.SheetComboBox.SelectedValueChanged += new EventHandler(this.onSheetComboBoxSelect);
            form.DataGrid.MouseUp += new MouseEventHandler(this.onDataGridMouseUp);
            form.MeasureLabelsTextBox.Click += new EventHandler(this.onMeasureLabelsTextBoxClick);

            if (dataSource != null && dataSource.Tables != null && dataSource.Tables.Count > 0)
            {
                form.SheetComboBox.Enabled = true;
                form.SheetComboBox.DataSource = dataSource.Tables;
            }
            else
            {
                form.SheetComboBox.Enabled = false;
            }
        }


        private void onDataGridMouseUp(Object sender,EventArgs e)
        {
            selection = form.DataGrid.SelectedCells;
        }

        private void onMeasureLabelsTextBoxClick(Object sender,EventArgs e)
        {
            if (selection == null) return;
            //form.MeasureLabelsTextBox.Text = selection.
            if (!isSelectSingleDimension())
            {
                MessageBox.Show("selected cells must be a single dimension!");
                return;
            }
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
