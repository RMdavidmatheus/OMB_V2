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
        public Añadir_Editar_Eliminar_Formulario()
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

        private void Añadir_tom_btn_Click(object sender, EventArgs e)
        {
            // FORMATO DE FECHA
            string Fecha_formato = Fecha_tom.Value.ToString("yyyy-MM-dd");
            // CONDICIONAL VALIDACION ESPACIOS
            if (Documento_tom_txb.Text == "" || Nombres_tom_txb.Text == "" || Apellidos_tom_txb.Text == ""
                || Direccion_tom_txb.Text == "" || Telefono_tom_txb.Text == "" || Email_tom_txb.Text == "")
            {
                MessageBox.Show("Por favor verifique, hay espacios vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            }
            else 
            {
                using (DB_Entities_OMB db = new DB_Entities_OMB()) 
                {
                    Tomador Tomador_tabla = new Tomador();
                    Tomador_tabla.Tom_Documento = Convert.ToInt64(Documento_tom_txb.Text);
                    Tomador_tabla.Tom_Tip_Doc = Tipo_cel_tom.selectedValue.ToString();
                    Tomador_tabla.Tom_Nombres = Nombres_tom_txb.Text;
                    Tomador_tabla.Tom_Apellidos = Apellidos_tom_txb.Text;
                    Tomador_tabla.Tom_Direccion = Direccion_tom_txb.Text;
                    Tomador_tabla.Tom_Telefono = Convert.ToInt64(Telefono_tom_txb.Text);
                    Tomador_tabla.Tom_Email = Email_tom_txb.Text;
                    Tomador_tabla.Tom_Fecha_Nacimiento = Convert.ToDateTime(Fecha_formato);
                    Tomador_tabla.Fecha_Creacion = DateTime.Now;
                    // INSERTAR
                    if (Tomador_tabla.Tom_Documento.ToString() != "" || Tomador_tabla.Tom_Tip_Doc.ToString() != ""
                        || Tomador_tabla.Tom_Nombres.ToString() != "" || Tomador_tabla.Tom_Apellidos.ToString() != "" ||
                        Tomador_tabla.Tom_Direccion.ToString() != "" || Tomador_tabla.Tom_Telefono.ToString() != "" || Tomador_tabla.Tom_Email.ToString() != ""
                        || Tomador_tabla.Tom_Fecha_Nacimiento.ToString() != "")
                    {
                        db.Tomador.Add(Tomador_tabla);
                        db.SaveChanges();
                        MessageBox.Show("Registro Agregado");
                        Control_tab.SelectedTab = Beneficiario_page;
                    }
                    else 
                    {
                        MessageBox.Show("No se pudo realizar el ingreso del registro");
                    }
                }
            }
        }
    }
}
