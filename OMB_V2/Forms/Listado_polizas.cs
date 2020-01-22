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

        // Inicializacion Metodos DB
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();
        private void Listado_polizas_Load(object sender, EventArgs e)
        {
            Metodos.Listar_DB_Polizas(Dtg_Listado_polizas);
        }
    }
}
