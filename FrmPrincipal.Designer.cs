namespace LaboratorioCompiladores
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtContenidoArchivo = new System.Windows.Forms.TextBox();
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.txtVariables = new System.Windows.Forms.TextBox();
            this.txtTerminales = new System.Windows.Forms.TextBox();
            this.lblTerminales = new System.Windows.Forms.Label();
            this.lblVariables = new System.Windows.Forms.Label();
            this.lblContenidoArchivo = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.dgvMatrizProducciones = new System.Windows.Forms.DataGridView();
            this.lblMatrizProducciones = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizProducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(952, 576);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 36);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtContenidoArchivo
            // 
            this.txtContenidoArchivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContenidoArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContenidoArchivo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtContenidoArchivo.Location = new System.Drawing.Point(41, 195);
            this.txtContenidoArchivo.Margin = new System.Windows.Forms.Padding(5);
            this.txtContenidoArchivo.Multiline = true;
            this.txtContenidoArchivo.Name = "txtContenidoArchivo";
            this.txtContenidoArchivo.ReadOnly = true;
            this.txtContenidoArchivo.Size = new System.Drawing.Size(319, 274);
            this.txtContenidoArchivo.TabIndex = 5;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 9;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.309811F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.82112F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0034F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14852F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0034F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14852F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.988074F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.26734F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.309811F));
            this.tlpPrincipal.Controls.Add(this.txtContenidoArchivo, 1, 4);
            this.tlpPrincipal.Controls.Add(this.txtVariables, 3, 4);
            this.tlpPrincipal.Controls.Add(this.txtTerminales, 5, 4);
            this.tlpPrincipal.Controls.Add(this.lblTerminales, 5, 3);
            this.tlpPrincipal.Controls.Add(this.lblVariables, 3, 3);
            this.tlpPrincipal.Controls.Add(this.lblContenidoArchivo, 1, 3);
            this.tlpPrincipal.Controls.Add(this.txtArchivo, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblAutor, 1, 1);
            this.tlpPrincipal.Controls.Add(this.dgvMatrizProducciones, 7, 4);
            this.tlpPrincipal.Controls.Add(this.lblMatrizProducciones, 7, 3);
            this.tlpPrincipal.Controls.Add(this.btnLimpiar, 1, 5);
            this.tlpPrincipal.Controls.Add(this.btnSalir, 7, 5);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 7;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.777778F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.333333F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1106, 640);
            this.tlpPrincipal.TabIndex = 4;
            // 
            // txtVariables
            // 
            this.txtVariables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVariables.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVariables.Location = new System.Drawing.Point(391, 193);
            this.txtVariables.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVariables.Multiline = true;
            this.txtVariables.Name = "txtVariables";
            this.txtVariables.ReadOnly = true;
            this.txtVariables.Size = new System.Drawing.Size(159, 278);
            this.txtVariables.TabIndex = 6;
            // 
            // txtTerminales
            // 
            this.txtTerminales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTerminales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminales.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTerminales.Location = new System.Drawing.Point(580, 193);
            this.txtTerminales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTerminales.Multiline = true;
            this.txtTerminales.Name = "txtTerminales";
            this.txtTerminales.ReadOnly = true;
            this.txtTerminales.Size = new System.Drawing.Size(159, 278);
            this.txtTerminales.TabIndex = 7;
            // 
            // lblTerminales
            // 
            this.lblTerminales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTerminales.AutoSize = true;
            this.lblTerminales.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTerminales.Location = new System.Drawing.Point(596, 163);
            this.lblTerminales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminales.Name = "lblTerminales";
            this.lblTerminales.Size = new System.Drawing.Size(127, 27);
            this.lblTerminales.TabIndex = 4;
            this.lblTerminales.Text = "Terminales";
            // 
            // lblVariables
            // 
            this.lblVariables.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVariables.AutoSize = true;
            this.lblVariables.Font = new System.Drawing.Font("Arial", 14F);
            this.lblVariables.Location = new System.Drawing.Point(416, 163);
            this.lblVariables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(109, 27);
            this.lblVariables.TabIndex = 3;
            this.lblVariables.Text = "Variables";
            // 
            // lblContenidoArchivo
            // 
            this.lblContenidoArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblContenidoArchivo.AutoSize = true;
            this.lblContenidoArchivo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblContenidoArchivo.Location = new System.Drawing.Point(77, 163);
            this.lblContenidoArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoArchivo.Name = "lblContenidoArchivo";
            this.lblContenidoArchivo.Size = new System.Drawing.Size(246, 27);
            this.lblContenidoArchivo.TabIndex = 2;
            this.lblContenidoArchivo.Text = "Contenido del Archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.AllowDrop = true;
            this.txtArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPrincipal.SetColumnSpan(this.txtArchivo, 7);
            this.txtArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivo.Font = new System.Drawing.Font("Arial", 14F);
            this.txtArchivo.Location = new System.Drawing.Point(40, 80);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 10, 4, 3);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(1021, 34);
            this.txtArchivo.TabIndex = 1;
            this.txtArchivo.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragDrop);
            this.txtArchivo.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragEnter);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblAutor, 7);
            this.lblAutor.Font = new System.Drawing.Font("Arial", 14F);
            this.lblAutor.Location = new System.Drawing.Point(40, 25);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(83, 27);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "[Autor]";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMatrizProducciones
            // 
            this.dgvMatrizProducciones.AllowUserToAddRows = false;
            this.dgvMatrizProducciones.AllowUserToDeleteRows = false;
            this.dgvMatrizProducciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatrizProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizProducciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrizProducciones.Location = new System.Drawing.Point(767, 193);
            this.dgvMatrizProducciones.Name = "dgvMatrizProducciones";
            this.dgvMatrizProducciones.ReadOnly = true;
            this.dgvMatrizProducciones.RowHeadersWidth = 51;
            this.dgvMatrizProducciones.Size = new System.Drawing.Size(295, 278);
            this.dgvMatrizProducciones.TabIndex = 12;
            // 
            // lblMatrizProducciones
            // 
            this.lblMatrizProducciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMatrizProducciones.AutoSize = true;
            this.lblMatrizProducciones.Font = new System.Drawing.Font("Arial", 14F);
            this.lblMatrizProducciones.Location = new System.Drawing.Point(784, 163);
            this.lblMatrizProducciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatrizProducciones.Name = "lblMatrizProducciones";
            this.lblMatrizProducciones.Size = new System.Drawing.Size(261, 27);
            this.lblMatrizProducciones.TabIndex = 13;
            this.lblMatrizProducciones.Text = "Matriz de producciones";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(40, 577);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 640);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 1 - Compiladores";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizProducciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtContenidoArchivo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblContenidoArchivo;
        private System.Windows.Forms.Label lblVariables;
        private System.Windows.Forms.TextBox txtVariables;
        private System.Windows.Forms.TextBox txtTerminales;
        private System.Windows.Forms.Label lblTerminales;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.DataGridView dgvMatrizProducciones;
        private System.Windows.Forms.Label lblMatrizProducciones;
    }
}

