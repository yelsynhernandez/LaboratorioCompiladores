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
            this.lblTotalTerminales = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtVariables = new System.Windows.Forms.TextBox();
            this.txtTerminales = new System.Windows.Forms.TextBox();
            this.lblTerminales = new System.Windows.Forms.Label();
            this.lblVariables = new System.Windows.Forms.Label();
            this.lblContenidoArchivo = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTotalVariables = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(958, 559);
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
            this.txtContenidoArchivo.Location = new System.Drawing.Point(38, 195);
            this.txtContenidoArchivo.Margin = new System.Windows.Forms.Padding(5);
            this.txtContenidoArchivo.Multiline = true;
            this.txtContenidoArchivo.Name = "txtContenidoArchivo";
            this.txtContenidoArchivo.ReadOnly = true;
            this.txtContenidoArchivo.Size = new System.Drawing.Size(492, 272);
            this.txtContenidoArchivo.TabIndex = 5;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 7;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.02611F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.39165F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.095299F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.18277F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.095299F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.18277F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.02611F));
            this.tlpPrincipal.Controls.Add(this.lblTotalTerminales, 5, 5);
            this.tlpPrincipal.Controls.Add(this.btnSalir, 5, 6);
            this.tlpPrincipal.Controls.Add(this.btnLimpiar, 1, 6);
            this.tlpPrincipal.Controls.Add(this.txtContenidoArchivo, 1, 4);
            this.tlpPrincipal.Controls.Add(this.txtVariables, 3, 4);
            this.tlpPrincipal.Controls.Add(this.txtTerminales, 5, 4);
            this.tlpPrincipal.Controls.Add(this.lblTerminales, 5, 3);
            this.tlpPrincipal.Controls.Add(this.lblVariables, 3, 3);
            this.tlpPrincipal.Controls.Add(this.lblContenidoArchivo, 1, 3);
            this.tlpPrincipal.Controls.Add(this.txtArchivo, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblAutor, 1, 1);
            this.tlpPrincipal.Controls.Add(this.lblTotalVariables, 3, 5);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 8;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.938614F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.020302F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.020302F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02742F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.12761F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.049911F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.87723F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.938614F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1106, 640);
            this.tlpPrincipal.TabIndex = 4;
            // 
            // lblTotalTerminales
            // 
            this.lblTotalTerminales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalTerminales.AutoSize = true;
            this.lblTotalTerminales.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTotalTerminales.Location = new System.Drawing.Point(878, 477);
            this.lblTotalTerminales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.lblTotalTerminales.Name = "lblTotalTerminales";
            this.lblTotalTerminales.Size = new System.Drawing.Size(152, 46);
            this.lblTotalTerminales.TabIndex = 9;
            this.lblTotalTerminales.Text = "[Total terminales]";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(37, 560);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(109, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtVariables
            // 
            this.txtVariables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVariables.Font = new System.Drawing.Font("Arial", 12F);
            this.txtVariables.Location = new System.Drawing.Point(573, 193);
            this.txtVariables.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVariables.Multiline = true;
            this.txtVariables.Name = "txtVariables";
            this.txtVariables.ReadOnly = true;
            this.txtVariables.Size = new System.Drawing.Size(226, 276);
            this.txtVariables.TabIndex = 6;
            // 
            // txtTerminales
            // 
            this.txtTerminales.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTerminales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTerminales.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTerminales.Location = new System.Drawing.Point(841, 193);
            this.txtTerminales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTerminales.Multiline = true;
            this.txtTerminales.Name = "txtTerminales";
            this.txtTerminales.ReadOnly = true;
            this.txtTerminales.Size = new System.Drawing.Size(226, 276);
            this.txtTerminales.TabIndex = 7;
            // 
            // lblTerminales
            // 
            this.lblTerminales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTerminales.AutoSize = true;
            this.lblTerminales.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTerminales.Location = new System.Drawing.Point(903, 168);
            this.lblTerminales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminales.Name = "lblTerminales";
            this.lblTerminales.Size = new System.Drawing.Size(102, 22);
            this.lblTerminales.TabIndex = 4;
            this.lblTerminales.Text = "Terminales";
            // 
            // lblVariables
            // 
            this.lblVariables.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVariables.AutoSize = true;
            this.lblVariables.Font = new System.Drawing.Font("Arial", 14F);
            this.lblVariables.Location = new System.Drawing.Point(642, 168);
            this.lblVariables.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(88, 22);
            this.lblVariables.TabIndex = 3;
            this.lblVariables.Text = "Variables";
            // 
            // lblContenidoArchivo
            // 
            this.lblContenidoArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblContenidoArchivo.AutoSize = true;
            this.lblContenidoArchivo.Font = new System.Drawing.Font("Arial", 14F);
            this.lblContenidoArchivo.Location = new System.Drawing.Point(186, 168);
            this.lblContenidoArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoArchivo.Name = "lblContenidoArchivo";
            this.lblContenidoArchivo.Size = new System.Drawing.Size(195, 22);
            this.lblContenidoArchivo.TabIndex = 2;
            this.lblContenidoArchivo.Text = "Contenido del Archivo";
            // 
            // txtArchivo
            // 
            this.txtArchivo.AllowDrop = true;
            this.txtArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPrincipal.SetColumnSpan(this.txtArchivo, 5);
            this.txtArchivo.Font = new System.Drawing.Font("Arial", 14F);
            this.txtArchivo.Location = new System.Drawing.Point(37, 89);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(1030, 29);
            this.txtArchivo.TabIndex = 1;
            this.txtArchivo.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragDrop);
            this.txtArchivo.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragEnter);
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAutor.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblAutor, 5);
            this.lblAutor.Location = new System.Drawing.Point(37, 64);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(53, 18);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "[Autor]";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalVariables
            // 
            this.lblTotalVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTotalVariables.AutoSize = true;
            this.lblTotalVariables.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTotalVariables.Location = new System.Drawing.Point(616, 477);
            this.lblTotalVariables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.lblTotalVariables.Name = "lblTotalVariables";
            this.lblTotalVariables.Size = new System.Drawing.Size(140, 46);
            this.lblTotalVariables.TabIndex = 8;
            this.lblTotalVariables.Text = "[Total variables]";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
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
        private System.Windows.Forms.Label lblTotalVariables;
        private System.Windows.Forms.Label lblTotalTerminales;
    }
}

