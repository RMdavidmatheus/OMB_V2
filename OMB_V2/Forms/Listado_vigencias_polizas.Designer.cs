﻿namespace OMB_V2.Forms
{
    partial class Listado_vigencias_polizas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_vigencias_polizas));
            this.panel_content = new System.Windows.Forms.Panel();
            this.Dtg_Listado_vigencia_pol = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_sup = new System.Windows.Forms.Panel();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.forma_app = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.forma_dtg = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Fecha_mes_vig_pol = new Bunifu.Framework.UI.BunifuDropdown();
            this.Forma = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Texto_fecha_vig_pol = new System.Windows.Forms.Label();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_vigencia_pol)).BeginInit();
            this.panel_sup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.Dtg_Listado_vigencia_pol);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 209);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1352, 472);
            this.panel_content.TabIndex = 3;
            // 
            // Dtg_Listado_vigencia_pol
            // 
            this.Dtg_Listado_vigencia_pol.AllowCustomTheming = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.Dtg_Listado_vigencia_pol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Listado_vigencia_pol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Listado_vigencia_pol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtg_Listado_vigencia_pol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtg_Listado_vigencia_pol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Listado_vigencia_pol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Dtg_Listado_vigencia_pol.ColumnHeadersHeight = 40;
            this.Dtg_Listado_vigencia_pol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prueba});
            this.Dtg_Listado_vigencia_pol.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_vigencia_pol.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dtg_Listado_vigencia_pol.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_vigencia_pol.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol.CurrentTheme.Name = null;
            this.Dtg_Listado_vigencia_pol.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_vigencia_pol.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_vigencia_pol.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtg_Listado_vigencia_pol.DefaultCellStyle = dataGridViewCellStyle15;
            this.Dtg_Listado_vigencia_pol.EnableHeadersVisualStyles = false;
            this.Dtg_Listado_vigencia_pol.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_vigencia_pol.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_vigencia_pol.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dtg_Listado_vigencia_pol.HeaderForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol.Location = new System.Drawing.Point(14, 3);
            this.Dtg_Listado_vigencia_pol.Name = "Dtg_Listado_vigencia_pol";
            this.Dtg_Listado_vigencia_pol.ReadOnly = true;
            this.Dtg_Listado_vigencia_pol.RowHeadersVisible = false;
            this.Dtg_Listado_vigencia_pol.RowTemplate.Height = 40;
            this.Dtg_Listado_vigencia_pol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Listado_vigencia_pol.Size = new System.Drawing.Size(1326, 457);
            this.Dtg_Listado_vigencia_pol.TabIndex = 9;
            this.Dtg_Listado_vigencia_pol.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // prueba
            // 
            this.prueba.HeaderText = "prueba";
            this.prueba.Name = "prueba";
            this.prueba.ReadOnly = true;
            // 
            // panel_sup
            // 
            this.panel_sup.Controls.Add(this.Texto_fecha_vig_pol);
            this.panel_sup.Controls.Add(this.Fecha_mes_vig_pol);
            this.panel_sup.Controls.Add(this.txt_search);
            this.panel_sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sup.Location = new System.Drawing.Point(0, 0);
            this.panel_sup.Name = "panel_sup";
            this.panel_sup.Size = new System.Drawing.Size(1352, 209);
            this.panel_sup.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.AcceptsReturn = false;
            this.txt_search.AcceptsTab = false;
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_search.BackgroundImage")));
            this.txt_search.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(143)))));
            this.txt_search.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_search.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.txt_search.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_search.BorderRadius = 5;
            this.txt_search.BorderThickness = 2;
            this.txt_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_search.DefaultFont = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.DefaultText = "";
            this.txt_search.FillColor = System.Drawing.Color.White;
            this.txt_search.HideSelection = true;
            this.txt_search.IconLeft = null;
            this.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_search.IconPadding = 10;
            this.txt_search.IconRight = null;
            this.txt_search.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_search.Location = new System.Drawing.Point(14, 12);
            this.txt_search.MaxLength = 32767;
            this.txt_search.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_search.Modified = false;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.ReadOnly = false;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(1326, 35);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 10;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginLeft = 8;
            this.txt_search.TextPlaceholder = "Buscar...";
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // forma_app
            // 
            this.forma_app.ElipseRadius = 5;
            this.forma_app.TargetControl = this;
            // 
            // forma_dtg
            // 
            this.forma_dtg.ElipseRadius = 20;
            this.forma_dtg.TargetControl = this.Dtg_Listado_vigencia_pol;
            // 
            // Fecha_mes_vig_pol
            // 
            this.Fecha_mes_vig_pol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha_mes_vig_pol.BackColor = System.Drawing.Color.Transparent;
            this.Fecha_mes_vig_pol.BorderRadius = 3;
            this.Fecha_mes_vig_pol.DisabledColor = System.Drawing.Color.Gray;
            this.Fecha_mes_vig_pol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_mes_vig_pol.ForeColor = System.Drawing.Color.White;
            this.Fecha_mes_vig_pol.items = new string[] {
        "ENERO",
        "FEBRERO",
        "MARZO",
        "ABRIL",
        "MAYO",
        "JUNIO",
        "JULIO",
        "AGOSTO",
        "SEPTIEMBRE",
        "OCTUBRE",
        "NOVIEMBRE",
        "DICIEMBRE"};
            this.Fecha_mes_vig_pol.Location = new System.Drawing.Point(14, 100);
            this.Fecha_mes_vig_pol.Name = "Fecha_mes_vig_pol";
            this.Fecha_mes_vig_pol.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Fecha_mes_vig_pol.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Fecha_mes_vig_pol.selectedIndex = 0;
            this.Fecha_mes_vig_pol.Size = new System.Drawing.Size(838, 52);
            this.Fecha_mes_vig_pol.TabIndex = 11;
            // 
            // Forma
            // 
            this.Forma.ElipseRadius = 18;
            this.Forma.TargetControl = this.Fecha_mes_vig_pol;
            // 
            // Texto_fecha_vig_pol
            // 
            this.Texto_fecha_vig_pol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Texto_fecha_vig_pol.AutoSize = true;
            this.Texto_fecha_vig_pol.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_fecha_vig_pol.Location = new System.Drawing.Point(873, 103);
            this.Texto_fecha_vig_pol.Name = "Texto_fecha_vig_pol";
            this.Texto_fecha_vig_pol.Size = new System.Drawing.Size(301, 45);
            this.Texto_fecha_vig_pol.TabIndex = 12;
            this.Texto_fecha_vig_pol.Text = "Seleccione una fecha";
            // 
            // Listado_vigencias_polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 681);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_vigencias_polizas";
            this.Text = "Listado_vigencias_polizas";
            this.panel_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_vigencia_pol)).EndInit();
            this.panel_sup.ResumeLayout(false);
            this.panel_sup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_content;
        private Bunifu.UI.WinForms.BunifuDataGridView Dtg_Listado_vigencia_pol;
        private System.Windows.Forms.Panel panel_sup;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
        private Bunifu.Framework.UI.BunifuElipse forma_app;
        private Bunifu.Framework.UI.BunifuElipse forma_dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn prueba;
        private Bunifu.Framework.UI.BunifuDropdown Fecha_mes_vig_pol;
        private Bunifu.Framework.UI.BunifuElipse Forma;
        private System.Windows.Forms.Label Texto_fecha_vig_pol;
    }
}