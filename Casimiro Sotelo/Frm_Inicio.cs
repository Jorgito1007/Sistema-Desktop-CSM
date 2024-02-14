using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;
using System.Threading;
using Capa_Negocio;

namespace Ginmasio
{
    public partial class Frm_Inicio : Form
    {
        public static string n, a,Cedula_Empleado;
        Frm_Login ventana_login = new Frm_Login();
        campus CargaRegistroMatricula = new campus();

        //DataTable llenar()
        //{
        //    DataTable Contar = new DataTable();
        //    Contar = CargaRegistroMatricula.Mostrar_Registro();
        //    //txtCantidad.Text = Convert.ToString(Contar.Rows.Count);
        //    return Contar;
        //}


        public Frm_Inicio(string cedula,string nombre, string apellido)
        {
            InitializeComponent();
            Cedula_Empleado = cedula;
            n = nombre;
            a = apellido;
            mostrar_usuario_activo();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            abrirFormHijo(new Frm_LogoReloj());
        }


        /*Metodos*/
        public void mostrar_usuario_activo() //Metodo para mostrar el nombre del usuario activo en le panel superior
         {
           
             LbUsuario.Text = n.ToUpper() + " " + a;
         }


        //public void desplazar_menu_productos()
        //{
        //    if (band_producto == true)
        //    {
        //        //Panel_Producto.Visible = true;
        //        //btnCompras.Location = new Point(3, (270 + 110));
        //        //panel_compra.Location = new Point(0, (270 + 110));

        //        //btnEmpleados.Location = new Point(3, (305 + 110));
        //        //panel_empelados.Location = new Point(0, (305 + 110));

        //        //btnProovedores.Location = new Point(3, (340 + 110));
        //        //panel_proovedores.Location = new Point(0, (340 + 110));

        //        //btnReportes.Location = new Point(3, (375 + 110));
        //        //panel_reportes.Location = new Point(0, (375 + 110));

        //        //btnServicios.Location = new Point(3, (409 + 110));
        //        //Panel_Ser_Admin.Location = new Point(0, (409 + 110));

        //        band_producto = false;
        //    }
        //    else
        //    {
        //        //Panel_Producto.Visible = false;
        //        //btnCompras.Location = new Point(3, 270);
        //        //panel_compra.Location = new Point(0, 270);

        //        //btnEmpleados.Location = new Point(3, 305);
        //        //panel_empelados.Location = new Point(0, 305);

        //        //btnProovedores.Location = new Point(3, 340);
        //        //panel_proovedores.Location = new Point(0, 340);

        //        //btnReportes.Location = new Point(3, 375);
        //        //panel_reportes.Location = new Point(0, 375);

        //        //btnServicios.Location = new Point(3, 409);
        //        //Panel_Ser_Admin.Location = new Point(0, 409);

        //        band_producto = true;
        //    }
        //}
        //public void contraer_menu_productos()
        //{
        //    if (band_producto == false)
        //    {
        //        //Panel_Producto.Visible = false;
        //        //btnCompras.Location = new Point(3, 270);
        //        //panel_compra.Location = new Point(0, 270);

        //        //btnEmpleados.Location = new Point(3, 305);
        //        //panel_empelados.Location = new Point(0, 305);

        //        //btnProovedores.Location = new Point(3, 340);
        //        //panel_proovedores.Location = new Point(0, 340);

        //        //btnReportes.Location = new Point(3, 375);
        //        //panel_reportes.Location = new Point(0, 375);

        //        //btnServicios.Location = new Point(3, 409);
        //        //Panel_Ser_Admin.Location = new Point(0, 409);

        //        band_producto = true;
        //    }
        //    //Panel_Producto.Visible = false;
        //}

        private void abrirFormHijo(object frmhijo) //Metodo para cargar los formularios hijos dentro del panel contenedor
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = frmhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        /*FIN METODOS*/


        //-----------BOTONES DE MINIMIZAR, MAXIMIZAR Y CERRAR---------------//
        private void btn_Minimizar_Todo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_maximizar_todo_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar_todo.Visible = false;
            btn_normalizar_todo.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;
            btn_maximizar_todo.Visible = true;

            btn_normalizar_todo.Visible = false;
        }


        private void bnt_Cerrar_todo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTA SEGURO QUE DESEA SALIR", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (System.Windows.Forms.DialogResult.Yes))
            {
                Environment.Exit(0);
            }
        }
        //-----------BOTONES DE MINIMIZAR, MAXIMIZAR Y CERRAR-------FIN--------//




        ///--------------------OPCIONES DE MENU-------------///
        //private void button2_Click(object sender, EventArgs e) ///Menu Facturacion
        //{
        //    contraer_menu_productos();
        //    //abrirFormHijo(new Frm_Facturacion());
        //}
        //private void button1_Click(object sender, EventArgs e)//Menu Clientes
        //{
        //    // sonido_boton();
        //    contraer_menu_productos();
        //    abrirFormHijo(new Frm_Registro());
        //}
     
     
     

      
       



        /// <summary>
        /// / CODIGO PARA PODER MOVER EL FORMULARIO PRINCIPAL EN LA PANTALLA
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Panel_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        /// <summary>
        /// METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        /// </summary>
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void LbUsuario_Click(object sender, EventArgs e)
        {

        }

        //private void bntAsistencia_Click(object sender, EventArgs e)
        //{
        //    abrirFormHijo(new Frm_Cliente());
        //}

        private void btnClientes_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            pgrCarga.Visible = true;
            lbCarga.Visible = true;

            // Deshabilita el botón de inicio mientras se ejecuta la tarea
            bntAsistencia.Enabled = false;
            btnClientes.Enabled = false;
            this.Enabled = false;

            // Configura la barra de progreso
            pgrCarga.Minimum = 0;
            pgrCarga.Maximum = 200;
            pgrCarga.Value = 0;
            //tabla = llenar();
            // Inicia la tarea en un hilo separado para no bloquear la interfaz de usuario
            Thread tareaThread = new Thread(new ThreadStart(RealizarTarea));
            tareaThread.Start();
            
            void RealizarTarea()
            {
  
                for (int i = 0; i <= 200; i++)
                {
                    // Actualiza la barra de progreso desde el hilo de la interfaz de usuario
                    this.Invoke((MethodInvoker)delegate
                    {
                        pgrCarga.Value = i;
                    });
                    // Simula una pausa en la tarea
                    Thread.Sleep(50);
                }
                // Habilita el botón después de que la tarea haya terminado
                this.Invoke((MethodInvoker)delegate
                {
                    abrirFormHijo(new Frm_Registro(tabla));
                    //btnCargar.Enabled = true;
                    //progressBar1.Visible = false;
                    pgrCarga.Visible = false;
                    lbCarga.Visible = false;
                    bntAsistencia.Enabled = true;
                    btnClientes.Enabled = true;
                    this.Enabled = true;

                });
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width == 170)
            {
                Panel_Menu.Width -= 130;
            }
            else
            {
                Panel_Menu.Width += 130;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Docente());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_Calificaciones());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Frm_GrupDoc());
        }

        private void bntAsistencia_Click(object sender, EventArgs e)
        {
            //abrirFormHijo(new Frm_Cliente());
            abrirFormHijo(new Matricula());

        }







        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.Panel_superior.Region = region;
            this.Invalidate();
        }

        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }











    }
}
