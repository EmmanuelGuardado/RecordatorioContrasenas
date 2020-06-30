using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecordatorioContraseñas.Modelos;

namespace RecordatorioContraseñas.Vistas
{
    public partial class Principal : Form
    {
        private Usuarios miUsuarioLogeado = new Usuarios();
        public Principal(Usuarios u)
        {
            InitializeComponent();
            miUsuarioLogeado = u;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.VisualizarDatos();
        }
        private byte ObtenerIDUsuarioLogeado()
        {
            using(RecordatorioContrasenaContext db = new RecordatorioContrasenaContext())
            {
                IEnumerable<byte> usuarioID = from usuID in db.Usuarios
                                              where usuID.Id.Equals(miUsuarioLogeado.Id)
                                              select usuID.Id;
                return usuarioID.FirstOrDefault();
            }
        }

        private void VisualizarDatos()
        {
            using (RecordatorioContrasenaContext db = new RecordatorioContrasenaContext())
            {
                var cuenta = (from c in db.Cuentas
                              where c.UsuarioId == this.ObtenerIDUsuarioLogeado()
                              select new { c.Nombre, c.Usuario, c.Contrasena }).ToList();    

                dgvDatos.DataSource = cuenta;
            }
        }
    }
}
