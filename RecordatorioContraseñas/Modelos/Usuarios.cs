using System;
using System.Collections.Generic;

namespace RecordatorioContraseñas.Modelos
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Cuentas = new HashSet<Cuentas>();
        }

        public byte Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool? Activo { get; set; }

        public virtual ICollection<Cuentas> Cuentas { get; set; }
    }
}
