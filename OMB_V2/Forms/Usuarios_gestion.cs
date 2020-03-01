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
        // VARIABLE METODOS DB
        Models.Metodos_Login.Metodos_login Metodos_login = new Models.Metodos_Login.Metodos_login();
        Models.Metodos_diseño.Metodos_diseño Metodos_diseño = new Models.Metodos_diseño.Metodos_diseño();
        // VARIABLES 
        private int? Id_usuario;
        // METODOS GET
        private int? Get_Id_user() 
        {
            try
            {
                return int.Parse(Dtg_Listado_polizas.Rows[Dtg_Listado_polizas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                return null;
            }
        }
        private void Usuarios_gestion_Load(object sender, EventArgs e)
        {
            OK_pass.Visible = false;
            Ok_email.Visible = false;
            Error_Email.Visible = false;
            Error_pass.Visible = false;
            Metodos_login.Refrescar_usuarios(Dtg_Listado_polizas);
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

        private void Añadir_btn_Click(object sender, EventArgs e)
        {
            if (Pass_user_txb.Text == Conf_pass_txb.Text || Email_user_txb.Text == Conf_email_txb.Text)
            {
                Metodos_login.Añadir_Editar_Usuario(Id_usuario,Pregunta_drp,Nombre_user_txb,Telefono_user_txb,Email_user_txb,
                    Pass_user_txb,Respuesta_txb);
                Metodos_login.Refrescar_usuarios(Dtg_Listado_polizas);
                Metodos_diseño.reset_txb_users(Pregunta_drp, Nombre_user_txb, Telefono_user_txb, Email_user_txb,
                    Pass_user_txb, Respuesta_txb, Conf_pass_txb, Conf_email_txb, Ok_email,OK_pass,Error_Email,Error_pass);

            }
            else
            {
                MessageBox.Show("Algunos valores no coinciden, por favor valide campos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Dtg_Listado_polizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_usuario = Get_Id_user();
        }

        private void Editar_user_btn_Click(object sender, EventArgs e)
        {
            if (Id_usuario != null)
            {
                Metodos_login.Llenar_editar_usuario(Id_usuario, Pregunta_drp, Nombre_user_txb, Telefono_user_txb, Email_user_txb,
                Pass_user_txb, Respuesta_txb, Conf_pass_txb, Conf_email_txb);
            }
        }
    }
}
