namespace TP2_19A
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.txtboxFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrarAvanzado = new System.Windows.Forms.Button();
            this.btncategoria = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(105, 137);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 102;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(845, 315);
            this.dgvArticulos.TabIndex = 1;
             this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(197, 475);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 65);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(988, 137);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(332, 315);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(426, 474);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 65);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(649, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 65);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(102, 99);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(89, 13);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "FILTRO RAPIDO";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(197, 96);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(1);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(184, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(102, 620);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(423, 620);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(734, 620);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.lblFiltroAvanzado.TabIndex = 10;
            this.lblFiltroAvanzado.Text = "Filtro";
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(166, 617);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(121, 21);
            this.cboxCampo.TabIndex = 11;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(488, 619);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboxCriterio.TabIndex = 12;
            // 
            // txtboxFiltro
            // 
            this.txtboxFiltro.Location = new System.Drawing.Point(791, 617);
            this.txtboxFiltro.Name = "txtboxFiltro";
            this.txtboxFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtboxFiltro.TabIndex = 13;
            // 
            // btnFiltrarAvanzado
            // 
            this.btnFiltrarAvanzado.Location = new System.Drawing.Point(997, 614);
            this.btnFiltrarAvanzado.Name = "btnFiltrarAvanzado";
            this.btnFiltrarAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarAvanzado.TabIndex = 14;
            this.btnFiltrarAvanzado.Text = "Buscar";
            this.btnFiltrarAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltrarAvanzado.Click += new System.EventHandler(this.btnFiltrarAvanzado_Click);
            // 
            // btncategoria
            // 
            this.btncategoria.Location = new System.Drawing.Point(12, 12);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(117, 52);
            this.btncategoria.TabIndex = 15;
            this.btncategoria.Text = "Categorias";
            this.btncategoria.UseVisualStyleBackColor = true;
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(135, 12);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMarcas.Size = new System.Drawing.Size(117, 52);
            this.btnMarcas.TabIndex = 16;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1370, 716);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btncategoria);
            this.Controls.Add(this.btnFiltrarAvanzado);
            this.Controls.Add(this.txtboxFiltro);
            this.Controls.Add(this.cboxCriterio);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pograma Administrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.TextBox txtboxFiltro;
        private System.Windows.Forms.Button btnFiltrarAvanzado;
        private System.Windows.Forms.Button btncategoria;
        private System.Windows.Forms.Button btnMarcas;
    }
}

