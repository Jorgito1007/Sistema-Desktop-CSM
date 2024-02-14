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
    public partial class Frm_Docente : Form
    {

     
        campus insertar = new campus();
        Mensaje_Suscripcion mensaje = new Mensaje_Suscripcion();
        Frm_Alerta mensaje_02 = new Frm_Alerta();
        //Variables Goblales********************************************
        public static string @GOVERMENT_ID,@PREFIX, @NAME01, @NAME02, @LASTNAME01, @LASTNAME02, @GENDER, @ADDRES_COMPLETE, @ADDRES_MAIL, @PHONE01, @P_DESCRIPTION01, @PHONE02, @P_DESCRIPTION02, @PHONE03, @P_DESCRIPTION03;

        private void Frm_Docente_Load(object sender, EventArgs e)
        {

        }

        public static int @ID_ETNIA, @ID_MARITAL_STATUS, @ID_REGLIGION, @ID_BIRTH_COUNTRY, @ID_COUNTRY_LIVE, @ID_DEPARTMENTO, @ID_MUNICIPIO, @PEOPLE_TYPE;
        public static DateTime @BIRTH_DATE;

        public static String genero = "";
        public Frm_Docente()
        {
            InitializeComponent();
            llenar_cbSexo();
            llenar_cbestadocivil();
            llenar_cbnivelacademico();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(cbnivelacademico.Text) ||
                string.IsNullOrWhiteSpace(txtPrimer_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrimerApellido.Text) ||
                string.IsNullOrWhiteSpace(cbSexo.Text) ||
                string.IsNullOrWhiteSpace(cbestadocivil.Text) ||
                string.IsNullOrWhiteSpace(cbnivelacademico.Text) ||
                DtpFecha_Nac.Value == null)
            {
                mensaje_02.ShowDialog();
                return false;
            }

            // Puedes agregar más condiciones de validación según tus necesidades.

            return true;
        }

       
        void guardar()
        {

          
            int salida = 0;
            @P_DESCRIPTION01 = "CLARO";
            @PHONE02 = txtTigo.Text;
            @P_DESCRIPTION02 = "TIGO";
            @PHONE03 = txtCovencional.Text;
            @P_DESCRIPTION03 = "CONVENCIONAL";
            @PHONE01 = txtClaro.Text;
            @ID_BIRTH_COUNTRY = 404;
            @ID_COUNTRY_LIVE = 404;
            @ID_REGLIGION = 1002;
            @GOVERMENT_ID = txtCedula.Text;
            @PREFIX = cbnivelacademico.Text;
            @NAME01 = txtPrimer_Nombre.Text;
            @NAME02 = txtSegundo_Nombre.Text;
            @LASTNAME01 = txtPrimerApellido.Text;
            @LASTNAME02 = txtSegundoApellido.Text;
            @ID_ETNIA = 1007;
            if (cbSexo.Text == "FEMENINO")
            {
                genero = "F";
            }else
            {
                genero = "M";
            }
            @GENDER = genero;
            @ADDRES_COMPLETE = txtDireccion.Text;
            @ADDRES_MAIL = txtMail.Text;
            @PEOPLE_TYPE = 16;
            @BIRTH_DATE = Convert.ToDateTime(DtpFecha_Nac.Text);
            salida =  insertar.Insertar_Estudiante(@GOVERMENT_ID, @PREFIX, @NAME01, @NAME02, @LASTNAME01, @LASTNAME02, @ID_ETNIA, @GENDER, @ID_MARITAL_STATUS, @ID_REGLIGION, @ADDRES_COMPLETE, @BIRTH_DATE, @ID_BIRTH_COUNTRY, @ID_COUNTRY_LIVE, @ID_DEPARTMENTO, @ID_MUNICIPIO, @ADDRES_MAIL, @PHONE01, @P_DESCRIPTION01, @PHONE02, @P_DESCRIPTION02, @PHONE03, @P_DESCRIPTION03, @PEOPLE_TYPE);
           
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

        public void llenar_cbSexo()
        {
            cbSexo.Text = "Sexo";
            //cbSexo.Items.Add("--------------");
            cbSexo.Items.Add("FEMENINO");
            cbSexo.Items.Add("MASCULINO");
        }

        public void llenar_cbestadocivil()
        {
            cbestadocivil.Text = "Estado Civil";
            //cbSexo.Items.Add("--------------");
            cbestadocivil.Items.Add("SOLTER@");
            cbestadocivil.Items.Add("CASAD@");
            cbestadocivil.Items.Add("VIUD@");
            cbestadocivil.Items.Add("DIVORCIAD@");
            cbestadocivil.Items.Add("UNIÒN LIBRE");
        }

        public void llenar_cbnivelacademico()
        {
            cbnivelacademico.Text = "Titulo";
            cbnivelacademico.Items.Add("Lic.");
            cbnivelacademico.Items.Add("Msc.");
            cbnivelacademico.Items.Add("Tec.");
            cbnivelacademico.Items.Add("Arq.");
            cbnivelacademico.Items.Add("Ing.");
        }


        public void limpiar_texbox()
        {
            txtCedula.Clear();
            txtPrimer_Nombre.Clear();
            txtSegundo_Nombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtDepartamento.Clear();
            txtmunicipio.Clear();
            txtDireccion.Clear();
            txtCovencional.Clear();
            txtClaro.Clear();
            txtTigo.Clear();
            txtMail.Clear();
           

            DtpFecha_Nac.Text = "";
            cbSexo.SelectedIndex = -1;
            cbestadocivil.SelectedIndex = -1;
            cbnivelacademico.SelectedIndex = -1;
        }


    }
}
