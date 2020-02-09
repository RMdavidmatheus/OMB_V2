﻿using System;
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
        // Llenar Formularios para editar tomador
        public void Llenar_Tomador_Edit(long? Cedula,Bunifu.Framework.UI.BunifuDropdown Tipo_doc , Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_cedula, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Txb_nombres,
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
        public void Llenar_Poliza_Edit(long? Numero_Poliza, Bunifu.Framework.UI.BunifuDropdown Aseguradora_drop, Bunifu.Framework.UI.BunifuDropdown Tipo_poliza_drop, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Numero_Poliza_txb,Bunifu.Framework.UI.BunifuDatepicker Fecha_inicial,
            Bunifu.Framework.UI.BunifuDatepicker Fecha_final, Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Valor_txb)
        {
            DB_Entities_OMB db = new DB_Entities_OMB();
            Poliza Pol_tabla = new Poliza();
            Pol_tabla = db.Poliza.Find(Numero_Poliza);

            if (Pol_tabla.Pol_Numero_Poliza == Numero_Poliza)
            {
                Aseguradora_drop.selectedIndex = Pol_tabla.Aseguradora_ID-1;
                Tipo_poliza_drop.selectedIndex = Pol_tabla.Tipo_Poliza_ID-1;
                Numero_Poliza_txb.Text = Pol_tabla.Pol_Numero_Poliza.ToString();
                Fecha_inicial.Value = Pol_tabla.Pol_Vigencia_Inicial;
                Fecha_final.Value = Pol_tabla.Pol_Vigencia_Final;
                Valor_txb.Text = Pol_tabla.Pol_Valor_Prima.ToString();
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
    }
}
