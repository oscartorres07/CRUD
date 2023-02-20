namespace CRUD
{
    partial class vista0
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
            this.dgv_ordenes = new System.Windows.Forms.DataGridView();
            this.btn_nuevaorden = new System.Windows.Forms.Button();
            this.btn_modificarorden = new System.Windows.Forms.Button();
            this.btn_eliminarorden = new System.Windows.Forms.Button();
            this.btn_enviarordenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ordenes
            // 
            this.dgv_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenes.Location = new System.Drawing.Point(12, 12);
            this.dgv_ordenes.MultiSelect = false;
            this.dgv_ordenes.Name = "dgv_ordenes";
            this.dgv_ordenes.ReadOnly = true;
            this.dgv_ordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ordenes.Size = new System.Drawing.Size(622, 200);
            this.dgv_ordenes.TabIndex = 0;
            // 
            // btn_nuevaorden
            // 
            this.btn_nuevaorden.Location = new System.Drawing.Point(640, 12);
            this.btn_nuevaorden.Name = "btn_nuevaorden";
            this.btn_nuevaorden.Size = new System.Drawing.Size(148, 44);
            this.btn_nuevaorden.TabIndex = 1;
            this.btn_nuevaorden.Text = "Nueva orden";
            this.btn_nuevaorden.UseVisualStyleBackColor = true;
            this.btn_nuevaorden.Click += new System.EventHandler(this.btn_nuevaorden_Click);
            // 
            // btn_modificarorden
            // 
            this.btn_modificarorden.Location = new System.Drawing.Point(640, 62);
            this.btn_modificarorden.Name = "btn_modificarorden";
            this.btn_modificarorden.Size = new System.Drawing.Size(148, 44);
            this.btn_modificarorden.TabIndex = 2;
            this.btn_modificarorden.Text = "Modificar orden";
            this.btn_modificarorden.UseVisualStyleBackColor = true;
            this.btn_modificarorden.Click += new System.EventHandler(this.btn_modificarorden_Click);
            // 
            // btn_eliminarorden
            // 
            this.btn_eliminarorden.Location = new System.Drawing.Point(640, 118);
            this.btn_eliminarorden.Name = "btn_eliminarorden";
            this.btn_eliminarorden.Size = new System.Drawing.Size(148, 44);
            this.btn_eliminarorden.TabIndex = 3;
            this.btn_eliminarorden.Text = "Eliminar orden";
            this.btn_eliminarorden.UseVisualStyleBackColor = true;
            this.btn_eliminarorden.Click += new System.EventHandler(this.btn_eliminarorden_Click);
            // 
            // btn_enviarordenes
            // 
            this.btn_enviarordenes.Location = new System.Drawing.Point(640, 168);
            this.btn_enviarordenes.Name = "btn_enviarordenes";
            this.btn_enviarordenes.Size = new System.Drawing.Size(148, 44);
            this.btn_enviarordenes.TabIndex = 4;
            this.btn_enviarordenes.Text = "Enviar ordenes emitidas";
            this.btn_enviarordenes.UseVisualStyleBackColor = true;
            this.btn_enviarordenes.Click += new System.EventHandler(this.btn_enviarordenes_Click);
            // 
            // vista0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.btn_enviarordenes);
            this.Controls.Add(this.btn_eliminarorden);
            this.Controls.Add(this.btn_modificarorden);
            this.Controls.Add(this.btn_nuevaorden);
            this.Controls.Add(this.dgv_ordenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "vista0";
            this.Text = "Lista de ordenes de servicio";
            this.Load += new System.EventHandler(this.vista0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ordenes;
        private System.Windows.Forms.Button btn_nuevaorden;
        private System.Windows.Forms.Button btn_modificarorden;
        private System.Windows.Forms.Button btn_eliminarorden;
        private System.Windows.Forms.Button btn_enviarordenes;
    }
}

