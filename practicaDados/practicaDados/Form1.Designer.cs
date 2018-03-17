namespace practicaDados
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
            this.btnLanzar1 = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnLanzar2 = new System.Windows.Forms.Button();
            this.btn2Dados = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanzar1
            // 
            this.btnLanzar1.Location = new System.Drawing.Point(15, 24);
            this.btnLanzar1.Name = "btnLanzar1";
            this.btnLanzar1.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar1.TabIndex = 0;
            this.btnLanzar1.Text = ":)";
            this.btnLanzar1.UseVisualStyleBackColor = true;
            this.btnLanzar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(15, 66);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(165, 226);
            this.txtBox1.TabIndex = 1;
            // 
            // btnLanzar2
            // 
            this.btnLanzar2.Location = new System.Drawing.Point(105, 24);
            this.btnLanzar2.Name = "btnLanzar2";
            this.btnLanzar2.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar2.TabIndex = 2;
            this.btnLanzar2.Text = ":(";
            this.btnLanzar2.UseVisualStyleBackColor = true;
            this.btnLanzar2.Click += new System.EventHandler(this.btnLanzar2_Click);
            // 
            // btn2Dados
            // 
            this.btn2Dados.Location = new System.Drawing.Point(198, 24);
            this.btn2Dados.Name = "btn2Dados";
            this.btn2Dados.Size = new System.Drawing.Size(75, 23);
            this.btn2Dados.TabIndex = 4;
            this.btn2Dados.Text = ":v";
            this.btn2Dados.UseVisualStyleBackColor = true;
            this.btn2Dados.Click += new System.EventHandler(this.btn2Dados_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(198, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::practicaDados.Properties.Resources.ms_icon_150x150;
            this.pictureBox1.Location = new System.Drawing.Point(145, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 307);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn2Dados);
            this.Controls.Add(this.btnLanzar2);
            this.Controls.Add(this.btnLanzar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnLanzar2;
        private System.Windows.Forms.Button btn2Dados;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

