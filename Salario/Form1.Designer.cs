namespace Salario
{
    partial class frmSalario
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
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblValorVentas = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lblAntiguedad = new System.Windows.Forms.Label();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(130, 116);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 0;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(22, 24);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(88, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Ingrese el Salario";
            // 
            // lblValorVentas
            // 
            this.lblValorVentas.AutoSize = true;
            this.lblValorVentas.Location = new System.Drawing.Point(22, 56);
            this.lblValorVentas.Name = "lblValorVentas";
            this.lblValorVentas.Size = new System.Drawing.Size(97, 13);
            this.lblValorVentas.TabIndex = 2;
            this.lblValorVentas.Text = "Valor de las ventas";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(22, 123);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(130, 21);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 4;
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(130, 56);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(100, 20);
            this.txtVentas.TabIndex = 5;
            // 
            // lblAntiguedad
            // 
            this.lblAntiguedad.AutoSize = true;
            this.lblAntiguedad.Location = new System.Drawing.Point(22, 88);
            this.lblAntiguedad.Name = "lblAntiguedad";
            this.lblAntiguedad.Size = new System.Drawing.Size(102, 13);
            this.lblAntiguedad.TabIndex = 6;
            this.lblAntiguedad.Text = "Años de antiguedad";
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(130, 85);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.txtAntiguedad.TabIndex = 7;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(130, 161);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(100, 23);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 224);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.lblAntiguedad);
            this.Controls.Add(this.txtVentas);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblValorVentas);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.dtpFechaNac);
            this.Name = "frmSalario";
            this.Text = "Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblValorVentas;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Label lblAntiguedad;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

