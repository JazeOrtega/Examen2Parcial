namespace Vista
{
    partial class TicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdentidadTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DescripcionResTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DescripcionSoliTextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecioTextBox1 = new System.Windows.Forms.TextBox();
            this.TotalTextBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescuentoTextBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ImpuestoTextBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelarButton2 = new System.Windows.Forms.Button();
            this.CalcularButton1 = new System.Windows.Forms.Button();
            this.GuardarButton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickect";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaDateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UsuarioTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FechaDateTimePicker1
            // 
            this.FechaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker1.Location = new System.Drawing.Point(594, 15);
            this.FechaDateTimePicker1.Name = "FechaDateTimePicker1";
            this.FechaDateTimePicker1.Size = new System.Drawing.Size(115, 22);
            this.FechaDateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // UsuarioTextBox1
            // 
            this.UsuarioTextBox1.Location = new System.Drawing.Point(66, 18);
            this.UsuarioTextBox1.Name = "UsuarioTextBox1";
            this.UsuarioTextBox1.ReadOnly = true;
            this.UsuarioTextBox1.Size = new System.Drawing.Size(147, 22);
            this.UsuarioTextBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdentidadTextBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 77);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // IdentidadTextBox1
            // 
            this.IdentidadTextBox1.Location = new System.Drawing.Point(75, 25);
            this.IdentidadTextBox1.Name = "IdentidadTextBox1";
            this.IdentidadTextBox1.Size = new System.Drawing.Size(147, 22);
            this.IdentidadTextBox1.TabIndex = 7;
            this.IdentidadTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClienteTextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identidad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DescripcionResTextBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.DescripcionSoliTextBox1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(732, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // DescripcionResTextBox1
            // 
            this.DescripcionResTextBox1.Location = new System.Drawing.Point(417, 58);
            this.DescripcionResTextBox1.Name = "DescripcionResTextBox1";
            this.DescripcionResTextBox1.Size = new System.Drawing.Size(309, 22);
            this.DescripcionResTextBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descripcion de Respuesta";
            // 
            // DescripcionSoliTextBox1
            // 
            this.DescripcionSoliTextBox1.Location = new System.Drawing.Point(417, 23);
            this.DescripcionSoliTextBox1.Name = "DescripcionSoliTextBox1";
            this.DescripcionSoliTextBox1.Size = new System.Drawing.Size(309, 22);
            this.DescripcionSoliTextBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion de Solicitud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Soporte";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Celular",
            "Equipo de computo"});
            this.comboBox1.Location = new System.Drawing.Point(117, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio";
            // 
            // PrecioTextBox1
            // 
            this.PrecioTextBox1.Location = new System.Drawing.Point(107, 288);
            this.PrecioTextBox1.Name = "PrecioTextBox1";
            this.PrecioTextBox1.Size = new System.Drawing.Size(118, 22);
            this.PrecioTextBox1.TabIndex = 14;
            // 
            // TotalTextBox1
            // 
            this.TotalTextBox1.Location = new System.Drawing.Point(107, 372);
            this.TotalTextBox1.Name = "TotalTextBox1";
            this.TotalTextBox1.ReadOnly = true;
            this.TotalTextBox1.Size = new System.Drawing.Size(118, 22);
            this.TotalTextBox1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Total";
            // 
            // DescuentoTextBox1
            // 
            this.DescuentoTextBox1.Location = new System.Drawing.Point(107, 344);
            this.DescuentoTextBox1.Name = "DescuentoTextBox1";
            this.DescuentoTextBox1.Size = new System.Drawing.Size(118, 22);
            this.DescuentoTextBox1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Descuento";
            // 
            // ImpuestoTextBox2
            // 
            this.ImpuestoTextBox2.Location = new System.Drawing.Point(107, 316);
            this.ImpuestoTextBox2.Name = "ImpuestoTextBox2";
            this.ImpuestoTextBox2.ReadOnly = true;
            this.ImpuestoTextBox2.Size = new System.Drawing.Size(118, 22);
            this.ImpuestoTextBox2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Impuesto";
            // 
            // CancelarButton2
            // 
            this.CancelarButton2.Location = new System.Drawing.Point(94, 411);
            this.CancelarButton2.Name = "CancelarButton2";
            this.CancelarButton2.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton2.TabIndex = 28;
            this.CancelarButton2.Text = "Cancelar";
            this.CancelarButton2.UseVisualStyleBackColor = true;
            // 
            // CalcularButton1
            // 
            this.CalcularButton1.Location = new System.Drawing.Point(175, 411);
            this.CalcularButton1.Name = "CalcularButton1";
            this.CalcularButton1.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton1.TabIndex = 29;
            this.CalcularButton1.Text = "Calcular";
            this.CalcularButton1.UseVisualStyleBackColor = true;
            this.CalcularButton1.Click += new System.EventHandler(this.CalcularButton1_Click);
            // 
            // GuardarButton1
            // 
            this.GuardarButton1.Location = new System.Drawing.Point(13, 411);
            this.GuardarButton1.Name = "GuardarButton1";
            this.GuardarButton1.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton1.TabIndex = 30;
            this.GuardarButton1.Text = "Guardar";
            this.GuardarButton1.UseVisualStyleBackColor = true;
            this.GuardarButton1.Click += new System.EventHandler(this.GuardarButton1_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(751, 446);
            this.Controls.Add(this.GuardarButton1);
            this.Controls.Add(this.CalcularButton1);
            this.Controls.Add(this.CancelarButton2);
            this.Controls.Add(this.TotalTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescuentoTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ImpuestoTextBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PrecioTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketForm";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdentidadTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DescripcionResTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescripcionSoliTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PrecioTextBox1;
        private System.Windows.Forms.TextBox TotalTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescuentoTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ImpuestoTextBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CancelarButton2;
        private System.Windows.Forms.Button CalcularButton1;
        private System.Windows.Forms.Button GuardarButton1;
    }
}