using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using sys_bodega.Models;
using System.Data;

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
                producto.marca = dr["marca"].ToString();
                producto.descripcion = dr["descripcion"].ToString();
                producto.cantEstablecida = Convert.ToInt32(dr["cantEstablecida"].ToString());
                producto.cantExistencia = Convert.ToInt32(dr["cantExistencia"].ToString());
                producto.cantMinima = Convert.ToInt32(dr["cantMinima"].ToString());
                producto.fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"].ToString());
                producto.fechaVencimientoProducto = Convert.ToDateTime(dr["fechaVencimientoProducto"].ToString());
                producto.idEstado = Convert.ToInt32(dr["IdEstado"].ToString());
                lstProducto.Add(producto);
            }
            cn.Close();
            cmd.Dispose();
            return lstProducto;
        }

        public string addProducto(Producto producto)
        { 
            var msg = "";
            try
            {
                cn = conexion.conectar();
                cmd = new SqlCommand("sp_agregar_Prodcuctos", cn);
                cn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@marca",producto.marca);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@cantEstablecida", producto.cantEstablecida);
                cmd.Parameters.AddWithValue("@cantExistencia", producto.cantExistencia);
                cmd.Parameters.AddWithValue("@cantMinima", producto.cantMinima);
                cmd.Parameters.AddWithValue("@fechaRegistro", producto.fechaRegistro);
                cmd.Parameters.AddWithValue("@fechaVencimientoProducto", producto.fechaVencimientoProducto);
                cmd.ExecuteNonQuery();
                msg = "ok";
            }
            catch(Exception ex)
            {
                msg = "Error"+ex.Message;
            }            
            finally
            {
                cn.Close();
                cmd.Dispose();
            }
            return msg;
        }
    }
}