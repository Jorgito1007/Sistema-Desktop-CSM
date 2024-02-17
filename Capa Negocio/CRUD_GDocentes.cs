using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{

    public class CRUD_GDocentes
    {
        Capa_Datos.Acceso conexion = new Capa_Datos.Acceso(); // se instancia un objeto de tipo acceso
        private SqlCommand Comando; // objeto de tipo SqlCommand para los comandos de SQL
        SqlDataAdapter Adaptador; // objeto de tipo SqlDataAdapter para convertir las tablas de SQL y guardarlas en una tabla

        public DataTable busqueda_docentes(String cedula,int id)
        {
            DataTable Tabla_Docentes = new DataTable(); // Instancia de un objeto de tipo DataTable para recibir la tabla que devuelve el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); // se abre la conexión para el comando
            Comando = new SqlCommand(); // instancia del objeto de tipo SqlCommand
            Comando.CommandText = "BUSQUEDA_DOCENTES_2024"; // se pasa el procedimiento almacenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@CEDULA", System.Data.SqlDbType.VarChar)).Value = cedula;
            Comando.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int)).Value = id;
            Comando.Connection = conexion.conexion_datos; // se abre la conexión para el comando
            Adaptador = new SqlDataAdapter(Comando); // se recibe la tabla producto de la ejecución del procedimiento
            Adaptador.Fill(Tabla_Docentes); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexión
            return Tabla_Docentes; // retorno de la tabla 
        }

        public DataTable Mostrar_Roles()
        {
            DataTable Tabla_roles = new DataTable(); // Instancia de un objeto de tipo DataTable para recibir la tabla que devuelve el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); // se abre la conexión para el comando
            Comando = new SqlCommand(); // instancia del objeto de tipo SqlCommand
            Comando.CommandText = "MOSTRAR_TIPO_ROL"; // se pasa el procedimiento almacenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Connection = conexion.conexion_datos; // se abre la conexión para el comando
            Adaptador = new SqlDataAdapter(Comando); // se recibe la tabla producto de la ejecución del procedimiento
            Adaptador.Fill(Tabla_roles); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexión
            return Tabla_roles; // retorno de la tabla 
        }




    }

}