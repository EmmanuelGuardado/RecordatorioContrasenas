using System;
using System.Collections.Generic;

namespace RecordatorioContraseñas.Modelos
{
    public partial class Cuentas
    {
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaModificacion { get; set; }
        public byte UsuarioId { get; set; }

        public virtual Usuarios UsuarioNavigation { get; set; }
    }
}
