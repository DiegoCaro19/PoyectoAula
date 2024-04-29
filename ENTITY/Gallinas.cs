using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENTITY
{
    internal class Gallinas
    {
        public String ID { get; set; }
        public float Peso { get; set; }
        public String Estado { get; set; }
        public String Raza { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_salida { get; set; }
        public int Periodo_Engorde { get; set; }

        public Gallinas() { }

        public Gallinas(string iD, float peso, string estado, string raza, DateTime fecha_inicio, DateTime fecha_salida, int periodo_Engorde)
        {
            ID = iD;
            Peso = peso;
            Estado = estado;
            Raza = raza;
            Fecha_inicio = fecha_inicio;
            Fecha_salida = fecha_salida;
            Periodo_Engorde = periodo_Engorde;
        }
    }
}
