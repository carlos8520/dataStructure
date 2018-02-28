namespace Practica2
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValidación = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTamanoBytes = new System.Windows.Forms.TextBox();
            this.txtBoxAncho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAlto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxBitsPixel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(267, 43);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa un archivo .bmp para validarlo";
            // 
            // lblValidación
            // 
            this.lblValidación.AutoSize = true;
            this.lblValidación.Location = new System.Drawing.Point(37, 85);
            this.lblValidación.Name = "lblValidación";
            this.lblValidación.Size = new System.Drawing.Size(111, 13);
            this.lblValidación.TabIndex = 2;
            this.lblValidación.Text = "Validación del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tamaño real en bytes:";
            // 
            // txtBoxTamanoBytes
            // 
            this.txtBoxTamanoBytes.Location = new System.Drawing.Point(267, 114);
            this.txtBoxTamanoBytes.Name = "txtBoxTamanoBytes";
            this.txtBoxTamanoBytes.Size = new System.Drawing.Size(100, 20);
            this.txtBoxTamanoBytes.TabIndex = 4;
            // 
            // txtBoxAncho
            // 
            this.txtBoxAncho.Location = new System.Drawing.Point(267, 151);
            this.txtBoxAncho.Name = "txtBoxAncho";
            this.txtBoxAncho.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAncho.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ancho de la imagen:";
            // 
            // txtBoxAlto
            // 
            this.txtBoxAlto.Location = new System.Drawing.Point(267, 188);
            this.txtBoxAlto.Name = "txtBoxAlto";
            this.txtBoxAlto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAlto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alto de la imagen:";
            // 
            // txtBoxBitsPixel
            // 
            this.txtBoxBitsPixel.Location = new System.Drawing.Point(267, 225);
            this.txtBoxBitsPixel.Name = "txtBoxBitsPixel";
            this.txtBoxBitsPixel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBitsPixel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de bits por pixel:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 507);
            this.Controls.Add(this.txtBoxBitsPixel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxAlto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxTamanoBytes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblValidación);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValidación;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTamanoBytes;
        private System.Windows.Forms.TextBox txtBoxAncho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAlto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxBitsPixel;
        private System.Windows.Forms.Label label5;
    }
}

