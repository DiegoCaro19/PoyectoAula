using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    internal class Empresa
    {
        public string ID_Empre {  get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Empresa() { }

        public Empresa(string iD_Empre, string nombre, string telefono, string direccion)
        {
            ID_Empre = iD_Empre;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
