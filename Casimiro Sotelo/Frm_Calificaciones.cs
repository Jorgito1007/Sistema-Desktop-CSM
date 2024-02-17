using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ginmasio
{
    public partial class Frm_Calificaciones : Form
    {
        
        CRUD_Docente_Asignatura buscar_docente_Asig = new CRUD_Docente_Asignatura();
        CRUD_Docente_Asignatura Buscar_Lista_Alumnos = new CRUD_Docente_Asignatura();
        CRUD_Docente_Asignatura Actualizar_Notas_Alumnos = new CRUD_Docente_Asignatura();
        campus buscar = new campus();
        Mensaje_Suscripcion mensaje = new Mensaje_Suscripcion();
        Frm_Alerta mensaje_02 = new Frm_Alerta();
        public static string @GOVERNMENT_ID, @FIRTSNAME, @MIDDLE_NAME, @LAST_NAME, @LAST_NAME02;

       

        public static string @AREA_CONOCIMIENTO, @CARRERA, @TURNO, @ASIGNATURA,@COD_ASIG, @GRUPO;

        

        public Frm_Calificaciones()
        {
            InitializeComponent();
            dataGridLista.DataBindingComplete += dataGridLista_DataBindingComplete;
        }

  

        private void btnmostrarlista_Click(object sender, EventArgs e)
        {
            btnnotas.Enabled=true;
            btnmostrarlista.Enabled = false;
            string grupo = txtgrupo.Text;
            string cod_asig = txtcodasig.Text;

            // Llamar al método de búsqueda
            DataTable resultadoBusqueda = Buscar_Lista_Alumnos.Busqueda_Lista_Alumnos(grupo, cod_asig);

            // Mostrar los datos en el DataGridView
            dataGridLista.DataSource = resultadoBusqueda;
           


        }

        private void dataGridLista_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                textBox.KeyPress -= TextBox_KeyPress; // Asegúrate de eliminar el controlador existente
                textBox.KeyPress += TextBox_KeyPress; // Agrega el nuevo controlador
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }
        }

        private void dataGridLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Desvincular el evento temporalmente para evitar recursión infinita
            dataGridLista.DataBindingComplete -= dataGridLista_DataBindingComplete;
            dataGridLista.EditingControlShowing -= dataGridLista_EditingControlShowing;

            // Hacer la columna "NOTA_FINAL" editable
            if (dataGridLista.Columns.Contains("ACUMULADO") || dataGridLista.Columns.Contains("PARCIAL"))
            {
                dataGridLista.Columns["ACUMULADO"].ReadOnly = false;
                dataGridLista.Columns["PARCIAL"].ReadOnly = false;
            }

            // Hacer las demás columnas no editables
            foreach (DataGridViewColumn column in dataGridLista.Columns)
            {
                if (column.Name != "ACUMULADO" && column.Name != "PARCIAL" && column.Name != "NOTA_FINAL")
                {
                    column.ReadOnly = true;
                }
            }

            // Calcular la suma de las columnas "ACUMULADO" y "PARCIAL" y colocar el resultado en "NOTA_FINAL"
            foreach (DataGridViewRow row in dataGridLista.Rows)
            {
                object acumuladoValue = row.Cells["ACUMULADO"].Value;
                object parcialValue = row.Cells["PARCIAL"].Value;

                // Verificar que los valores no sean nulos
                if (acumuladoValue != null && parcialValue != null)
                {
                    // Intentar convertir los valores a enteros
                    if (int.TryParse(acumuladoValue.ToString(), out int acumulado) &&
                        int.TryParse(parcialValue.ToString(), out int parcial))
                    {
                        // Sumar los valores de "ACUMULADO" y "PARCIAL"
                        int notaFinal = acumulado + parcial;

                        // Colocar el resultado en la columna "NOTA_FINAL"
                        row.Cells["NOTA_FINAL"].Value = notaFinal;
                    }
                    else
                    {
                        // Manejar el caso en que las conversiones no sean exitosas
                        // Puedes mostrar un mensaje de error o tomar otra acción según tus necesidades.
                    }
                }
            }

            // Volver a vincular el evento después de realizar las actualizaciones
            dataGridLista.DataBindingComplete += dataGridLista_DataBindingComplete;
            dataGridLista.EditingControlShowing += dataGridLista_EditingControlShowing;
        }




        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llamar a tu función aquí
                busqueda_insecto();
             
                // Indicar que se ha manejado la tecla para evitar su procesamiento adicional
                e.Handled = true;
            }
        }

       /*Busqueda del docente y su asignatura */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda_insecto();
          
          
        }

        void busqueda_insecto()
        {
            DataTable Tabla_Doc_Asi = new DataTable();

            if (txtcedula.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR UN VALOR PARA INICAR BUSQUEDA");
            }
            else
            {

                Tabla_Doc_Asi = buscar_docente_Asig.Busqueda_Docentes_Asignatura(txtcedula.Text,1);
                if (Tabla_Doc_Asi.Rows.Count == 0)
                {
                    MessageBox.Show("NO SE ENCONTRARON REGISTROS");
                    txtcedula.Clear();
                }
                else
                {
                    Obtener_valores();
                }

            }

            void Obtener_valores()
            {
                foreach (DataRow row in Tabla_Doc_Asi.Rows)
                {
                    txtdocente.Text = Convert.ToString(row["NOMBRE_DOCENTE"]);
                    txtareaconocimiento.Text = Convert.ToString(row["AREA_CONOCIMIENTO"]);
                    txtcarrera.Text = Convert.ToString(row["CARRERA"]);
                    txtgrupo.Text = Convert.ToString(row["GRUPO"]);
                    txtturno.Text = Convert.ToString(row["TURNO"]);
                    txtcodasig.Text = Convert.ToString(row["COD_ASIG"]);
                    txtasignatura.Text = Convert.ToString(row["ASIGNATURA"]);
                    btnmostrarlista.Enabled = true;
                }
            }

            
        }
        /* Ingresando Notas*/
        private void btnnotas_Click(object sender, EventArgs e)
        {
            GuardarNotas();
            }

        private void GuardarNotas()
        {
            // Verificar si hay filas en el DataGridView
            if (dataGridLista.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridLista.Rows)
                {
                    // Verificar si la fila no está vacía
                    if (!row.IsNewRow)
                    {
                        // Verificar si la celda de la nota final está vacía
                        if (row.Cells["NOTA_FINAL"].Value == null || string.IsNullOrWhiteSpace(row.Cells["NOTA_FINAL"].Value.ToString()))
                        {
                            MessageBox.Show("Error: Hay filas con notas vacías. Por favor, llene todas las notas antes de guardar.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                // Si todas las notas están llenas, procede a guardar
                foreach (DataGridViewRow row in dataGridLista.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Obtener los valores de las celdas
                        string people_id = row.Cells["PEOPLE_ID"].Value.ToString();
                        string cod_asig = row.Cells["CODIGO_ASIGNATURA"].Value.ToString();
                        string nota_final = row.Cells["NOTA_FINAL"].Value.ToString();

                        // Llamar al método para actualizar las notas
                        Actualizar_Notas_Alumnos.Actualiza_Notas_Alumnos(people_id, cod_asig, nota_final);
                    }
                }

                MessageBox.Show("Notas guardadas correctamente.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay filas para guardar.", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}