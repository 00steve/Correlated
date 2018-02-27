
using System.Collections.Generic;
using System.Data;

namespace Maintain.Services
{
    public abstract class Import
    {
        public abstract bool Load();
        public abstract void SetDataSource(string file);
        public abstract DataTable Data();
        public abstract List<string> Tables();
        public abstract bool LoadTable(string table);
    }
}
