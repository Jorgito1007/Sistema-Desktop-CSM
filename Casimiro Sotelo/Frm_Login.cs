﻿using System;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            
        }
        public static string cedula,nombre, apellido;
        Login acceso = new Login();
        Frm_Inicio inicio;
        public static string usser,contra;
        public static int intentos=0;
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text== "Usuario")
            {
                txtUsuario.Clear();
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Clear();
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contraseña";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Llamar a tu función aquí
                bton_acceso();

                // Indicar que se ha manejado la tecla para evitar su procesamiento adicional
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bton_acceso();
            /*
        if (acceso.verficar_login(usser,contra).validacion==0)
        {
            MessageBox.Show("USUARIO NO ECONTRADO");
        }*/



        }

        void bton_acceso()
        {
            usser = txtUsuario.Text;
            contra = txtpass.Text;
            Bienvenida_Login mensaje;
            switch (acceso.verficar_login(usser, contra).validacion)
            {
                case 0:
                    // MessageBox.Show("USUARIO NO ECONTRADO");
                    if (intentos >= 3)
                    {
                        mensaje = new Bienvenida_Login(acceso.verficar_login(usser, contra).nombre, 1);
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        mensaje = new Bienvenida_Login(acceso.verficar_login(usser, contra).nombre, acceso.verficar_login(usser, contra).validacion);
                        mensaje.ShowDialog();
                    }
                    intentos++;
                    break;
                // case 1:

                // MessageBox.Show("BIENVENIDO " + acceso.verficar_login(usser, contra).nombre);
                // break;
                case 2:
                    if (intentos >= 3)
                    {
                        mensaje = new Bienvenida_Login(acceso.verficar_login(usser, contra).nombre, 1);
                        mensaje.ShowDialog();
                    }
                    else
                    {
                        mensaje = new Bienvenida_Login(acceso.verficar_login(usser, contra).nombre, acceso.verficar_login(usser, contra).validacion);
                        mensaje.ShowDialog();
                    }

                    intentos++;
                    // MessageBox.Show("CONTRASEÑA INCORRECTA");
                    break;
                case 3:
                    mensaje = new Bienvenida_Login(acceso.verficar_login(usser, contra).nombre, acceso.verficar_login(usser, contra).validacion);
                    cedula = acceso.verficar_login(usser, contra).cedula;
                    nombre = acceso.verficar_login(usser, contra).nombre;
                    apellido = acceso.verficar_login(usser, contra).apellido;
                    mensaje.ShowDialog();
                    inicio = new Frm_Inicio(cedula, nombre, apellido);
                    inicio.Show();
                    this.Hide();
                    break;

            }
        }
    }
}
