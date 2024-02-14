using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class Login
    {
        Acceso conexion = new Acceso();

        SqlCommand comando = new SqlCommand();

        public struct login
        {
            public int validacion;
            public string cedula;
            public String nombre;
            public String apellido;
        }

        public login verficar_login(string usser, string contra)
        {
            login l = new login();
            //conexion.conexion_datos.Open();
            //comando = new SqlCommand();
            //comando.CommandText = "SP_Login";
            //comando.CommandType = System.Data.CommandType.StoredProcedure;
            //comando.Parameters.Add(new SqlParameter("@usser", System.Data.SqlDbType.VarChar)).Value = usser;
            //comando.Parameters.Add(new SqlParameter("@contra", System.Data.SqlDbType.VarChar)).Value = contra;
            //comando.Parameters.Add("@validacion", SqlDbType.Int).Direction = ParameterDirection.Output;
            //comando.Parameters.Add("@cedula", SqlDbType.VarChar,16).Direction=ParameterDirection.Output;
            //comando.Parameters.Add("@nombre", SqlDbType.VarChar,20).Direction = ParameterDirection.Output;
            //comando.Parameters.Add("@apellido", SqlDbType.VarChar,20).Direction=ParameterDirection.Output;
            //comando.Connection = conexion.conexion_datos;
            //comando.ExecuteNonQuery();
            //l.validacion = Convert.ToInt32(comando.Parameters["@validacion"].Value);
            //l.cedula = Convert.ToString(comando.Parameters["@cedula"].Value);
            //l.nombre = Convert.ToString(comando.Parameters["@nombre"].Value);
            //l.apellido = Convert.ToString(comando.Parameters["@apellido"].Value);


            if (usser == "registro")
            {
                if (contra == "1234")
                {
                    l.validacion = 3;
                    l.cedula = "";
                    l.nombre = "Registro Academico";
                    l.apellido = "";
                }
                else
                {
                    l.validacion = 2;
                    l.cedula = "";
                    l.nombre = "Registro Academico";
                    l.apellido = "";
                }
            }
            else
            {
                l.validacion = 0;
                l.cedula = "";
                l.nombre = "Registro Academico";
                l.apellido = "";

            }


        
           
            return l;  
         }

    }
}
