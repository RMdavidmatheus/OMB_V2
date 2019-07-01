namespace OMB_V2.Forms
{
    partial class Listado_polizas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_polizas));
            this.panel_content = new System.Windows.Forms.Panel();
            this.Dtg_Listado_polizas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_sup = new System.Windows.Forms.Panel();
            this.txt_user_edit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_bienvenida = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.User_image = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btn_edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_añadir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Forma_ventana = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.forma_grid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_polizas)).BeginInit();
            this.panel_sup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.SystemColors.Control;
            this.panel_content.Controls.Add(this.Dtg_Listado_polizas);
            this.panel_content.Controls.Add(this.panel_sup);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1352, 681);
            this.panel_content.TabIndex = 0;
            // 
            // Dtg_Listado_polizas
            // 
            this.Dtg_Listado_polizas.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dtg_Listado_polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Listado_polizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Listado_polizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtg_Listado_polizas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtg_Listado_polizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Listado_polizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Dtg_Listado_polizas.ColumnHeadersHeight = 40;
            this.Dtg_Listado_polizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba,
            this.nombre});
            this.Dtg_Listado_polizas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Dtg_Listado_polizas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_polizas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_polizas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dtg_Listado_polizas.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_polizas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_polizas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_polizas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_polizas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.CurrentTheme.Name = null;
            this.Dtg_Listado_polizas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Dtg_Listado_polizas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_polizas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_polizas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtg_Listado_polizas.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dtg_Listado_polizas.EnableHeadersVisualStyles = false;
            this.Dtg_Listado_polizas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_polizas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_polizas.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dtg_Listado_polizas.HeaderForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.Location = new System.Drawing.Point(14, 201);
            this.Dtg_Listado_polizas.Name = "Dtg_Listado_polizas";
            this.Dtg_Listado_polizas.ReadOnly = true;
            this.Dtg_Listado_polizas.RowHeadersVisible = false;
            this.Dtg_Listado_polizas.RowTemplate.Height = 40;
            this.Dtg_Listado_polizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Listado_polizas.Size = new System.Drawing.Size(1326, 468);
            this.Dtg_Listado_polizas.TabIndex = 2;
            this.Dtg_Listado_polizas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // Prueba
            // 
            this.Prueba.HeaderText = "Prueba";
            this.Prueba.Name = "Prueba";
            this.Prueba.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // panel_sup
            // 
            this.panel_sup.BackColor = System.Drawing.SystemColors.Control;
            this.panel_sup.Controls.Add(this.txt_user_edit);
            this.panel_sup.Controls.Add(this.txt_bienvenida);
            this.panel_sup.Controls.Add(this.User_image);
            this.panel_sup.Controls.Add(this.txt_search);
            this.panel_sup.Controls.Add(this.btn_edit);
            this.panel_sup.Controls.Add(this.btn_añadir);
            this.panel_sup.Controls.Add(this.btn_delete);
            this.panel_sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sup.Location = new System.Drawing.Point(0, 0);
            this.panel_sup.Name = "panel_sup";
            this.panel_sup.Size = new System.Drawing.Size(1352, 195);
            this.panel_sup.TabIndex = 0;
            // 
            // txt_user_edit
            // 
            this.txt_user_edit.AutoSize = true;
            this.txt_user_edit.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_user_edit.Location = new System.Drawing.Point(343, 125);
            this.txt_user_edit.Name = "txt_user_edit";
            this.txt_user_edit.Size = new System.Drawing.Size(428, 43);
            this.txt_user_edit.TabIndex = 8;
            this.txt_user_edit.Text = "David Alejandro Mateus Martinez";
            // 
            // txt_bienvenida
            // 
            this.txt_bienvenida.AutoSize = true;
            this.txt_bienvenida.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_bienvenida.Location = new System.Drawing.Point(343, 82);
            this.txt_bienvenida.Name = "txt_bienvenida";
            this.txt_bienvenida.Size = new System.Drawing.Size(165, 43);
            this.txt_bienvenida.TabIndex = 7;
            this.txt_bienvenida.Text = "¡Bienvenido!";
            // 
            // User_image
            // 
            this.User_image.AllowFocused = false;
            this.User_image.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.User_image.BorderRadius = 57;
            this.User_image.Image = ((System.Drawing.Image)(resources.GetObject("User_image.Image")));
            this.User_image.IsCircle = true;
            this.User_image.Location = new System.Drawing.Point(222, 68);
            this.User_image.Name = "User_image";
            this.User_image.Size = new System.Drawing.Size(115, 115);
            this.User_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_image.TabIndex = 6;
            this.User_image.TabStop = false;
            this.User_image.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
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
            this.txt_search.Location = new System.Drawing.Point(225, 20);
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
            this.txt_search.Size = new System.Drawing.Size(1105, 35);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 5;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginLeft = 8;
            this.txt_search.TextPlaceholder = "Buscar...";
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // btn_edit
            // 
            this.btn_edit.ActiveBorderThickness = 1;
            this.btn_edit.ActiveCornerRadius = 20;
            this.btn_edit.ActiveFillColor = System.Drawing.Color.White;
            this.btn_edit.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_edit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_edit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.ButtonText = "Editar";
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_edit.IdleBorderThickness = 1;
            this.btn_edit.IdleCornerRadius = 20;
            this.btn_edit.IdleFillColor = System.Drawing.Color.White;
            this.btn_edit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_edit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_edit.Location = new System.Drawing.Point(14, 71);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(187, 53);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_añadir
            // 
            this.btn_añadir.ActiveBorderThickness = 1;
            this.btn_añadir.ActiveCornerRadius = 20;
            this.btn_añadir.ActiveFillColor = System.Drawing.Color.White;
            this.btn_añadir.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(88)))));
            this.btn_añadir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(88)))));
            this.btn_añadir.BackColor = System.Drawing.SystemColors.Control;
            this.btn_añadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_añadir.BackgroundImage")));
            this.btn_añadir.ButtonText = "Añadir";
            this.btn_añadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_añadir.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_añadir.IdleBorderThickness = 1;
            this.btn_añadir.IdleCornerRadius = 20;
            this.btn_añadir.IdleFillColor = System.Drawing.Color.White;
            this.btn_añadir.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_añadir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_añadir.Location = new System.Drawing.Point(14, 8);
            this.btn_añadir.Margin = new System.Windows.Forms.Padding(5);
            this.btn_añadir.Name = "btn_añadir";
            this.btn_añadir.Size = new System.Drawing.Size(187, 53);
            this.btn_añadir.TabIndex = 3;
            this.btn_añadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveBorderThickness = 1;
            this.btn_delete.ActiveCornerRadius = 20;
            this.btn_delete.ActiveFillColor = System.Drawing.Color.White;
            this.btn_delete.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.btn_delete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.ButtonText = "Eliminar";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleCornerRadius = 20;
            this.btn_delete.IdleFillColor = System.Drawing.Color.White;
            this.btn_delete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_delete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_delete.Location = new System.Drawing.Point(14, 134);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(187, 53);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Forma_ventana
            // 
            this.Forma_ventana.ElipseRadius = 5;
            this.Forma_ventana.TargetControl = this;
            // 
            // forma_grid
            // 
            this.forma_grid.ElipseRadius = 20;
            this.forma_grid.TargetControl = this.Dtg_Listado_polizas;
            // 
            // Listado_polizas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1352, 681);
            this.Controls.Add(this.panel_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_polizas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_polizas";
            this.panel_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_polizas)).EndInit();
            this.panel_sup.ResumeLayout(false);
            this.panel_sup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_content;
        private Bunifu.UI.WinForms.BunifuDataGridView Dtg_Listado_polizas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Panel panel_sup;
        private Bunifu.Framework.UI.BunifuElipse Forma_ventana;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_delete;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_edit;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_añadir;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
        private Bunifu.UI.WinForms.BunifuPictureBox User_image;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_bienvenida;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_user_edit;
        private Bunifu.Framework.UI.BunifuElipse forma_grid;
    }
}