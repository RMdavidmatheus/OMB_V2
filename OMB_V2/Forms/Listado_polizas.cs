using OMB_V2.Models;
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
        private long? Cedula_Parametro_tom, Cedula_Parametro_ben,Numero_poliza_parametro;
        private int? ID_Aseguradora_Parametro, ID_Tipo_poliza_Parametro;
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
        private long? Get_Numero_de_poliza()
        {
            try
            {
                return long.Parse(Dtg_Listado_polizas.Rows[Dtg_Listado_polizas.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }
        private int? Get_Aseguradora_ID() 
        {
            try
            {
                DB_Entities_OMB db = new DB_Entities_OMB();
                var Aseguradora_ID = from pol in db.Poliza where pol.Pol_Numero_Poliza == Numero_poliza_parametro select pol.Aseguradora_ID;
                return ID_Aseguradora_Parametro = Aseguradora_ID.First();
            }
            catch (Exception)
            {

                return ID_Aseguradora_Parametro = null;
            }
        }
        private int? Get_Tipo_poliza_ID() 
        {
            try
            {
                DB_Entities_OMB db = new DB_Entities_OMB();
                var Tipo_Poliza = from pol in db.Poliza where pol.Pol_Numero_Poliza == Numero_poliza_parametro select pol.Tipo_Poliza_ID;
                return ID_Tipo_poliza_Parametro = Tipo_Poliza.First();

            }
            catch (Exception)
            {
                return ID_Tipo_poliza_Parametro = null;
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
            Numero_poliza_parametro = Get_Numero_de_poliza();
        }

        private void Añadir_btn_Click(object sender, EventArgs e)
        {
            // ENVIANDO IDS PRIMARIOS
            ID_Aseguradora_Parametro = Get_Aseguradora_ID();
            ID_Tipo_poliza_Parametro = Get_Tipo_poliza_ID();
            //
            Añadir_Editar_Eliminar_Formulario Añadir = new Añadir_Editar_Eliminar_Formulario(Cedula_Parametro_tom,Cedula_Parametro_ben,Numero_poliza_parametro,ID_Aseguradora_Parametro,ID_Tipo_poliza_Parametro);
            Añadir.Text = "Añadir documento";
            Añadir.Editar_tom.Visible = false;
            Añadir.Editar_ben_btn.Visible = false;
            Añadir.Editar_pol_btn.Visible = false;
            Añadir.ShowDialog();
        }

        private void Editar_btn_Click(object sender, EventArgs e)
        {
            // ENVIANDO IDS PRIMARIOS
            ID_Aseguradora_Parametro = Get_Aseguradora_ID();
            ID_Tipo_poliza_Parametro = Get_Tipo_poliza_ID();
            //
            Añadir_Editar_Eliminar_Formulario Editar = new Añadir_Editar_Eliminar_Formulario(Cedula_Parametro_tom, Cedula_Parametro_ben,Numero_poliza_parametro,ID_Aseguradora_Parametro,ID_Tipo_poliza_Parametro);
            Editar.Text = "Editar documento";
            Editar.Documento_tom_txb.Enabled = false;
            Editar.Documento_ben_txb.Enabled = false;
            Editar.Numero_poliza_txb.Enabled = false;
            Editar.Añadir_tom_btn.Visible = false;
            Editar.Añadir_ben_btn.Visible = false;
            Editar.Añadir_pol_btn.Visible = false;
            Editar.ShowDialog();
        }
    }
}
