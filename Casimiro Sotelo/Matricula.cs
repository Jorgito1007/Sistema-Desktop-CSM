using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
using Capa_Negocio;
using UNCSM;

namespace Ginmasio
{
    public partial class Matricula : Form
    {
        CRUD_Cliente prematricula = new CRUD_Cliente();
        DataTable tbl_Departamento = new DataTable(); //DataTable para almacenar los departamentos
        DataTable tbl_Departamento02 = new DataTable(); //DataTable para almacenar los departamentos
        DataTable tbl_Municipio = new DataTable();  //DataTable para almacenar los municipios en base al ID de cada Departamento
        DataTable tbl_Municipio02 = new DataTable();  //DataTable para almacenar los municipios en base al ID de cada Departamento
        DataTable tbl_Centro_Estudios = new DataTable();  //DataTable para almacenar los centros de estudios segun cada municipio
        DataTable Table = new DataTable();
        DataTable tbl_Discapacidad = new DataTable();
        Frm_Mensaje_Advertencia mensaje;


        public Matricula() //Constructor
        {
            InitializeComponent();
            llenar_etnia();
            llenar_Estado_Civil();
            llenar_Sexo();
            llenar_Departamento();
            llenar_Departamento02();
            llenar_mano();
            llenarAccesoInternet();
            llenarDiscapacidad();
            llenarTipoBachillerato();
            llenar_anio();

            txtCedula.TextChanged += ConvertirAMayusculas;
            txtPrimerNombre.TextChanged += ConvertirAMayusculas;
            txtPrimerApellido.TextChanged += ConvertirAMayusculas;
        }




        //==================================EVENTOS==================================   ---->  INCIO

        private void txtMat4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtLL4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtGeo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtFis4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtQuimi4_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtMat4_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtMat4.Text) == false)
            {
                txtMat4.Clear();
                txtMat4.Focus();
            }
        }

        private void txtLL4_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtLL4.Text) == false)
            {
                txtLL4.Clear();
                txtLL4.Focus();
            }
        }

        private void txtGeo4_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtGeo4.Text) == false)
            {
                txtGeo4.Clear();
                txtGeo4.Focus();
            }
        }

        private void txtFis4_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtFis4.Text) == false)
            {
                txtFis4.Clear();
                txtFis4.Focus();
            }
        }

        private void txtQuimi4_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtQuimi4.Text) == false)
            {
                txtQuimi4.Clear();
                txtQuimi4.Focus();
            }
        }

        private void txtMat5_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtMat5.Text) == false)
            {
                txtMat5.Clear();
                txtMat5.Focus();
            }
        }

        private void txtLL5_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtLL5.Text) == false)
            {
                txtLL5.Clear();
                txtLL5.Focus();
            }
        }

        private void txtHistoria5_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtHistoria5.Text) == false)
            {
                txtHistoria5.Clear();
                txtHistoria5.Focus();
            }
        }

        private void txtFisica5_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtFisica5.Text) == false)
            {
                txtFisica5.Clear();
                txtFisica5.Focus();
            }
        }

        private void txtQuimi5_Leave(object sender, EventArgs e)
        {
            if (Valida_Nota(txtQuimi5.Text) == false)
            {
                txtQuimi5.Clear();
                txtQuimi5.Focus();
            }
            else
            {
                Calcular_Promedio();
            }

        }

        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //se utiliza este evento para encontrar el departemanto seleccionado y asi obtener los municipios de dicho departamento
            string departamento;
            departamento = cbDepartamento.Text;

            foreach (DataRow row in tbl_Departamento.Rows)
            {
                if (Convert.ToString(row["Nombre"]) == departamento)
                {
                    tbl_Municipio = prematricula.Mostrar_Municipio(Convert.ToInt32(row["id"]));
                }
            }

            cbMunicipio.Items.Clear();
            cbMunicipio.Text = "";
            foreach (DataRow row in tbl_Municipio.Rows)
            {
                cbMunicipio.Items.Add(Convert.ToString(row["Nombre"]));
            }
            // Establecer el modo de autocompletado
            cbMunicipio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMunicipio.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cbAccesoInternet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbAccesoInternet.Text == "NO")
            {

                cbProveedor.Enabled = false;
                cbTipoConexion.Enabled = false;
                chkCelular.Enabled = false;
                chkCompu.Enabled = false;
                chkTableta.Enabled = false;

                cbProveedor.SelectedIndex = -1;
                cbTipoConexion.SelectedIndex = -1;
            }
            else
            {
                cbProveedor.Enabled = true;
                cbTipoConexion.Enabled = true;
                chkCelular.Enabled = true;
                chkCompu.Enabled = true;
                chkTableta.Enabled = true;
            }
        }

        private void btnValidar01_Click(object sender, EventArgs e)
        {
            if (ValidarCamposTab01() == true)
            {
                btnSiguiente01.Enabled = true;
                valida_segundo_tab(true);
            }
            else
            {
                Frm_Mensaje_Advertencia mensaje = new Frm_Mensaje_Advertencia("¡CAMPOS INCOMPLETOS!");
                mensaje.ShowDialog();
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            // Expresión regular para validar números enteros positivos
            string patron = @"^\d{13}[A-Za-z]$";

            // Creamos una instancia de Regex con la expresión regular
            Regex regex = new Regex(patron);


            mensaje = new Frm_Mensaje_Advertencia("El formato de cèdula es incorrecto");

            // Comprobamos si el input coincide con el patrón
            if (regex.IsMatch(txtCedula.Text))
            {

                //MessageBox.Show("El input es válido."); // Si coincide, el input es válido
            }
            else
            {
                /// MessageBox.Show("El input no es válido."); // Si no coincide, el input no es válido
                mensaje.ShowDialog();
                //txtCedula.Clear();
                txtCedula.Focus();
            }

        }

        private void ConvertirAMayusculas(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = textBox.Text.ToUpper();
            }
        }

        private void txtClaro_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtTigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void txtConvencional_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e);
        }

        private void btnSiguiente01_Click(object sender, EventArgs e)
        {

        }

        //==================================EVENTOS==================================   ---->  FIN





        //==================================FUNCIONES================================== ---->  INICIO

        //Funcion para evitar que se ingresen letras, solo numeros
        void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso (backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, se ignora la tecla presionada
                e.Handled = true;
            }
        }

        //Funcion para evitar que el usuario ingrese valores mayores que 100
        bool Valida_Nota(String Texbox)
        {
            bool bandera;
            int nota;
            if (Texbox == "")
            {
                Frm_Mensaje_Advertencia mensaje = new Frm_Mensaje_Advertencia("DEBE INGRESAR UNA NOTA!");
                mensaje.ShowDialog();
                //MessageBox.Show("DEBE INGRESAR UNA NOTA!");
                bandera = false;
            }
            else
            {
                nota = Convert.ToInt32(Texbox);
                if (nota <= 100)
                {
                    bandera = true;
                }
                else
                {
                    Frm_Mensaje_Advertencia mensaje = new Frm_Mensaje_Advertencia("LA NOTA REGISTRADA NO PUEDE SER MAYOR QUE 100!");
                    mensaje.ShowDialog();
                    //MessageBox.Show("LA NOTA REGISTRADA NO PUEDE SER MAYOR QUE 100");
                    bandera = false;
                }
            }
            return bandera;
        }

        void llenarDiscapacidad()
        {
            tbl_Discapacidad = prematricula.Mostrar_Discapacidad();
            foreach (DataRow row in tbl_Discapacidad.Rows)
            {
                cbDiscapacidad.Items.Add(Convert.ToString(row["Nombre"]).ToUpper());
            }
            // Establecer el modo de autocompletado
            cbDiscapacidad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDiscapacidad.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenarAccesoInternet()
        {
            DataTable dtProveedor = new DataTable();
            cbAccesoInternet.Items.Add("SI");
            cbAccesoInternet.Items.Add("NO");
            dtProveedor = prematricula.Mostrar_Proveedor_Internet();
            foreach (DataRow row in dtProveedor.Rows)
            {
                cbProveedor.Items.Add(Convert.ToString(row["ProveedorIntenet"]).ToUpper());
            }
            // Establecer el modo de autocompletado
            cbAccesoInternet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAccesoInternet.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_mano()
        {
            cbMano.Items.Add("DIESTRO");
            cbMano.Items.Add("ZURDO");

            cbTipoConexion.Items.Add("INTERNET MOVIL");
            cbTipoConexion.Items.Add("INTERNET RESINDENCIAL");

            // Establecer el modo de autocompletado
            cbMano.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMano.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Establecer el modo de autocompletado
            cbTipoConexion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipoConexion.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_Departamento()
        {

            tbl_Departamento.Clear();
            tbl_Departamento = prematricula.Mostrar_Departamento();
            foreach (DataRow row in tbl_Departamento.Rows)
            {
                cbDepartamento.Items.Add(Convert.ToString(row["Nombre"]));
            }


            // Establecer el modo de autocompletado
            cbDepartamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepartamento.AutoCompleteSource = AutoCompleteSource.ListItems;

            tbl_Departamento02.Clear();
            tbl_Departamento02 = prematricula.Mostrar_Departamento();
            foreach (DataRow row in tbl_Departamento02.Rows)
            {
                cbDepartamento02.Items.Add(Convert.ToString(row["Nombre"]));
            }

            // Establecer el modo de autocompletado
            cbDepartamento02.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepartamento02.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_Departamento02()
        {

            tbl_Departamento.Clear();
            tbl_Departamento = prematricula.Mostrar_Departamento();
            foreach (DataRow row in tbl_Departamento.Rows)
            {
                cbDepartamento02.Items.Add(Convert.ToString(row["Nombre"]));
            }
            // Establecer el modo de autocompletado
            cbDepartamento02.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepartamento02.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_Sexo()
        {
            Table.Clear();
            Table = prematricula.Mostrar_Sexo();
            foreach (DataRow row in Table.Rows)
            {
                cbSexo.Items.Add(Convert.ToString(row["Nombre"]));
            }
            // Establecer el modo de autocompletado
            cbSexo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSexo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_etnia()
        {
            Table.Clear();
            Table = prematricula.Mostrar_Etnia();
            foreach (DataRow row in Table.Rows)
            {
                cbEtnia.Items.Add(Convert.ToString(row["Nombre"]));
            }
            // Establecer el modo de autocompletado
            cbEtnia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEtnia.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_Estado_Civil()
        {
            Table.Clear();
            Table = prematricula.Mostrar_Estado_Civil();
            foreach (DataRow row in Table.Rows)
            {
                cbEstadoCivil.Items.Add(Convert.ToString(row["Nombre"]));
            }
            // Establecer el modo de autocompletado
            cbEstadoCivil.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbEstadoCivil.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenar_anio() 
        {
            List<int> numeros = new List<int>();

            for (int i = 1980; i <= 2024; i++)
            {
                numeros.Add(i);
            }

            // Invertir el orden de la lista
            numeros.Reverse();

            // Convertir los números a objetos y agregarlos al ComboBox
            foreach (int numero in numeros)
            {
                cbAnioFin.Items.Add(numero);
            }

            // Establecer el modo de autocompletado
            cbAnioFin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAnioFin.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void llenarTipoBachillerato()
        {
            tbl_Discapacidad = prematricula.Mostrar_Tipo_Bachillerato();
            foreach (DataRow row in tbl_Discapacidad.Rows)
            {
                cbTipoBachillerato.Items.Add(Convert.ToString(row["tipo"]).ToUpper());
            }
            // Establecer el modo de autocompletado
            cbTipoBachillerato.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbTipoBachillerato.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        // validando todos los campos //
        public bool ValidarCamposTab01()
        {
            bool bandera = true;

            // Llamadas a las funciones para validar cada campo
            if (false == ValidarCampo(txtCedula, epCedula, "INGRESE CÉDULA, ¡ES UN CAMPO OBLIGATORIO!"))
                {
                    bandera = false;
                }
            if (false == ValidarCampo(txtPrimerNombre, epCedula, "INGRESE PRIMER NOMBRE, ¡ES UN CAMPO OBLIGATORIO!"))
                {
                    bandera = false;
                }
            if (false == ValidarCampo(txtPrimerApellido, epPrimerApellido, "INGRESE PRIMER APELLIDO, ¡ES UN CAMPO OBLIGATORIO!"))
                {   
                    bandera = false; 
                }
            if (false == ValidarComboBox(cbEtnia, epEtnia, "SELECCIONE ETNIA, ¡ES UN CAMPO OBLIGATORIO!"))
                {
                    bandera = false;
                }
            if (false == ValidarComboBox(cbSexo, epSexo, "SELECCIONE SEXO, ¡ES UN CAMPO OBLIGATORIO!"))
                { 
                    bandera = true; 
                }
            if (false == ValidarComboBox(cbDepartamento, epDepartamento, "SELECCIONE DEPARTAMENTO, ¡ES UN CAMPO OBLIGATORIO!"))
            { bandera = false; }
           if ( false == ValidarComboBox(cbMunicipio, epMunicipio, "SELECCIONE MUNICIPIO, ¡ES UN CAMPO OBLIGATORIO!"))
            { bandera = false; }
            if (false == ValidarCampo(txtDireccion, epDireccion, "INGRESE DIRECCION, ¡ES UN CAMPO OBLIGATORIO!")) 
            { bandera = false; }
           if( false == ValidarCampo(txtBarrio, epBarrio, "INGRESE BARRIO O COMARCA, ¡ES UN CAMPO OBLIGATORIO!"))
            { bandera = false; }
           if (false == ValidarComboBox(cbAccesoInternet, epAccesoInternet, "SELECCIONE OPCION, ¡ES UN CAMPO OBLIGATORIO!"))
            { bandera = false; }
            if (false == ValidarComboBox(cbMano, epZurdoDiestro, "SELECCIONE OPCION, ¡ES UN CAMPO OBLIGATORIO!")) 
            { bandera = false; }
            if (false == ValidarComboBox(cbDiscapacidad, epDiscapacidad, "SELECCIONE DISCAPACIDAD, ¡ES UN CAMPO OBLIGATORIO!")) 
            { bandera = false; }

            if (false == ValidarComboBox(cbEstadoCivil, epEstadoCivil, "SELECCIONE ESTADO CIVIL, ¡ES UN CAMPO OBLIGATORIO!")) 
            { bandera = false; }

            return bandera;
        }

        bool ValidarCampo(TextBoxBase control, ErrorProvider errorProvider, string mensajeError)
        {
            bool bandera = true;
            if (control.Text == string.Empty)
            {
                errorProvider.SetError(control, mensajeError);
                bandera = false;
            }
            else
            {
                errorProvider.Clear();
                bandera = true;
            }
            return bandera;
        }

        bool ValidarComboBox(ComboBox control, ErrorProvider errorProvider, string mensajeError)
        {
            bool bandera = true;
            if (control.SelectedIndex == -1)
            {
                errorProvider.SetError(control, mensajeError);
                bandera = false;
            }
            else
            {
                errorProvider.Clear();
            }
            return bandera;
        }


        //Funcion para validar eñ segundo TAB
        void valida_segundo_tab(bool bandera)
        { 
            cbTipoBachillerato.Enabled = bandera;
            cbDepartamento02.Enabled = bandera;
            cbAnioFin.Enabled = bandera;
            cbMunicipio02.Enabled = bandera;
            cbCentroEstudios.Enabled = bandera;
            txtMat4.Enabled = bandera;
            txtMat5.Enabled = bandera;
            txtLL4.Enabled = bandera;
            txtLL5.Enabled = bandera;
            txtGeo4.Enabled = bandera;
            txtHistoria5.Enabled = bandera;
            txtFis4.Enabled = bandera;
            txtFisica5.Enabled = bandera;
            txtQuimi4.Enabled = bandera;
            txtQuimi5.Enabled = bandera;
            btnLimpiar.Enabled = bandera;
            btnValidar02.Enabled = bandera;
            Frm_Mensaje_Advertencia mensaje = new Frm_Mensaje_Advertencia("la opción de datos educativos se ha habilitado");
            mensaje.ShowDialog();

        }

        private void btnValidar02_Click(object sender, EventArgs e)
        {
          
        }

        void Calcular_Promedio() 
        {
            double mat04, mat05, lengua04, lengua05,geografia04,historia05,fisica04,fisica05,quimica04,quimica05,prom4,prom5,promt;
            mat04 = Convert.ToDouble(txtMat4.Text);
            mat05 = Convert.ToDouble(txtMat5.Text);
            lengua04 = Convert.ToDouble(txtLL4.Text);
            lengua05 = Convert.ToDouble(txtLL5.Text);
            geografia04 = Convert.ToDouble(txtGeo4.Text);
            historia05 = Convert.ToDouble(txtHistoria5.Text);
            fisica04 = Convert.ToDouble(txtFis4.Text);
            fisica05 = Convert.ToDouble(txtFisica5.Text);
            quimica04 = Convert.ToDouble(txtQuimi4.Text);
            quimica05 = Convert.ToDouble(txtQuimi5.Text);
            prom4 = (mat04 + lengua04 + geografia04 + fisica04 + quimica04) / 5 ;
            prom5 = (mat05 + lengua05 + historia05 + fisica05 + quimica05) / 5;
            promt = (prom4 + prom5) / 2;
            txtProm4.Text = Convert.ToString(prom4);
            txtProm5.Text = Convert.ToString(prom5);
            txtPromG.Text = Convert.ToString(promt);
        }

        private void cbDepartamento02_SelectedValueChanged(object sender, EventArgs e)
        {
            //se utiliza este evento para encontrar el departemanto seleccionado y asi obtener los municipios de dicho departamento
            string departamento;
            departamento = cbDepartamento02.Text;
            cbMunicipio02.Items.Clear();
            cbMunicipio02.Text = "";

            foreach (DataRow row in tbl_Departamento02.Rows)
            {
                if (Convert.ToString(row["Nombre"]) == departamento)
                {
                    tbl_Municipio02 = prematricula.Mostrar_Municipio(Convert.ToInt32(row["id"]));
                }
            }

            cbMunicipio.Items.Clear();
            foreach (DataRow row in tbl_Municipio02.Rows)
            {
                cbMunicipio02.Items.Add(Convert.ToString(row["Nombre"]));
            }


            cbMunicipio02.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbMunicipio02.AutoCompleteSource = AutoCompleteSource.ListItems;
            //llenar el cb de Municipio
        }

        private void cbMunicipio02_SelectedValueChanged(object sender, EventArgs e)
        {
            string municipio;
            municipio = cbMunicipio02.Text;
            cbCentroEstudios.Text = "";
            cbCentroEstudios.Items.Clear();
            

            foreach (DataRow row in tbl_Municipio02.Rows)
            {
                if (Convert.ToString(row["Nombre"]) == municipio)
                {
                    tbl_Centro_Estudios = prematricula.Mostrar_Centro_Estudios(Convert.ToInt32(row["Id"]));
                }
            }

            cbCentroEstudios.Items.Clear();
            foreach (DataRow row in tbl_Centro_Estudios.Rows)
            {
                cbCentroEstudios.Items.Add(Convert.ToString(row["Nombre"]));
            }
            //llenar el cb de Municipio
        }

        private void cbDepartamento_TextChanged(object sender, EventArgs e)
        {
            cbDepartamento.Text = cbDepartamento.Text.ToUpper();
            // Mover el cursor al final del texto
            cbDepartamento.SelectionStart = cbDepartamento.Text.Length;
        }

        private void cbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        



        //==================================FUNCIONES================================== ---->  FIN
    }
}
