﻿namespace OMB_V2.Forms
{
    partial class Listado_beneficiarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_beneficiarios));
            this.Forma_app = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Dtg_Listado_beneficiarios = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Prueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_sup = new System.Windows.Forms.Panel();
            this.txt_user_edit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_bienvenida = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.User_image = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Forma_datagrid = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_beneficiarios)).BeginInit();
            this.panel_sup.SuspendLayout();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Forma_app
            // 
            this.Forma_app.ElipseRadius = 5;
            this.Forma_app.TargetControl = this;
            // 
            // Dtg_Listado_beneficiarios
            // 
            this.Dtg_Listado_beneficiarios.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_beneficiarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_Listado_beneficiarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Listado_beneficiarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Listado_beneficiarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtg_Listado_beneficiarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtg_Listado_beneficiarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Listado_beneficiarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dtg_Listado_beneficiarios.ColumnHeadersHeight = 40;
            this.Dtg_Listado_beneficiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prueba,
            this.nombre});
            this.Dtg_Listado_beneficiarios.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_beneficiarios.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_beneficiarios.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dtg_Listado_beneficiarios.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_beneficiarios.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_beneficiarios.CurrentTheme.Name = null;
            this.Dtg_Listado_beneficiarios.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Dtg_Listado_beneficiarios.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_beneficiarios.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.Dtg_Listado_beneficiarios.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtg_Listado_beneficiarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtg_Listado_beneficiarios.EnableHeadersVisualStyles = false;
            this.Dtg_Listado_beneficiarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_beneficiarios.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_beneficiarios.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dtg_Listado_beneficiarios.HeaderForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_beneficiarios.Location = new System.Drawing.Point(14, 215);
            this.Dtg_Listado_beneficiarios.Name = "Dtg_Listado_beneficiarios";
            this.Dtg_Listado_beneficiarios.ReadOnly = true;
            this.Dtg_Listado_beneficiarios.RowHeadersVisible = false;
            this.Dtg_Listado_beneficiarios.RowTemplate.Height = 40;
            this.Dtg_Listado_beneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Listado_beneficiarios.Size = new System.Drawing.Size(1326, 454);
            this.Dtg_Listado_beneficiarios.TabIndex = 9;
            this.Dtg_Listado_beneficiarios.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
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
            this.panel_sup.Controls.Add(this.txt_search);
            this.panel_sup.Controls.Add(this.txt_user_edit);
            this.panel_sup.Controls.Add(this.User_image);
            this.panel_sup.Controls.Add(this.txt_bienvenida);
            this.panel_sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_sup.Location = new System.Drawing.Point(0, 0);
            this.panel_sup.Name = "panel_sup";
            this.panel_sup.Size = new System.Drawing.Size(1352, 209);
            this.panel_sup.TabIndex = 2;
            // 
            // txt_user_edit
            // 
            this.txt_user_edit.AutoSize = true;
            this.txt_user_edit.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_user_edit.Location = new System.Drawing.Point(133, 127);
            this.txt_user_edit.Name = "txt_user_edit";
            this.txt_user_edit.Size = new System.Drawing.Size(428, 43);
            this.txt_user_edit.TabIndex = 13;
            this.txt_user_edit.Text = "David Alejandro Mateus Martinez";
            // 
            // txt_bienvenida
            // 
            this.txt_bienvenida.AutoSize = true;
            this.txt_bienvenida.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txt_bienvenida.Location = new System.Drawing.Point(133, 84);
            this.txt_bienvenida.Name = "txt_bienvenida";
            this.txt_bienvenida.Size = new System.Drawing.Size(165, 43);
            this.txt_bienvenida.TabIndex = 12;
            this.txt_bienvenida.Text = "¡Bienvenido!";
            // 
            // panel_content
            // 
            this.panel_content.Controls.Add(this.Dtg_Listado_beneficiarios);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(1352, 681);
            this.panel_content.TabIndex = 3;
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
            this.txt_search.Location = new System.Drawing.Point(12, 12);
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
            this.txt_search.Size = new System.Drawing.Size(1328, 35);
            this.txt_search.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_search.TabIndex = 10;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginLeft = 8;
            this.txt_search.TextPlaceholder = "Buscar...";
            this.txt_search.UseSystemPasswordChar = false;
            // 
            // User_image
            // 
            this.User_image.AllowFocused = false;
            this.User_image.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.User_image.BorderRadius = 57;
            this.User_image.Image = ((System.Drawing.Image)(resources.GetObject("User_image.Image")));
            this.User_image.IsCircle = true;
            this.User_image.Location = new System.Drawing.Point(12, 70);
            this.User_image.Name = "User_image";
            this.User_image.Size = new System.Drawing.Size(115, 115);
            this.User_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_image.TabIndex = 11;
            this.User_image.TabStop = false;
            this.User_image.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // Forma_datagrid
            // 
            this.Forma_datagrid.ElipseRadius = 20;
            this.Forma_datagrid.TargetControl = this.Dtg_Listado_beneficiarios;
            // 
            // Listado_beneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 681);
            this.Controls.Add(this.panel_sup);
            this.Controls.Add(this.panel_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_beneficiarios";
            this.Text = "Listado_beneficiarios";
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_beneficiarios)).EndInit();
            this.panel_sup.ResumeLayout(false);
            this.panel_sup.PerformLayout();
            this.panel_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Forma_app;
        private System.Windows.Forms.Panel panel_sup;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_user_edit;
        private Bunifu.UI.WinForms.BunifuPictureBox User_image;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_bienvenida;
        private System.Windows.Forms.Panel panel_content;
        private Bunifu.UI.WinForms.BunifuDataGridView Dtg_Listado_beneficiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private Bunifu.Framework.UI.BunifuElipse Forma_datagrid;
    }
}