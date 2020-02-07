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
        private long? Cedula_Parametro_tom, Cedula_Parametro_ben;
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
        private long? Get_Cedula_Beneficiario()
        {
            try
            {
                return long.Parse(Dtg_Listado_polizas.Rows[Dtg_Listado_polizas.CurrentRow.Index].Cells[7].Value.ToString());
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
            Cedula_Parametro_tom = Get_Cedula_Tomador();
            Cedula_Parametro_ben = Get_Cedula_Beneficiario();

        }

        private void Añadir_btn_Click(object sender, EventArgs e)
        {
            Añadir_Editar_Eliminar_Formulario Añadir = new Añadir_Editar_Eliminar_Formulario(Cedula_Parametro_tom,Cedula_Parametro_ben);
            Añadir.Text = "Añadir documento";
            Añadir.Editar_tom.Visible = false;
            Añadir.Editar_ben_btn.Visible = false;
            Añadir.ShowDialog();
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            Añadir_Editar_Eliminar_Formulario Añadir = new Añadir_Editar_Eliminar_Formulario(Cedula_Parametro_tom, Cedula_Parametro_ben);
            Añadir.Text = "Editar documento";
            Añadir.Documento_tom_txb.Enabled = false;
            Añadir.Documento_ben_txb.Enabled = false;
            Añadir.Añadir_tom_btn.Visible = false;
            Añadir.Añadir_ben_btn.Visible = false;
            Añadir.ShowDialog();
        }
    }
}
