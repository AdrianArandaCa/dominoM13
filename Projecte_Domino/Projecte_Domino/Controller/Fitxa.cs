using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecte_Domino.Controller
{
    class Fitxa
    {
        int fila { get; set;}
        int columna { get; set; }
        List<int> pos { get; set; }

        public Fitxa(int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
        }

        public Fitxa()
        {
        }
    }
}
