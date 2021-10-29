using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyxekhach.AbstractModel
{
    class SqlFactory : AbstractDbFactory
    {
        public override DbConnection CreateConnection()
        {
            var conStr = ConfigurationManager.ConnectionStrings["AbstractFactoryConnect"].ConnectionString;
            return new SqlConnection(conStr);
        }

        public override DbCommand CreateCommand(string cmdText, DbConnection cn)
        {
            return new SqlCommand(cmdText, (SqlConnection)cn);
        }

        public override DbConnection CreateConnection(string cnString)
        {
            return new SqlConnection(cnString);
        }
        public override DbDataAdapter CreateDataAdapter(DbCommand selectCmd)
        {
            return new SqlDataAdapter((SqlCommand)selectCmd);
        }

        public override DbParameter SqlParameter(string parameterName, SqlDbType dbType)
        {
            return new SqlParameter(parameterName, (SqlDbType)dbType);
        }

    }
}
