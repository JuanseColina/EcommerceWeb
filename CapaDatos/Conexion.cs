using System;
using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cn = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}