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
            byte[] bytesUtf16 = Encoding.Unicode.GetBytes("U+1F037");
            using (MemoryStream ms = new MemoryStream(bytesUtf16))
            {
                f.picture.Image = Image.FromStream(ms);
            }
            
           // string convertedUtf16 = Encoding.Unicode.GetString(bytesUtf16);
          //  f.labelPrueba.Text = convertedUtf16;
        }
       



    }
}
