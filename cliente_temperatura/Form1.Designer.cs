
namespace cliente_temperatura
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.rbnCelsius = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rbnFahren = new System.Windows.Forms.RadioButton();
            this.btnConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(91, 10);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 23);
            this.txtTemp.TabIndex = 0;
            // 
            // rbnCelsius
            // 
            this.rbnCelsius.AutoSize = true;
            this.rbnCelsius.Location = new System.Drawing.Point(197, 14);
            this.rbnCelsius.Name = "rbnCelsius";
            this.rbnCelsius.Size = new System.Drawing.Size(135, 19);
            this.rbnCelsius.TabIndex = 1;
            this.rbnCelsius.TabStop = true;
            this.rbnCelsius.Text = "Celsius to Fahrenheit";
            this.rbnCelsius.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(116, 39);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rbnFahren
            // 
            this.rbnFahren.AutoSize = true;
            this.rbnFahren.Location = new System.Drawing.Point(197, 39);
            this.rbnFahren.Name = "rbnFahren";
            this.rbnFahren.Size = new System.Drawing.Size(135, 19);
            this.rbnFahren.TabIndex = 4;
            this.rbnFahren.TabStop = true;
            this.rbnFahren.Text = "Fahrenheit to Celsius";
            this.rbnFahren.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(35, 39);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 92);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.rbnFahren);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnCelsius);
            this.Controls.Add(this.txtTemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.RadioButton rbnCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton rbnFahren;
        private System.Windows.Forms.Button btnConectar;
    }
}

