using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_V2.Models.Metodos_diseño
{
    class Metodos_diseño
    {
        // METODO PARA LLENAR UN PANEL CON UN FORMULARIO HIJO
        public void Llenar_panel(Panel Panel_Receptor, object Formulario_Hijo)
        {
            if (Panel_Receptor.Controls.Count >= 0)
            {
                Panel_Receptor.Controls.Clear();
                Form fh = Formulario_Hijo as Form;

                if (fh.Visible == true)
                {
                    fh.BringToFront();
                }
                else
                {
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    Panel_Receptor.Controls.Add(fh);
                    Panel_Receptor.Tag = fh;
                    fh.Show();
                }
            }
        }
    }
}
