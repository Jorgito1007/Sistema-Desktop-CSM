﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos; // se agrega la refetencia de la capa datos

namespace Capa_Negocio
{
    public class CRUD_Cliente
    {
        Capa_Datos.Acceso02 conexion = new Capa_Datos.Acceso02(); //se instancia un objeto de tipo acceso
        private SqlCommand Comando; //objeto de tipo SqlCommand para los comandos de sql
        SqlDataAdapter Adaptador; //objeto de tipo sqlAdapter para convertir las tablas de sql y guardarlas en una tabla

        public DataTable Busca_Estudiante_Cedual(String Boleta,String cedula, int tipo)
        {
            DataTable Tabla_Estudiante = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_SHOW_STUDENT"; //se pasa el procedimiento almancenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@ID_BOLETA", System.Data.SqlDbType.VarChar)).Value = Boleta;
            Comando.Parameters.Add(new SqlParameter("@CEDULA", System.Data.SqlDbType.VarChar)).Value = cedula;
            Comando.Parameters.Add(new SqlParameter("@TIPO", System.Data.SqlDbType.Int)).Value = tipo;
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla_Estudiante); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla_Estudiante; // retorno de la tabla 
        }

        public DataTable Mostrar_Etnia()
        {
            DataTable Tabla_Etnia = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRAR_ETNIA"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla_Etnia); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla_Etnia; // retorno de la tabla 
        }

        public DataTable Mostrar_Estado_Civil()
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRAR_ESTADO_CIVIL"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }

        public DataTable Mostrar_Sexo()
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRAR_SEXO"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }

        public DataTable Mostrar_Departamento()
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRAR_DEPARTAMENTO"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }

        public DataTable Mostrar_Municipio(int ID_Departamento)
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRAR_MUNICIPIO"; //se pasa el procedimiento almancenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("ID_DEPARTAMENTO", System.Data.SqlDbType.Int)).Value = ID_Departamento;
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }


        public DataTable Mostrar_Proveedor_Internet()
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRA_PROVEEDOR"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }

        public DataTable Mostrar_Discapacidad()
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_DISCAPACIDAD"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }

        public DataTable Mostrar_Tipo_Bachillerato()
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_BACHILLERATO"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }

        public DataTable Mostrar_Centro_Estudios(int ID_Municipio)
        {
            DataTable Tabla = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_MOSTRAR_CENTRO"; //se pasa el procedimiento almancenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@ID_MUNICIPO", System.Data.SqlDbType.Int)).Value = ID_Municipio;
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla; // retorno de la tabla 
        }













































        public DataTable Mostrar_Cliente()
        {
            DataTable Tabla_Cliente = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_Mostrar_Clientes"; //se pasa el procedimiento almancenado
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            Adaptador.Fill(Tabla_Cliente); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
            return Tabla_Cliente; // retorno de la tabla 
        }

        public bool Insertar_Cliente(String Cedula, String PNombre, String SNombre, String PApellido, String SApellido, Char Sexo, String Fecha)
        {
            int salida;
            conexion.conexion_datos.Open();
            Comando = new SqlCommand();
            Comando.CommandText = "SP_Insertar_Cliente";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@Cedula_Cliente", System.Data.SqlDbType.VarChar)).Value = Cedula;
            Comando.Parameters.Add(new SqlParameter("@Primer_Nombre", System.Data.SqlDbType.VarChar)).Value = PNombre;
            Comando.Parameters.Add(new SqlParameter("@Segundo_Nombre", System.Data.SqlDbType.VarChar)).Value = SNombre;
            Comando.Parameters.Add(new SqlParameter("@Primer_Apellido", System.Data.SqlDbType.VarChar)).Value = PApellido;
            Comando.Parameters.Add(new SqlParameter("@Segundo_Apellido", System.Data.SqlDbType.VarChar)).Value = SApellido;
            Comando.Parameters.Add(new SqlParameter("@Sexo", System.Data.SqlDbType.Char)).Value = Sexo;
            Comando.Parameters.Add(new SqlParameter("@Fecha_Nac", System.Data.SqlDbType.Date)).Value = Fecha;
            Comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;
            Comando.Connection = conexion.conexion_datos; //Establece la conexio al objeto comando
            Comando.ExecuteNonQuery();
            salida = Convert.ToInt32(Comando.Parameters["@salida"].Value);
            conexion.conexion_datos.Close();
            if (salida == 0)
            {
                return true;
            }
            else return false;
        }
        public bool Eliminar_Cliente(String Cedula)
        {
            int salida;
            conexion.conexion_datos.Open();
            Comando = new SqlCommand();
            Comando.CommandText = "SP_Eliminar_Cliente";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@Cedula", System.Data.SqlDbType.VarChar)).Value = Cedula;
            Comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;
            Comando.Connection = conexion.conexion_datos;
            Comando.ExecuteNonQuery();
            salida = Convert.ToInt32(Comando.Parameters["@salida"].Value);
            conexion.conexion_datos.Close();
            if (salida == 1)
            {
                return true;
            }
            else return false;
        }

        public struct Cantidad
        {
            public int activo;
            public int inactivo;
            public int total;
        }
        public Cantidad Cantidad_Cliente()
        {
            Cantidad c = new Cantidad();
            conexion.conexion_datos.Open();
            Comando = new SqlCommand();
            Comando.CommandText = "SP_Cantidad_Cliente";
            Comando.CommandType= System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add("@inactivo",SqlDbType.Int).Direction=ParameterDirection.Output;
            Comando.Parameters.Add("@activo",SqlDbType.Int).Direction=ParameterDirection.Output;
            Comando.Parameters.Add("@total",SqlDbType.Int).Direction=ParameterDirection.Output;
            Comando.Connection = conexion.conexion_datos;
            Comando.ExecuteNonQuery();
            c.activo = Convert.ToInt32(Comando.Parameters["@activo"].Value);
            c.inactivo = Convert.ToInt32(Comando.Parameters["@inactivo"].Value);
            c.total = Convert.ToInt32(Comando.Parameters["@total"].Value);
            conexion.conexion_datos.Close();
            return c;
        }
      /*  struct Cliente
        {
            String Primer_Nombre;
            String Segundo_Nombre;
            String Primer_Apellido;
            String Segundo_Apellido;
            char Sexo;
            DateTime Fecha_Nac;
            DateTime Fecha_Registro;
            char Estado;
        }*/

        public bool Actualizar_cliente(String Cedula, String PNombre, String SNombre, String PApellido, String SApellido, Char Sexo, String Fecha)
        {
            int salida;
            bool band = false;
            conexion.conexion_datos.Open();
            Comando = new SqlCommand();
            Comando.CommandText = "SP_Actualizar_Cliente";
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@Cedula_Cliente", System.Data.SqlDbType.VarChar)).Value = Cedula;
            Comando.Parameters.Add(new SqlParameter("@Primer_Nombre", System.Data.SqlDbType.VarChar)).Value = PNombre;
            Comando.Parameters.Add(new SqlParameter("@Segundo_Nombre", System.Data.SqlDbType.VarChar)).Value = SNombre;
            Comando.Parameters.Add(new SqlParameter("@Primer_Apellido", System.Data.SqlDbType.VarChar)).Value = PApellido;
            Comando.Parameters.Add(new SqlParameter("@Segundo_Apellido",System.Data.SqlDbType.VarChar)).Value= SApellido;
            Comando.Parameters.Add(new SqlParameter("@Sexo",System.Data.SqlDbType.Char)).Value=Sexo;
            Comando.Parameters.Add(new SqlParameter("@Fecha_Nac",System.Data.SqlDbType.Date)).Value = Fecha;
            Comando.Parameters.Add("@salida",SqlDbType.Int).Direction = ParameterDirection.Output;
            Comando.Connection = conexion.conexion_datos;
            Comando.ExecuteNonQuery();
            salida = Convert.ToInt32(Comando.Parameters["@salida"].Value);
            conexion.conexion_datos.Close();
            if (salida == 0)
            {
                band = true;
            }
            return band;
        }
    }
}
