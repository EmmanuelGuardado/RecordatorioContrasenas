﻿using RecordatorioContraseñas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordatorioContraseñas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (RecordatorioContrasenaContext db = new Modelos.RecordatorioContrasenaContext())
            {
                var lstusuario = from u in db.Usuarios
                              where u.Usuario == txtUsuario.Text && u.Contrasena == txtContrasena.Text
                              select u;

                if (lstusuario.Count() > 0)
                {
                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos","E R R O R",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            } 
        }
    }
}
