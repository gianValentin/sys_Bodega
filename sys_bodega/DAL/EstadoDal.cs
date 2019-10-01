using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using sys_bodega.Models;

namespace sys_bodega.DAL
{
    public class EstadoDal
    {
        SqlConnection cn = new SqlConnection();
        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public List<Estado> findAllEstado()
        {
            List<Estado> lst = new List<Estado>();
            cn = conexion.conectar();
            cmd = new SqlCommand("select * from estado", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Estado estado = new Estado();
                estado.id = Convert.ToInt32(dr["id"].ToString());
                estado.nombreEstado = dr["nombreEstado"].ToString();
                lst.Add(estado);
            }
            cmd.Dispose();
            cn.Close();
            return lst;
        }
    }
}