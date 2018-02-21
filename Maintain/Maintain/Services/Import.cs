
using System.Data;

namespace Maintain.Services
{
    public abstract class Import
    {
        public abstract DataTable Load(string file);
        
    }
}
