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
    public partial class Listado_polizas : Form
    {
        public Listado_polizas()
        {
            InitializeComponent();
        }
        private long? Cedula_Parametro;
        // Metodos get de llaves primarias
        #region
        private long? Get_Cedula_Tomador() 
        {
            try
            {
               return long.Parse(Dtg_Listado_polizas.Rows[Dtg_Listado_polizas.CurrentRow.Index].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
        // Inicializacion Metodos DB
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();
        private void Listado_polizas_Load(object sender, EventArgs e)
        {
            Metodos.Listar_DB_Polizas(Dtg_Listado_polizas);
        }
        // Evento Click en celda
        private void Dtg_Listado_polizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Cedula_Parametro = Get_Cedula_Tomador();
        }

        private void Añadir_btn_Click(object sender, EventArgs e)
        {
            Añadir_Editar_Eliminar_Formulario Añadir = new Añadir_Editar_Eliminar_Formulario(Cedula_Parametro);
            Añadir.Text = "Añadir documento";
            Añadir.ShowDialog();
            if (Añadir.Documento_tom_txb.Text != "")
            {
                if (MessageBox.Show("¿El registro pertenece al mismo cliente?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
                else
                {
                    Añadir.Tip_Doc_Tom.selectedIndex = 0;
                    Añadir.Documento_tom_txb.Text = "";
                    Añadir.Nombres_tom_txb.Text = "";
                    Añadir.Apellidos_tom_txb.Text = "";
                    Añadir.Direccion_tom_txb.Text = "";
                    Añadir.Telefono_tom_txb.Text = "";
                    Añadir.Email_tom_txb.Text = "";
                    Añadir.Fecha_tom.Value = DateTime.Now;
                }
            }
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            Añadir_Editar_Eliminar_Formulario Añadir = new Añadir_Editar_Eliminar_Formulario(Cedula_Parametro);
            Añadir.Text = "Editar documento";
            Añadir.Documento_tom_txb.Enabled = false;
            Añadir.Añadir_tom_btn.Visible = false;
            Añadir.ShowDialog();
        }
    }
}
