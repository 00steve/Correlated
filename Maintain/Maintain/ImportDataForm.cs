
using System.Windows.Forms;
using Maintain.Services;

namespace Maintain
{
    public partial class ImportDataForm : Form
    {
        private string dataFile;
        private bool isLoaded;
        private DataSource dataSource;


        public bool ReloadFileData()
        {
            dataSource = new DataSource();
            return dataSource.Load(dataFile);
        }

        public ImportDataForm(string file)
        {
            InitializeComponent();
            dataFile = file;
            isLoaded = ReloadFileData();
        }


        public bool IsValid()
        {
            return isLoaded;
        }


        public ComboBox SheetComboBox { get{ return sheetComboBox; } }
        public DataSource ImportDataSource { get { return dataSource; } }
        public DataGridView DataGrid { get { return data; } }
        public TextBox MeasureLabelsTextBox { get { return measureLabelsTextBox; } }
    }
}
