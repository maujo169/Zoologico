namespace Zoo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Reporte = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.BTN_Esp = new System.Windows.Forms.Button();
            this.BTN_Zoo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.BTN_Reporte);
            this.panel1.Controls.Add(this.BTN_Salir);
            this.panel1.Controls.Add(this.BTN_Esp);
            this.panel1.Controls.Add(this.BTN_Zoo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 453);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // BTN_Reporte
            // 
            this.BTN_Reporte.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reporte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reporte.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Reporte.Location = new System.Drawing.Point(0, 292);
            this.BTN_Reporte.Name = "BTN_Reporte";
            this.BTN_Reporte.Size = new System.Drawing.Size(183, 60);
            this.BTN_Reporte.TabIndex = 3;
            this.BTN_Reporte.Text = "Reportes";
            this.BTN_Reporte.UseVisualStyleBackColor = false;
            this.BTN_Reporte.Click += new System.EventHandler(this.BTN_Reporte_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Salir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Salir.Location = new System.Drawing.Point(0, 382);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(183, 60);
            this.BTN_Salir.TabIndex = 4;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_Esp
            // 
            this.BTN_Esp.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Esp.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Esp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Esp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Esp.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Esp.Location = new System.Drawing.Point(0, 203);
            this.BTN_Esp.Name = "BTN_Esp";
            this.BTN_Esp.Size = new System.Drawing.Size(183, 60);
            this.BTN_Esp.TabIndex = 3;
            this.BTN_Esp.Text = "Registrar Especie";
            this.BTN_Esp.UseVisualStyleBackColor = false;
            this.BTN_Esp.Click += new System.EventHandler(this.BTN_Esp_Click);
            // 
            // BTN_Zoo
            // 
            this.BTN_Zoo.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Zoo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Zoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Zoo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Zoo.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Zoo.Location = new System.Drawing.Point(0, 114);
            this.BTN_Zoo.Name = "BTN_Zoo";
            this.BTN_Zoo.Size = new System.Drawing.Size(183, 60);
            this.BTN_Zoo.TabIndex = 2;
            this.BTN_Zoo.Text = "Registrar Zoologico";
            this.BTN_Zoo.UseVisualStyleBackColor = false;
            this.BTN_Zoo.Click += new System.EventHandler(this.BTN_Zoo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de \r\ninformación \r\nde zoologicos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Zoo.Properties.Resources.bienvenido_ilustracion_dibujos_animados_zoologico_1284_24036;
            this.pictureBox3.Location = new System.Drawing.Point(183, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(578, 453);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox1.Image = global::Zoo.Properties.Resources.close_icon;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(738, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox2.Image = global::Zoo.Properties.Resources.min_icon;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(720, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(758, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Reporte;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Button BTN_Esp;
        private System.Windows.Forms.Button BTN_Zoo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

