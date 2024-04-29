using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    internal class Usuario
    {
        public string Cedula {  get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get;  set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }

        public Usuario(){ }

        public Usuario(string cedula, string nombres, string apellido1, string apellido2, string telefono)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Telefono = telefono;
        }
    }
}
