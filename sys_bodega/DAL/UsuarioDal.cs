using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using sys_bodega.Models;
using sys_bodega.Controllers;

namespace sys_bodega.DAL
{
    public class UsuarioDal
    {
        SqlConnection cn = new SqlConnection();
        Conexion conexion = new Conexion();
        SqlCommand cmd;

        public bool VerificaUsuarioLogin(string nombrecorreo,string contraseña)
        {            
            bool ok = false;
            //contraseña = PasswordHash.GetSHA256(contraseña);
            cn = conexion.conectar();
            cmd = new SqlCommand("sp_validarUsariorLogin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@nombrecorreo", nombrecorreo);            
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.ExecuteNonQuery();            
            SqlDataReader dr = cmd.ExecuteReader();
            Usuario usuario;
            if (dr.HasRows)
            {
                usuario = new Usuario();
                while (dr.Read())
                {
                    usuario.id = Convert.ToInt32(dr["id"].ToString());
                    usuario.nombre = dr["nombre"].ToString();
                    usuario.correo = dr["id"].ToString();
                    usuario.contraseña = dr["id"].ToString();
                    //usuario.token = Convert.ToChar(dr["token"].ToString());
                    usuario.idEstado = Convert.ToInt32(dr["idEstado"].ToString());
                }                
                ok = true;
            }
            else
            {
                usuario = null;
                ok = false;
            }
            HttpContext.Current.Session["usuario"] = usuario;
            cmd.Dispose();
            cn.Close();
            return ok;
        }

        public List<Usuario> FindAllUsuario()
        {
            List<Usuario> lstUsarios = new List<Usuario>();
            cn = conexion.conectar();
            cmd = new SqlCommand("sp_listarUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = Convert.ToInt32(dr["id"].ToString());
                usuario.nombre = dr["nombre"].ToString();
                usuario.correo = dr["correo"].ToString();
                usuario.contraseña = dr["contraseña"].ToString();
                usuario.token = dr["token"].ToString()[0];
                usuario.idEstado = Convert.ToInt32(dr["idEstado"].ToString());
                lstUsarios.Add(usuario);
            }
            cmd.Dispose();
            cn.Close();
            return lstUsarios;
        }
    }
}