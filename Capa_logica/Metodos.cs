using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_logica
{
    public class Metodos
    {
        // METODO PARA ABRIR UN FORMULARIO EXTERNO EN UN PANEL
        public void Llenar_panel(Panel Panel_contenido, object Formulario_a_enviar)
        {
            if (Panel_contenido.Controls.Count >= 0)
            {
                Panel_contenido.Controls.Clear();
                Form Formulario = Formulario_a_enviar as Form;

                if (Formulario.Visible == true)
                {
                    Formulario.BringToFront();
                }
                else
                {
                    Formulario.TopLevel = false;
                    Formulario.Dock = DockStyle.Fill;
                    Panel_contenido.Controls.Add(Formulario);
                    Panel_contenido.Tag = Formulario;
                    Formulario.Show();
                }
            }
        }
    }
}
