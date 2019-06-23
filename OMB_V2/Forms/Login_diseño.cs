using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_V2.Forms
{
    public partial class Login_diseño : Form
    {
        public Login_diseño()
        {
            InitializeComponent();
        }
        // VARIABLES PRIVADAS
        private bool Presion_1 = false;
        // METODOS VALIDACION BOTON
        public bool Presionado_btn_1(bool Presionado_in)
        {
            if (Presionado_in == false)
            {
                Btn_sound.Image = Properties.Resources.no_audio;
            }
            else
            {
                Btn_sound.Image = Properties.Resources.audio;
            }
            Presion_1 = true;
            return Presionado_in = true;
        }
        public bool Presionado_btn_2(bool Presionado_out)
        {
            if (Presionado_out == true)
            {
                Btn_sound.Image = Properties.Resources.audio;
            }
            else
            {
                Btn_sound.Image = Properties.Resources.no_audio;
            }
            Presion_1 = false;
            return Presionado_out = false;
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del aplicativo?","SALIENDO",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_sound_Click(object sender, EventArgs e)
        {
            if (Presion_1 == false)
            {
                Presionado_btn_1(Presion_1);
            }
            else if (Presion_1 == true)
            {
                Presionado_btn_2(Presion_1);
            }
        }
    }
}
