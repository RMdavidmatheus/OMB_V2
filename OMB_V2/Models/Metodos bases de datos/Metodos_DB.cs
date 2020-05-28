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
        private Tomador tom;
        private Beneficiario ben;
        private Poliza Pol;
        private Vehiculo Veh;
        // Listar Polizas
        private void Listar_DB_Polizas(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Polizas = from pol in db.Vista_Listado_Polizas select pol;
                Datagrid_receptor.DataSource = Listado_Polizas.ToList();
            }
        }
        // Cambiar nombres de columnas DTG Polizas
        private void Cambiar_Columns_Poliza(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Datagrid_receptor.Columns[0].HeaderText = "Numero de poliza";
            Datagrid_receptor.Columns[2].HeaderText = "Aseguradora";
            Datagrid_receptor.Columns[3].HeaderText = "Tipo documento tomador";
            Datagrid_receptor.Columns[4].HeaderText = "Documento tomador";
            Datagrid_receptor.Columns[5].HeaderText = "Nombres tomador";
            Datagrid_receptor.Columns[6].HeaderText = "Tipo documento beneficiario";
            Datagrid_receptor.Columns[7].HeaderText = "Documento beneficiario";
            Datagrid_receptor.Columns[8].HeaderText = "Nombres beneficiario";
            Datagrid_receptor.Columns[9].HeaderText = "Vigencia inicial";
            Datagrid_receptor.Columns[10].HeaderText = "Vigencia final";
            Datagrid_receptor.Columns[11].HeaderText = "Valor prima";
        }
        // Metodo Refrescar e y listar Polizas
        public void Refrescar_pol(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Listar_DB_Polizas(Datagrid_receptor);
            Cambiar_Columns_Poliza(Datagrid_receptor);
            Datagrid_receptor.AutoResizeColumnHeadersHeight();
        }
        // Listar Tomadores
        private void Listar_DB_Tomadores(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Tomadores = from tom in db.Vista_Tom_2 select tom;
                Datagrid_receptor.DataSource = Listado_Tomadores.ToList();
            }
        }
        // Cambiar nombres de columnbas DTG Tomadores
        private void Cambiar_Columns_Tomadores(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Datagrid_receptor.Columns[1].HeaderText = "Tipo documento";
            Datagrid_receptor.Columns[3].HeaderText = "Fecha de nacimiento";
        }
        // Refrescar y listar Tomadores
        public void Refrescar_tom(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Listar_DB_Tomadores(Datagrid_receptor);
            Cambiar_Columns_Tomadores(Datagrid_receptor);
            Datagrid_receptor.ColumnHeadersHeight = 50;
        }
        // Listar Beneficiarios
        private void Listar_DB_Beneficiarios(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Beneficiarios = from ben in db.Vista_Ben_2 select ben;
                Datagrid_receptor.DataSource = Listado_Beneficiarios.ToList();
            }
        }
        // Cambiar nombres de columnas DTG Beneficiarios
        private void Cambiar_Columns_Beneficiarios(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Datagrid_receptor.Columns[1].HeaderText = "Tipo documento";
            Datagrid_receptor.Columns[3].HeaderText = "Fecha de nacimiento";
        }
        // Refrescar y listar Beneficiarios
        public void Refrescar_ben(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Listar_DB_Beneficiarios(Datagrid_receptor);
            Cambiar_Columns_Beneficiarios(Datagrid_receptor);
            Datagrid_receptor.ColumnHeadersHeight = 50;
        }
        // Listar Vehiculos
        private void Listar_DB_Vehiculos(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Vehiculos = from veh in db.Vehiculos_V2 select veh;
                Datagrid_receptor.DataSource = Listado_Vehiculos.ToList();
            }
        }
        // Cambiar nombres de columnas DTG Vehiculos
        private void Cambiar_Columns_Vehiculos(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Datagrid_receptor.Columns[0].HeaderText = "Numero de poliza";
            Datagrid_receptor.Columns[2].HeaderText = "Ramo";
            Datagrid_receptor.Columns[3].HeaderText = "Tipo de documento tomador";
            Datagrid_receptor.Columns[4].HeaderText = "Documento tomador";
            Datagrid_receptor.Columns[5].HeaderText = "Nombres tomador";
            Datagrid_receptor.Columns[6].HeaderText = "Tipo de documento beneficiario";
            Datagrid_receptor.Columns[7].HeaderText = "Documento beneficiario";
            Datagrid_receptor.Columns[8].HeaderText = "Nombres beneficiario";
        }
        // Refrescar y listar vehiculos
        public void Refrescar_veh(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            Listar_DB_Vehiculos(Datagrid_receptor);
            Cambiar_Columns_Vehiculos(Datagrid_receptor);
            Datagrid_receptor.AutoResizeColumnHeadersHeight();
        }
        // Listar vigencias polizas
        private void Listar_DB_Vigencia_Polizas(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Vig = from vig in db.Vista_Vig_Pol_2 select vig;
                Datagrid_receptor.DataSource = Listado_Vig.ToList();
            }
        }
        // Cambiar Columns
        private void Cambiar_Columns_Vig_Pol(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor) 
        {
            Datagrid_receptor.Columns[0].HeaderText = "Numero de poliza";
            Datagrid_receptor.Columns[1].HeaderText = "Tipo de documento";
            Datagrid_receptor.Columns[2].HeaderText = "Nombres";
            Datagrid_receptor.Columns[4].HeaderText = "Valor prima";
            Datagrid_receptor.Columns[5].HeaderText = "Vigencia inicial";
            Datagrid_receptor.Columns[6].HeaderText = "Vigencia final";
            Datagrid_receptor.Columns[7].HeaderText = "Estado";
        }
        // Refrescar tabla
        public void Refrescar_Vig(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor) 
        {
            Listar_DB_Vigencia_Polizas(Datagrid_receptor);
            Cambiar_Columns_Vig_Pol(Datagrid_receptor);
            Datagrid_receptor.AutoResizeColumnHeadersHeight();
        }
        // Listar vigencias soat
        public void Listar_DB_Vigencia_Soat(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                var Listado_Vig_Soat = from vig_soat in db.Reporte_SOAT_2020 select vig_soat;
                Datagrid_receptor.DataSource = Listado_Vig_Soat.ToList();
            }
        }
        // Llenar Formularios para editar tomador
        public void Llenar_Tomador_Edit(long? Cedula, Bunifu.Framework.UI.BunifuDropdown Tipo_doc, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_cedula, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_apellidos, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_direccion,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_telefono, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.Framework.UI.BunifuDatepicker Fecha_nacimiento)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            Tomador tom_tabla = new Tomador();
            //LOGICA ANTERIOR
            /*var Tipo_documento = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Tip_Doc;
            var Nombres = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Nombres;
            var Apellidos = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Apellidos;
            var Direccion = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Direccion;
            var Telefono = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Telefono;
            var Email = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Email;
            var Fecha_Nacimiento = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Fecha_Nacimiento;
            */
            tom_tabla = db.Tomador.Find(Cedula);

            if (tom_tabla.Tom_Documento.ToString() == Cedula.ToString())
            {
                Tipo_doc.SelectedItem(tom_tabla.Tom_Tip_Doc);
                Txb_cedula.Text = tom_tabla.Tom_Documento.ToString();
                Txb_cedula.Enabled = false;
                Txb_nombres.Text = tom_tabla.Tom_Nombres.ToString();
                Txb_apellidos.Text = tom_tabla.Tom_Apellidos.ToString();
                Txb_direccion.Text = tom_tabla.Tom_Direccion.ToString();
                Txb_telefono.Text = tom_tabla.Tom_Telefono.ToString();
                Txb_email.Text = tom_tabla.Tom_Email.ToString();
                Fecha_nacimiento.Value = tom_tabla.Tom_Fecha_Nacimiento;
                // LOGICA ANTERIOR
                /*Tipo_doc.SelectedItem(Tipo_documento.First());
                Txb_cedula.Text = Cedula.ToString();
                Txb_nombres.Text = Nombres.First();
                Txb_apellidos.Text = Apellidos.First();
                Txb_direccion.Text = Direccion.First();
                Txb_telefono.Text = Telefono.First().ToString();
                Txb_email.Text = Email.First();
                Fecha_nacimiento.Value = Fecha_Nacimiento.First();*/
            }
            else
            {
                MessageBox.Show("No hay datos en los registros");
            }
        }
        // Llenar Formularios para editar beneficiario
        public void Llenar_Beneficiario_Edit(long? Cedula, Bunifu.Framework.UI.BunifuDropdown Tipo_doc, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_cedula, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_apellidos, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_direccion,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_telefono, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.Framework.UI.BunifuDatepicker Fecha_nacimiento)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            Beneficiario ben_tabla = new Beneficiario();
            //LOGICA ANTERIOR
            /*var Tipo_documento = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Tip_Doc;
            var Nombres = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Nombres;
            var Apellidos = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Apellidos;
            var Direccion = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Direccion;
            var Telefono = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Telefono;
            var Email = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Email;
            var Fecha_Nacimiento = from tom in db.Tomador where tom.Tom_Documento == Cedula select tom.Tom_Fecha_Nacimiento;
            */
            ben_tabla = db.Beneficiario.Find(Cedula);

            if (ben_tabla.Ben_Documento.ToString() == Cedula.ToString())
            {
                Tipo_doc.SelectedItem(ben_tabla.Ben_Tipo_Doc);
                Txb_cedula.Text = ben_tabla.Ben_Documento.ToString();
                Txb_cedula.Enabled = false;
                Txb_nombres.Text = ben_tabla.Ben_Nombres.ToString();
                Txb_apellidos.Text = ben_tabla.Ben_Apellidos.ToString();
                Txb_direccion.Text = ben_tabla.Ben_Direccion.ToString();
                Txb_telefono.Text = ben_tabla.Ben_Telefono.ToString();
                Txb_email.Text = ben_tabla.Ben_Email.ToString();
                Fecha_nacimiento.Value = ben_tabla.Ben_Fecha_Nacimiento;
                // LOGICA ANTERIOR
                /*Tipo_doc.SelectedItem(Tipo_documento.First());
                Txb_cedula.Text = Cedula.ToString();
                Txb_nombres.Text = Nombres.First();
                Txb_apellidos.Text = Apellidos.First();
                Txb_direccion.Text = Direccion.First();
                Txb_telefono.Text = Telefono.First().ToString();
                Txb_email.Text = Email.First();
                Fecha_nacimiento.Value = Fecha_Nacimiento.First();*/
            }
            else
            {
                MessageBox.Show("No hay datos en los registros");
            }
        }
        // Llenar Poliza
        public void Llenar_Poliza_Edit(long? Numero_Poliza, Bunifu.Framework.UI.BunifuDropdown Aseguradora_drop, Bunifu.Framework.UI.BunifuDropdown Tipo_poliza_drop, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Numero_Poliza_txb, Bunifu.Framework.UI.BunifuDatepicker Fecha_inicial,
            Bunifu.Framework.UI.BunifuDatepicker Fecha_final, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Valor_txb)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            Poliza Pol_tabla = new Poliza();
            Pol_tabla = db.Poliza.Find(Numero_Poliza);

            if (Pol_tabla.Pol_Numero_Poliza == Numero_Poliza)
            {
                Aseguradora_drop.selectedIndex = Pol_tabla.Aseguradora_ID - 1;
                Aseguradora_drop.Enabled = false;
                Tipo_poliza_drop.selectedIndex = Pol_tabla.Tipo_Poliza_ID - 1;
                Tipo_poliza_drop.Enabled = false;
                Numero_Poliza_txb.Text = Pol_tabla.Pol_Numero_Poliza.ToString();
                Numero_Poliza_txb.Enabled = false;
                Fecha_inicial.Value = Pol_tabla.Pol_Vigencia_Inicial;
                Fecha_final.Value = Pol_tabla.Pol_Vigencia_Final;
                Valor_txb.Text = Pol_tabla.Pol_Valor_Prima.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos en los registros");
            }
        }
        // Llenar Vehiculo
        public void Llenar_Vehiculo_Edit(long? Numero_Poliza, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Placa_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Modelo_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Fascolda_txb,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Servicio_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Clase_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Marca_txb,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Valor_txb, Bunifu.Framework.UI.BunifuDatepicker Fecha_Soat)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            Vehiculo Tabla_veh = new Vehiculo();
            var Placa = from veh in db.Pol_veh_entity_framework where veh.PolizaPol_Numero_Poliza == Numero_Poliza select veh.VehiculoVeh_Placa;
            Tabla_veh = db.Vehiculo.Find(Placa.First());

            if (Tabla_veh.Veh_Placa == Placa.First())
            {
                Placa_txb.Text = Tabla_veh.Veh_Placa;
                Placa_txb.Enabled = false;
                Modelo_txb.Text = Tabla_veh.Veh_Modelo;
                Fascolda_txb.Text = Tabla_veh.Veh_Fasecolda.ToString();
                Servicio_txb.Text = Tabla_veh.Veh_Servicio;
                Clase_txb.Text = Tabla_veh.Veh_Clase;
                Marca_txb.Text = Tabla_veh.Veh_Marca;
                Valor_txb.Text = Tabla_veh.Veh_Valor_Auto.ToString();
                Fecha_Soat.Value = Tabla_veh.Veh_Vigencia_Soat;
            }
            else
            {
                MessageBox.Show("No hay datos en los registros");
            }
        }
        // METODO PARA AÑADIR U EDITAR REGISTROS
        public void Añadir_Editar_Tom(long? Cedula, Bunifu.Framework.UI.BunifuDropdown Tipo_doc, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_cedula, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_apellidos, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_direccion,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_telefono, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.Framework.UI.BunifuDatepicker Fecha_nacimiento)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {

                // SI LA CEDULA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                if (Cedula == null)
                {
                    tom = new Tomador();
                    tom.Tom_Documento = Convert.ToInt64(Txb_cedula.Text);
                    tom.Tom_Tip_Doc = Tipo_doc.selectedValue.ToString();
                    tom.Tom_Nombres = Txb_nombres.Text;
                    tom.Tom_Apellidos = Txb_apellidos.Text;
                    tom.Tom_Direccion = Txb_direccion.Text;
                    tom.Tom_Telefono = Convert.ToInt64(Txb_telefono.Text);
                    tom.Tom_Email = Txb_email.Text;
                    tom.Tom_Fecha_Nacimiento = Fecha_nacimiento.Value;
                    tom.Fecha_Creacion = DateTime.Now;

                }
                // SI LA CEDULA ES NULA AGREGARA LOS REGISTROS
                if (Cedula == null)
                {
                    db.Tomador.Add(tom);
                    MessageBox.Show("Registros agregados");
                }
                else
                {
                    // SI LA CEDULA NO ES NULA NOS EDITARA LOS REGISTROS
                    tom = new Tomador();
                    tom.Tom_Documento = Convert.ToInt64(Txb_cedula.Text);
                    tom.Tom_Tip_Doc = Tipo_doc.selectedValue.ToString();
                    tom.Tom_Nombres = Txb_nombres.Text;
                    tom.Tom_Apellidos = Txb_apellidos.Text;
                    tom.Tom_Direccion = Txb_direccion.Text;
                    tom.Tom_Telefono = Convert.ToInt64(Txb_telefono.Text);
                    tom.Tom_Email = Txb_email.Text;
                    tom.Tom_Fecha_Nacimiento = Fecha_nacimiento.Value;
                    tom.Fecha_Creacion = DateTime.Now;
                    if (Cedula != null)
                    {
                        db.Tomador.Add(tom);
                        db.Entry(tom).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Edición de registros completada");
                    }
                }
                db.SaveChanges();
            }
        }
        public void Añadir_Editar_Ben(long? Cedula, Bunifu.Framework.UI.BunifuDropdown Tipo_doc, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_cedula, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_apellidos, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_direccion,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_telefono, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_email, Bunifu.Framework.UI.BunifuDatepicker Fecha_nacimiento)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {

                // SI LA CEDULA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                if (Cedula == null)
                {
                    ben = new Beneficiario();
                    ben.Ben_Documento = Convert.ToInt64(Txb_cedula.Text);
                    ben.Ben_Tipo_Doc = Tipo_doc.selectedValue.ToString();
                    ben.Ben_Nombres = Txb_nombres.Text;
                    ben.Ben_Apellidos = Txb_apellidos.Text;
                    ben.Ben_Direccion = Txb_direccion.Text;
                    ben.Ben_Telefono = Convert.ToInt64(Txb_telefono.Text);
                    ben.Ben_Email = Txb_email.Text;
                    ben.Ben_Fecha_Nacimiento = Fecha_nacimiento.Value;
                    ben.Fecha_Creacion = DateTime.Now;

                }
                // SI LA CEDULA ES NULA AGREGARA LOS REGISTROS
                if (Cedula == null)
                {
                    db.Beneficiario.Add(ben);
                    MessageBox.Show("Registros agregados");
                }
                else
                {
                    // SI LA CEDULA NO ES NULA NOS EDITARA LOS REGISTROS
                    ben = new Beneficiario();
                    ben.Ben_Documento = Convert.ToInt64(Txb_cedula.Text);
                    ben.Ben_Tipo_Doc = Tipo_doc.selectedValue.ToString();
                    ben.Ben_Nombres = Txb_nombres.Text;
                    ben.Ben_Apellidos = Txb_apellidos.Text;
                    ben.Ben_Direccion = Txb_direccion.Text;
                    ben.Ben_Telefono = Convert.ToInt64(Txb_telefono.Text);
                    ben.Ben_Email = Txb_email.Text;
                    ben.Ben_Fecha_Nacimiento = Fecha_nacimiento.Value;
                    ben.Fecha_Creacion = DateTime.Now;
                    // Si la cedula es distinto a nulo hara la edicion del registro
                    if (Cedula != null)
                    {
                        db.Beneficiario.Add(ben);
                        db.Entry(ben).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Edición de registros completada");
                    }
                }
                db.SaveChanges();
            }
        }
        public void Añadir_Editar_Pol(long? Numero_poliza, Bunifu.Framework.UI.BunifuDropdown Aseguradora, Bunifu.Framework.UI.BunifuDropdown Tipo_de_poliza, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_num_pol,
            Bunifu.Framework.UI.BunifuDatepicker Fecha_inicio, Bunifu.Framework.UI.BunifuDatepicker Fecha_Final, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Valor_prima, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Documento_tom, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Documento_ben)
        {
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {

                // SI LA CEDULA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                if (Numero_poliza == null)
                {
                    Pol = new Poliza();
                    Pol.Pol_Numero_Poliza = long.Parse(Txb_num_pol.Text);
                    Pol.Tipo_Poliza_ID = Tipo_de_poliza.selectedIndex + 1;
                    Pol.Aseguradora_ID = Aseguradora.selectedIndex + 1;
                    Pol.Tomador_Documento = long.Parse(Documento_tom.Text);
                    Pol.Beneficiario_Documento = long.Parse(Documento_ben.Text);
                    Pol.Pol_Vigencia_Inicial = Fecha_inicio.Value;
                    Pol.Pol_Vigencia_Final = Fecha_Final.Value;
                    Pol.Pol_Valor_Prima = Decimal.Parse(Valor_prima.Text);
                    Pol.Pol_Estado = "ACTIVO";

                }
                // SI LA CEDULA ES NULA AGREGARA LOS REGISTROS
                if (Numero_poliza == null)
                {
                    db.Poliza.Add(Pol);
                    MessageBox.Show("Registros agregados");
                }
                else
                {
                    // SI LA CEDULA NO ES NULA NOS EDITARA LOS REGISTROS
                    Pol = new Poliza();
                    Pol.Pol_Numero_Poliza = long.Parse(Txb_num_pol.Text);
                    Pol.Tipo_Poliza_ID = Tipo_de_poliza.selectedIndex + 1;
                    Pol.Aseguradora_ID = Aseguradora.selectedIndex + 1;
                    Pol.Tomador_Documento = long.Parse(Documento_tom.Text);
                    Pol.Beneficiario_Documento = long.Parse(Documento_ben.Text);
                    Pol.Pol_Vigencia_Inicial = Fecha_inicio.Value;
                    Pol.Pol_Vigencia_Final = Fecha_Final.Value;
                    Pol.Pol_Valor_Prima = Decimal.Parse(Valor_prima.Text);
                    Pol.Pol_Estado = "ACTIVO";
                    // Si la cedula es distinto a nulo hara la edicion del registro
                    if (Numero_poliza != null)
                    {
                        db.Poliza.Add(Pol);
                        db.Entry(Pol).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Edición de registros completada");
                    }
                }
                db.SaveChanges();
            }
        }
        public void Añadir_Editar_Veh(long? Numero_poliza, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_num_pol, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Placa_txb,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Modelo_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Fasecolda_txb,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Servicio_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Clase_txb, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Marca_txb,
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Valor_auto_txb, Bunifu.Framework.UI.BunifuDatepicker Fecha_soat)
        {
            // INSERTANDO O EDITANDO LA ENTIDAD VEHICULO
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                // SI EL NUMERO DE POLIZA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                if (Numero_poliza == null)
                {
                    Veh = new Vehiculo();
                    Veh.Veh_Placa = Placa_txb.Text;
                    Veh.Veh_Modelo = Modelo_txb.Text;
                    Veh.Veh_Fasecolda = Int32.Parse(Fasecolda_txb.Text);
                    Veh.Veh_Servicio = Servicio_txb.Text;
                    Veh.Veh_Clase = Clase_txb.Text;
                    Veh.Veh_Marca = Marca_txb.Text;
                    Veh.Veh_Valor_Auto = Decimal.Parse(Valor_auto_txb.Text);
                    Veh.Veh_Vigencia_Soat = Fecha_soat.Value;
                    Veh.Veh_Soat_Estado = "ACTIVO";

                }
                // SI LA POLIZA ES NULA AGREGARA LOS REGISTROS
                if (Numero_poliza == null)
                {
                    db.Vehiculo.Add(Veh);
                    MessageBox.Show("Registros agregados");
                }
                else
                {
                    // SI LA POLIZA NO ES NULA NOS EDITARA LOS REGISTROS
                    Veh = new Vehiculo();
                    Veh.Veh_Placa = Placa_txb.Text;
                    Veh.Veh_Modelo = Modelo_txb.Text;
                    Veh.Veh_Fasecolda = int.Parse(Fasecolda_txb.Text);
                    Veh.Veh_Servicio = Servicio_txb.Text;
                    Veh.Veh_Clase = Clase_txb.Text;
                    Veh.Veh_Marca = Marca_txb.Text;
                    Veh.Veh_Valor_Auto = Decimal.Parse(Valor_auto_txb.Text);
                    Veh.Veh_Vigencia_Soat = Fecha_soat.Value;
                    // Si la poliza es distinto a nulo hara la edicion del registro
                    if (Numero_poliza != null)
                    {
                        db.Vehiculo.Add(Veh);
                        db.Entry(Veh).State = System.Data.Entity.EntityState.Modified;
                        MessageBox.Show("Edición de registros completada");
                    }
                }
                db.SaveChanges();
            }
            // INSERTANDO LA RELACION A LA TABLA POLIZAS VEHICULOS
            using (DB_Entities_OMB db = new DB_Entities_OMB())
            {
                // SI EL NUMERO DE POLIZA ES NULA NOS INICIALIZARA LA CLASE TOMADOR
                if (Numero_poliza == null)
                {
                    long Poliza_n = long.Parse(Txb_num_pol.Text);
                    Pol_veh_entity_framework Poliza_veh = new Pol_veh_entity_framework();
                    Poliza Poliza_rela = db.Poliza.FirstOrDefault(pol => pol.Pol_Numero_Poliza == Poliza_n);
                    Vehiculo vehi_rela = db.Vehiculo.FirstOrDefault(veh => veh.Veh_Placa == Placa_txb.Text);
                    Poliza_veh.Poliza = Poliza_rela;
                    Poliza_veh.Vehiculo = vehi_rela;
                    db.Pol_veh_entity_framework.Add(Poliza_veh);
                    MessageBox.Show("Registros de la relacion agregados");
                }
                db.SaveChanges();
            }
        }
        // ELIMINAR REGISTROS
        public void Eliminar_registro_condicion(long? Numero_poliza)
        {
            // HACIENDO LA ELIMINACION DEL REGISTRO
            if (Numero_poliza == null)
            {
                MessageBox.Show("No hay un registro el cual eliminar");
            }
            else
            {
                using (DB_Entities_OMB db = new DB_Entities_OMB())
                {
                    // INICIALIZACION DE LAS VARIABLES
                    var Poliza_encontrar = db.Poliza.Find(Numero_poliza);
                    var Vehiculo_encontrar = db.Pol_veh_entity_framework.Find(Numero_poliza);
                    long Cedula_tomador = Poliza_encontrar.Tomador_Documento;
                    long Cedula_beneficiario = Poliza_encontrar.Beneficiario_Documento;
                    var Tomador_encontrar = db.Tomador.Find(Cedula_tomador);
                    var Beneficiario_encontrar = db.Beneficiario.Find(Cedula_beneficiario);
                    string Placa = Vehiculo_encontrar.VehiculoVeh_Placa;
                    // SI EL NUMERO DE LA POLIZA ENCONTRADA COINCIDE CON EL PARAMETRO 
                    if (Poliza_encontrar.Pol_Numero_Poliza.Equals(Numero_poliza) || Tomador_encontrar.Tom_Documento.Equals(Cedula_tomador) || Beneficiario_encontrar.Ben_Documento.Equals(Cedula_beneficiario))
                    {
                        // ELIMINACION DEL REGISTRO POLIZA UNICAMENTE
                        if (MessageBox.Show("¿Desea eliminar solo la poliza?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (Poliza_encontrar.Tipo_Poliza_ID == 1)
                            {
                                var Vehiculo_entidad_encontrar = db.Vehiculo.Find(Placa);
                                db.Pol_veh_entity_framework.Remove(Vehiculo_encontrar);
                                db.SaveChanges();
                                db.Vehiculo.Remove(Vehiculo_entidad_encontrar);
                                db.SaveChanges();
                                db.Poliza.Remove(Poliza_encontrar);
                                db.SaveChanges();
                                MessageBox.Show("Se elimino correctamente la poliza");
                            }
                            else
                            {
                                db.Poliza.Remove(Poliza_encontrar);
                                db.SaveChanges();
                                MessageBox.Show("Se elimino correctamente la poliza");
                            }
                        }
                        // ELIMINACION DE TODO EL REGISTRO
                        else
                        {
                            if (Poliza_encontrar.Tipo_Poliza_ID == 1)
                            {
                                var Vehiculo_entidad_encontrar = db.Vehiculo.Find(Placa);
                                db.Pol_veh_entity_framework.Remove(Vehiculo_encontrar);
                                db.SaveChanges();
                                db.Vehiculo.Remove(Vehiculo_entidad_encontrar);
                                db.SaveChanges();
                                db.Poliza.Remove(Poliza_encontrar);
                                db.SaveChanges();
                                db.Beneficiario.Remove(Beneficiario_encontrar);
                                db.SaveChanges();
                                db.Tomador.Remove(Tomador_encontrar);
                                db.SaveChanges();
                                MessageBox.Show("Se elimino correctamente el registro");

                            }
                            else
                            {
                                db.Poliza.Remove(Poliza_encontrar);
                                db.SaveChanges();
                                db.Beneficiario.Remove(Beneficiario_encontrar);
                                db.SaveChanges();
                                db.Tomador.Remove(Tomador_encontrar);
                                db.SaveChanges();
                                MessageBox.Show("Se elimino correctamente el registro");

                            }
                        }

                    }
                }
            }
        }
        // FILTROS
        public void Filtrar_poliza(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor, string Busqueda)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            var Filtro = from p in db.Vista_Listado_Polizas
                         where p.Numero_de_Poliza.ToString().Contains(Busqueda) || p.Documento_Tomador.ToString().Contains(Busqueda)
                         || p.Documento_Beneficiario.ToString().Contains(Busqueda) || p.Nombres_Tomador.Contains(Busqueda) || p.Nombres_Beneficiario.Contains(Busqueda)
                         select p;
            if (Busqueda == "")
            {
                Datagrid_receptor.DataSource = null;
                Refrescar_pol(Datagrid_receptor);
            }
            else
            {
                Datagrid_receptor.DataSource = null;
                Datagrid_receptor.DataSource = Filtro.ToList();
                // FORMATO A LAS COLUMNAS
                #region
                Datagrid_receptor.Columns[0].HeaderText = "Numero de poliza";
                Datagrid_receptor.Columns[2].HeaderText = "Aseguradora";
                Datagrid_receptor.Columns[3].HeaderText = "Tipo documento tomador";
                Datagrid_receptor.Columns[4].HeaderText = "Documento tomador";
                Datagrid_receptor.Columns[5].HeaderText = "Nombres tomador";
                Datagrid_receptor.Columns[6].HeaderText = "Tipo documento beneficiario";
                Datagrid_receptor.Columns[7].HeaderText = "Documento beneficiario";
                Datagrid_receptor.Columns[8].HeaderText = "Nombres beneficiario";
                Datagrid_receptor.Columns[9].HeaderText = "Vigencia inicial";
                Datagrid_receptor.Columns[10].HeaderText = "Vigencia final";
                Datagrid_receptor.Columns[11].HeaderText = "Valor prima";
                #endregion

            }
        }
        public void Filtrar_tomador(Bunifu.UI.WinForms.BunifuDataGridView Datagrid_receptor, string Busqueda)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            var Filtro = from t in db.Vista_Tom_2
                         where t.Documento.ToString().Contains(Busqueda) || t.Nombres.Contains(Busqueda) || t.Telefono.ToString().Contains(Busqueda)
                         select t;
            if (Busqueda == "")
            {
                Datagrid_receptor.DataSource = null;
                Refrescar_tom(Datagrid_receptor);
            }
            else
            {
                Datagrid_receptor.DataSource = null;
                Datagrid_receptor.DataSource = Filtro.ToList();
                // FORMATO A LAS COLUMNAS
                #region
                Datagrid_receptor.Columns[1].HeaderText = "Tipo documento";
                Datagrid_receptor.Columns[3].HeaderText = "Fecha de nacimiento";
                #endregion

            }
        }
    }
}
