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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado_polizas));
            this.panel_content = new System.Windows.Forms.Panel();
            this.Dtg_Listado_polizas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel_sup = new System.Windows.Forms.Panel();
            this.txt_user_edit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_bienvenida = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.User_image = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txt_search = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dtg_Listado_polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Listado_polizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Listado_polizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtg_Listado_polizas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtg_Listado_polizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Listado_polizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Dtg_Listado_polizas.ColumnHeadersHeight = 40;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtg_Listado_polizas.DefaultCellStyle = dataGridViewCellStyle6;
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
            // panel_sup
            // 
            this.panel_sup.BackColor = System.Drawing.SystemColors.Control;
            this.panel_sup.Controls.Add(this.txt_user_edit);
            this.panel_sup.Controls.Add(this.txt_bienvenida);
            this.panel_sup.Controls.Add(this.User_image);
            this.panel_sup.Controls.Add(this.txt_search);
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
            this.txt_user_edit.Location = new System.Drawing.Point(139, 116);
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
            this.txt_bienvenida.Location = new System.Drawing.Point(139, 73);
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
            this.User_image.Location = new System.Drawing.Point(18, 59);
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
            this.txt_search.TabIndex = 5;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search.TextMarginLeft = 8;
            this.txt_search.TextPlaceholder = "Buscar...";
            this.txt_search.UseSystemPasswordChar = false;
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
            this.Load += new System.EventHandler(this.Listado_polizas_Load);
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
        private System.Windows.Forms.Panel panel_sup;
        private Bunifu.Framework.UI.BunifuElipse Forma_ventana;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_search;
        private Bunifu.UI.WinForms.BunifuPictureBox User_image;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_bienvenida;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_user_edit;
        private Bunifu.Framework.UI.BunifuElipse forma_grid;
    }
}