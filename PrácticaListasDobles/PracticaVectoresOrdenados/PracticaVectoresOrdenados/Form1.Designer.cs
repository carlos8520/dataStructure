namespace PracticaVectoresOrdenados
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
            this.txtBoxEliminar = new System.Windows.Forms.TextBox();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBoxInv = new System.Windows.Forms.TextBox();
            this.txtBoxCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelPrimero = new System.Windows.Forms.Button();
            this.btnDelUltimo = new System.Windows.Forms.Button();
            this.btnListarInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxEliminar
            // 
            this.txtBoxEliminar.Location = new System.Drawing.Point(426, 68);
            this.txtBoxEliminar.Name = "txtBoxEliminar";
            this.txtBoxEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEliminar.TabIndex = 32;
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(426, 31);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscar.TabIndex = 31;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(335, 104);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 30;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(335, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar ID";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(335, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar ID";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(234, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBoxInv
            // 
            this.txtBoxInv.Location = new System.Drawing.Point(41, 194);
            this.txtBoxInv.Multiline = true;
            this.txtBoxInv.Name = "txtBoxInv";
            this.txtBoxInv.Size = new System.Drawing.Size(485, 132);
            this.txtBoxInv.TabIndex = 25;
            // 
            // txtBoxCosto
            // 
            this.txtBoxCosto.Location = new System.Drawing.Point(97, 148);
            this.txtBoxCosto.Name = "txtBoxCosto";
            this.txtBoxCosto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCosto.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Costo:";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(96, 107);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCantidad.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad:";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(97, 68);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre:";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(97, 31);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // btnDelPrimero
            // 
            this.btnDelPrimero.Location = new System.Drawing.Point(335, 140);
            this.btnDelPrimero.Name = "btnDelPrimero";
            this.btnDelPrimero.Size = new System.Drawing.Size(75, 23);
            this.btnDelPrimero.TabIndex = 33;
            this.btnDelPrimero.Text = "Del Primero";
            this.btnDelPrimero.UseVisualStyleBackColor = true;
            this.btnDelPrimero.Click += new System.EventHandler(this.btnDelPrimero_Click);
            // 
            // btnDelUltimo
            // 
            this.btnDelUltimo.Location = new System.Drawing.Point(426, 141);
            this.btnDelUltimo.Name = "btnDelUltimo";
            this.btnDelUltimo.Size = new System.Drawing.Size(100, 23);
            this.btnDelUltimo.TabIndex = 34;
            this.btnDelUltimo.Text = "Delete Ultimo";
            this.btnDelUltimo.UseVisualStyleBackColor = true;
            this.btnDelUltimo.Click += new System.EventHandler(this.btnDelUltimo_Click);
            // 
            // btnListarInv
            // 
            this.btnListarInv.Location = new System.Drawing.Point(426, 104);
            this.btnListarInv.Name = "btnListarInv";
            this.btnListarInv.Size = new System.Drawing.Size(100, 23);
            this.btnListarInv.TabIndex = 35;
            this.btnListarInv.Text = "Listar Inverso";
            this.btnListarInv.UseVisualStyleBackColor = true;
            this.btnListarInv.Click += new System.EventHandler(this.btnListarUlt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 357);
            this.Controls.Add(this.btnListarInv);
            this.Controls.Add(this.btnDelUltimo);
            this.Controls.Add(this.btnDelPrimero);
            this.Controls.Add(this.txtBoxEliminar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxInv);
            this.Controls.Add(this.txtBoxCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxEliminar;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBoxInv;
        private System.Windows.Forms.TextBox txtBoxCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelPrimero;
        private System.Windows.Forms.Button btnDelUltimo;
        private System.Windows.Forms.Button btnListarInv;
    }
}

