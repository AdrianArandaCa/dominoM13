using Projecte_Domino.Vista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecte_Domino.Controller
{
    internal class ControllerPrincipal
    {
        Form1 f;

        public ControllerPrincipal()
        {
            f = new Form1();

            //  initListeners();
            prova();
            Application.Run(f);
           
        }

        public void prova()
        {
            //f.labelPrueba.Text
            byte[] bytesUtf16 = Encoding.Unicode.GetBytes("\U0001F037");
            int ultimByte = 2;
            List<Fitxa> fitxes = new List<Fitxa>();
            string text;
            Fitxa fitxa;
            for (int columna = 0; columna <= 7; columna++)
            {
                for (int fila = 0; fila <= 7; fila++)
                {
                    if (columna >= fila)
                    {
                        fitxa = new Fitxa(fila, columna);
                        fitxes.Add(fitxa);
                    }
                }
            }
. 

            text = Encoding.Unicode.GetString(bytesUtf16);
            fitxes.Add(text);
            bytesUtf16[ultimByte]++;
            f.labelPrueba.Text = text;
        }
        // string convertedUtf16 = Encoding.Unicode.GetString(bytesUtf16);
        //  f.labelPrueba.Text = convertedUtf16;
    }
       



    }
}
