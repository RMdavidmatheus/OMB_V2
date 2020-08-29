namespace OMB_V2.Forms
{
    partial class Listado_vigencias_Soat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_vigencias_Soat));
            this.panel_content = new System.Windows.Forms.Panel();
            this.Dtg_Listado_vigencia_pol_so = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel_sup = new System.Windows.Forms.Panel();
            this.Reset_txt_btn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Texto_fecha_vig_pol = new System.Windows.Forms.Label();
            this.Fecha_mes_vig_pol_soat = new Bunifu.Framework.UI.BunifuDropdown();
            this.forma_dtg = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.forma_app = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_vigencia_pol_so)).BeginInit();
            this.panel_sup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.Dtg_Listado_vigencia_pol_so);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 209);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1352, 472);
            this.panel_content.TabIndex = 5;
            // 
            // Dtg_Listado_vigencia_pol_so
            // 
            this.Dtg_Listado_vigencia_pol_so.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol_so.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_Listado_vigencia_pol_so.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Listado_vigencia_pol_so.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Listado_vigencia_pol_so.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtg_Listado_vigencia_pol_so.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtg_Listado_vigencia_pol_so.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Listado_vigencia_pol_so.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtg_Listado_vigencia_pol_so.ColumnHeadersHeight = 40;
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.Name = null;
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_vigencia_pol_so.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtg_Listado_vigencia_pol_so.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtg_Listado_vigencia_pol_so.EnableHeadersVisualStyles = false;
            this.Dtg_Listado_vigencia_pol_so.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_vigencia_pol_so.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_vigencia_pol_so.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dtg_Listado_vigencia_pol_so.HeaderForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_vigencia_pol_so.Location = new System.Drawing.Point(13, 4);
            this.Dtg_Listado_vigencia_pol_so.Name = "Dtg_Listado_vigencia_pol_so";
            this.Dtg_Listado_vigencia_pol_so.ReadOnly = true;
            this.Dtg_Listado_vigencia_pol_so.RowHeadersVisible = false;
            this.Dtg_Listado_vigencia_pol_so.RowTemplate.Height = 40;
            this.Dtg_Listado_vigencia_pol_so.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Listado_vigencia_pol_so.Size = new System.Drawing.Size(1326, 457);
            this.Dtg_Listado_vigencia_pol_so.TabIndex = 10;
            this.Dtg_Listado_vigencia_pol_so.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.Dtg_Listado_vigencia_pol_so.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Dtg_Listado_vigencia_pol_so_CellFormatting);
            // 
            // panel_sup
            // 
            this.panel_sup.Controls.Add(this.Reset_txt_btn);
            this.panel_sup.Controls.Add(this.txt_search);
            this.panel_sup.Controls.Add(this.Texto_fecha_vig_pol);
            this.panel_sup.Controls.Add(this.Fecha_mes_vig_pol_soat);
            this.panel_sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sup.Location = new System.Drawing.Point(0, 0);
            this.panel_sup.Name = "panel_sup";
            this.panel_sup.Size = new System.Drawing.Size(1352, 209);
            this.panel_sup.TabIndex = 4;
            // 
            // Reset_txt_btn
            // 
            this.Reset_txt_btn.ActiveImage = null;
            this.Reset_txt_btn.AllowAnimations = true;
            this.Reset_txt_btn.AllowZooming = true;
            this.Reset_txt_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset_txt_btn.BackColor = System.Drawing.Color.Transparent;
            this.Reset_txt_btn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Reset_txt_btn.ErrorImage")));
            this.Reset_txt_btn.FadeWhenInactive = false;
            this.Reset_txt_btn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.Reset_txt_btn.Image = ((System.Drawing.Image)(resources.GetObject("Reset_txt_btn.Image")));
            this.Reset_txt_btn.ImageActive = null;
            this.Reset_txt_btn.ImageLocation = null;
            this.Reset_txt_btn.ImageMargin = 10;
            this.Reset_txt_btn.ImageSize = new System.Drawing.Size(21, 25);
            this.Reset_txt_btn.ImageZoomSize = new System.Drawing.Size(31, 35);
            this.Reset_txt_btn.InitialImage = ((System.Drawing.Image)(resources.GetObject("Reset_txt_btn.InitialImage")));
            this.Reset_txt_btn.Location = new System.Drawing.Point(1293, 12);
            this.Reset_txt_btn.Name = "Reset_txt_btn";
            this.Reset_txt_btn.Rotation = 0;
            this.Reset_txt_btn.ShowActiveImage = true;
            this.Reset_txt_btn.ShowCursorChanges = true;
            this.Reset_txt_btn.ShowImageBorders = true;
            this.Reset_txt_btn.ShowSizeMarkers = false;
            this.Reset_txt_btn.Size = new System.Drawing.Size(31, 35);
            this.Reset_txt_btn.TabIndex = 16;
            this.Reset_txt_btn.ToolTipText = "";
            this.Reset_txt_btn.WaitOnLoad = false;
            this.Reset_txt_btn.Zoom = 10;
            this.Reset_txt_btn.ZoomSpeed = 10;
            this.Reset_txt_btn.Click += new System.EventHandler(this.Reset_txt_btn_Click);
            // 
            // txt_search
            // 
            this.txt_search.AcceptsReturn = false;
            this.txt_search.AcceptsTab = false;
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_search.BackColor = System.Drawing.Color.White;
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
            this.txt_search.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_search.IconLeft")));
            this.txt_search.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_search.IconPadding = 6;
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
            this.txt_search.Size = new System.Drawing.Size(1273, 35);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txt_search.TabIndex = 15;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginLeft = 8;
            this.txt_search.TextPlaceholder = "Buscar...";
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // Texto_fecha_vig_pol
            // 
            this.Texto_fecha_vig_pol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Texto_fecha_vig_pol.AutoSize = true;
            this.Texto_fecha_vig_pol.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texto_fecha_vig_pol.Location = new System.Drawing.Point(873, 103);
            this.Texto_fecha_vig_pol.Name = "Texto_fecha_vig_pol";
            this.Texto_fecha_vig_pol.Size = new System.Drawing.Size(301, 45);
            this.Texto_fecha_vig_pol.TabIndex = 14;
            this.Texto_fecha_vig_pol.Text = "Seleccione una fecha";
            // 
            // Fecha_mes_vig_pol_soat
            // 
            this.Fecha_mes_vig_pol_soat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fecha_mes_vig_pol_soat.BackColor = System.Drawing.Color.Transparent;
            this.Fecha_mes_vig_pol_soat.BorderRadius = 3;
            this.Fecha_mes_vig_pol_soat.DisabledColor = System.Drawing.Color.Gray;
            this.Fecha_mes_vig_pol_soat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha_mes_vig_pol_soat.ForeColor = System.Drawing.Color.White;
            this.Fecha_mes_vig_pol_soat.items = new string[] {
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
            this.Fecha_mes_vig_pol_soat.Location = new System.Drawing.Point(14, 100);
            this.Fecha_mes_vig_pol_soat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Fecha_mes_vig_pol_soat.Name = "Fecha_mes_vig_pol_soat";
            this.Fecha_mes_vig_pol_soat.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Fecha_mes_vig_pol_soat.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.Fecha_mes_vig_pol_soat.selectedIndex = 0;
            this.Fecha_mes_vig_pol_soat.Size = new System.Drawing.Size(838, 52);
            this.Fecha_mes_vig_pol_soat.TabIndex = 13;
            this.Fecha_mes_vig_pol_soat.onItemSelected += new System.EventHandler(this.Fecha_mes_vig_pol_soat_onItemSelected);
            // 
            // forma_dtg
            // 
            this.forma_dtg.ElipseRadius = 20;
            this.forma_dtg.TargetControl = this.Dtg_Listado_vigencia_pol_so;
            // 
            // forma_app
            // 
            this.forma_app.ElipseRadius = 5;
            this.forma_app.TargetControl = this;
            // 
            // Listado_vigencias_Soat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 681);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_sup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_vigencias_Soat";
            this.Text = "Listado_vigencias_Soat";
            this.Load += new System.EventHandler(this.Listado_vigencias_Soat_Load);
            this.panel_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_vigencia_pol_so)).EndInit();
            this.panel_sup.ResumeLayout(false);
            this.panel_sup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Panel panel_sup;
        private Bunifu.Framework.UI.BunifuElipse forma_dtg;
        private Bunifu.Framework.UI.BunifuElipse forma_app;
        private System.Windows.Forms.Label Texto_fecha_vig_pol;
        private Bunifu.Framework.UI.BunifuDropdown Fecha_mes_vig_pol_soat;
        private Bunifu.UI.WinForms.BunifuDataGridView Dtg_Listado_vigencia_pol_so;
        private Bunifu.UI.WinForms.BunifuImageButton Reset_txt_btn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
    }
}