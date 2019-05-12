using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI.PI.Data.Repository
{
    public class SGIContext : DbContext
    {

        public SGIContext()
            : base("SGI")
        {
            Database.SetInitializer<SGIContext>(null);
        }
    }
}
