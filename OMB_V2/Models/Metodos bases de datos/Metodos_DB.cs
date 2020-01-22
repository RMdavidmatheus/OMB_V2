using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMB_V2.Models;

namespace OMB_V2.Models.Metodos_bases_de_datos
{
    class Metodos_DB
    {
        // Listar Polizas
        public void Listar_DB_Polizas(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor) 
        {
            using (Data_base_entities db = new Data_base_entities()) 
            {
                var Listado_Polizas = from pol in db.Vista_Listado_Polizas select pol;
                Datagrid_receptor.DataSource = Listado_Polizas.ToList();
            }
        }
        // Listar Tomadores
        public void Listar_DB_Tomadores(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (Data_base_entities db = new Data_base_entities())
            {
                var Listado_Tomadores = from tom in db.Vista_Tom_2 select tom;
                Datagrid_receptor.DataSource = Listado_Tomadores.ToList();
            }
        }

    }
}
