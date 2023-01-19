using Projecte_Domino.Vista;
using System;
using System.Collections.Generic;
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

            // initListeners();

            Application.Run(f);
        }

    }
}
