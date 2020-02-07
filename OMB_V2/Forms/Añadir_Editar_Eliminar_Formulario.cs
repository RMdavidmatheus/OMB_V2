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
using OMB_V2.Models;

namespace OMB_V2.Forms
{
    public partial class Añadir_Editar_Eliminar_Formulario : MaterialForm
    {
        public Añadir_Editar_Eliminar_Formulario(long? Cedula_tomador = null, long? Cedula_beneficiario = null)
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;
            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Grey900, Accent.LightBlue400, TextShade.WHITE);
            this.Cedula_tomador = Cedula_tomador;
            this.Cedula_beneficiario = Cedula_beneficiario;
        }
        // Long receptor
        private long? Cedula_tomador, Cedula_beneficiario;
        // Metodos
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();

        // AÑADIR TOM
        private void Añadir_tom_btn_Click(object sender, EventArgs e)
        {
            // AÑADIENDO DATOS DESDE EL METODO
            Metodos.Añadir_Editar_Tom(Cedula_tomador, Tip_Doc_Tom, Documento_tom_txb, Nombres_tom_txb, Apellidos_tom_txb,
                 Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb, Fecha_tom);
        }
        //AÑADIR BEN
        private void Añadir_ben_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Cedula_beneficiario.ToString());
        }
        // LOAD DEL FORMULARIO
        private void Añadir_Editar_Eliminar_Formulario_Load(object sender, EventArgs e)
        {
            // VALIDACION CUANDO Y COMO TRAER LOS DATOS
            
            if (Cedula_tomador != null && Cedula_beneficiario != null)
            {
                if (Añadir_tom_btn.Visible == false && Añadir_ben_btn.Visible == false)
                {
                    Metodos.Llenar_Tomador_Edit(Cedula_tomador, Tip_Doc_Tom, Documento_tom_txb, Nombres_tom_txb, Apellidos_tom_txb, Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb, Fecha_tom);
                    Metodos.Llenar_Beneficiario_Edit(Cedula_beneficiario, Doc_Tip_Ben, Documento_ben_txb, Nombres_ben_txb, Apellidos_ben_txb,
                        Direccion_ben_txb, Telefono_ben_txb, Email_ben_txb, Fecha_ben);
                }
                else
                {
                    if (MessageBox.Show("¿El registro pertenece al mismo cliente?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Metodos.Llenar_Tomador_Edit(Cedula_tomador, Tip_Doc_Tom, Documento_tom_txb, Nombres_tom_txb, Apellidos_tom_txb, Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb, Fecha_tom);
                        Metodos.Llenar_Beneficiario_Edit(Cedula_beneficiario, Doc_Tip_Ben, Documento_ben_txb, Nombres_ben_txb, Apellidos_ben_txb,
                        Direccion_ben_txb, Telefono_ben_txb, Email_ben_txb, Fecha_ben);
                    }
                    else
                    {
                        // TOMADOR
                        Cedula_tomador = null;
                        Tip_Doc_Tom.selectedIndex = 0;
                        Documento_tom_txb.Text = "";
                        Nombres_tom_txb.Text = "";
                        Apellidos_tom_txb.Text = "";
                        Direccion_tom_txb.Text = "";
                        Telefono_tom_txb.Text = "";
                        Email_tom_txb.Text = "";
                        Fecha_tom.Value = DateTime.Now;
                        // BENEFICIARIO
                        Cedula_beneficiario = null;
                        Doc_Tip_Ben.selectedIndex = 0;
                        Documento_ben_txb.Text = "";
                        Nombres_ben_txb.Text = "";
                        Apellidos_ben_txb.Text = "";
                        Direccion_ben_txb.Text = "";
                        Telefono_ben_txb.Text = "";
                        Email_ben_txb.Text = "";
                        Fecha_ben.Value = DateTime.Now;
                    }
                }
            }
        }

        private void Editar_ben_btn_Click(object sender, EventArgs e)
        {
            //
        }

        private void Editar_tom_Click(object sender, EventArgs e)
        {
            Metodos.Añadir_Editar_Tom(Cedula_tomador,Tip_Doc_Tom,Documento_tom_txb,Nombres_tom_txb,Apellidos_tom_txb,
                Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb,Fecha_tom);
        }
    }
}
