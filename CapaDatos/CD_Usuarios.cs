using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Usuarios
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdUsuario,Nombres,Apellidos,Correo,Clave,Reestablecer,Activo from USUARIO"; 
                    
                    SqlCommand cmd = new SqlCommand(query, oconexion);//creamos el comando
                    cmd.CommandType = System.Data.CommandType.Text; //tipo de comando
                    
                    oconexion.Open(); //abrimos la conexion

                    using (SqlDataReader dr = cmd.ExecuteReader())//ejecutamos el comando
                    {
                        while (dr.Read())
                        {
                            lista.Add(
                                new Usuario()//agregamos a la lista
                                {
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                    Nombres = dr["Nombres"].ToString(),
                                    Apellidos = dr["Apellidos"].ToString(),
                                    Correo = dr["Correo"].ToString(),
                                    Clave = dr["Clave"].ToString(),
                                    Reestablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                    Activo = Convert.ToBoolean(dr["Activo"])
                                }
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
            return lista;
        }
    }
}