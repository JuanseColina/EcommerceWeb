
using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objCapaDato = new CD_Usuarios();
        public List<Usuario> Listar()
        {
            return objCapaDato.Listar();
        }
        
        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.Nombres) ||  string.IsNullOrEmpty(obj.Apellidos) )
            {
                Mensaje= "Los campos Nombres y Apellidos son obligatorios";
            }
            else
            {
                if (string.IsNullOrEmpty(obj.Correo))
                {
                    Mensaje = "El campo Correo es obligatorio";
                }
                else
                {
                    if (string.IsNullOrEmpty(obj.Clave))
                    {
                        Mensaje = "El campo Clave es obligatorio";
                    }
                }
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                string clave = "test123";
                obj.Clave = clave;
                
                return objCapaDato.Registrar(obj, out Mensaje);
            }
            else
            {
                return 0;
            }
            
        }
    }
}