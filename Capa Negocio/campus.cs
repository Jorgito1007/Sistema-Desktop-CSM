using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    public class campus
    {

        Capa_Datos.Acceso conexion = new Capa_Datos.Acceso(); //se instancia un objeto de tipo acceso
        private SqlCommand Comando; //objeto de tipo SqlCommand para los comandos de sql
        SqlDataAdapter Adaptador; //objeto de tipo sqlAdapter para convertir las tablas de sql y guardarlas en una tabla

        //public DataTable Mostrar_Registro()
        //{
        //    DataTable Tabla_Registro = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
        //    conexion.conexion_datos.Open(); //se abre la conexion para el comando
        //    Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
        //    Comando.CommandText = "SP_MOSTRAR_MATRICULA_2024"; //se pasa el procedimiento almancenado
        //    Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
        //    Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
        //    Adaptador.Fill(Tabla_Registro); // con el SqlDataAdapter se llena la tabla
        //    conexion.conexion_datos.Close(); // se cierra la conexion
        //    return Tabla_Registro; // retorno de la tabla 
        //}



        public int Insertar_Estudiante(String GOVERMENT_ID,string PREFIX, String NAME01, string NAME02, string LASTNAME01, string LASTNAME02, int ID_ETNIA,string GENDER, int ID_MARITAL_STATUS,int ID_REGLIGION,string ADDRES_COMPLETE,DateTime BIRTH_DATE,int  ID_BIRTH_COUNTRY,int ID_COUNTRY_LIVE,int ID_DEPARTMENTO, int ID_MUNICIPIO, string ADDRES_MAIL,string PHONE01,string P_DESCRIPTION01, string PHONE02, string P_DESCRIPTION02, string PHONE03, string P_DESCRIPTION03,int PEOPLE_TYPE)
        {
            int salida = 3;
            DataTable Tabla_Estudiante = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "SP_INGRESAR_DOCENTES_2024"; //se pasa el procedimiento almancenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
          
            Comando.Parameters.Add(new SqlParameter("@GOVERMENT_ID", System.Data.SqlDbType.VarChar)).Value = GOVERMENT_ID;
            Comando.Parameters.Add(new SqlParameter("@PREFIX", System.Data.SqlDbType.VarChar)).Value = PREFIX;
            Comando.Parameters.Add(new SqlParameter("@NAME01", System.Data.SqlDbType.VarChar)).Value = NAME01;
            Comando.Parameters.Add(new SqlParameter("@NAME02", System.Data.SqlDbType.VarChar)).Value = NAME02;
            Comando.Parameters.Add(new SqlParameter("@LASTNAME01", System.Data.SqlDbType.VarChar)).Value = LASTNAME01;
            Comando.Parameters.Add(new SqlParameter("@LASTNAME02", System.Data.SqlDbType.VarChar)).Value = LASTNAME02;
            Comando.Parameters.Add(new SqlParameter("@ID_ETNIA", System.Data.SqlDbType.Int)).Value = ID_ETNIA;
            Comando.Parameters.Add(new SqlParameter("@GENDER", System.Data.SqlDbType.VarChar)).Value = GENDER;
            Comando.Parameters.Add(new SqlParameter("@ID_MARITAL_STATUS", System.Data.SqlDbType.Int)).Value = ID_MARITAL_STATUS;
            Comando.Parameters.Add(new SqlParameter("@ID_REGLIGION", System.Data.SqlDbType.Int)).Value = ID_REGLIGION;
            Comando.Parameters.Add(new SqlParameter("@ADDRES_COMPLETE", System.Data.SqlDbType.VarChar)).Value = ADDRES_COMPLETE;
            Comando.Parameters.Add(new SqlParameter("@BIRTH_DATE", System.Data.SqlDbType.DateTime)).Value = BIRTH_DATE;
            Comando.Parameters.Add(new SqlParameter("@ID_BIRTH_COUNTRY", System.Data.SqlDbType.Int)).Value = ID_BIRTH_COUNTRY;
            Comando.Parameters.Add(new SqlParameter("@ID_COUNTRY_LIVE", System.Data.SqlDbType.Int)).Value = ID_COUNTRY_LIVE;
            Comando.Parameters.Add(new SqlParameter("@ID_DEPARTMENTO", System.Data.SqlDbType.Int)).Value = ID_DEPARTMENTO;
            Comando.Parameters.Add(new SqlParameter("@ID_MUNICIPIO", System.Data.SqlDbType.Int)).Value = ID_MUNICIPIO;
            Comando.Parameters.Add(new SqlParameter("@ADDRES_MAIL", System.Data.SqlDbType.NVarChar)).Value = ADDRES_MAIL;
            //Comando.Parameters.Add(new SqlParameter("@HOUSE_NUMBER", System.Data.SqlDbType.NVarChar)).Value = HOUSE_NUMBER;
            Comando.Parameters.Add(new SqlParameter("@P_DESCRIPTION01", System.Data.SqlDbType.NVarChar)).Value = P_DESCRIPTION01;
            Comando.Parameters.Add(new SqlParameter("@PHONE01", System.Data.SqlDbType.NVarChar)).Value = PHONE01;
            Comando.Parameters.Add(new SqlParameter("@P_DESCRIPTION02", System.Data.SqlDbType.NVarChar)).Value = P_DESCRIPTION02;
            Comando.Parameters.Add(new SqlParameter("@PHONE02", System.Data.SqlDbType.NVarChar)).Value = PHONE02;
            Comando.Parameters.Add(new SqlParameter("@P_DESCRIPTION03", System.Data.SqlDbType.NVarChar)).Value = P_DESCRIPTION03;
            Comando.Parameters.Add(new SqlParameter("@PHONE03", System.Data.SqlDbType.NVarChar)).Value = PHONE03;
            Comando.Parameters.Add(new SqlParameter("@PEOPLE_TYPE", System.Data.SqlDbType.Int)).Value = PEOPLE_TYPE;
            //Comando.Parameters.Add(new SqlParameter("@ID_CURRICULUM_P", System.Data.SqlDbType.Int)).Value = ID_CURRICULUM_P;
            //Comando.Parameters.Add(new SqlParameter("@ACA_SESSION_P", System.Data.SqlDbType.NVarChar)).Value = ACA_SESSION_P;
            Comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Comando.ExecuteNonQuery();
            salida = Convert.ToInt32(Comando.Parameters["@SALIDA"].Value);

            //Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            //Adaptador.Fill(Tabla_Estudiante); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
                                             //return Tabla_Estudiante; // retorno de la tabla 

            return salida;

        }
        public int Insertar_Doc_Grupos(String GOVERNMENT_ID,  String NAME01, string NAME02, string LASTNAME01, string LASTNAME02, String AREA_CONOCIMIENTO, String CARRRERA, String TURNO,String COD_ASIG, String ASIGNATURA, String GRUPO)
        {
            int salida = 5;
            DataTable Tabla_DocGrup = new DataTable(); //Instancia de un ojeto de tipo DataTable para recibir la tabla que devuelde el objeto SqlDataAdapter
            conexion.conexion_datos.Open(); //se abre la conexion para el comando
            Comando = new SqlCommand(); //instancia del objeto de tipo sqlcommando
            Comando.CommandText = "InsertarDocenteGrupo"; //se pasa el procedimiento almancenado
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.Parameters.Add(new SqlParameter("@GOVERNMENT_ID", System.Data.SqlDbType.VarChar)).Value = GOVERNMENT_ID;
            Comando.Parameters.Add(new SqlParameter("@FIRTSNAME", System.Data.SqlDbType.VarChar)).Value = NAME01;
            Comando.Parameters.Add(new SqlParameter("@MIDDLE_NAME", System.Data.SqlDbType.VarChar)).Value = NAME02;
            Comando.Parameters.Add(new SqlParameter("@LAST_NAME", System.Data.SqlDbType.VarChar)).Value = LASTNAME01;
            Comando.Parameters.Add(new SqlParameter("@LAST_NAME02", System.Data.SqlDbType.VarChar)).Value = LASTNAME02;
            Comando.Parameters.Add(new SqlParameter("@AREA_CONOCIMIENTO", System.Data.SqlDbType.VarChar)).Value = AREA_CONOCIMIENTO;
            Comando.Parameters.Add(new SqlParameter("@CARRERA", System.Data.SqlDbType.VarChar)).Value = CARRRERA;
            Comando.Parameters.Add(new SqlParameter("@TURNO", System.Data.SqlDbType.VarChar)).Value = TURNO;
            Comando.Parameters.Add(new SqlParameter("@GRUPO", System.Data.SqlDbType.VarChar)).Value = GRUPO;
            Comando.Parameters.Add(new SqlParameter("@COD_ASIG", System.Data.SqlDbType.VarChar)).Value = COD_ASIG;
            Comando.Parameters.Add(new SqlParameter("@ASIGNATURA", System.Data.SqlDbType.VarChar)).Value = ASIGNATURA;
            Comando.Parameters.Add("@salida", SqlDbType.Int).Direction = ParameterDirection.Output;
            Comando.Connection = conexion.conexion_datos; // se abre la conexion para el comando
            Comando.ExecuteNonQuery();
            salida = Convert.ToInt32(Comando.Parameters["@SALIDA"].Value);

            //Adaptador = new SqlDataAdapter(Comando); //se reciebe la tabla producto de la ejecucion del procedimiento
            //Adaptador.Fill(Tabla_Estudiante); // con el SqlDataAdapter se llena la tabla
            conexion.conexion_datos.Close(); // se cierra la conexion
                                             //return Tabla_Estudiante; // retorno de la tabla 

            return salida;
        }
}
}