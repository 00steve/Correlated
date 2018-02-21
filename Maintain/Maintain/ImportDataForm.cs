
using System.Windows.Forms;
using Maintain.Services;

namespace Maintain
{
    public partial class ImportDataForm : Form
    {
        private string dataFile;
        private bool isLoaded;



        public bool ReloadFileData()
        {
            DataSource fileSystem = new DataSource();
            return fileSystem.Load(dataFile);
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

    }
}
