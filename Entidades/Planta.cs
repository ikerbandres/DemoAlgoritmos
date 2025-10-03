using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAlgoritmos.Entidades
{
    public class Planta
    {
        public string IdPlanta { get; set; }
        public int IdLote { get; set; }

        public Planta(Planta planta)
        {
            IdPlanta = planta.IdPlanta;
            IdLote = planta.IdLote;
        }
    }
}
