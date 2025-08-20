
namespace _3NLIDTS_YairGonzalez_03cs
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
            this.lbCelcius = new System.Windows.Forms.Label();
            this.lbFahrenheit = new System.Windows.Forms.Label();
            this.lbKelvin = new System.Windows.Forms.Label();
            this.btnCalcularTemps = new System.Windows.Forms.Button();
            this.tbCelcius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.tbKelvin = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCelcius
            // 
            this.lbCelcius.AutoSize = true;
            this.lbCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelcius.Location = new System.Drawing.Point(96, 82);
            this.lbCelcius.Name = "lbCelcius";
            this.lbCelcius.Size = new System.Drawing.Size(56, 13);
            this.lbCelcius.TabIndex = 0;
            this.lbCelcius.Text = "Celcius :";
            this.lbCelcius.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFahrenheit
            // 
            this.lbFahrenheit.AutoSize = true;
            this.lbFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFahrenheit.Location = new System.Drawing.Point(99, 113);
            this.lbFahrenheit.Name = "lbFahrenheit";
            this.lbFahrenheit.Size = new System.Drawing.Size(75, 13);
            this.lbFahrenheit.TabIndex = 1;
            this.lbFahrenheit.Text = "Fahrenheit :";
            this.lbFahrenheit.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbKelvin
            // 
            this.lbKelvin.AutoSize = true;
            this.lbKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKelvin.Location = new System.Drawing.Point(99, 140);
            this.lbKelvin.Name = "lbKelvin";
            this.lbKelvin.Size = new System.Drawing.Size(50, 13);
            this.lbKelvin.TabIndex = 2;
            this.lbKelvin.Text = "Kelvin :";
            this.lbKelvin.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalcularTemps
            // 
            this.btnCalcularTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTemps.Location = new System.Drawing.Point(99, 181);
            this.btnCalcularTemps.Name = "btnCalcularTemps";
            this.btnCalcularTemps.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularTemps.TabIndex = 3;
            this.btnCalcularTemps.Text = "Calcular";
            this.btnCalcularTemps.UseVisualStyleBackColor = true;
            // 
            // tbCelcius
            // 
            this.tbCelcius.Location = new System.Drawing.Point(180, 74);
            this.tbCelcius.Name = "tbCelcius";
            this.tbCelcius.Size = new System.Drawing.Size(100, 20);
            this.tbCelcius.TabIndex = 4;
            this.tbCelcius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(180, 100);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFahrenheit.TabIndex = 5;
            this.tbFahrenheit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbKelvin
            // 
            this.tbKelvin.Location = new System.Drawing.Point(180, 133);
            this.tbKelvin.Name = "tbKelvin";
            this.tbKelvin.Size = new System.Drawing.Size(100, 20);
            this.tbKelvin.TabIndex = 6;
            this.tbKelvin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(141, 32);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(157, 25);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Temperaturas";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(202, 180);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tbKelvin);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelcius);
            this.Controls.Add(this.btnCalcularTemps);
            this.Controls.Add(this.lbKelvin);
            this.Controls.Add(this.lbFahrenheit);
            this.Controls.Add(this.lbCelcius);
            this.Name = "Form1";
            this.Text = "Actividad 03 - Conversor Basico de Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCelcius;
        private System.Windows.Forms.Label lbFahrenheit;
        private System.Windows.Forms.Label lbKelvin;
        private System.Windows.Forms.Button btnCalcularTemps;
        private System.Windows.Forms.TextBox tbCelcius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.TextBox tbKelvin;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnBorrar;
    }
}

