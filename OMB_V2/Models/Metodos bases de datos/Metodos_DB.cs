using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMB_V2.Models;

namespace OMB_V2.Models.Metodos_bases_de_datos
{
    class Metodos_DB
    {
        // Listar Polizas
        public void Listar_DB_Polizas(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor) 
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB()) 
            {
                var Listado_Polizas = from pol in db.Vista_Listado_Polizas select pol;
                Datagrid_receptor.DataSource = Listado_Polizas.ToList();
            }
        }
        // Listar Tomadores
        public void Listar_DB_Tomadores(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Tomadores = from tom in db.Vista_Tom_2 select tom;
                Datagrid_receptor.DataSource = Listado_Tomadores.ToList();
            }
        }
        // Listar Beneficiarios
        public void Listar_DB_Beneficiarios(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Beneficiarios = from ben in db.Vista_Ben_2 select ben;
                Datagrid_receptor.DataSource = Listado_Beneficiarios.ToList();
            }
        }
        // Listar Vehiculos
        public void Listar_DB_Vehiculos(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Vehiculos = from veh in db.Vista_Vehiculos select veh;
                Datagrid_receptor.DataSource = Listado_Vehiculos.ToList();
            }
        }
        // Listar vigencias polizas
        public void Listar_DB_Vigencia_Polizas(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Vig = from vig in db.Vista_Vig_Pol_2 select vig;
                Datagrid_receptor.DataSource = Listado_Vig.ToList();
            }
        }
        // Listar vigencias soat
        public void Listar_DB_Vigencia_Soat(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Vig_Soat = from vig_soat in db.Reporte_SOAT_V3 select vig_soat;
                Datagrid_receptor.DataSource = Listado_Vig_Soat.ToList();
            }
        }
        // Llenar Formularios para editar
        public void Llenar_Tomador_Edit(long? Cedula,Bunifu.Framework.UI.BunifuDropdown Tipo_doc ,Bunifu.Framework.UI.BunifuMaterialTextbox Txb_cedula, Bunifu.Framework.UI.BunifuMaterialTextbox Txb_nombres,
            Bunifu.Framework.UI.BunifuMaterialTextbox Txb_apellidos, Bunifu.Framework.UI.BunifuMaterialTextbox Txb_direccion,
            Bunifu.Framework.UI.BunifuMaterialTextbox Txb_telefono, Bunifu.Framework.UI.BunifuMaterialTextbox Txb_email, Bunifu.Framework.UI.BunifuDatepicker Fecha_nacimiento) 
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            var Tipo_documento = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Tip_Doc;
            var Nombres = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Nombres;
            var Apellidos = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Apellidos;
            var Direccion = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Direccion;
            var Telefono = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Telefono;
            var Email = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Email;
            var Fecha_Nacimiento = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Fecha_Nacimiento;


            if (Nombres.Count() != 0 || Apellidos.Count() != 0 || Direccion.Count() != 0 ||
                Telefono.Count() != 0 || Email.Count() != 0 || Fecha_Nacimiento.Count() != 0)
            {
                Tipo_doc.SelectedItem(Tipo_documento.First());
                Txb_cedula.Text = Cedula.ToString();
                Txb_nombres.Text = Nombres.First();
                Txb_apellidos.Text = Apellidos.First();
                Txb_direccion.Text = Direccion.First();
                Txb_telefono.Text = Telefono.First().ToString();
                Txb_email.Text = Email.First();
                Fecha_nacimiento.Value = Fecha_Nacimiento.First();
            }
            else
            {
                MessageBox.Show("No hay datos en los registros");
            }
        }
    }
}
