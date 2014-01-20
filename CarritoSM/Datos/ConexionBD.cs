using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionBD
    {

        #region Conexion()
        public static SqlConnection GET_CONEXION()
        {
            return new SqlConnection(String.Format(@"Server=MCRUZ-PC;Database=SanMiguel;User Id=mainorcruz;Password=mainorcruz;"));
        }
        #endregion
    }
}
