using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sys_bodega.Models;
using System.Data;
using System.Data.SqlClient;

namespace sys_bodega.DAL
{
    public class StockDal
    {
        SqlConnection cn = new SqlConnection();
        Conexion conexion = new Conexion();
        SqlCommand cmd;
        public bool addStock(Stock stock)
        {           
            bool add = false;
            try
            {
                cn = conexion.conectar();
                cmd = new SqlCommand("sp_agregar_Stock", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoBarra", stock.codigoBarra);
                cmd.Parameters.AddWithValue("@idProducto", stock.idProducto);
                cmd.Parameters.AddWithValue("@idEstado", stock.idEstado);
                cmd.ExecuteNonQuery();
                add = true;
            }
            catch(Exception ex)
            {
                ex.ToString();
                add = false;
            }
            finally
            {
                cn.Close();
                cmd.Dispose();
            }
            return add;
        }
    }
}