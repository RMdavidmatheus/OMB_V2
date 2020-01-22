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
    public partial class Listado_tomadores : Form
    {
        public Listado_tomadores()
        {
            InitializeComponent();
        }
        // INICIALIZACION METODOS
        #region
        Models.Metodos_bases_de_datos.Metodos_DB Metodos_DB = new Models.Metodos_bases_de_datos.Metodos_DB();
        #endregion
        // FIN
        private void Listado_tomadores_Load(object sender, EventArgs e)
        {
            // Llenar tabla
            Metodos_DB.Listar_DB_Tomadores(Dtg_Listado_tomadores);
        }
    }
}
