using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ginmasio
{
    public partial class Frm_GrupDoc : Form
    {

       CRUD_GDocentes buscar_docente = new CRUD_GDocentes();
        CRUD_GCARRERA buscar_grupos = new CRUD_GCARRERA();
        campus buscar = new campus();
        campus insertar = new campus();
        Mensaje_Suscripcion mensaje = new Mensaje_Suscripcion();
        Frm_Alerta mensaje_02 = new Frm_Alerta();
        public static string @GOVERNMENT_ID, @FIRTSNAME, @MIDDLE_NAME, @LAST_NAME, @LAST_NAME02;
        public static string @AREA_CONOCIMIENTO,@CARRERA,@TURNO,@COD_ASIG,@ASIGNATURA,@GRUPO;

        public Frm_GrupDoc()
        {
            InitializeComponent();
            llenar_cb();
   
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda_insecto();
            btnasignar.Enabled = true;
        }

        private void btnbusgrupo_Click(object sender, EventArgs e)
        {
            busqueda_insecto2();
        }

        //private void btnBuscar_Click_1(object sender, EventArgs e)
        //{
            
        //}

        //private void btnbusgrupo_Click_1(object sender, EventArgs e)
        //{
        
        //}


        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llamar a tu función aquí
                busqueda_insecto();
                busqueda_insecto2();
                // Indicar que se ha manejado la tecla para evitar su procesamiento adicional
                e.Handled = true;
            }
        }
        

        public void llenar_cb()
        {
            cbTipo.Text = "SELECCIONE TIPO";
            //cbSexo.Items.Add("--------------");
            cbTipo.Items.Add("");
            cbTipo.Items.Add("NO. CEDULA");

        }

       

        /*----------- busqueda de docentes------------------- */
        void busqueda_insecto()
        {

            DataTable Respuesta = new DataTable();

            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN VALOR PARA INICAR BUSQUEDA");
            }
            else
            {
                if (cbTipo.SelectedIndex == 1) //BUSQUEDA POR CEDULA
                {
                    Respuesta = buscar_docente.busqueda_docentes(txtBusqueda.Text,1);
                    if (Respuesta.Rows.Count == 0)
                    {
                        MessageBox.Show("NO SE ENCONTRARON REGISTROS");
                        txtBusqueda.Clear();
                    }
                    else
                    {
                        Obtener_valores();
                    }

                }
                else
                {
                    MessageBox.Show("DEBE SELECCIONAR UNA OPCION PARA INICAR BUSQUEDA");
                }
            }

            void Obtener_valores()
            {
                foreach (DataRow row in Respuesta.Rows)
                {
                    txtcedula.Text = Convert.ToString(row["GOVERNMENT_ID"]);
                    txtPrimer_Nombre.Text = Convert.ToString(row["FIRST_NAME"]);
                    txtSegundo_Nombre.Text = Convert.ToString(row["MIDDLE_NAME"]);
                    txtPrimerApellido.Text = Convert.ToString(row["LAST_NAME"]);
                    txtSegundoApellido.Text = Convert.ToString(row["Last_Name_Prefix"]);
                }
            }
        }


        /*----------- busqueda de grupos y turnos------------------- */

        private void btnasignar_click (object sender, EventArgs e)
        {
            btnbusgrupo.Enabled = true;
            txtbusgrupos.Enabled = true;
        }
     
        void busqueda_insecto2()
                {
            DataTable Tabla_Grupos = new DataTable();

            if (txtbusgrupos.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN VALOR PARA INICAR BUSQUEDA");
            }
            else
            {
               
                    Tabla_Grupos = buscar_grupos.Busqueda_Grupos_Carrera(txtbusgrupos.Text,1);
                    if (Tabla_Grupos.Rows.Count == 0)
                    {
                        MessageBox.Show("NO SE ENCONTRARON REGISTROS");
                        txtbusgrupos.Clear();
                    }
                    else
                    {
                        Obtener_valores2();
                    }
                
            }

            void Obtener_valores2()
            {
                foreach (DataRow row in Tabla_Grupos.Rows)
                {
                    txtareaconocimiento.Text = Convert.ToString(row["AREA_CONOCIMIENTO"]);
                    txtcarrera.Text = Convert.ToString(row["CARRERA"]);
                    txtgrupo.Text = Convert.ToString(row["GRUPO"]);
                    txtturno.Text = Convert.ToString(row["TURNO"]);
                    txtcodasig.Text= Convert.ToString(row["COD_ASIGNATURA"]);
                    cbasignatura.Items.Add(Convert.ToString(row["ASIGNATURA"]));
                }

                cbasignatura.SelectedIndexChanged += (sender, e) =>
                {
                    // Obtener el índice seleccionado
                    int selectedIndex = cbasignatura.SelectedIndex;

                    // Verificar si el índice es válido
                    if (selectedIndex >= 0 && selectedIndex < Tabla_Grupos.Rows.Count)
                    {
                        // Obtener el código de asignatura correspondiente al índice seleccionado
                        string codigoAsignatura = Convert.ToString(Tabla_Grupos.Rows[selectedIndex]["COD_ASIGNATURA"]);

                        // Asignar el código de asignatura al TextBox
                        txtcodasig.Text = codigoAsignatura;
                    }
                };
            }



        }
        /*guarda los registro en docentes*/
        private void btnguardar2_Click(object sender, EventArgs e)
        {
            guardardoc();
            cbasignatura.Items.Clear();
            txtcodasig.Clear();
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrWhiteSpace(txtBusqueda.Text) ||
                string.IsNullOrWhiteSpace(txtbusgrupos.Text) 
            
              )

            {
                mensaje_02.ShowDialog();
                return false;
            }

            // Puedes agregar más condiciones de validación según tus necesidades.

            return true;
        }

        void guardardoc()
        {


            int salida = 0;

            @GOVERNMENT_ID = txtcedula.Text;
            @FIRTSNAME = txtPrimer_Nombre.Text;
            @MIDDLE_NAME = txtSegundo_Nombre.Text;
            @LAST_NAME = txtPrimerApellido.Text;
            @LAST_NAME02 = txtSegundoApellido.Text;
            @AREA_CONOCIMIENTO = txtareaconocimiento.Text;
            @CARRERA = txtcarrera.Text;
            @TURNO = txtturno.Text;
            @COD_ASIG = txtcodasig.Text;
            @GRUPO = txtgrupo.Text;

            @ASIGNATURA = cbasignatura.Text;

            salida = insertar.Insertar_Doc_Grupos(@GOVERNMENT_ID, @FIRTSNAME, @MIDDLE_NAME, @LAST_NAME, @LAST_NAME02, @AREA_CONOCIMIENTO,@CARRERA,@TURNO,@COD_ASIG,@ASIGNATURA,@GRUPO);

            if (salida == 1)
            {
                mensaje.ShowDialog();
            }
            else
            {
                mensaje_02.ShowDialog();
            }

            //MessageBox.Show("OPERACION FINALIZADA");

            limpiar_texbox();



        }
        public void limpiar_texbox()
        {
            txtcedula.Clear();
            txtPrimer_Nombre.Clear();
            txtSegundo_Nombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtBusqueda.Clear();
            txtbusgrupos.Clear();
            txtgrupo.Clear();
            txtareaconocimiento.Clear();
            txtcarrera.Clear();
            txtturno.Clear();
            txtgrupo.Clear();
            cbasignatura.Items.Clear();
        }

    }

}
   
