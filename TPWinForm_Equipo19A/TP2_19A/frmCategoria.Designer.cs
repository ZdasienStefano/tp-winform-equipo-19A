namespace TP2_19A
{
    partial class frmCategoria
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVCat = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnCat = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCat)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCat
            // 
            this.DGVCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVCat.Location = new System.Drawing.Point(172, 92);
            this.DGVCat.Name = "DGVCat";
            this.DGVCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCat.Size = new System.Drawing.Size(380, 186);
            this.DGVCat.TabIndex = 0;
            this.DGVCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCat_CellContentClick);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(195, 67);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(61, 13);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtro rapido";
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(491, 57);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(60, 26);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Buscar";
            this.btnCat.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(270, 63);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(215, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 314);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.DGVCat);
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCat;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.TextBox txtFiltro;
    }
}
