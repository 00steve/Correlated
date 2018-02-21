

using Maintain.Objects.Correlated;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Maintain.Services
{
    class Database
    {
        static public Source GetSource(string url)
        {
            Correlated c = new Correlated();
            Source s = c.Sources.Where(x => x.SourceURL == url).FirstOrDefault();
            if (s == null)
            {
                s = new Source();
                s.SourceURL = url;
            }
            return s;
        }
    }
}
