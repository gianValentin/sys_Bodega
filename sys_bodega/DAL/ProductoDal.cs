using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using sys_bodega.Models;

namespace sys_bodega.DAL
{

    public class ProductoDal
    {
        SqlConnection cn = new SqlConnection();
        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public List<Producto> FindAllProducto()
        {
            List<Producto> lstProducto = new List<Producto>();
            cn = conexion.conectar();
            cmd = new SqlCommand("sp_listarProductos",cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Producto producto = new Producto();
                producto.id = Convert.ToInt32(dr["id"].ToString());
                producto.marca = dr["nombre"].ToString();
                producto.descripcion = dr["descripcion"].ToString();
                producto.idStock = Convert.ToInt32(dr["IdEstado"].ToString());
                lstProducto.Add(producto);
            }
            cn.Close();
            cmd.Dispose();
            return lstProducto;
        }
    }
}