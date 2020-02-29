using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Usuarios_gestion : MaterialForm
    {
        public Usuarios_gestion()
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;
            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Grey900, Accent.LightBlue400, TextShade.WHITE);
        }

        private void Usuarios_gestion_Load(object sender, EventArgs e)
        {
            OK_pass.Visible = false;
            Ok_email.Visible = false;
            Error_Email.Visible = false;
            Error_pass.Visible = false;
        }

        private void Conf_email_txb_KeyUp(object sender, KeyEventArgs e)
        {
            if (Conf_email_txb.Text != Email_user_txb.Text)
            {
                if (Conf_email_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_Email);
                    Imagenes_slide.Hide(Ok_email);
                }
                else
                {
                    Imagenes_slide.Show(Error_Email);
                }
            }
            else
            {
                if (Conf_email_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_Email);
                    Imagenes_slide.Hide(Ok_email);
                }
                else
                {
                    Imagenes_slide.Hide(Error_Email);
                    Imagenes_slide.Show(Ok_email);
                }
            }
        }

        private void Conf_pass_txb_KeyUp(object sender, KeyEventArgs e)
        {
            if (Conf_pass_txb.Text != Pass_user_txb.Text)
            {
                if (Conf_pass_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_pass);
                    Imagenes_slide.Hide(OK_pass);
                }
                else
                {
                    Imagenes_slide.Show(Error_pass);
                }
            }
            else
            {
                if (Conf_pass_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_pass);
                    Imagenes_slide.Hide(OK_pass);
                }
                else
                {
                    Imagenes_slide.Hide(Error_pass);
                    Imagenes_slide.Show(OK_pass);
                }
            }
        }

        private void Pass_user_txb_KeyUp(object sender, KeyEventArgs e)
        {
            if (Conf_pass_txb.Text != Pass_user_txb.Text)
            {
                if (Conf_pass_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_pass);
                    Imagenes_slide.Hide(OK_pass);
                }
                else
                {
                    Imagenes_slide.Show(Error_pass);
                }
            }
            else
            {
                if (Conf_pass_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_pass);
                    Imagenes_slide.Hide(OK_pass);
                }
                else
                {
                    Imagenes_slide.Hide(Error_pass);
                    Imagenes_slide.Show(OK_pass);
                }
            }
        }

        private void Email_user_txb_KeyUp(object sender, KeyEventArgs e)
        {
            if (Conf_email_txb.Text != Email_user_txb.Text)
            {
                if (Conf_email_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_Email);
                    Imagenes_slide.Hide(Ok_email);
                }
                else
                {
                    Imagenes_slide.Show(Error_Email);
                }
            }
            else
            {
                if (Conf_email_txb.Text == "")
                {
                    Imagenes_slide.Hide(Error_Email);
                    Imagenes_slide.Hide(Ok_email);
                }
                else
                {
                    Imagenes_slide.Hide(Error_Email);
                    Imagenes_slide.Show(Ok_email);
                }
            }
        }
    }
}
