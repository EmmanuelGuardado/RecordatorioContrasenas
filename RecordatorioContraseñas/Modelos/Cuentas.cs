using System;
using System.Collections.Generic;

namespace RecordatorioContraseñas.Modelos
{
    public partial class Cuentas
    {
        public byte Id { get; set; }
<<<<<<< HEAD
        public string Nombre { get; set; }
=======
>>>>>>> 0f6e00568be5effe1d556f5196c0d9b6ffaacd02
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaModificacion { get; set; }
        public byte UsuarioId { get; set; }

        public virtual Usuarios UsuarioNavigation { get; set; }
    }
}
