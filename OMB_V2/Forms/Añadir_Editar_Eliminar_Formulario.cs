using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OMB_V2.Models;

namespace OMB_V2.Forms
{
    public partial class Añadir_Editar_Eliminar_Formulario : MaterialForm
    {
        public Añadir_Editar_Eliminar_Formulario(long? Cedula_tomador = null, long? Cedula_beneficiario = null, long? Numero_poliza= null,
            int? Aseguradora_ID = null, int? Tipo_poliza_ID = null)
        {
            InitializeComponent();
            MaterialSkinManager Tema = MaterialSkinManager.Instance;
            Tema.AddFormToManage(this);
            Tema.Theme = MaterialSkinManager.Themes.LIGHT;
            // COLOR
            Tema.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Grey900, Accent.LightBlue400, TextShade.WHITE);
            this.Cedula_tomador = Cedula_tomador;
            this.Cedula_beneficiario = Cedula_beneficiario;
            this.Numero_Poliza = Numero_poliza;
            this.Aseguradora_ID = Aseguradora_ID;
            this.Tipo_poliza_ID = Tipo_poliza_ID;
        }
        // Long receptor
        private long? Cedula_tomador, Cedula_beneficiario, Numero_Poliza;
        // Int Receptor
        private int? Aseguradora_ID, Tipo_poliza_ID;
        // double formato txb con comillas
        private double Numero_prima, Valor_Auto;
        // Metodos
        Models.Metodos_bases_de_datos.Metodos_DB Metodos = new Models.Metodos_bases_de_datos.Metodos_DB();

        // AÑADIR TOM
        private void Añadir_tom_btn_Click(object sender, EventArgs e)
        {
            // AÑADIENDO DATOS DESDE EL METODO
            Metodos.Añadir_Editar_Tom(Cedula_tomador, Tip_Doc_Tom, Documento_tom_txb, Nombres_tom_txb, Apellidos_tom_txb,
                 Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb, Fecha_tom);
            Documento_tom_txb.Enabled = false;
            Control_tab.SelectedTab = Beneficiario_page;
        }
        //AÑADIR BEN
        private void Añadir_ben_btn_Click(object sender, EventArgs e)
        {
            // Metodo para agregar o editar beneficiario
            Metodos.Añadir_Editar_Ben(Cedula_beneficiario, Doc_Tip_Ben, Documento_ben_txb, Nombres_ben_txb, Apellidos_ben_txb,
                Direccion_ben_txb, Telefono_ben_txb, Email_ben_txb, Fecha_ben);
            Documento_ben_txb.Enabled = false;
            Control_tab.SelectedTab = Poliza_page;
        }

        private void Valor_prima_pol_txb_KeyUp(object sender, KeyEventArgs e)
        {
            // FORMATO AL ESCRIBIR
            if (double.TryParse(Valor_prima_pol_txb.Text, out Numero_prima))
            {
                Valor_prima_pol_txb.Text = Numero_prima.ToString("N0");
                Valor_prima_pol_txb.SelectionStart = Valor_prima_pol_txb.TextLength;
            }
        }

        private void Valor_prima_pol_txb_Load(object sender, EventArgs e)
        {
            // SI TRAE UN VALOR DESDE LA BASE LE DARA FORMATO
            if (Valor_prima_pol_txb.Text != "")
            {
                if (double.TryParse(Valor_prima_pol_txb.Text, out Numero_prima))
                {
                    Valor_prima_pol_txb.Text = Numero_prima.ToString("N0");
                    Valor_prima_pol_txb.SelectionStart = Valor_prima_pol_txb.TextLength;
                }
            }
        }
        // EVENTO QUE NOS CAMBIA EL PARENT DEL PAGE VEHICULO
        private void Tipo_de_poliza_dropdown_onItemSelected(object sender, EventArgs e)
        {
            if (Tipo_de_poliza_dropdown.selectedValue == "AUTOS")
            {
                Vehiculo_page.Parent = Control_tab;
            }
            else
            {
                Vehiculo_page.Parent = null;
            }
        }

        private void Añadir_pol_btn_Click(object sender, EventArgs e)
        {
            // INSERTAR
            Metodos.Añadir_Editar_Pol(Numero_Poliza,Aseguradoras_dropdown,Tipo_de_poliza_dropdown,Numero_poliza_txb,Fecha_inicial,Fecha_final,Valor_prima_pol_txb,Documento_tom_txb,Documento_ben_txb);
            if (Tipo_de_poliza_dropdown.selectedValue == "AUTOS")
            {
                Numero_poliza_txb.Enabled = false;
                Control_tab.SelectedTab = Vehiculo_page;
            }
            else
            {
                this.Close();
            }
        }

        private void Editar_pol_btn_Click(object sender, EventArgs e)
        {
            // EDITAR
            Metodos.Añadir_Editar_Pol(Numero_Poliza, Aseguradoras_dropdown, Tipo_de_poliza_dropdown, Numero_poliza_txb, Fecha_inicial, Fecha_final, Valor_prima_pol_txb, Documento_tom_txb, Documento_ben_txb);
            if (Tipo_de_poliza_dropdown.selectedValue == "AUTOS")
            {
                Control_tab.SelectedTab = Vehiculo_page;
            }
            else
            {
                this.Close();
            }
        }

        private void Añadir_veh_btn_Click(object sender, EventArgs e)
        {
            // INSERTAR
            Metodos.Añadir_Editar_Veh(Numero_Poliza,Numero_poliza_txb,Placa_txb,Modelo_txb,Fasecolda_txb,Servicio_txb,
                Clase_txb,Marca_txb,Valor_auto_txb,Fecha_soat);
            this.Close();
        }

        private void Editar_veh_btn_Click(object sender, EventArgs e)
        {
            // EDITAR
            Metodos.Añadir_Editar_Veh(Numero_Poliza, Numero_poliza_txb, Placa_txb, Modelo_txb, Fasecolda_txb, Servicio_txb,
                Clase_txb, Marca_txb, Valor_auto_txb, Fecha_soat);
            this.Close();
        }

        private void Valor_auto_txb_KeyUp(object sender, KeyEventArgs e)
        {
            // FORMATO AL TEXTO DEL VALOR
            if (Valor_auto_txb.Text != "")
            {
                if (double.TryParse(Valor_auto_txb.Text, out Valor_Auto))
                {
                    Valor_auto_txb.Text = Valor_Auto.ToString("N0");
                    Valor_auto_txb.SelectionStart = Valor_auto_txb.TextLength;
                }
            }
        }

        private void Valor_auto_txb_Load(object sender, EventArgs e)
        {
            // FORMATEANDO EL TEXTO TRAIDO DESDE LA DB
            if (Valor_auto_txb.Text != "")
            {
                if (double.TryParse(Valor_auto_txb.Text, out Valor_Auto))
                {
                    Valor_auto_txb.Text = Valor_Auto.ToString("N0");
                    Valor_auto_txb.SelectionStart = Valor_auto_txb.TextLength;
                }
            }
        }

        // LOAD DEL FORMULARIO
        private void Añadir_Editar_Eliminar_Formulario_Load(object sender, EventArgs e)
        {
            // VALIDACION CUANDO Y COMO TRAER LOS DATOS
            
            if (Cedula_tomador != null && Cedula_beneficiario != null)
            {
                if (Añadir_tom_btn.Visible == false && Añadir_ben_btn.Visible == false)
                {
                    Metodos.Llenar_Tomador_Edit(Cedula_tomador, Tip_Doc_Tom, Documento_tom_txb, Nombres_tom_txb, Apellidos_tom_txb, Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb, Fecha_tom);
                    Metodos.Llenar_Beneficiario_Edit(Cedula_beneficiario, Doc_Tip_Ben, Documento_ben_txb, Nombres_ben_txb, Apellidos_ben_txb,
                        Direccion_ben_txb, Telefono_ben_txb, Email_ben_txb, Fecha_ben);
                    Metodos.Llenar_Poliza_Edit(Numero_Poliza,Aseguradoras_dropdown,Tipo_de_poliza_dropdown, Numero_poliza_txb,
                        Fecha_inicial,Fecha_final,Valor_prima_pol_txb);
                    Metodos.Llenar_Vehiculo_Edit(Numero_Poliza, Placa_txb,Modelo_txb,Fasecolda_txb,Servicio_txb,Clase_txb,Marca_txb,Valor_auto_txb,Fecha_soat);
                }
                else
                {
                    if (MessageBox.Show("¿El registro pertenece al mismo cliente?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Metodos.Llenar_Tomador_Edit(Cedula_tomador, Tip_Doc_Tom, Documento_tom_txb, Nombres_tom_txb, Apellidos_tom_txb, Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb, Fecha_tom);
                        Metodos.Llenar_Beneficiario_Edit(Cedula_beneficiario, Doc_Tip_Ben, Documento_ben_txb, Nombres_ben_txb, Apellidos_ben_txb,
                        Direccion_ben_txb, Telefono_ben_txb, Email_ben_txb, Fecha_ben);
                    }
                    else
                    {
                        // TOMADOR
                        Cedula_tomador = null;
                        Tip_Doc_Tom.selectedIndex = 0;
                        Documento_tom_txb.Text = "";
                        Nombres_tom_txb.Text = "";
                        Apellidos_tom_txb.Text = "";
                        Direccion_tom_txb.Text = "";
                        Telefono_tom_txb.Text = "";
                        Email_tom_txb.Text = "";
                        Fecha_tom.Value = DateTime.Now;
                        // BENEFICIARIO
                        Cedula_beneficiario = null;
                        Doc_Tip_Ben.selectedIndex = 0;
                        Documento_ben_txb.Text = "";
                        Nombres_ben_txb.Text = "";
                        Apellidos_ben_txb.Text = "";
                        Direccion_ben_txb.Text = "";
                        Telefono_ben_txb.Text = "";
                        Email_ben_txb.Text = "";
                        Fecha_ben.Value = DateTime.Now;
                    }
                }
            }
        }

        private void Editar_ben_btn_Click(object sender, EventArgs e)
        {
            // Metodo para editar beneficiario
            Metodos.Añadir_Editar_Ben(Cedula_beneficiario, Doc_Tip_Ben, Documento_ben_txb, Nombres_ben_txb, Apellidos_ben_txb,
                Direccion_ben_txb, Telefono_ben_txb, Email_ben_txb, Fecha_ben);
            Control_tab.SelectedTab = Poliza_page;
        }

        private void Editar_tom_Click(object sender, EventArgs e)
        {
            // Iniciando metodo
            Metodos.Añadir_Editar_Tom(Cedula_tomador,Tip_Doc_Tom,Documento_tom_txb,Nombres_tom_txb,Apellidos_tom_txb,
                Direccion_tom_txb, Telefono_tom_txb, Email_tom_txb,Fecha_tom);
            Control_tab.SelectedTab = Beneficiario_page;
        }
    }
}
