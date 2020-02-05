namespace OMB_V2.Forms
{
    partial class Añadir_Editar_Eliminar_Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Añadir_Editar_Eliminar_Formulario));
            this.Control_tab = new MaterialSkin.Controls.MaterialTabControl();
            this.Tomador_page = new System.Windows.Forms.TabPage();
            this.Añadir_tom_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Fecha_tom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Email_tom_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Telefono_tom_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Direccion_tom_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Apellidos_tom_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Nombres_tom_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Documento_tom_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tip_Doc_Tom = new Bunifu.Framework.UI.BunifuDropdown();
            this.Beneficiario_page = new System.Windows.Forms.TabPage();
            this.Añadir_ben_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Fecha_ben = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Email_ben_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Telefono_ben_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Direccion_ben_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Apellidos_ben_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Nombres_ben_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Documento_ben_txb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Doc_Tip_Ben = new Bunifu.Framework.UI.BunifuDropdown();
            this.Poliza_page = new System.Windows.Forms.TabPage();
            this.Vehiculo_page = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.Forma = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Control_tab.SuspendLayout();
            this.Tomador_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Beneficiario_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Control_tab
            // 
            this.Control_tab.Controls.Add(this.Tomador_page);
            this.Control_tab.Controls.Add(this.Beneficiario_page);
            this.Control_tab.Controls.Add(this.Poliza_page);
            this.Control_tab.Controls.Add(this.Vehiculo_page);
            this.Control_tab.Depth = 0;
            this.Control_tab.Location = new System.Drawing.Point(3, 109);
            this.Control_tab.MouseState = MaterialSkin.MouseState.HOVER;
            this.Control_tab.Name = "Control_tab";
            this.Control_tab.SelectedIndex = 0;
            this.Control_tab.Size = new System.Drawing.Size(546, 697);
            this.Control_tab.TabIndex = 1;
            // 
            // Tomador_page
            // 
            this.Tomador_page.BackColor = System.Drawing.Color.White;
            this.Tomador_page.Controls.Add(this.Añadir_tom_btn);
            this.Tomador_page.Controls.Add(this.label1);
            this.Tomador_page.Controls.Add(this.Fecha_tom);
            this.Tomador_page.Controls.Add(this.Email_tom_txb);
            this.Tomador_page.Controls.Add(this.Telefono_tom_txb);
            this.Tomador_page.Controls.Add(this.Direccion_tom_txb);
            this.Tomador_page.Controls.Add(this.Apellidos_tom_txb);
            this.Tomador_page.Controls.Add(this.Nombres_tom_txb);
            this.Tomador_page.Controls.Add(this.Documento_tom_txb);
            this.Tomador_page.Controls.Add(this.pictureBox1);
            this.Tomador_page.Controls.Add(this.Tip_Doc_Tom);
            this.Tomador_page.Location = new System.Drawing.Point(4, 22);
            this.Tomador_page.Name = "Tomador_page";
            this.Tomador_page.Padding = new System.Windows.Forms.Padding(3);
            this.Tomador_page.Size = new System.Drawing.Size(538, 671);
            this.Tomador_page.TabIndex = 0;
            this.Tomador_page.Text = "Tomador";
            // 
            // Añadir_tom_btn
            // 
            this.Añadir_tom_btn.AutoEllipsis = true;
            this.Añadir_tom_btn.Depth = 0;
            this.Añadir_tom_btn.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadir_tom_btn.Image = ((System.Drawing.Image)(resources.GetObject("Añadir_tom_btn.Image")));
            this.Añadir_tom_btn.Location = new System.Drawing.Point(56, 607);
            this.Añadir_tom_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Añadir_tom_btn.Name = "Añadir_tom_btn";
            this.Añadir_tom_btn.Primary = true;
            this.Añadir_tom_btn.Size = new System.Drawing.Size(421, 52);
            this.Añadir_tom_btn.TabIndex = 12;
            this.Añadir_tom_btn.Text = "Añadir";
            this.Añadir_tom_btn.UseVisualStyleBackColor = true;
            this.Añadir_tom_btn.Click += new System.EventHandler(this.Añadir_tom_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // Fecha_tom
            // 
            this.Fecha_tom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Fecha_tom.BorderRadius = 0;
            this.Fecha_tom.ForeColor = System.Drawing.Color.White;
            this.Fecha_tom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_tom.FormatCustom = "";
            this.Fecha_tom.Location = new System.Drawing.Point(18, 528);
            this.Fecha_tom.Name = "Fecha_tom";
            this.Fecha_tom.Size = new System.Drawing.Size(244, 42);
            this.Fecha_tom.TabIndex = 10;
            this.Fecha_tom.Value = new System.DateTime(2020, 2, 2, 19, 53, 32, 0);
            // 
            // Email_tom_txb
            // 
            this.Email_tom_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Email_tom_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Email_tom_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email_tom_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_tom_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_tom_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_tom_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Email_tom_txb.HintText = "Email";
            this.Email_tom_txb.isPassword = false;
            this.Email_tom_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Email_tom_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Email_tom_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Email_tom_txb.LineThickness = 2;
            this.Email_tom_txb.Location = new System.Drawing.Point(19, 481);
            this.Email_tom_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Email_tom_txb.MaxLength = 32767;
            this.Email_tom_txb.Name = "Email_tom_txb";
            this.Email_tom_txb.Size = new System.Drawing.Size(495, 40);
            this.Email_tom_txb.TabIndex = 7;
            this.Email_tom_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Telefono_tom_txb
            // 
            this.Telefono_tom_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Telefono_tom_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Telefono_tom_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Telefono_tom_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Telefono_tom_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_tom_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telefono_tom_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Telefono_tom_txb.HintText = "Teléfono";
            this.Telefono_tom_txb.isPassword = false;
            this.Telefono_tom_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Telefono_tom_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Telefono_tom_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Telefono_tom_txb.LineThickness = 2;
            this.Telefono_tom_txb.Location = new System.Drawing.Point(19, 433);
            this.Telefono_tom_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Telefono_tom_txb.MaxLength = 32767;
            this.Telefono_tom_txb.Name = "Telefono_tom_txb";
            this.Telefono_tom_txb.Size = new System.Drawing.Size(495, 40);
            this.Telefono_tom_txb.TabIndex = 6;
            this.Telefono_tom_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Direccion_tom_txb
            // 
            this.Direccion_tom_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Direccion_tom_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Direccion_tom_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Direccion_tom_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Direccion_tom_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion_tom_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Direccion_tom_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Direccion_tom_txb.HintText = "Dirección";
            this.Direccion_tom_txb.isPassword = false;
            this.Direccion_tom_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Direccion_tom_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Direccion_tom_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Direccion_tom_txb.LineThickness = 2;
            this.Direccion_tom_txb.Location = new System.Drawing.Point(18, 385);
            this.Direccion_tom_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Direccion_tom_txb.MaxLength = 32767;
            this.Direccion_tom_txb.Name = "Direccion_tom_txb";
            this.Direccion_tom_txb.Size = new System.Drawing.Size(495, 40);
            this.Direccion_tom_txb.TabIndex = 5;
            this.Direccion_tom_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Apellidos_tom_txb
            // 
            this.Apellidos_tom_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Apellidos_tom_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Apellidos_tom_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Apellidos_tom_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Apellidos_tom_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos_tom_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Apellidos_tom_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Apellidos_tom_txb.HintText = "Apellidos";
            this.Apellidos_tom_txb.isPassword = false;
            this.Apellidos_tom_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Apellidos_tom_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Apellidos_tom_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Apellidos_tom_txb.LineThickness = 2;
            this.Apellidos_tom_txb.Location = new System.Drawing.Point(18, 337);
            this.Apellidos_tom_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Apellidos_tom_txb.MaxLength = 32767;
            this.Apellidos_tom_txb.Name = "Apellidos_tom_txb";
            this.Apellidos_tom_txb.Size = new System.Drawing.Size(495, 40);
            this.Apellidos_tom_txb.TabIndex = 4;
            this.Apellidos_tom_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Nombres_tom_txb
            // 
            this.Nombres_tom_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Nombres_tom_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Nombres_tom_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Nombres_tom_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombres_tom_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres_tom_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nombres_tom_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Nombres_tom_txb.HintText = "Nombres";
            this.Nombres_tom_txb.isPassword = false;
            this.Nombres_tom_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Nombres_tom_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Nombres_tom_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Nombres_tom_txb.LineThickness = 2;
            this.Nombres_tom_txb.Location = new System.Drawing.Point(18, 289);
            this.Nombres_tom_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Nombres_tom_txb.MaxLength = 32767;
            this.Nombres_tom_txb.Name = "Nombres_tom_txb";
            this.Nombres_tom_txb.Size = new System.Drawing.Size(495, 40);
            this.Nombres_tom_txb.TabIndex = 3;
            this.Nombres_tom_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Documento_tom_txb
            // 
            this.Documento_tom_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Documento_tom_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Documento_tom_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Documento_tom_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Documento_tom_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documento_tom_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Documento_tom_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Documento_tom_txb.HintText = "Documento";
            this.Documento_tom_txb.isPassword = false;
            this.Documento_tom_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Documento_tom_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Documento_tom_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Documento_tom_txb.LineThickness = 2;
            this.Documento_tom_txb.Location = new System.Drawing.Point(19, 241);
            this.Documento_tom_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Documento_tom_txb.MaxLength = 32767;
            this.Documento_tom_txb.Name = "Documento_tom_txb";
            this.Documento_tom_txb.Size = new System.Drawing.Size(495, 40);
            this.Documento_tom_txb.TabIndex = 2;
            this.Documento_tom_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Tip_Doc_Tom
            // 
            this.Tip_Doc_Tom.BackColor = System.Drawing.Color.Transparent;
            this.Tip_Doc_Tom.BorderRadius = 3;
            this.Tip_Doc_Tom.DisabledColor = System.Drawing.Color.Gray;
            this.Tip_Doc_Tom.ForeColor = System.Drawing.Color.White;
            this.Tip_Doc_Tom.items = new string[] {
        "CEDULA",
        "NIT",
        "PASAPORTE",
        "TARJETA DE IDENTIDAD",
        "REGISTRO CIVIL",
        "CEDULA EXTRANJERA"};
            this.Tip_Doc_Tom.Location = new System.Drawing.Point(18, 192);
            this.Tip_Doc_Tom.Name = "Tip_Doc_Tom";
            this.Tip_Doc_Tom.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Tip_Doc_Tom.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Tip_Doc_Tom.selectedIndex = 0;
            this.Tip_Doc_Tom.Size = new System.Drawing.Size(496, 42);
            this.Tip_Doc_Tom.TabIndex = 0;
            // 
            // Beneficiario_page
            // 
            this.Beneficiario_page.BackColor = System.Drawing.Color.White;
            this.Beneficiario_page.Controls.Add(this.Añadir_ben_btn);
            this.Beneficiario_page.Controls.Add(this.label2);
            this.Beneficiario_page.Controls.Add(this.Fecha_ben);
            this.Beneficiario_page.Controls.Add(this.Email_ben_txb);
            this.Beneficiario_page.Controls.Add(this.Telefono_ben_txb);
            this.Beneficiario_page.Controls.Add(this.Direccion_ben_txb);
            this.Beneficiario_page.Controls.Add(this.Apellidos_ben_txb);
            this.Beneficiario_page.Controls.Add(this.Nombres_ben_txb);
            this.Beneficiario_page.Controls.Add(this.Documento_ben_txb);
            this.Beneficiario_page.Controls.Add(this.pictureBox2);
            this.Beneficiario_page.Controls.Add(this.Doc_Tip_Ben);
            this.Beneficiario_page.Location = new System.Drawing.Point(4, 22);
            this.Beneficiario_page.Name = "Beneficiario_page";
            this.Beneficiario_page.Padding = new System.Windows.Forms.Padding(3);
            this.Beneficiario_page.Size = new System.Drawing.Size(538, 671);
            this.Beneficiario_page.TabIndex = 1;
            this.Beneficiario_page.Text = "Beneficiario";
            // 
            // Añadir_ben_btn
            // 
            this.Añadir_ben_btn.AutoEllipsis = true;
            this.Añadir_ben_btn.Depth = 0;
            this.Añadir_ben_btn.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Añadir_ben_btn.Image = ((System.Drawing.Image)(resources.GetObject("Añadir_ben_btn.Image")));
            this.Añadir_ben_btn.Location = new System.Drawing.Point(56, 607);
            this.Añadir_ben_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Añadir_ben_btn.Name = "Añadir_ben_btn";
            this.Añadir_ben_btn.Primary = true;
            this.Añadir_ben_btn.Size = new System.Drawing.Size(421, 52);
            this.Añadir_ben_btn.TabIndex = 23;
            this.Añadir_ben_btn.Text = "Añadir";
            this.Añadir_ben_btn.UseVisualStyleBackColor = true;
            this.Añadir_ben_btn.Click += new System.EventHandler(this.Añadir_ben_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha de nacimiento";
            // 
            // Fecha_ben
            // 
            this.Fecha_ben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Fecha_ben.BorderRadius = 0;
            this.Fecha_ben.ForeColor = System.Drawing.Color.White;
            this.Fecha_ben.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_ben.FormatCustom = "";
            this.Fecha_ben.Location = new System.Drawing.Point(18, 528);
            this.Fecha_ben.Name = "Fecha_ben";
            this.Fecha_ben.Size = new System.Drawing.Size(244, 42);
            this.Fecha_ben.TabIndex = 21;
            this.Fecha_ben.Value = new System.DateTime(2020, 2, 2, 19, 53, 32, 0);
            // 
            // Email_ben_txb
            // 
            this.Email_ben_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Email_ben_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Email_ben_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email_ben_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_ben_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_ben_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_ben_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Email_ben_txb.HintText = "Email";
            this.Email_ben_txb.isPassword = false;
            this.Email_ben_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Email_ben_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Email_ben_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Email_ben_txb.LineThickness = 2;
            this.Email_ben_txb.Location = new System.Drawing.Point(19, 481);
            this.Email_ben_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Email_ben_txb.MaxLength = 32767;
            this.Email_ben_txb.Name = "Email_ben_txb";
            this.Email_ben_txb.Size = new System.Drawing.Size(495, 40);
            this.Email_ben_txb.TabIndex = 20;
            this.Email_ben_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Telefono_ben_txb
            // 
            this.Telefono_ben_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Telefono_ben_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Telefono_ben_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Telefono_ben_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Telefono_ben_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono_ben_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telefono_ben_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Telefono_ben_txb.HintText = "Teléfono";
            this.Telefono_ben_txb.isPassword = false;
            this.Telefono_ben_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Telefono_ben_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Telefono_ben_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Telefono_ben_txb.LineThickness = 2;
            this.Telefono_ben_txb.Location = new System.Drawing.Point(19, 433);
            this.Telefono_ben_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Telefono_ben_txb.MaxLength = 32767;
            this.Telefono_ben_txb.Name = "Telefono_ben_txb";
            this.Telefono_ben_txb.Size = new System.Drawing.Size(495, 40);
            this.Telefono_ben_txb.TabIndex = 19;
            this.Telefono_ben_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Direccion_ben_txb
            // 
            this.Direccion_ben_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Direccion_ben_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Direccion_ben_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Direccion_ben_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Direccion_ben_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion_ben_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Direccion_ben_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Direccion_ben_txb.HintText = "Dirección";
            this.Direccion_ben_txb.isPassword = false;
            this.Direccion_ben_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Direccion_ben_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Direccion_ben_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Direccion_ben_txb.LineThickness = 2;
            this.Direccion_ben_txb.Location = new System.Drawing.Point(18, 385);
            this.Direccion_ben_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Direccion_ben_txb.MaxLength = 32767;
            this.Direccion_ben_txb.Name = "Direccion_ben_txb";
            this.Direccion_ben_txb.Size = new System.Drawing.Size(495, 40);
            this.Direccion_ben_txb.TabIndex = 18;
            this.Direccion_ben_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Apellidos_ben_txb
            // 
            this.Apellidos_ben_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Apellidos_ben_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Apellidos_ben_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Apellidos_ben_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Apellidos_ben_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos_ben_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Apellidos_ben_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Apellidos_ben_txb.HintText = "Apellidos";
            this.Apellidos_ben_txb.isPassword = false;
            this.Apellidos_ben_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Apellidos_ben_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Apellidos_ben_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Apellidos_ben_txb.LineThickness = 2;
            this.Apellidos_ben_txb.Location = new System.Drawing.Point(18, 337);
            this.Apellidos_ben_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Apellidos_ben_txb.MaxLength = 32767;
            this.Apellidos_ben_txb.Name = "Apellidos_ben_txb";
            this.Apellidos_ben_txb.Size = new System.Drawing.Size(495, 40);
            this.Apellidos_ben_txb.TabIndex = 17;
            this.Apellidos_ben_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Nombres_ben_txb
            // 
            this.Nombres_ben_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Nombres_ben_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Nombres_ben_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Nombres_ben_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombres_ben_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres_ben_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nombres_ben_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Nombres_ben_txb.HintText = "Nombres";
            this.Nombres_ben_txb.isPassword = false;
            this.Nombres_ben_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Nombres_ben_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Nombres_ben_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Nombres_ben_txb.LineThickness = 2;
            this.Nombres_ben_txb.Location = new System.Drawing.Point(18, 289);
            this.Nombres_ben_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Nombres_ben_txb.MaxLength = 32767;
            this.Nombres_ben_txb.Name = "Nombres_ben_txb";
            this.Nombres_ben_txb.Size = new System.Drawing.Size(495, 40);
            this.Nombres_ben_txb.TabIndex = 16;
            this.Nombres_ben_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Documento_ben_txb
            // 
            this.Documento_ben_txb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Documento_ben_txb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Documento_ben_txb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Documento_ben_txb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Documento_ben_txb.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documento_ben_txb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Documento_ben_txb.HintForeColor = System.Drawing.Color.Gray;
            this.Documento_ben_txb.HintText = "Documento";
            this.Documento_ben_txb.isPassword = false;
            this.Documento_ben_txb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.Documento_ben_txb.LineIdleColor = System.Drawing.Color.Gray;
            this.Documento_ben_txb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.Documento_ben_txb.LineThickness = 2;
            this.Documento_ben_txb.Location = new System.Drawing.Point(19, 241);
            this.Documento_ben_txb.Margin = new System.Windows.Forms.Padding(4);
            this.Documento_ben_txb.MaxLength = 32767;
            this.Documento_ben_txb.Name = "Documento_ben_txb";
            this.Documento_ben_txb.Size = new System.Drawing.Size(495, 40);
            this.Documento_ben_txb.TabIndex = 15;
            this.Documento_ben_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(167, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Doc_Tip_Ben
            // 
            this.Doc_Tip_Ben.BackColor = System.Drawing.Color.Transparent;
            this.Doc_Tip_Ben.BorderRadius = 3;
            this.Doc_Tip_Ben.DisabledColor = System.Drawing.Color.Gray;
            this.Doc_Tip_Ben.ForeColor = System.Drawing.Color.White;
            this.Doc_Tip_Ben.items = new string[] {
        "CEDULA",
        "NIT",
        "PASAPORTE",
        "TARJETA DE IDENTIDAD",
        "REGISTRO CIVIL",
        "CEDULA EXTRANJERA"};
            this.Doc_Tip_Ben.Location = new System.Drawing.Point(18, 192);
            this.Doc_Tip_Ben.Name = "Doc_Tip_Ben";
            this.Doc_Tip_Ben.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Doc_Tip_Ben.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Doc_Tip_Ben.selectedIndex = 0;
            this.Doc_Tip_Ben.Size = new System.Drawing.Size(496, 42);
            this.Doc_Tip_Ben.TabIndex = 13;
            // 
            // Poliza_page
            // 
            this.Poliza_page.Location = new System.Drawing.Point(4, 22);
            this.Poliza_page.Name = "Poliza_page";
            this.Poliza_page.Size = new System.Drawing.Size(538, 671);
            this.Poliza_page.TabIndex = 2;
            this.Poliza_page.Text = "Poliza";
            this.Poliza_page.UseVisualStyleBackColor = true;
            // 
            // Vehiculo_page
            // 
            this.Vehiculo_page.Location = new System.Drawing.Point(4, 22);
            this.Vehiculo_page.Name = "Vehiculo_page";
            this.Vehiculo_page.Size = new System.Drawing.Size(538, 671);
            this.Vehiculo_page.TabIndex = 3;
            this.Vehiculo_page.Text = "Vehiculo";
            this.Vehiculo_page.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.Control_tab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-10, 55);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(559, 57);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "Tab_selector";
            // 
            // Forma
            // 
            this.Forma.ElipseRadius = 20;
            this.Forma.TargetControl = this;
            // 
            // Añadir_Editar_Eliminar_Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 806);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.Control_tab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Añadir_Editar_Eliminar_Formulario";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Añadir_Editar_Eliminar_Formulario_Load);
            this.Control_tab.ResumeLayout(false);
            this.Tomador_page.ResumeLayout(false);
            this.Tomador_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Beneficiario_page.ResumeLayout(false);
            this.Beneficiario_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl Control_tab;
        private System.Windows.Forms.TabPage Tomador_page;
        private System.Windows.Forms.TabPage Beneficiario_page;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage Poliza_page;
        private System.Windows.Forms.TabPage Vehiculo_page;
        private Bunifu.Framework.UI.BunifuElipse Forma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton Añadir_ben_btn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker Fecha_ben;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email_ben_txb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Telefono_ben_txb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Direccion_ben_txb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Apellidos_ben_txb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Nombres_ben_txb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Documento_ben_txb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuDropdown Doc_Tip_Ben;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Documento_tom_txb;
        public MaterialSkin.Controls.MaterialRaisedButton Añadir_tom_btn;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Nombres_tom_txb;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Apellidos_tom_txb;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Direccion_tom_txb;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Email_tom_txb;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Telefono_tom_txb;
        public Bunifu.Framework.UI.BunifuDatepicker Fecha_tom;
        public Bunifu.Framework.UI.BunifuDropdown Tip_Doc_Tom;
    }
}