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
            this.dgvFuncionSiguiente = new System.Windows.Forms.DataGridView();
            this.dgvFuncionPrimero = new System.Windows.Forms.DataGridView();
            this.dgvTerminalesSinRecursividad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVariablesSinRecursividad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtGramaticaSinRecursividad = new System.Windows.Forms.TextBox();
            this.lblGramaticaNoRecursiva = new System.Windows.Forms.Label();
            this.dgvProducciones = new System.Windows.Forms.DataGridView();
            this.lblContenidoArchivo = new System.Windows.Forms.Label();
            this.lblVariablesNoRecursivas = new System.Windows.Forms.Label();
            this.lblGramaticaRecursiva = new System.Windows.Forms.Label();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.ColumnaVariableRecursiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTerminales = new System.Windows.Forms.DataGridView();
            this.VariableTerminalRecursiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduccionesSinRecursividad = new System.Windows.Forms.DataGridView();
            this.lblFuncionPrimero = new System.Windows.Forms.Label();
            this.lblFuncionSiguiente = new System.Windows.Forms.Label();
            this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
            this.lblTablaSimbolos = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionPrimero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalesSinRecursividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesSinRecursividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionesSinRecursividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(970, 615);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 28);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtContenidoArchivo
            // 
            this.txtContenidoArchivo.BackColor = System.Drawing.SystemColors.Control;
            this.txtContenidoArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContenidoArchivo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtContenidoArchivo.Location = new System.Drawing.Point(20, 152);
            this.txtContenidoArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContenidoArchivo.Multiline = true;
            this.txtContenidoArchivo.Name = "txtContenidoArchivo";
            this.txtContenidoArchivo.ReadOnly = true;
            this.txtContenidoArchivo.Size = new System.Drawing.Size(136, 207);
            this.txtContenidoArchivo.TabIndex = 5;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 13;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.521007F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33539F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.460531F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.77089F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.460531F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.77089F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.460531F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.60587F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.775145F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77154F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.775145F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.77154F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.521007F));
            this.tlpPrincipal.Controls.Add(this.dgvFuncionSiguiente, 11, 5);
            this.tlpPrincipal.Controls.Add(this.dgvFuncionPrimero, 9, 5);
            this.tlpPrincipal.Controls.Add(this.dgvTerminalesSinRecursividad, 5, 7);
            this.tlpPrincipal.Controls.Add(this.dgvVariablesSinRecursividad, 3, 7);
            this.tlpPrincipal.Controls.Add(this.txtArchivo, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblAutor, 1, 1);
            this.tlpPrincipal.Controls.Add(this.btnLimpiar, 1, 8);
            this.tlpPrincipal.Controls.Add(this.txtGramaticaSinRecursividad, 1, 7);
            this.tlpPrincipal.Controls.Add(this.lblGramaticaNoRecursiva, 1, 6);
            this.tlpPrincipal.Controls.Add(this.txtContenidoArchivo, 1, 5);
            this.tlpPrincipal.Controls.Add(this.dgvProducciones, 7, 5);
            this.tlpPrincipal.Controls.Add(this.lblContenidoArchivo, 1, 4);
            this.tlpPrincipal.Controls.Add(this.lblVariablesNoRecursivas, 3, 3);
            this.tlpPrincipal.Controls.Add(this.lblGramaticaRecursiva, 1, 3);
            this.tlpPrincipal.Controls.Add(this.dgvVariables, 3, 5);
            this.tlpPrincipal.Controls.Add(this.dgvTerminales, 5, 5);
            this.tlpPrincipal.Controls.Add(this.dgvProduccionesSinRecursividad, 7, 7);
            this.tlpPrincipal.Controls.Add(this.btnSalir, 11, 8);
            this.tlpPrincipal.Controls.Add(this.lblFuncionPrimero, 9, 4);
            this.tlpPrincipal.Controls.Add(this.lblFuncionSiguiente, 11, 4);
            this.tlpPrincipal.Controls.Add(this.dgvTablaSimbolos, 9, 7);
            this.tlpPrincipal.Controls.Add(this.lblTablaSimbolos, 9, 6);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 10;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.816182F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.24299F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.282362F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.235301F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.084394F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53492F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.205184F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53492F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.247567F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.816184F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1082, 661);
            this.tlpPrincipal.TabIndex = 4;
            // 
            // dgvFuncionSiguiente
            // 
            this.dgvFuncionSiguiente.AllowUserToAddRows = false;
            this.dgvFuncionSiguiente.AllowUserToDeleteRows = false;
            this.dgvFuncionSiguiente.AllowUserToResizeColumns = false;
            this.dgvFuncionSiguiente.AllowUserToResizeRows = false;
            this.dgvFuncionSiguiente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFuncionSiguiente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionSiguiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionSiguiente.Location = new System.Drawing.Point(892, 150);
            this.dgvFuncionSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFuncionSiguiente.Name = "dgvFuncionSiguiente";
            this.dgvFuncionSiguiente.ReadOnly = true;
            this.dgvFuncionSiguiente.RowHeadersWidth = 51;
            this.dgvFuncionSiguiente.Size = new System.Drawing.Size(164, 211);
            this.dgvFuncionSiguiente.TabIndex = 27;
            // 
            // dgvFuncionPrimero
            // 
            this.dgvFuncionPrimero.AllowUserToAddRows = false;
            this.dgvFuncionPrimero.AllowUserToDeleteRows = false;
            this.dgvFuncionPrimero.AllowUserToResizeColumns = false;
            this.dgvFuncionPrimero.AllowUserToResizeRows = false;
            this.dgvFuncionPrimero.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFuncionPrimero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionPrimero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionPrimero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionPrimero.Location = new System.Drawing.Point(703, 150);
            this.dgvFuncionPrimero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFuncionPrimero.Name = "dgvFuncionPrimero";
            this.dgvFuncionPrimero.ReadOnly = true;
            this.dgvFuncionPrimero.RowHeadersWidth = 51;
            this.dgvFuncionPrimero.Size = new System.Drawing.Size(164, 211);
            this.dgvFuncionPrimero.TabIndex = 26;
            // 
            // dgvTerminalesSinRecursividad
            // 
            this.dgvTerminalesSinRecursividad.AllowUserToAddRows = false;
            this.dgvTerminalesSinRecursividad.AllowUserToDeleteRows = false;
            this.dgvTerminalesSinRecursividad.AllowUserToResizeColumns = false;
            this.dgvTerminalesSinRecursividad.AllowUserToResizeRows = false;
            this.dgvTerminalesSinRecursividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTerminalesSinRecursividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminalesSinRecursividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dgvTerminalesSinRecursividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerminalesSinRecursividad.Location = new System.Drawing.Point(309, 400);
            this.dgvTerminalesSinRecursividad.Name = "dgvTerminalesSinRecursividad";
            this.dgvTerminalesSinRecursividad.ReadOnly = true;
            this.dgvTerminalesSinRecursividad.RowHeadersVisible = false;
            this.dgvTerminalesSinRecursividad.RowHeadersWidth = 51;
            this.dgvTerminalesSinRecursividad.Size = new System.Drawing.Size(110, 209);
            this.dgvTerminalesSinRecursividad.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Terminal";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dgvVariablesSinRecursividad
            // 
            this.dgvVariablesSinRecursividad.AllowUserToAddRows = false;
            this.dgvVariablesSinRecursividad.AllowUserToDeleteRows = false;
            this.dgvVariablesSinRecursividad.AllowUserToResizeColumns = false;
            this.dgvVariablesSinRecursividad.AllowUserToResizeRows = false;
            this.dgvVariablesSinRecursividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVariablesSinRecursividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariablesSinRecursividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvVariablesSinRecursividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariablesSinRecursividad.Location = new System.Drawing.Point(178, 400);
            this.dgvVariablesSinRecursividad.Name = "dgvVariablesSinRecursividad";
            this.dgvVariablesSinRecursividad.ReadOnly = true;
            this.dgvVariablesSinRecursividad.RowHeadersVisible = false;
            this.dgvVariablesSinRecursividad.RowHeadersWidth = 51;
            this.dgvVariablesSinRecursividad.Size = new System.Drawing.Size(110, 209);
            this.dgvVariablesSinRecursividad.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Variable";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // txtArchivo
            // 
            this.txtArchivo.AllowDrop = true;
            this.txtArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPrincipal.SetColumnSpan(this.txtArchivo, 11);
            this.txtArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtArchivo.Location = new System.Drawing.Point(20, 48);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 2);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(1035, 29);
            this.txtArchivo.TabIndex = 1;
            this.txtArchivo.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragDrop);
            this.txtArchivo.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragEnter);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblAutor, 7);
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAutor.Location = new System.Drawing.Point(20, 15);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(65, 21);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "[Autor]";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.Location = new System.Drawing.Point(20, 614);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 30);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtGramaticaSinRecursividad
            // 
            this.txtGramaticaSinRecursividad.BackColor = System.Drawing.SystemColors.Control;
            this.txtGramaticaSinRecursividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGramaticaSinRecursividad.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtGramaticaSinRecursividad.Location = new System.Drawing.Point(20, 401);
            this.txtGramaticaSinRecursividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtGramaticaSinRecursividad.Multiline = true;
            this.txtGramaticaSinRecursividad.Name = "txtGramaticaSinRecursividad";
            this.txtGramaticaSinRecursividad.ReadOnly = true;
            this.txtGramaticaSinRecursividad.Size = new System.Drawing.Size(136, 207);
            this.txtGramaticaSinRecursividad.TabIndex = 15;
            // 
            // lblGramaticaNoRecursiva
            // 
            this.lblGramaticaNoRecursiva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblGramaticaNoRecursiva.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblGramaticaNoRecursiva, 7);
            this.lblGramaticaNoRecursiva.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramaticaNoRecursiva.Location = new System.Drawing.Point(283, 376);
            this.lblGramaticaNoRecursiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGramaticaNoRecursiva.Name = "lblGramaticaNoRecursiva";
            this.lblGramaticaNoRecursiva.Size = new System.Drawing.Size(130, 21);
            this.lblGramaticaNoRecursiva.TabIndex = 14;
            this.lblGramaticaNoRecursiva.Text = "Sin recursividad";
            // 
            // dgvProducciones
            // 
            this.dgvProducciones.AllowUserToAddRows = false;
            this.dgvProducciones.AllowUserToDeleteRows = false;
            this.dgvProducciones.AllowUserToResizeColumns = false;
            this.dgvProducciones.AllowUserToResizeRows = false;
            this.dgvProducciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProducciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducciones.Location = new System.Drawing.Point(440, 150);
            this.dgvProducciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducciones.Name = "dgvProducciones";
            this.dgvProducciones.ReadOnly = true;
            this.dgvProducciones.RowHeadersWidth = 51;
            this.dgvProducciones.Size = new System.Drawing.Size(238, 211);
            this.dgvProducciones.TabIndex = 12;
            // 
            // lblContenidoArchivo
            // 
            this.lblContenidoArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblContenidoArchivo.AutoSize = true;
            this.lblContenidoArchivo.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblContenidoArchivo.Location = new System.Drawing.Point(39, 115);
            this.lblContenidoArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoArchivo.Name = "lblContenidoArchivo";
            this.lblContenidoArchivo.Size = new System.Drawing.Size(97, 33);
            this.lblContenidoArchivo.TabIndex = 2;
            this.lblContenidoArchivo.Text = "Contenido del Archivo";
            // 
            // lblVariablesNoRecursivas
            // 
            this.lblVariablesNoRecursivas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVariablesNoRecursivas.AutoSize = true;
            this.lblVariablesNoRecursivas.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblVariablesNoRecursivas.Location = new System.Drawing.Point(690, 94);
            this.lblVariablesNoRecursivas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVariablesNoRecursivas.Name = "lblVariablesNoRecursivas";
            this.lblVariablesNoRecursivas.Size = new System.Drawing.Size(0, 21);
            this.lblVariablesNoRecursivas.TabIndex = 16;
            // 
            // lblGramaticaRecursiva
            // 
            this.lblGramaticaRecursiva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblGramaticaRecursiva.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblGramaticaRecursiva, 7);
            this.lblGramaticaRecursiva.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramaticaRecursiva.Location = new System.Drawing.Point(192, 93);
            this.lblGramaticaRecursiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGramaticaRecursiva.Name = "lblGramaticaRecursiva";
            this.lblGramaticaRecursiva.Size = new System.Drawing.Size(313, 22);
            this.lblGramaticaRecursiva.TabIndex = 18;
            this.lblGramaticaRecursiva.Text = "Información con gramática recursiva";
            // 
            // dgvVariables
            // 
            this.dgvVariables.AllowUserToAddRows = false;
            this.dgvVariables.AllowUserToDeleteRows = false;
            this.dgvVariables.AllowUserToResizeColumns = false;
            this.dgvVariables.AllowUserToResizeRows = false;
            this.dgvVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaVariableRecursiva});
            this.dgvVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariables.Location = new System.Drawing.Point(178, 151);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.ReadOnly = true;
            this.dgvVariables.RowHeadersVisible = false;
            this.dgvVariables.RowHeadersWidth = 51;
            this.dgvVariables.Size = new System.Drawing.Size(110, 209);
            this.dgvVariables.TabIndex = 19;
            // 
            // ColumnaVariableRecursiva
            // 
            this.ColumnaVariableRecursiva.HeaderText = "Variable";
            this.ColumnaVariableRecursiva.MinimumWidth = 6;
            this.ColumnaVariableRecursiva.Name = "ColumnaVariableRecursiva";
            this.ColumnaVariableRecursiva.ReadOnly = true;
            this.ColumnaVariableRecursiva.Width = 125;
            // 
            // dgvTerminales
            // 
            this.dgvTerminales.AllowUserToAddRows = false;
            this.dgvTerminales.AllowUserToDeleteRows = false;
            this.dgvTerminales.AllowUserToResizeColumns = false;
            this.dgvTerminales.AllowUserToResizeRows = false;
            this.dgvTerminales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTerminales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableTerminalRecursiva});
            this.dgvTerminales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerminales.Location = new System.Drawing.Point(309, 151);
            this.dgvTerminales.Name = "dgvTerminales";
            this.dgvTerminales.ReadOnly = true;
            this.dgvTerminales.RowHeadersVisible = false;
            this.dgvTerminales.RowHeadersWidth = 51;
            this.dgvTerminales.Size = new System.Drawing.Size(110, 209);
            this.dgvTerminales.TabIndex = 20;
            // 
            // VariableTerminalRecursiva
            // 
            this.VariableTerminalRecursiva.HeaderText = "Terminal";
            this.VariableTerminalRecursiva.MinimumWidth = 6;
            this.VariableTerminalRecursiva.Name = "VariableTerminalRecursiva";
            this.VariableTerminalRecursiva.ReadOnly = true;
            this.VariableTerminalRecursiva.Width = 125;
            // 
            // dgvProduccionesSinRecursividad
            // 
            this.dgvProduccionesSinRecursividad.AllowUserToAddRows = false;
            this.dgvProduccionesSinRecursividad.AllowUserToDeleteRows = false;
            this.dgvProduccionesSinRecursividad.AllowUserToResizeColumns = false;
            this.dgvProduccionesSinRecursividad.AllowUserToResizeRows = false;
            this.dgvProduccionesSinRecursividad.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvProduccionesSinRecursividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduccionesSinRecursividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccionesSinRecursividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduccionesSinRecursividad.Location = new System.Drawing.Point(440, 399);
            this.dgvProduccionesSinRecursividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduccionesSinRecursividad.Name = "dgvProduccionesSinRecursividad";
            this.dgvProduccionesSinRecursividad.ReadOnly = true;
            this.dgvProduccionesSinRecursividad.RowHeadersWidth = 51;
            this.dgvProduccionesSinRecursividad.Size = new System.Drawing.Size(238, 211);
            this.dgvProduccionesSinRecursividad.TabIndex = 23;
            // 
            // lblFuncionPrimero
            // 
            this.lblFuncionPrimero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFuncionPrimero.AutoSize = true;
            this.lblFuncionPrimero.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFuncionPrimero.Location = new System.Drawing.Point(730, 131);
            this.lblFuncionPrimero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionPrimero.Name = "lblFuncionPrimero";
            this.lblFuncionPrimero.Size = new System.Drawing.Size(110, 17);
            this.lblFuncionPrimero.TabIndex = 28;
            this.lblFuncionPrimero.Text = "Función primero";
            // 
            // lblFuncionSiguiente
            // 
            this.lblFuncionSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFuncionSiguiente.AutoSize = true;
            this.lblFuncionSiguiente.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFuncionSiguiente.Location = new System.Drawing.Point(915, 131);
            this.lblFuncionSiguiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionSiguiente.Name = "lblFuncionSiguiente";
            this.lblFuncionSiguiente.Size = new System.Drawing.Size(117, 17);
            this.lblFuncionSiguiente.TabIndex = 29;
            this.lblFuncionSiguiente.Text = "Función siguiente";
            // 
            // dgvTablaSimbolos
            // 
            this.dgvTablaSimbolos.AllowUserToAddRows = false;
            this.dgvTablaSimbolos.AllowUserToDeleteRows = false;
            this.dgvTablaSimbolos.AllowUserToResizeColumns = false;
            this.dgvTablaSimbolos.AllowUserToResizeRows = false;
            this.dgvTablaSimbolos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTablaSimbolos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpPrincipal.SetColumnSpan(this.dgvTablaSimbolos, 3);
            this.dgvTablaSimbolos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaSimbolos.Location = new System.Drawing.Point(703, 399);
            this.dgvTablaSimbolos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
            this.dgvTablaSimbolos.ReadOnly = true;
            this.dgvTablaSimbolos.RowHeadersWidth = 51;
            this.dgvTablaSimbolos.Size = new System.Drawing.Size(353, 211);
            this.dgvTablaSimbolos.TabIndex = 30;
            // 
            // lblTablaSimbolos
            // 
            this.lblTablaSimbolos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTablaSimbolos.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblTablaSimbolos, 3);
            this.lblTablaSimbolos.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTablaSimbolos.Location = new System.Drawing.Point(822, 380);
            this.lblTablaSimbolos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTablaSimbolos.Name = "lblTablaSimbolos";
            this.lblTablaSimbolos.Size = new System.Drawing.Size(115, 17);
            this.lblTablaSimbolos.TabIndex = 31;
            this.lblTablaSimbolos.Text = "Tabla de símbolos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 661);
            this.Controls.Add(this.tlpPrincipal);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio 1 - Compiladores";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionSiguiente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionPrimero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalesSinRecursividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesSinRecursividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionesSinRecursividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtContenidoArchivo;
        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Label lblContenidoArchivo;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.DataGridView dgvProducciones;
        private System.Windows.Forms.Label lblGramaticaNoRecursiva;
        private System.Windows.Forms.TextBox txtGramaticaSinRecursividad;
        private System.Windows.Forms.Label lblVariablesNoRecursivas;
        private System.Windows.Forms.Label lblGramaticaRecursiva;
        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVariableRecursiva;
        private System.Windows.Forms.DataGridView dgvTerminales;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableTerminalRecursiva;
        private System.Windows.Forms.DataGridView dgvProduccionesSinRecursividad;
        private System.Windows.Forms.DataGridView dgvTerminalesSinRecursividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvVariablesSinRecursividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvFuncionSiguiente;
        private System.Windows.Forms.DataGridView dgvFuncionPrimero;
        private System.Windows.Forms.Label lblFuncionPrimero;
        private System.Windows.Forms.Label lblFuncionSiguiente;
        private System.Windows.Forms.DataGridView dgvTablaSimbolos;
        private System.Windows.Forms.Label lblTablaSimbolos;
    }
}

