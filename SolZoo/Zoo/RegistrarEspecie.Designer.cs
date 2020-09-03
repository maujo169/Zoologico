namespace Zoo
{
    partial class RegistrarEspecie
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Guardar = new System.Windows.Forms.Button();
            this.TBX_CantAnimales = new System.Windows.Forms.TextBox();
            this.TBX_NombreC = new System.Windows.Forms.TextBox();
            this.TBX_NombreV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBX_Clase = new System.Windows.Forms.ComboBox();
            this.CBX_Extincion = new System.Windows.Forms.ComboBox();
            this.CBX_Zoo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de especie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Cancelar.Location = new System.Drawing.Point(346, 251);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(106, 29);
            this.BTN_Cancelar.TabIndex = 30;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            // 
            // BTN_Guardar
            // 
            this.BTN_Guardar.BackColor = System.Drawing.Color.DarkGreen;
            this.BTN_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.BTN_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Guardar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Guardar.Location = new System.Drawing.Point(458, 251);
            this.BTN_Guardar.Name = "BTN_Guardar";
            this.BTN_Guardar.Size = new System.Drawing.Size(106, 29);
            this.BTN_Guardar.TabIndex = 29;
            this.BTN_Guardar.Text = "Guardar";
            this.BTN_Guardar.UseVisualStyleBackColor = false;
            this.BTN_Guardar.Click += new System.EventHandler(this.BTN_Guardar_Click);
            // 
            // TBX_CantAnimales
            // 
            this.TBX_CantAnimales.Location = new System.Drawing.Point(270, 143);
            this.TBX_CantAnimales.Name = "TBX_CantAnimales";
            this.TBX_CantAnimales.Size = new System.Drawing.Size(202, 20);
            this.TBX_CantAnimales.TabIndex = 26;
            this.TBX_CantAnimales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_CantAnimales_KeyPress);
            // 
            // TBX_NombreC
            // 
            this.TBX_NombreC.Location = new System.Drawing.Point(164, 117);
            this.TBX_NombreC.Name = "TBX_NombreC";
            this.TBX_NombreC.Size = new System.Drawing.Size(202, 20);
            this.TBX_NombreC.TabIndex = 25;
            // 
            // TBX_NombreV
            // 
            this.TBX_NombreV.Location = new System.Drawing.Point(164, 91);
            this.TBX_NombreV.Name = "TBX_NombreV";
            this.TBX_NombreV.Size = new System.Drawing.Size(372, 20);
            this.TBX_NombreV.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Peligro Extinción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad de animales por especie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre Cientifico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre vulgar";
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
            this.panel1.Size = new System.Drawing.Size(576, 26);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Zoo.Properties.Resources.min_icon;
            this.pictureBox2.Location = new System.Drawing.Point(533, 5);
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
            this.pictureBox1.Location = new System.Drawing.Point(553, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CBX_Clase
            // 
            this.CBX_Clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Clase.FormattingEnabled = true;
            this.CBX_Clase.Items.AddRange(new object[] {
            "Mamifero",
            "Ave",
            "Anfibio",
            "Reptil"});
            this.CBX_Clase.Location = new System.Drawing.Point(81, 169);
            this.CBX_Clase.Name = "CBX_Clase";
            this.CBX_Clase.Size = new System.Drawing.Size(121, 21);
            this.CBX_Clase.TabIndex = 31;
            // 
            // CBX_Extincion
            // 
            this.CBX_Extincion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Extincion.FormattingEnabled = true;
            this.CBX_Extincion.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CBX_Extincion.Location = new System.Drawing.Point(150, 196);
            this.CBX_Extincion.Name = "CBX_Extincion";
            this.CBX_Extincion.Size = new System.Drawing.Size(121, 21);
            this.CBX_Extincion.TabIndex = 32;
            // 
            // CBX_Zoo
            // 
            this.CBX_Zoo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Zoo.FormattingEnabled = true;
            this.CBX_Zoo.Location = new System.Drawing.Point(120, 60);
            this.CBX_Zoo.Name = "CBX_Zoo";
            this.CBX_Zoo.Size = new System.Drawing.Size(204, 21);
            this.CBX_Zoo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Zoologico";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistrarEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 292);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBX_Zoo);
            this.Controls.Add(this.CBX_Extincion);
            this.Controls.Add(this.CBX_Clase);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Guardar);
            this.Controls.Add(this.TBX_CantAnimales);
            this.Controls.Add(this.TBX_NombreC);
            this.Controls.Add(this.TBX_NombreV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarEspecie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarEspecie";
            this.Load += new System.EventHandler(this.RegistrarEspecie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Guardar;
        private System.Windows.Forms.TextBox TBX_CantAnimales;
        private System.Windows.Forms.TextBox TBX_NombreC;
        private System.Windows.Forms.TextBox TBX_NombreV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBX_Clase;
        private System.Windows.Forms.ComboBox CBX_Extincion;
        private System.Windows.Forms.ComboBox CBX_Zoo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}