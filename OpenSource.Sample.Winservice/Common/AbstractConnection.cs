using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSource.Sample.Winservice.Common
{
    public abstract class AbstractConnection
    {
        protected IDbConnection connection = null;

        public AbstractConnection(IDbConnection conn)
        {
            this.connection = conn;
        }
    }
}
