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

            mostrarFitxes();
            Application.Run(f);

        }

        public void mostrarFitxes()
        {
            string[,] fitxes = generarFitxes();
            Label label = new Label();
            Font font = new Font(label.Font.FontFamily, 55);
            label.Size = new Size(1171, 675);
            label.Font = font;
            for (int i = 0; i < fitxes.GetLength(0); i++)
            {
                for (int j = 0; j < fitxes.GetLength(1); j++)
                {

                    label.Text += fitxes[i, j].ToString() + " ";
                    f.Controls.Add(label);
                }
                label.Text += "\n";
            }
        }

        public string[,] generarFitxes()
        {
            int pos = 2;
            byte[] bytesUtf16 = Encoding.Unicode.GetBytes("\U0001F031");
            string[,] dominoFitxes = new string[7, 7];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    dominoFitxes[i, j] = Encoding.Unicode.GetString(bytesUtf16).ToString();
                    bytesUtf16[pos]++;
                }
            }
            return dominoFitxes;
        }
    }
}
