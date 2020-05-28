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
        public void reset_txb_users(Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_tel,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_pass, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txb_resp,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_conf_p, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_conf_e,PictureBox OK_e, PictureBox OK_p, PictureBox Error_e, PictureBox Error_p) 
        {
            Txb_nombres.Text = "";
            Txb_tel.Text = "";
            txb_resp.Text = "";
            txb_pass.Text = "";
            Txb_email.Text = "";
            Txb_conf_p.Text = "";
            Txb_conf_e.Text = "";
            OK_e.Visible = false;
            OK_p.Visible = false;
            Error_e.Visible = false;
            Error_p.Visible = false;
        }
    }
}
