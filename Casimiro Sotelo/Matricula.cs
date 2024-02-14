using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Ginmasio
{
    public partial class Matricula : Form
    {
        CRUD_Cliente prematricula = new CRUD_Cliente();
        DataTable tbl_Departamento = new DataTable(); //DataTable para almacenar los departamentos
        DataTable tbl_Municipio = new DataTable();  //DataTable para almacenar los municipios en base al ID de cada Departamento
        DataTable Table = new DataTable();
        DataTable tbl_Discapacidad = new DataTable();
        public Matricula()
        {
            InitializeComponent();
            llenar_etnia();
            llenar_Estado_Civil();
            llenar_Sexo();
            llenar_Departamento();
            llenar_mano();
            llenarAccesoInternet();
            llenarDiscapacidad();
        }






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
                MessageBox.Show("DEBE INGRESAR UNA NOTA!");
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
                    MessageBox.Show("LA NOTA REGISTRADA NO PUEDE SER MAYOR QUE 100");
                    bandera = false;
                }
            }
            return bandera;
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
            if (Valida_Nota(txtFis4.Text) == false)
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
        }

 


        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            //se utiliza este evento para encontrar el departemanto seleccionado y asi obtener los municipios de dicho departamento
            string departamento;
            departamento = cbDepartamento.Text;

            foreach (DataRow row in tbl_Departamento.Rows)
            {
                if  (Convert.ToString(row["Nombre"]) == departamento)
                {
                    tbl_Municipio = prematricula.Mostrar_Municipio(Convert.ToInt32(row["id"]));
                }     
            }

            cbMunicipio.Items.Clear();
            foreach (DataRow row in tbl_Municipio.Rows)
            {
                cbMunicipio.Items.Add(Convert.ToString(row["Nombre"]));
            }
            //llenar el cb de Municipio

        }

        void llenarDiscapacidad()
        {
            tbl_Discapacidad = prematricula.Mostrar_Discapacidad();
            foreach (DataRow row in tbl_Discapacidad.Rows)
            {
                cbDiscapacidad.Items.Add(Convert.ToString(row["Nombre"]).ToUpper());
            }
        }

        void llenarAccesoInternet()
        {
            DataTable dtProveedor = new DataTable(); 
            cbAccesoInternet.Items.Add("SI");
            cbAccesoInternet.Items.Add("NO");
            dtProveedor = prematricula.Mostrar_Proveedor_Internet();
            foreach (DataRow row in dtProveedor.Rows)
            {
                cbProveedor.Items.Add( Convert.ToString(row["ProveedorIntenet"]).ToUpper());
            }

        }

        void llenar_mano()
        {
            cbMano.Items.Add("DIESTRO");
            cbMano.Items.Add("ZURDO");

            cbTipoConexion.Items.Add("INTERNET MOVIL");
            cbTipoConexion.Items.Add("INTERNET RESINDENCIAL");
          
        }
        void llenar_Departamento()
        {

            tbl_Departamento.Clear();
            tbl_Departamento = prematricula.Mostrar_Departamento();
            foreach (DataRow row in tbl_Departamento.Rows)
            {
                cbDepartamento.Items.Add(Convert.ToString(row["Nombre"]));
            }
        }
        void llenar_Sexo()
        {
            Table.Clear();
            Table = prematricula.Mostrar_Sexo();
            foreach (DataRow row in Table.Rows)
            {
                cbSexo.Items.Add(Convert.ToString(row["Nombre"]));
            }
        }

        void llenar_etnia()
        {
            Table.Clear();
            Table = prematricula.Mostrar_Etnia();
            foreach (DataRow row in Table.Rows)
            {
                cbEtnia.Items.Add(Convert.ToString(row["Nombre"]));
            }
        }

        void llenar_Estado_Civil()
        {
            Table.Clear();
            Table = prematricula.Mostrar_Estado_Civil();
            foreach (DataRow row in Table.Rows)
            {
                cbEstadoCivil.Items.Add(Convert.ToString(row["Nombre"]));
            }
        }

        private void cbAccesoInternet_SelectedValueChanged(object sender, EventArgs e)
        {
          if(  cbAccesoInternet.Text == "NO")
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
            if (txtCedula.Text == string.Empty)
            {
                epCedula.SetError(txtCedula, "INGRESE CÉDULA, ¡ES UN CAMPO OBLIGATORIO!");
            }
            else
            {
                epCedula.Clear();   
            }

            if(txtPrimerNombre.Text == string.Empty)
            {
                epCedula.SetError(txtPrimerNombre, "INGRESE PRIMER NOMBRE, ¡ES UN CAMPO OBLIGATORIO!");
            }
            else
            {
                epCedula.Clear();
            }

            if (txtPrimerApellido.Text == string.Empty)
            {
                epPrimerApellido.SetError(txtPrimerApellido, "INGRESE PRIMER APELLIDO, ¡ES UN CAMPO OBLIGATORIO!");
            }
            else {
                epPrimerApellido.Clear(); 
            }

            if (cbEtnia.SelectedIndex == -1)
            {
                epEtnia.SetError(cbEtnia, "SELECCIONE ETNIA, ¡ES UN CAMPO OBLIGATORIO!");
            }

            else
            {
                epEtnia.Clear();
            }

        }
    }
}
