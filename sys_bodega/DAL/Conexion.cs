using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace sys_bodega.DAL
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["MiConexion"].ToString());
        }
    }
}