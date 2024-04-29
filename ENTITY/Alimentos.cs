using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    internal class Alimentos
    {
        public string ID_Alimentos { get; set; }
        public string Marca { get; set; }
        public string Nombre_Ali {  get; set; }
        public int Precio { get; set; }
        public Alimentos() { }

        public Alimentos(string iD_Alimentos, string marca, string nombre_Ali, int precio)
        {
            ID_Alimentos = iD_Alimentos;
            Marca = marca;
            Nombre_Ali = nombre_Ali;
            Precio = precio;
        }
    }
}
