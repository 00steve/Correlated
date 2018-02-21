
using System.Data;

namespace Maintain.Services
{
    public abstract class Import
    {
        public abstract bool Load();
        public abstract void SetDataSource(string file);
        public abstract DataTable Data();
        public abstract string[] Sheets();
        
    }
}
