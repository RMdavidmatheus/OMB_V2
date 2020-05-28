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
    public partial class Listado_beneficiarios : Form
    {
        public Listado_beneficiarios()
        {
            InitializeComponent();
        }
        #region
        // Metodos base de datos
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();
        #endregion
        private void Listado_beneficiarios_Load(object sender, EventArgs e)
        {
            Metodos.Refrescar_ben(Dtg_Listado_beneficiarios);
        }

        private void Reset_txt_btn_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }
    }
}
