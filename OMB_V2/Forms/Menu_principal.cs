using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using OMB_V2.Models;

namespace OMB_V2.Forms
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            // INICIO CON FORM DE BIENVENIDA
            #region
            Metodos_d.Llenar_panel(Panel_content, new Forms.Bienvenida());
            #endregion
            Logo_pic.Visible = false;
        }
        Forms.Submenus.Tab_page Paginado = new Submenus.Tab_page();
        // BOOLEANO METODO PARA MENU AUTOMATICO
        bool Menu_expandido = false;
        // METODO MOVER PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // FIN METODO MOVER PANTALLA

        // METODOS PROPIOS DEL MENU
        
        // VARIABLES PRIVADAS
        private int LX, LY;
        // VARIABLE DISEÑO
        Models.Metodos_diseño.Metodos_diseño Metodos_d = new Models.Metodos_diseño.Metodos_diseño();

        private void Btn_close_Click(object sender, EventArgs e)
        {
            // PREGUNTANDO ANTES DE CERRAR
            if (MessageBox.Show("¿Desea salir del aplicativo?", "SALIENDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // NADA AL DECIR QUE NO
            }
        }

        private void Btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_rest_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1368, 720);
            this.Location = new Point(LX, LY);
            Btn_max.Visible = true;
            Btn_rest.Visible = false;
        }

        private void Panel_sup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            // ABRIENDO DE NUEVO EL FORM DE BIENVENIDA
            Metodos_d.Llenar_panel(Panel_content,new Forms.Bienvenida());
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            // VS REACTIVE EN MENU
            VSReactive<int>.SetState("menu", int.Parse(((Control)sender).Tag.ToString()));
            Paginado.Paneles(Panel_content, Animacion_txt_title, Titulo_window);
        }

        private void Logo_pic_Click(object sender, EventArgs e)
        {
            Metodos_d.Llenar_panel(Panel_content, new Forms.Bienvenida());
            if (Titulo_window.Visible == true)
            {
                Animacion_txt_title.HideSync(Titulo_window);
                Titulo_window.Text = "Pantalla de bienvenida";
                Animacion_txt_title.ShowSync(Titulo_window);
            }
            else
            {
                Animacion_txt_title.ShowSync(Titulo_window);
            }
        }

        private void Mouse_detectado_Tick(object sender, EventArgs e)
        {
            // ABRIR EL MENU AUTOMATICAMENTE
            if (!Animacion_menu_lateral.IsCompleted) return;
            if (Panel_lateral.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!Menu_expandido)
                {
                    Menu_expandido = true;
                    Panel_lateral.Width = 301;
                    Animacion_logo.Show(Logo_pic);
                }
            }
            else 
            {
                if (Menu_expandido) 
                {
                    Menu_expandido = false;
                    Animacion_logo.Hide(Logo_pic);
                    Panel_lateral.Visible = false;
                    Panel_lateral.Width = 42;
                    Animacion_menu_lateral.Show(Panel_lateral);
                }
            }
        }

        private void Btn_admin_Click(object sender, EventArgs e)
        {
            Usuarios_gestion Admin = new Usuarios_gestion();
            Admin.Show();
        }

        private void Btn_max_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            Btn_rest.Visible = true;
            Btn_max.Visible = false;
        }
    }
}
