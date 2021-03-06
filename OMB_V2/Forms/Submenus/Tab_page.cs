﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimtToo.VisualReactive;
using OMB_V2.Models;

namespace OMB_V2.Forms.Submenus
{
    public partial class Tab_page : UserControl
    {
        public Tab_page()
        {
            InitializeComponent();
            Hider_pnl.Height = 33;
            VSReactive<int>.Subscribe("menu",e=>tabControl1.SelectedIndex = e);
        }
        // Variables Llaves primarias
        Models.Metodos_diseño.Metodos_diseño Metodos = new Models.Metodos_diseño.Metodos_diseño();
        public void Paneles(Panel Receptor, BunifuAnimatorNS.BunifuTransition Animacion, Label Receptor_lbl) 
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Metodos.Llenar_panel(Receptor, new Bienvenida());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Pantalla de bienvenida";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                Metodos.Llenar_panel(Receptor, new Listado_polizas());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Polizas";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                Metodos.Llenar_panel(Receptor, new Listado_tomadores());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Tomadores";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                Metodos.Llenar_panel(Receptor, new Listado_beneficiarios());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Beneficiarios";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
            else if (tabControl1.SelectedIndex == 4)
            {
                Metodos.Llenar_panel(Receptor, new Listados_vehiculos());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Vehiculos";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else 
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
            else if (tabControl1.SelectedIndex == 5)
            {
                Metodos.Llenar_panel(Receptor, new Listado_vigencias_polizas());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Vigencias polizas";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else 
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
            else if (tabControl1.SelectedIndex == 6)
            {
                Metodos.Llenar_panel(Receptor, new Listado_vigencias_Soat());
                if (Receptor_lbl.Visible == true)
                {
                    Animacion.HideSync(Receptor_lbl);
                    Receptor_lbl.Text = "Vigencias SOAT";
                    Animacion.ShowSync(Receptor_lbl);
                }
                else 
                {
                    Animacion.ShowSync(Receptor_lbl);
                }
            }
        }
    }
}
