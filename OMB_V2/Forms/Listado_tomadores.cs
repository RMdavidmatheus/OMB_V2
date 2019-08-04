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
        Capa_login.Metodos_login Metodos_mongo = new Capa_login.Metodos_login();
        #endregion
        // FIN
        private void Listado_tomadores_Load(object sender, EventArgs e)
        {
            // LLENAR EL DATAGRID CON EL METODO CORRESPONDIENTE PARA TENER EL DATA SOURCE
            //Metodos_mongo.Listar_usuarios(Dtg_Listado_tomadores);
        }
    }
}
