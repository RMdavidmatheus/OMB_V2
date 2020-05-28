namespace OMB_V2.Forms
{
    partial class Usuarios_gestion
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios_gestion));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Tab_selector_user = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Añadir_users = new System.Windows.Forms.TabPage();
            this.Pregunta_seguridad = new Bunifu.Framework.UI.BunifuDropdown();
            this.Eliminar_user_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Editar_user_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Añadir_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.OK_pass = new System.Windows.Forms.PictureBox();
            this.Error_pass = new System.Windows.Forms.PictureBox();
            this.Error_Email = new System.Windows.Forms.PictureBox();
            this.Ok_email = new System.Windows.Forms.PictureBox();
            this.Dtg_Listado_polizas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Conf_pass_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Conf_email_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Email_user_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Pass_user_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Respuesta_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Telefono_user_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Nombre_user_txb = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.Editar_roles = new System.Windows.Forms.TabPage();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Imagenes_slide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.materialTabControl1.SuspendLayout();
            this.Añadir_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OK_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ok_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_polizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Tab_selector_user
            // 
            this.Tab_selector_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_selector_user.BaseTabControl = this.materialTabControl1;
            this.Imagenes_slide.SetDecoration(this.Tab_selector_user, BunifuAnimatorNS.DecorationType.None);
            this.Tab_selector_user.Depth = 0;
            this.Tab_selector_user.Location = new System.Drawing.Point(0, 24);
            this.Tab_selector_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab_selector_user.Name = "Tab_selector_user";
            this.Tab_selector_user.Size = new System.Drawing.Size(1352, 56);
            this.Tab_selector_user.TabIndex = 0;
            this.Tab_selector_user.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.Añadir_users);
            this.materialTabControl1.Controls.Add(this.Editar_roles);
            this.Imagenes_slide.SetDecoration(this.materialTabControl1, BunifuAnimatorNS.DecorationType.None);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 86);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1352, 594);
            this.materialTabControl1.TabIndex = 1;
            // 
            // Añadir_users
            // 
            this.Añadir_users.Controls.Add(this.Pregunta_seguridad);
            this.Añadir_users.Controls.Add(this.Eliminar_user_btn);
            this.Añadir_users.Controls.Add(this.Editar_user_btn);
            this.Añadir_users.Controls.Add(this.Añadir_btn);
            this.Añadir_users.Controls.Add(this.OK_pass);
            this.Añadir_users.Controls.Add(this.Error_pass);
            this.Añadir_users.Controls.Add(this.Error_Email);
            this.Añadir_users.Controls.Add(this.Ok_email);
            this.Añadir_users.Controls.Add(this.Dtg_Listado_polizas);
            this.Añadir_users.Controls.Add(this.Conf_pass_txb);
            this.Añadir_users.Controls.Add(this.Conf_email_txb);
            this.Añadir_users.Controls.Add(this.pictureBox1);
            this.Añadir_users.Controls.Add(this.Email_user_txb);
            this.Añadir_users.Controls.Add(this.Pass_user_txb);
            this.Añadir_users.Controls.Add(this.Respuesta_txb);
            this.Añadir_users.Controls.Add(this.Telefono_user_txb);
            this.Añadir_users.Controls.Add(this.Nombre_user_txb);
            this.Imagenes_slide.SetDecoration(this.Añadir_users, BunifuAnimatorNS.DecorationType.None);
            this.Añadir_users.Location = new System.Drawing.Point(4, 22);
            this.Añadir_users.Name = "Añadir_users";
            this.Añadir_users.Padding = new System.Windows.Forms.Padding(3);
            this.Añadir_users.Size = new System.Drawing.Size(1344, 568);
            this.Añadir_users.TabIndex = 0;
            this.Añadir_users.Text = "Añadir usuarios";
            this.Añadir_users.UseVisualStyleBackColor = true;
            // 
            // Pregunta_seguridad
            // 
            this.Pregunta_seguridad.BackColor = System.Drawing.Color.Transparent;
            this.Pregunta_seguridad.BorderRadius = 3;
            this.Imagenes_slide.SetDecoration(this.Pregunta_seguridad, BunifuAnimatorNS.DecorationType.None);
            this.Pregunta_seguridad.DisabledColor = System.Drawing.Color.Gray;
            this.Pregunta_seguridad.ForeColor = System.Drawing.Color.White;
            this.Pregunta_seguridad.items = new string[] {
        "Colegio de su infancia",
        "Nombre de su familiar más querido",
        "Año de nacimiento",
        "Lugar donde realizo sus estudios"};
            this.Pregunta_seguridad.Location = new System.Drawing.Point(7, 462);
            this.Pregunta_seguridad.Name = "Pregunta_seguridad";
            this.Pregunta_seguridad.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Pregunta_seguridad.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Pregunta_seguridad.selectedIndex = 0;
            this.Pregunta_seguridad.Size = new System.Drawing.Size(297, 42);
            this.Pregunta_seguridad.TabIndex = 71;
            // 
            // Eliminar_user_btn
            // 
            this.Eliminar_user_btn.BackColor = System.Drawing.Color.Transparent;
            this.Eliminar_user_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar_user_btn.BackgroundImage")));
            this.Eliminar_user_btn.ButtonText = "Eliminar";
            this.Eliminar_user_btn.ButtonTextMarginLeft = 0;
            this.Imagenes_slide.SetDecoration(this.Eliminar_user_btn, BunifuAnimatorNS.DecorationType.None);
            this.Eliminar_user_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Eliminar_user_btn.DisabledFillColor = System.Drawing.Color.Gray;
            this.Eliminar_user_btn.DisabledForecolor = System.Drawing.Color.White;
            this.Eliminar_user_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_user_btn.ForeColor = System.Drawing.Color.White;
            this.Eliminar_user_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Eliminar_user_btn.IconPadding = 8;
            this.Eliminar_user_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Eliminar_user_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Eliminar_user_btn.IdleBorderRadius = 30;
            this.Eliminar_user_btn.IdleBorderThickness = 0;
            this.Eliminar_user_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Eliminar_user_btn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Eliminar_user_btn.IdleIconLeftImage")));
            this.Eliminar_user_btn.IdleIconRightImage = null;
            this.Eliminar_user_btn.Location = new System.Drawing.Point(642, 4);
            this.Eliminar_user_btn.Name = "Eliminar_user_btn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            stateProperties1.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties1.IconLeftImage")));
            stateProperties1.IconRightImage = null;
            this.Eliminar_user_btn.onHoverState = stateProperties1;
            this.Eliminar_user_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Eliminar_user_btn.Size = new System.Drawing.Size(139, 45);
            this.Eliminar_user_btn.TabIndex = 70;
            this.Eliminar_user_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Eliminar_user_btn.Click += new System.EventHandler(this.Eliminar_user_btn_Click);
            // 
            // Editar_user_btn
            // 
            this.Editar_user_btn.BackColor = System.Drawing.Color.Transparent;
            this.Editar_user_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Editar_user_btn.BackgroundImage")));
            this.Editar_user_btn.ButtonText = "Editar";
            this.Editar_user_btn.ButtonTextMarginLeft = 0;
            this.Imagenes_slide.SetDecoration(this.Editar_user_btn, BunifuAnimatorNS.DecorationType.None);
            this.Editar_user_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Editar_user_btn.DisabledFillColor = System.Drawing.Color.Gray;
            this.Editar_user_btn.DisabledForecolor = System.Drawing.Color.White;
            this.Editar_user_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar_user_btn.ForeColor = System.Drawing.Color.White;
            this.Editar_user_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Editar_user_btn.IconPadding = 8;
            this.Editar_user_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Editar_user_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Editar_user_btn.IdleBorderRadius = 30;
            this.Editar_user_btn.IdleBorderThickness = 0;
            this.Editar_user_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Editar_user_btn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Editar_user_btn.IdleIconLeftImage")));
            this.Editar_user_btn.IdleIconRightImage = null;
            this.Editar_user_btn.Location = new System.Drawing.Point(497, 4);
            this.Editar_user_btn.Name = "Editar_user_btn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(136)))));
            stateProperties2.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties2.IconLeftImage")));
            stateProperties2.IconRightImage = null;
            this.Editar_user_btn.onHoverState = stateProperties2;
            this.Editar_user_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Editar_user_btn.Size = new System.Drawing.Size(139, 45);
            this.Editar_user_btn.TabIndex = 69;
            this.Editar_user_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Editar_user_btn.Click += new System.EventHandler(this.Editar_user_btn_Click);
            // 
            // Añadir_btn
            // 
            this.Añadir_btn.BackColor = System.Drawing.Color.Transparent;
            this.Añadir_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Añadir_btn.BackgroundImage")));
            this.Añadir_btn.ButtonText = "Añadir";
            this.Añadir_btn.ButtonTextMarginLeft = 0;
            this.Imagenes_slide.SetDecoration(this.Añadir_btn, BunifuAnimatorNS.DecorationType.None);
            this.Añadir_btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Añadir_btn.DisabledFillColor = System.Drawing.Color.Gray;
            this.Añadir_btn.DisabledForecolor = System.Drawing.Color.White;
            this.Añadir_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadir_btn.ForeColor = System.Drawing.Color.White;
            this.Añadir_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Añadir_btn.IconPadding = 8;
            this.Añadir_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Añadir_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Añadir_btn.IdleBorderRadius = 30;
            this.Añadir_btn.IdleBorderThickness = 0;
            this.Añadir_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.Añadir_btn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("Añadir_btn.IdleIconLeftImage")));
            this.Añadir_btn.IdleIconRightImage = null;
            this.Añadir_btn.Location = new System.Drawing.Point(352, 4);
            this.Añadir_btn.Name = "Añadir_btn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            stateProperties3.BorderRadius = 30;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(64)))));
            stateProperties3.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties3.IconLeftImage")));
            stateProperties3.IconRightImage = null;
            this.Añadir_btn.onHoverState = stateProperties3;
            this.Añadir_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Añadir_btn.Size = new System.Drawing.Size(139, 45);
            this.Añadir_btn.TabIndex = 68;
            this.Añadir_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Añadir_btn.Click += new System.EventHandler(this.Añadir_btn_Click);
            // 
            // OK_pass
            // 
            this.Imagenes_slide.SetDecoration(this.OK_pass, BunifuAnimatorNS.DecorationType.None);
            this.OK_pass.Image = ((System.Drawing.Image)(resources.GetObject("OK_pass.Image")));
            this.OK_pass.Location = new System.Drawing.Point(315, 416);
            this.OK_pass.Name = "OK_pass";
            this.OK_pass.Size = new System.Drawing.Size(26, 28);
            this.OK_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OK_pass.TabIndex = 67;
            this.OK_pass.TabStop = false;
            // 
            // Error_pass
            // 
            this.Imagenes_slide.SetDecoration(this.Error_pass, BunifuAnimatorNS.DecorationType.None);
            this.Error_pass.Image = ((System.Drawing.Image)(resources.GetObject("Error_pass.Image")));
            this.Error_pass.Location = new System.Drawing.Point(315, 416);
            this.Error_pass.Name = "Error_pass";
            this.Error_pass.Size = new System.Drawing.Size(26, 28);
            this.Error_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error_pass.TabIndex = 66;
            this.Error_pass.TabStop = false;
            // 
            // Error_Email
            // 
            this.Imagenes_slide.SetDecoration(this.Error_Email, BunifuAnimatorNS.DecorationType.None);
            this.Error_Email.Image = ((System.Drawing.Image)(resources.GetObject("Error_Email.Image")));
            this.Error_Email.Location = new System.Drawing.Point(315, 322);
            this.Error_Email.Name = "Error_Email";
            this.Error_Email.Size = new System.Drawing.Size(26, 28);
            this.Error_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error_Email.TabIndex = 65;
            this.Error_Email.TabStop = false;
            // 
            // Ok_email
            // 
            this.Imagenes_slide.SetDecoration(this.Ok_email, BunifuAnimatorNS.DecorationType.None);
            this.Ok_email.Image = ((System.Drawing.Image)(resources.GetObject("Ok_email.Image")));
            this.Ok_email.Location = new System.Drawing.Point(315, 322);
            this.Ok_email.Name = "Ok_email";
            this.Ok_email.Size = new System.Drawing.Size(26, 28);
            this.Ok_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ok_email.TabIndex = 64;
            this.Ok_email.TabStop = false;
            // 
            // Dtg_Listado_polizas
            // 
            this.Dtg_Listado_polizas.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dtg_Listado_polizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtg_Listado_polizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtg_Listado_polizas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dtg_Listado_polizas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Dtg_Listado_polizas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dtg_Listado_polizas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.Imagenes_slide.SetDecoration(this.Dtg_Listado_polizas, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dtg_Listado_polizas.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dtg_Listado_polizas.EnableHeadersVisualStyles = false;
            this.Dtg_Listado_polizas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.Dtg_Listado_polizas.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.Dtg_Listado_polizas.HeaderBgColor = System.Drawing.Color.Empty;
            this.Dtg_Listado_polizas.HeaderForeColor = System.Drawing.Color.White;
            this.Dtg_Listado_polizas.Location = new System.Drawing.Point(352, 57);
            this.Dtg_Listado_polizas.MultiSelect = false;
            this.Dtg_Listado_polizas.Name = "Dtg_Listado_polizas";
            this.Dtg_Listado_polizas.ReadOnly = true;
            this.Dtg_Listado_polizas.RowHeadersVisible = false;
            this.Dtg_Listado_polizas.RowTemplate.Height = 40;
            this.Dtg_Listado_polizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtg_Listado_polizas.Size = new System.Drawing.Size(984, 504);
            this.Dtg_Listado_polizas.TabIndex = 62;
            this.Dtg_Listado_polizas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.Dtg_Listado_polizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtg_Listado_polizas_CellClick);
            // 
            // Conf_pass_txb
            // 
            this.Conf_pass_txb.AcceptsReturn = false;
            this.Conf_pass_txb.AcceptsTab = false;
            this.Conf_pass_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Conf_pass_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Conf_pass_txb.BackColor = System.Drawing.Color.White;
            this.Conf_pass_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Conf_pass_txb.BackgroundImage")));
            this.Conf_pass_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Conf_pass_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Conf_pass_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Conf_pass_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Conf_pass_txb.BorderRadius = 30;
            this.Conf_pass_txb.BorderThickness = 3;
            this.Conf_pass_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Conf_pass_txb, BunifuAnimatorNS.DecorationType.None);
            this.Conf_pass_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf_pass_txb.DefaultText = "";
            this.Conf_pass_txb.FillColor = System.Drawing.Color.White;
            this.Conf_pass_txb.HideSelection = true;
            this.Conf_pass_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Conf_pass_txb.IconLeft")));
            this.Conf_pass_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Conf_pass_txb.IconPadding = 10;
            this.Conf_pass_txb.IconRight = null;
            this.Conf_pass_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Conf_pass_txb.Location = new System.Drawing.Point(7, 411);
            this.Conf_pass_txb.MaxLength = 30;
            this.Conf_pass_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Conf_pass_txb.Modified = false;
            this.Conf_pass_txb.Name = "Conf_pass_txb";
            this.Conf_pass_txb.PasswordChar = '●';
            this.Conf_pass_txb.ReadOnly = false;
            this.Conf_pass_txb.SelectedText = "";
            this.Conf_pass_txb.SelectionLength = 0;
            this.Conf_pass_txb.SelectionStart = 0;
            this.Conf_pass_txb.ShortcutsEnabled = true;
            this.Conf_pass_txb.Size = new System.Drawing.Size(297, 41);
            this.Conf_pass_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Conf_pass_txb.TabIndex = 58;
            this.Conf_pass_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Conf_pass_txb.TextMarginLeft = 5;
            this.Conf_pass_txb.TextPlaceholder = "Verificar contraseña";
            this.Conf_pass_txb.UseSystemPasswordChar = true;
            this.Conf_pass_txb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Conf_pass_txb_KeyUp);
            // 
            // Conf_email_txb
            // 
            this.Conf_email_txb.AcceptsReturn = false;
            this.Conf_email_txb.AcceptsTab = false;
            this.Conf_email_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Conf_email_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Conf_email_txb.BackColor = System.Drawing.Color.White;
            this.Conf_email_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Conf_email_txb.BackgroundImage")));
            this.Conf_email_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Conf_email_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Conf_email_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Conf_email_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Conf_email_txb.BorderRadius = 30;
            this.Conf_email_txb.BorderThickness = 3;
            this.Conf_email_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Conf_email_txb, BunifuAnimatorNS.DecorationType.None);
            this.Conf_email_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conf_email_txb.DefaultText = "";
            this.Conf_email_txb.FillColor = System.Drawing.Color.White;
            this.Conf_email_txb.HideSelection = true;
            this.Conf_email_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Conf_email_txb.IconLeft")));
            this.Conf_email_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Conf_email_txb.IconPadding = 10;
            this.Conf_email_txb.IconRight = null;
            this.Conf_email_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Conf_email_txb.Location = new System.Drawing.Point(7, 317);
            this.Conf_email_txb.MaxLength = 30;
            this.Conf_email_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Conf_email_txb.Modified = false;
            this.Conf_email_txb.Name = "Conf_email_txb";
            this.Conf_email_txb.PasswordChar = '\0';
            this.Conf_email_txb.ReadOnly = false;
            this.Conf_email_txb.SelectedText = "";
            this.Conf_email_txb.SelectionLength = 0;
            this.Conf_email_txb.SelectionStart = 0;
            this.Conf_email_txb.ShortcutsEnabled = true;
            this.Conf_email_txb.Size = new System.Drawing.Size(297, 41);
            this.Conf_email_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Conf_email_txb.TabIndex = 57;
            this.Conf_email_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Conf_email_txb.TextMarginLeft = 5;
            this.Conf_email_txb.TextPlaceholder = "Verificar email";
            this.Conf_email_txb.UseSystemPasswordChar = false;
            this.Conf_email_txb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Conf_email_txb_KeyUp);
            // 
            // pictureBox1
            // 
            this.Imagenes_slide.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // Email_user_txb
            // 
            this.Email_user_txb.AcceptsReturn = false;
            this.Email_user_txb.AcceptsTab = false;
            this.Email_user_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Email_user_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Email_user_txb.BackColor = System.Drawing.Color.White;
            this.Email_user_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Email_user_txb.BackgroundImage")));
            this.Email_user_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Email_user_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Email_user_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Email_user_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Email_user_txb.BorderRadius = 30;
            this.Email_user_txb.BorderThickness = 3;
            this.Email_user_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Email_user_txb, BunifuAnimatorNS.DecorationType.None);
            this.Email_user_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_user_txb.DefaultText = "";
            this.Email_user_txb.FillColor = System.Drawing.Color.White;
            this.Email_user_txb.HideSelection = true;
            this.Email_user_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Email_user_txb.IconLeft")));
            this.Email_user_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Email_user_txb.IconPadding = 10;
            this.Email_user_txb.IconRight = null;
            this.Email_user_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Email_user_txb.Location = new System.Drawing.Point(7, 270);
            this.Email_user_txb.MaxLength = 30;
            this.Email_user_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Email_user_txb.Modified = false;
            this.Email_user_txb.Name = "Email_user_txb";
            this.Email_user_txb.PasswordChar = '\0';
            this.Email_user_txb.ReadOnly = false;
            this.Email_user_txb.SelectedText = "";
            this.Email_user_txb.SelectionLength = 0;
            this.Email_user_txb.SelectionStart = 0;
            this.Email_user_txb.ShortcutsEnabled = true;
            this.Email_user_txb.Size = new System.Drawing.Size(297, 41);
            this.Email_user_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Email_user_txb.TabIndex = 54;
            this.Email_user_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Email_user_txb.TextMarginLeft = 5;
            this.Email_user_txb.TextPlaceholder = "Email";
            this.Email_user_txb.UseSystemPasswordChar = false;
            this.Email_user_txb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Email_user_txb_KeyUp);
            // 
            // Pass_user_txb
            // 
            this.Pass_user_txb.AcceptsReturn = false;
            this.Pass_user_txb.AcceptsTab = false;
            this.Pass_user_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Pass_user_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Pass_user_txb.BackColor = System.Drawing.Color.White;
            this.Pass_user_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pass_user_txb.BackgroundImage")));
            this.Pass_user_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Pass_user_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Pass_user_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Pass_user_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Pass_user_txb.BorderRadius = 30;
            this.Pass_user_txb.BorderThickness = 3;
            this.Pass_user_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Pass_user_txb, BunifuAnimatorNS.DecorationType.None);
            this.Pass_user_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_user_txb.DefaultText = "";
            this.Pass_user_txb.FillColor = System.Drawing.Color.White;
            this.Pass_user_txb.HideSelection = true;
            this.Pass_user_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Pass_user_txb.IconLeft")));
            this.Pass_user_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Pass_user_txb.IconPadding = 10;
            this.Pass_user_txb.IconRight = null;
            this.Pass_user_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Pass_user_txb.Location = new System.Drawing.Point(9, 364);
            this.Pass_user_txb.MaxLength = 30;
            this.Pass_user_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Pass_user_txb.Modified = false;
            this.Pass_user_txb.Name = "Pass_user_txb";
            this.Pass_user_txb.PasswordChar = '●';
            this.Pass_user_txb.ReadOnly = false;
            this.Pass_user_txb.SelectedText = "";
            this.Pass_user_txb.SelectionLength = 0;
            this.Pass_user_txb.SelectionStart = 0;
            this.Pass_user_txb.ShortcutsEnabled = true;
            this.Pass_user_txb.Size = new System.Drawing.Size(295, 41);
            this.Pass_user_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Pass_user_txb.TabIndex = 53;
            this.Pass_user_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pass_user_txb.TextMarginLeft = 5;
            this.Pass_user_txb.TextPlaceholder = "Contraseña";
            this.Pass_user_txb.UseSystemPasswordChar = true;
            this.Pass_user_txb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pass_user_txb_KeyUp);
            // 
            // Respuesta_txb
            // 
            this.Respuesta_txb.AcceptsReturn = false;
            this.Respuesta_txb.AcceptsTab = false;
            this.Respuesta_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Respuesta_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Respuesta_txb.BackColor = System.Drawing.Color.White;
            this.Respuesta_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Respuesta_txb.BackgroundImage")));
            this.Respuesta_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Respuesta_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Respuesta_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Respuesta_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Respuesta_txb.BorderRadius = 30;
            this.Respuesta_txb.BorderThickness = 3;
            this.Respuesta_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Respuesta_txb, BunifuAnimatorNS.DecorationType.None);
            this.Respuesta_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta_txb.DefaultText = "";
            this.Respuesta_txb.FillColor = System.Drawing.Color.White;
            this.Respuesta_txb.HideSelection = true;
            this.Respuesta_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Respuesta_txb.IconLeft")));
            this.Respuesta_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Respuesta_txb.IconPadding = 10;
            this.Respuesta_txb.IconRight = null;
            this.Respuesta_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Respuesta_txb.Location = new System.Drawing.Point(9, 510);
            this.Respuesta_txb.MaxLength = 30;
            this.Respuesta_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Respuesta_txb.Modified = false;
            this.Respuesta_txb.Name = "Respuesta_txb";
            this.Respuesta_txb.PasswordChar = '\0';
            this.Respuesta_txb.ReadOnly = false;
            this.Respuesta_txb.SelectedText = "";
            this.Respuesta_txb.SelectionLength = 0;
            this.Respuesta_txb.SelectionStart = 0;
            this.Respuesta_txb.ShortcutsEnabled = true;
            this.Respuesta_txb.Size = new System.Drawing.Size(295, 41);
            this.Respuesta_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Respuesta_txb.TabIndex = 52;
            this.Respuesta_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Respuesta_txb.TextMarginLeft = 5;
            this.Respuesta_txb.TextPlaceholder = "Respuesta";
            this.Respuesta_txb.UseSystemPasswordChar = false;
            // 
            // Telefono_user_txb
            // 
            this.Telefono_user_txb.AcceptsReturn = false;
            this.Telefono_user_txb.AcceptsTab = false;
            this.Telefono_user_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Telefono_user_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Telefono_user_txb.BackColor = System.Drawing.Color.White;
            this.Telefono_user_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Telefono_user_txb.BackgroundImage")));
            this.Telefono_user_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Telefono_user_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Telefono_user_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Telefono_user_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Telefono_user_txb.BorderRadius = 30;
            this.Telefono_user_txb.BorderThickness = 3;
            this.Telefono_user_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Telefono_user_txb, BunifuAnimatorNS.DecorationType.None);
            this.Telefono_user_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_user_txb.DefaultText = "";
            this.Telefono_user_txb.FillColor = System.Drawing.Color.White;
            this.Telefono_user_txb.HideSelection = true;
            this.Telefono_user_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Telefono_user_txb.IconLeft")));
            this.Telefono_user_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Telefono_user_txb.IconPadding = 10;
            this.Telefono_user_txb.IconRight = null;
            this.Telefono_user_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Telefono_user_txb.Location = new System.Drawing.Point(7, 223);
            this.Telefono_user_txb.MaxLength = 30;
            this.Telefono_user_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Telefono_user_txb.Modified = false;
            this.Telefono_user_txb.Name = "Telefono_user_txb";
            this.Telefono_user_txb.PasswordChar = '\0';
            this.Telefono_user_txb.ReadOnly = false;
            this.Telefono_user_txb.SelectedText = "";
            this.Telefono_user_txb.SelectionLength = 0;
            this.Telefono_user_txb.SelectionStart = 0;
            this.Telefono_user_txb.ShortcutsEnabled = true;
            this.Telefono_user_txb.Size = new System.Drawing.Size(297, 41);
            this.Telefono_user_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Telefono_user_txb.TabIndex = 50;
            this.Telefono_user_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Telefono_user_txb.TextMarginLeft = 5;
            this.Telefono_user_txb.TextPlaceholder = "Teléfono";
            this.Telefono_user_txb.UseSystemPasswordChar = false;
            // 
            // Nombre_user_txb
            // 
            this.Nombre_user_txb.AcceptsReturn = false;
            this.Nombre_user_txb.AcceptsTab = false;
            this.Nombre_user_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Nombre_user_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Nombre_user_txb.BackColor = System.Drawing.Color.White;
            this.Nombre_user_txb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nombre_user_txb.BackgroundImage")));
            this.Nombre_user_txb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Nombre_user_txb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Nombre_user_txb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Nombre_user_txb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Nombre_user_txb.BorderRadius = 30;
            this.Nombre_user_txb.BorderThickness = 3;
            this.Nombre_user_txb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Imagenes_slide.SetDecoration(this.Nombre_user_txb, BunifuAnimatorNS.DecorationType.None);
            this.Nombre_user_txb.DefaultFont = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_user_txb.DefaultText = "";
            this.Nombre_user_txb.FillColor = System.Drawing.Color.White;
            this.Nombre_user_txb.HideSelection = true;
            this.Nombre_user_txb.IconLeft = ((System.Drawing.Image)(resources.GetObject("Nombre_user_txb.IconLeft")));
            this.Nombre_user_txb.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Nombre_user_txb.IconPadding = 10;
            this.Nombre_user_txb.IconRight = null;
            this.Nombre_user_txb.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Nombre_user_txb.Location = new System.Drawing.Point(7, 176);
            this.Nombre_user_txb.MaxLength = 30;
            this.Nombre_user_txb.MinimumSize = new System.Drawing.Size(100, 35);
            this.Nombre_user_txb.Modified = false;
            this.Nombre_user_txb.Name = "Nombre_user_txb";
            this.Nombre_user_txb.PasswordChar = '\0';
            this.Nombre_user_txb.ReadOnly = false;
            this.Nombre_user_txb.SelectedText = "";
            this.Nombre_user_txb.SelectionLength = 0;
            this.Nombre_user_txb.SelectionStart = 0;
            this.Nombre_user_txb.ShortcutsEnabled = true;
            this.Nombre_user_txb.Size = new System.Drawing.Size(297, 41);
            this.Nombre_user_txb.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.Nombre_user_txb.TabIndex = 49;
            this.Nombre_user_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Nombre_user_txb.TextMarginLeft = 5;
            this.Nombre_user_txb.TextPlaceholder = "Nombres";
            this.Nombre_user_txb.UseSystemPasswordChar = false;
            // 
            // Editar_roles
            // 
            this.Imagenes_slide.SetDecoration(this.Editar_roles, BunifuAnimatorNS.DecorationType.None);
            this.Editar_roles.Location = new System.Drawing.Point(4, 22);
            this.Editar_roles.Name = "Editar_roles";
            this.Editar_roles.Padding = new System.Windows.Forms.Padding(3);
            this.Editar_roles.Size = new System.Drawing.Size(1344, 568);
            this.Editar_roles.TabIndex = 1;
            this.Editar_roles.Text = "Editar roles";
            this.Editar_roles.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.Dtg_Listado_polizas;
            // 
            // Imagenes_slide
            // 
            this.Imagenes_slide.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Imagenes_slide.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Imagenes_slide.DefaultAnimation = animation1;
            this.Imagenes_slide.Interval = 8;
            // 
            // Usuarios_gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 681);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.Tab_selector_user);
            this.Imagenes_slide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Usuarios_gestion";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de usuarios";
            this.Load += new System.EventHandler(this.Usuarios_gestion_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Añadir_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OK_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ok_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Listado_polizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Añadir_users;
        private System.Windows.Forms.TabPage Editar_roles;
        private MaterialSkin.Controls.MaterialTabSelector Tab_selector_user;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Nombre_user_txb;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Conf_pass_txb;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Conf_email_txb;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Email_user_txb;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Pass_user_txb;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Respuesta_txb;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox Telefono_user_txb;
        private Bunifu.UI.WinForms.BunifuDataGridView Dtg_Listado_polizas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox OK_pass;
        private System.Windows.Forms.PictureBox Error_pass;
        private System.Windows.Forms.PictureBox Error_Email;
        private System.Windows.Forms.PictureBox Ok_email;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Eliminar_user_btn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Editar_user_btn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Añadir_btn;
        private BunifuAnimatorNS.BunifuTransition Imagenes_slide;
        public Bunifu.Framework.UI.BunifuDropdown Pregunta_seguridad;
    }
}