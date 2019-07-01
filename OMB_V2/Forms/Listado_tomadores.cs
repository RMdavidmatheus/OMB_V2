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
        Capa_logica.Metodos Metodos = new Capa_logica.Metodos();
        #endregion
        // FIN
        private void Listado_tomadores_Load(object sender, EventArgs e)
        {
            // LLENAR EL DATAGRID CON EL METODO CORRESPONDIENTE PARA TENER EL DATA SOURCE
        }
    }
}
