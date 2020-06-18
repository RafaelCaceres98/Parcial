namespace Parcial3
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
            this.BtnCargar = new System.Windows.Forms.Button();
            this.DtgConsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSede1 = new System.Windows.Forms.ComboBox();
            this.CmbSede2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.TxtBonificaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(63, 91);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(123, 45);
            this.BtnCargar.TabIndex = 0;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // DtgConsulta
            // 
            this.DtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgConsulta.Location = new System.Drawing.Point(63, 192);
            this.DtgConsulta.Name = "DtgConsulta";
            this.DtgConsulta.Size = new System.Drawing.Size(605, 188);
            this.DtgConsulta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sede";
            // 
            // CmbSede1
            // 
            this.CmbSede1.FormattingEnabled = true;
            this.CmbSede1.Items.AddRange(new object[] {
            "Valledupar",
            "Barranquilla",
            "Cartagena"});
            this.CmbSede1.Location = new System.Drawing.Point(426, 73);
            this.CmbSede1.Name = "CmbSede1";
            this.CmbSede1.Size = new System.Drawing.Size(121, 21);
            this.CmbSede1.TabIndex = 3;
            this.CmbSede1.SelectedIndexChanged += new System.EventHandler(this.CmbSede1_SelectedIndexChanged);
            // 
            // CmbSede2
            // 
            this.CmbSede2.FormattingEnabled = true;
            this.CmbSede2.Items.AddRange(new object[] {
            "Valledupar",
            "Barranquilla",
            "Cartagena"});
            this.CmbSede2.Location = new System.Drawing.Point(302, 135);
            this.CmbSede2.Name = "CmbSede2";
            this.CmbSede2.Size = new System.Drawing.Size(121, 21);
            this.CmbSede2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sede";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(455, 135);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(137, 20);
            this.DtpFecha.TabIndex = 6;
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(627, 133);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltro.TabIndex = 7;
            this.BtnFiltro.Text = "Filtro";
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Salario";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(53, 405);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(100, 20);
            this.TxtSalario.TabIndex = 9;
            // 
            // TxtBonificaciones
            // 
            this.TxtBonificaciones.Location = new System.Drawing.Point(252, 409);
            this.TxtBonificaciones.Name = "TxtBonificaciones";
            this.TxtBonificaciones.Size = new System.Drawing.Size(100, 20);
            this.TxtBonificaciones.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bonificaciones";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(447, 406);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descuento";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(602, 405);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDescuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBonificaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnFiltro);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.CmbSede2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbSede1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtgConsulta);
            this.Controls.Add(this.BtnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DtgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.DataGridView DtgConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSede1;
        private System.Windows.Forms.ComboBox CmbSede2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.TextBox TxtBonificaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label6;
    }
}

