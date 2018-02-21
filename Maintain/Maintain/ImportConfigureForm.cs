
using System.Windows.Forms;
using Maintain.Services;

namespace Maintain
{
    public partial class ImportConfigureForm : Form
    {
        private string dataFile;
        private bool isLoaded;

        public bool ReloadFileData()
        {
            DataSource fileSystem = new DataSource();
            fileSystem.Load(dataFile);
            return false;
        }

        public ImportConfigureForm(string file)
        {
            InitializeComponent();
            dataFile = file;
            isLoaded = ReloadFileData();
        }


        internal bool IsValid()
        {
            return isLoaded;
        }
    }
}
