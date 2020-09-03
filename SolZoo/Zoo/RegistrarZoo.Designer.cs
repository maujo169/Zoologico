namespace Zoo
{
    partial class RegistrarZoo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBX_Nombre = new System.Windows.Forms.TextBox();
            this.TBX_Pais = new System.Windows.Forms.TextBox();
            this.TBX_Ciudad = new System.Windows.Forms.TextBox();
            this.TBX_Tam = new System.Windows.Forms.TextBox();
            this.TBX_PresupuestoAnual = new System.Windows.Forms.TextBox();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de zoológico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Zoo.Properties.Resources.min_icon;
            this.pictureBox2.Location = new System.Drawing.Point(469, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Zoo.Properties.Resources.close_icon;
            this.pictureBox1.Location = new System.Drawing.Point(489, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Presupuesto Anual (S/.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tamaño (m2)";
            // 
            // TBX_Nombre
            // 
            this.TBX_Nombre.Location = new System.Drawing.Point(103, 60);
            this.TBX_Nombre.Name = "TBX_Nombre";
            this.TBX_Nombre.Size = new System.Drawing.Size(372, 20);
            this.TBX_Nombre.TabIndex = 9;
            // 
            // TBX_Pais
            // 
            this.TBX_Pais.Location = new System.Drawing.Point(73, 87);
            this.TBX_Pais.Name = "TBX_Pais";
            this.TBX_Pais.Size = new System.Drawing.Size(202, 20);
            this.TBX_Pais.TabIndex = 10;
            // 
            // TBX_Ciudad
            // 
            this.TBX_Ciudad.Location = new System.Drawing.Point(93, 113);
            this.TBX_Ciudad.Name = "TBX_Ciudad";
            this.TBX_Ciudad.Size = new System.Drawing.Size(202, 20);
            this.TBX_Ciudad.TabIndex = 11;
            // 
            // TBX_Tam
            // 
            this.TBX_Tam.Location = new System.Drawing.Point(130, 141);
            this.TBX_Tam.Name = "TBX_Tam";
            this.TBX_Tam.Size = new System.Drawing.Size(136, 20);
            this.TBX_Tam.TabIndex = 12;
            this.TBX_Tam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_Tam_KeyPress);
            // 
            // TBX_PresupuestoAnual
            // 
            this.TBX_PresupuestoAnual.Location = new System.Drawing.Point(191, 169);
            this.TBX_PresupuestoAnual.Name = "TBX_PresupuestoAnual";
            this.TBX_PresupuestoAnual.Size = new System.Drawing.Size(117, 20);
            this.TBX_PresupuestoAnual.TabIndex = 13;
            this.TBX_PresupuestoAnual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_PresupuestoAnual_KeyPress);
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Guardar.Location = new System.Drawing.Point(393, 204);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(106, 29);
            this.BTN_Guardar.TabIndex = 15;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = false;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Cancelar.Location = new System.Drawing.Point(281, 204);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(106, 29);
            this.BTN_Cancelar.TabIndex = 17;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // RegistrarZoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 245);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.TBX_PresupuestoAnual);
            this.Controls.Add(this.TBX_Tam);
            this.Controls.Add(this.TBX_Ciudad);
            this.Controls.Add(this.TBX_Pais);
            this.Controls.Add(this.TBX_Nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarZoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarZoo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBX_Nombre;
        private System.Windows.Forms.TextBox TBX_Pais;
        private System.Windows.Forms.TextBox TBX_Ciudad;
        private System.Windows.Forms.TextBox TBX_Tam;
        private System.Windows.Forms.TextBox TBX_PresupuestoAnual;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.Button BTN_Cancelar;
    }
}