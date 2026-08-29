namespace WninFrmsAppConversionDeTemperaturas
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnDesdeCelsius = new System.Windows.Forms.Button();
            this.btnDesdeFahrenheit = new System.Windows.Forms.Button();
            this.btnDesdeKelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(59, 89);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(77, 25);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(59, 205);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(105, 25);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(59, 323);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(66, 25);
            this.lblKelvin.TabIndex = 2;
            this.lblKelvin.Text = "Kelvin";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(249, 89);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 29);
            this.txtCelsius.TabIndex = 3;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(249, 200);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 29);
            this.txtFahrenheit.TabIndex = 4;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(249, 318);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 29);
            this.txtKelvin.TabIndex = 5;
            // 
            // btnDesdeCelsius
            // 
            this.btnDesdeCelsius.Location = new System.Drawing.Point(494, 77);
            this.btnDesdeCelsius.Name = "btnDesdeCelsius";
            this.btnDesdeCelsius.Size = new System.Drawing.Size(171, 48);
            this.btnDesdeCelsius.TabIndex = 6;
            this.btnDesdeCelsius.Text = "Desde Celsius";
            this.btnDesdeCelsius.UseVisualStyleBackColor = true;
            this.btnDesdeCelsius.Click += new System.EventHandler(this.btnDesdeCelsius_Click);
            // 
            // btnDesdeFahrenheit
            // 
            this.btnDesdeFahrenheit.Location = new System.Drawing.Point(481, 200);
            this.btnDesdeFahrenheit.Name = "btnDesdeFahrenheit";
            this.btnDesdeFahrenheit.Size = new System.Drawing.Size(194, 57);
            this.btnDesdeFahrenheit.TabIndex = 7;
            this.btnDesdeFahrenheit.Text = "Desde Fahrenheit";
            this.btnDesdeFahrenheit.UseVisualStyleBackColor = true;
            this.btnDesdeFahrenheit.Click += new System.EventHandler(this.btnDesdeFahrenheit_Click);
            // 
            // btnDesdeKelvin
            // 
            this.btnDesdeKelvin.Location = new System.Drawing.Point(484, 316);
            this.btnDesdeKelvin.Name = "btnDesdeKelvin";
            this.btnDesdeKelvin.Size = new System.Drawing.Size(191, 38);
            this.btnDesdeKelvin.TabIndex = 8;
            this.btnDesdeKelvin.Text = "Desde Kelvin";
            this.btnDesdeKelvin.UseVisualStyleBackColor = true;
            this.btnDesdeKelvin.Click += new System.EventHandler(this.btnDesdeKelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 627);
            this.Controls.Add(this.btnDesdeKelvin);
            this.Controls.Add(this.btnDesdeFahrenheit);
            this.Controls.Add(this.btnDesdeCelsius);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Name = "Form1";
            this.Text = "CONVERSOR DE TEMPERATURAS: CELSIUS, FAHRENHEIT Y KELVIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnDesdeCelsius;
        private System.Windows.Forms.Button btnDesdeFahrenheit;
        private System.Windows.Forms.Button btnDesdeKelvin;
    }
}

