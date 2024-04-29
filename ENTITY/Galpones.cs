using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    internal class Galpones
    {
        public string ID_Galpon {  get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public string Ubicación { get; set; }
        public DateTime FechaCreacion { get; set;}

        public Galpones() { }
        public Galpones(string iD_Galpon, int capacidad, string estado, string ubicación, DateTime fechaCreacion)
        {
            ID_Galpon = iD_Galpon;
            Capacidad = capacidad;
            Estado = estado;
            Ubicación = ubicación;
            FechaCreacion = fechaCreacion;
        }
    }
}
