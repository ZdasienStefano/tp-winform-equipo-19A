namespace TP2_19A
{
    partial class frmAgregarMarcas
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
            this.lblID = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(33, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(12, 92);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 6;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(80, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(177, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(80, 89);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtdescripcion.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 33);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(145, 126);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(112, 33);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // frmAgregarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 185);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblID);
            this.Name = "frmAgregarMarcas";
            this.Text = "frmAgregarMarcas";
            this.Load += new System.EventHandler(this.frmAgregarMarcas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btncancelar;
    }
}