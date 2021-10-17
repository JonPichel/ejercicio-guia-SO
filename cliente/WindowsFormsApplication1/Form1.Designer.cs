namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.rbnAltura = new System.Windows.Forms.RadioButton();
            this.rbnLongitud = new System.Windows.Forms.RadioButton();
            this.rbnBonito = new System.Windows.Forms.RadioButton();
            this.btnConn = new System.Windows.Forms.Button();
            this.rbnPalin = new System.Windows.Forms.RadioButton();
            this.rbnMayus = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(128, 186);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.rbnMayus);
            this.groupBox1.Controls.Add(this.rbnPalin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.rbnAltura);
            this.groupBox1.Controls.Add(this.rbnLongitud);
            this.groupBox1.Controls.Add(this.rbnBonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 282);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(6, 111);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(66, 20);
            this.txtAltura.TabIndex = 10;
            // 
            // rbnAltura
            // 
            this.rbnAltura.AutoSize = true;
            this.rbnAltura.Location = new System.Drawing.Point(116, 114);
            this.rbnAltura.Name = "rbnAltura";
            this.rbnAltura.Size = new System.Drawing.Size(98, 17);
            this.rbnAltura.TabIndex = 9;
            this.rbnAltura.TabStop = true;
            this.rbnAltura.Text = "Dime si soy alto";
            this.rbnAltura.UseVisualStyleBackColor = true;
            // 
            // rbnLongitud
            // 
            this.rbnLongitud.AutoSize = true;
            this.rbnLongitud.Location = new System.Drawing.Point(116, 91);
            this.rbnLongitud.Name = "rbnLongitud";
            this.rbnLongitud.Size = new System.Drawing.Size(166, 17);
            this.rbnLongitud.TabIndex = 7;
            this.rbnLongitud.TabStop = true;
            this.rbnLongitud.Text = "Dime la longitud de mi nombre";
            this.rbnLongitud.UseVisualStyleBackColor = true;
            // 
            // rbnBonito
            // 
            this.rbnBonito.AutoSize = true;
            this.rbnBonito.Location = new System.Drawing.Point(116, 68);
            this.rbnBonito.Name = "rbnBonito";
            this.rbnBonito.Size = new System.Drawing.Size(156, 17);
            this.rbnBonito.TabIndex = 8;
            this.rbnBonito.TabStop = true;
            this.rbnBonito.Text = "Dime si mi nombre es bonito";
            this.rbnBonito.UseVisualStyleBackColor = true;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(12, 85);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(110, 23);
            this.btnConn.TabIndex = 7;
            this.btnConn.Text = "Conectarse";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // rbnPalin
            // 
            this.rbnPalin.AutoSize = true;
            this.rbnPalin.Location = new System.Drawing.Point(116, 137);
            this.rbnPalin.Name = "rbnPalin";
            this.rbnPalin.Size = new System.Drawing.Size(180, 17);
            this.rbnPalin.TabIndex = 12;
            this.rbnPalin.TabStop = true;
            this.rbnPalin.Text = "Dime si mi nombre es palíndromo";
            this.rbnPalin.UseVisualStyleBackColor = true;
            // 
            // rbnMayus
            // 
            this.rbnMayus.AutoSize = true;
            this.rbnMayus.Location = new System.Drawing.Point(116, 160);
            this.rbnMayus.Name = "rbnMayus";
            this.rbnMayus.Size = new System.Drawing.Size(173, 17);
            this.rbnMayus.TabIndex = 13;
            this.rbnMayus.TabStop = true;
            this.rbnMayus.Text = "Dime mi nombre en mayúsculas";
            this.rbnMayus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnLongitud;
        private System.Windows.Forms.RadioButton rbnBonito;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.RadioButton rbnAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.RadioButton rbnMayus;
        private System.Windows.Forms.RadioButton rbnPalin;
    }
}

