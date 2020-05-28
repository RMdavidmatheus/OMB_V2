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
    public partial class Listado_vigencias_polizas : Form
    {
        public Listado_vigencias_polizas()
        {
            InitializeComponent();
        }
        #region
        // Metodos bases de datos
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();
        #endregion

        private void Listado_vigencias_polizas_Load(object sender, EventArgs e)
        {
            Metodos.Refrescar_Vig(Dtg_Listado_vigencia_pol);
        }

        private void Dtg_Listado_vigencia_pol_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Dtg_Listado_vigencia_pol.Columns[e.ColumnIndex].Name == "Estado")
            {
                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {
                        if (e.Value.ToString().Equals("ACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.LightGreen;

                        }

                        if (e.Value.ToString().Equals("INACTIVO"))
                        {
                            e.CellStyle.BackColor = Color.IndianRed;
                        }

                    }
                }
                catch (Exception)
                {

                }
            }
        }
        private void Reset_txt_btn_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
    }
}
