namespace OMB_V2.Forms
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.Hora_fecha = new System.Windows.Forms.Timer(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1282, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(287, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a nuestro aplicativo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hora
            // 
            this.Hora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.Hora.Location = new System.Drawing.Point(518, 544);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(306, 80);
            this.Hora.TabIndex = 2;
            this.Hora.Text = "12:40 a.m";
            // 
            // Fecha
            // 
            this.Fecha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.Fecha.Location = new System.Drawing.Point(258, 614);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(811, 80);
            this.Fecha.TabIndex = 3;
            this.Fecha.Text = "domingo 23 de junio de 2019";
            // 
            // Hora_fecha
            // 
            this.Hora_fecha.Enabled = true;
            this.Hora_fecha.Tick += new System.EventHandler(this.Hora_fecha_Tick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 497);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1343, 16);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 150;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1367, 720);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenida";
            this.Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Timer Hora_fecha;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}