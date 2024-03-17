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
            this.lblContenidoArchivo = new System.Windows.Forms.Label();
            this.lblVariables = new System.Windows.Forms.Label();
            this.txtVariables = new System.Windows.Forms.TextBox();
            this.txtTerminales = new System.Windows.Forms.TextBox();
            this.lblTerminales = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(783, 556);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 30);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtContenidoArchivo
            // 
            this.txtContenidoArchivo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContenidoArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContenidoArchivo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtContenidoArchivo.Location = new System.Drawing.Point(58, 189);
            this.txtContenidoArchivo.Multiline = true;
            this.txtContenidoArchivo.Name = "txtContenidoArchivo";
            this.txtContenidoArchivo.ReadOnly = true;
            this.txtContenidoArchivo.Size = new System.Drawing.Size(379, 305);
            this.txtContenidoArchivo.TabIndex = 3;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 7;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.17646F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.64706F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882352F));
            this.tlpPrincipal.Controls.Add(this.txtContenidoArchivo, 1, 3);
            this.tlpPrincipal.Controls.Add(this.lblContenidoArchivo, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblVariables, 3, 2);
            this.tlpPrincipal.Controls.Add(this.txtVariables, 3, 3);
            this.tlpPrincipal.Controls.Add(this.txtTerminales, 5, 3);
            this.tlpPrincipal.Controls.Add(this.lblTerminales, 5, 2);
            this.tlpPrincipal.Controls.Add(this.btnSalir, 5, 4);
            this.tlpPrincipal.Controls.Add(this.btnLimpiar, 1, 4);
            this.tlpPrincipal.Controls.Add(this.txtArchivo, 1, 1);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 6;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPrincipal.Size = new System.Drawing.Size(936, 622);
            this.tlpPrincipal.TabIndex = 4;
            // 
            // lblContenidoArchivo
            // 
            this.lblContenidoArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblContenidoArchivo.AutoSize = true;
            this.lblContenidoArchivo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblContenidoArchivo.Location = new System.Drawing.Point(150, 164);
            this.lblContenidoArchivo.Name = "lblContenidoArchivo";
            this.lblContenidoArchivo.Size = new System.Drawing.Size(195, 22);
            this.lblContenidoArchivo.TabIndex = 4;
            this.lblContenidoArchivo.Text = "Contenido del Archivo";
            // 
            // lblVariables
            // 
            this.lblVariables.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVariables.AutoSize = true;
            this.lblVariables.Font = new System.Drawing.Font("Arial", 14F);
            this.lblVariables.Location = new System.Drawing.Point(533, 164);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(88, 22);
            this.lblVariables.TabIndex = 5;
            this.lblVariables.Text = "Variables";
            // 
            // txtVariables
            // 
            this.txtVariables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVariables.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVariables.Location = new System.Drawing.Point(498, 189);
            this.txtVariables.Multiline = true;
            this.txtVariables.Name = "txtVariables";
            this.txtVariables.ReadOnly = true;
            this.txtVariables.Size = new System.Drawing.Size(159, 305);
            this.txtVariables.TabIndex = 6;
            // 
            // txtTerminales
            // 
            this.txtTerminales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTerminales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminales.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTerminales.Location = new System.Drawing.Point(718, 189);
            this.txtTerminales.Multiline = true;
            this.txtTerminales.Name = "txtTerminales";
            this.txtTerminales.ReadOnly = true;
            this.txtTerminales.Size = new System.Drawing.Size(159, 305);
            this.txtTerminales.TabIndex = 7;
            // 
            // lblTerminales
            // 
            this.lblTerminales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTerminales.AutoSize = true;
            this.lblTerminales.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTerminales.Location = new System.Drawing.Point(746, 164);
            this.lblTerminales.Name = "lblTerminales";
            this.lblTerminales.Size = new System.Drawing.Size(102, 22);
            this.lblTerminales.TabIndex = 8;
            this.lblTerminales.Text = "Terminales";
            // 
            // txtArchivo
            // 
            this.txtArchivo.AllowDrop = true;
            this.txtArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPrincipal.SetColumnSpan(this.txtArchivo, 5);
            this.txtArchivo.Font = new System.Drawing.Font("Arial", 13F);
            this.txtArchivo.Location = new System.Drawing.Point(58, 64);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(819, 27);
            this.txtArchivo.TabIndex = 9;
            this.txtArchivo.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragDrop);
            this.txtArchivo.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragEnter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(58, 556);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 622);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 1 - Compiladores";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
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
    }
}

