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
    public partial class Listados_vehiculos : Form
    {
        public Listados_vehiculos()
        {
            InitializeComponent();
        }
        #region
        // Metodos Base de datos
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();
        #endregion
        private void Listados_vehiculos_Load(object sender, EventArgs e)
        {
            Metodos.Refrescar_veh(Dtg_Listado_vehiculos);
        }

        private void Reset_txt_btn_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
    }
}
