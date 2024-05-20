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
            this.dgvTerminalesSinRecursividad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVariablesSinRecursividad = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtGramaticaSinRecursividad = new System.Windows.Forms.TextBox();
            this.lblGramaticaNoRecursiva = new System.Windows.Forms.Label();
            this.dgvMatrizProducciones = new System.Windows.Forms.DataGridView();
            this.lblContenidoArchivo = new System.Windows.Forms.Label();
            this.lblVariablesNoRecursivas = new System.Windows.Forms.Label();
            this.lblGramaticaRecursiva = new System.Windows.Forms.Label();
            this.dgvVariablesRecursivas = new System.Windows.Forms.DataGridView();
            this.ColumnaVariableRecursiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTerminalesRecursivas = new System.Windows.Forms.DataGridView();
            this.VariableTerminalRecursiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMatrizProduccionesSinRecursividad = new System.Windows.Forms.DataGridView();
            this.dgvFuncionPrimera = new System.Windows.Forms.DataGridView();
            this.dgvFuncionSiguiente = new System.Windows.Forms.DataGridView();
            this.lblFuncionPrimero = new System.Windows.Forms.Label();
            this.lblFuncionSiguiente = new System.Windows.Forms.Label();
            this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
            this.lblTablaSimbolos = new System.Windows.Forms.Label();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalesSinRecursividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesSinRecursividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizProducciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesRecursivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalesRecursivas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizProduccionesSinRecursividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionPrimera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionSiguiente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(921, 615);
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
            this.txtContenidoArchivo.Location = new System.Drawing.Point(25, 152);
            this.txtContenidoArchivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContenidoArchivo.Multiline = true;
            this.txtContenidoArchivo.Name = "txtContenidoArchivo";
            this.txtContenidoArchivo.ReadOnly = true;
            this.txtContenidoArchivo.Size = new System.Drawing.Size(150, 207);
            this.txtContenidoArchivo.TabIndex = 5;
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.ColumnCount = 13;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.094529F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32392F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.377225F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.628F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.377225F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.628F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.377225F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.27366F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.673894F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73895F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.673894F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.73895F));
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.09453F));
            this.tlpPrincipal.Controls.Add(this.dgvFuncionSiguiente, 11, 5);
            this.tlpPrincipal.Controls.Add(this.dgvFuncionPrimera, 9, 5);
            this.tlpPrincipal.Controls.Add(this.dgvTerminalesSinRecursividad, 5, 7);
            this.tlpPrincipal.Controls.Add(this.dgvVariablesSinRecursividad, 3, 7);
            this.tlpPrincipal.Controls.Add(this.txtArchivo, 1, 2);
            this.tlpPrincipal.Controls.Add(this.lblAutor, 1, 1);
            this.tlpPrincipal.Controls.Add(this.btnLimpiar, 1, 8);
            this.tlpPrincipal.Controls.Add(this.txtGramaticaSinRecursividad, 1, 7);
            this.tlpPrincipal.Controls.Add(this.lblGramaticaNoRecursiva, 1, 6);
            this.tlpPrincipal.Controls.Add(this.txtContenidoArchivo, 1, 5);
            this.tlpPrincipal.Controls.Add(this.dgvMatrizProducciones, 7, 5);
            this.tlpPrincipal.Controls.Add(this.lblContenidoArchivo, 1, 4);
            this.tlpPrincipal.Controls.Add(this.lblVariablesNoRecursivas, 3, 3);
            this.tlpPrincipal.Controls.Add(this.lblGramaticaRecursiva, 1, 3);
            this.tlpPrincipal.Controls.Add(this.dgvVariablesRecursivas, 3, 5);
            this.tlpPrincipal.Controls.Add(this.dgvTerminalesRecursivas, 5, 5);
            this.tlpPrincipal.Controls.Add(this.dgvMatrizProduccionesSinRecursividad, 7, 7);
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
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.242992F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.282362F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.235301F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.084394F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53492F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.205185F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53492F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.247567F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.816184F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1036, 661);
            this.tlpPrincipal.TabIndex = 4;
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
            this.dgvTerminalesSinRecursividad.Location = new System.Drawing.Point(320, 400);
            this.dgvTerminalesSinRecursividad.Name = "dgvTerminalesSinRecursividad";
            this.dgvTerminalesSinRecursividad.ReadOnly = true;
            this.dgvTerminalesSinRecursividad.RowHeadersVisible = false;
            this.dgvTerminalesSinRecursividad.Size = new System.Drawing.Size(104, 209);
            this.dgvTerminalesSinRecursividad.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Terminal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            this.dgvVariablesSinRecursividad.Location = new System.Drawing.Point(196, 400);
            this.dgvVariablesSinRecursividad.Name = "dgvVariablesSinRecursividad";
            this.dgvVariablesSinRecursividad.ReadOnly = true;
            this.dgvVariablesSinRecursividad.RowHeadersVisible = false;
            this.dgvVariablesSinRecursividad.Size = new System.Drawing.Size(104, 209);
            this.dgvVariablesSinRecursividad.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Variable";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // txtArchivo
            // 
            this.txtArchivo.AllowDrop = true;
            this.txtArchivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tlpPrincipal.SetColumnSpan(this.txtArchivo, 11);
            this.txtArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivo.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.txtArchivo.Location = new System.Drawing.Point(25, 48);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 2);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(981, 29);
            this.txtArchivo.TabIndex = 1;
            this.txtArchivo.DragDrop += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragDrop);
            this.txtArchivo.DragEnter += new System.Windows.Forms.DragEventHandler(this.TxtArchivo_DragEnter);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblAutor, 7);
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblAutor.Location = new System.Drawing.Point(25, 15);
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
            this.btnLimpiar.Location = new System.Drawing.Point(25, 614);
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
            this.txtGramaticaSinRecursividad.Location = new System.Drawing.Point(25, 401);
            this.txtGramaticaSinRecursividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtGramaticaSinRecursividad.Multiline = true;
            this.txtGramaticaSinRecursividad.Name = "txtGramaticaSinRecursividad";
            this.txtGramaticaSinRecursividad.ReadOnly = true;
            this.txtGramaticaSinRecursividad.Size = new System.Drawing.Size(150, 207);
            this.txtGramaticaSinRecursividad.TabIndex = 15;
            // 
            // lblGramaticaNoRecursiva
            // 
            this.lblGramaticaNoRecursiva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblGramaticaNoRecursiva.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblGramaticaNoRecursiva, 7);
            this.lblGramaticaNoRecursiva.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramaticaNoRecursiva.Location = new System.Drawing.Point(260, 376);
            this.lblGramaticaNoRecursiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGramaticaNoRecursiva.Name = "lblGramaticaNoRecursiva";
            this.lblGramaticaNoRecursiva.Size = new System.Drawing.Size(130, 21);
            this.lblGramaticaNoRecursiva.TabIndex = 14;
            this.lblGramaticaNoRecursiva.Text = "Sin recursividad";
            // 
            // dgvMatrizProducciones
            // 
            this.dgvMatrizProducciones.AllowUserToAddRows = false;
            this.dgvMatrizProducciones.AllowUserToDeleteRows = false;
            this.dgvMatrizProducciones.AllowUserToResizeColumns = false;
            this.dgvMatrizProducciones.AllowUserToResizeRows = false;
            this.dgvMatrizProducciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatrizProducciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatrizProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizProducciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrizProducciones.Location = new System.Drawing.Point(444, 150);
            this.dgvMatrizProducciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatrizProducciones.Name = "dgvMatrizProducciones";
            this.dgvMatrizProducciones.ReadOnly = true;
            this.dgvMatrizProducciones.Size = new System.Drawing.Size(183, 211);
            this.dgvMatrizProducciones.TabIndex = 12;
            // 
            // lblContenidoArchivo
            // 
            this.lblContenidoArchivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblContenidoArchivo.AutoSize = true;
            this.lblContenidoArchivo.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblContenidoArchivo.Location = new System.Drawing.Point(28, 131);
            this.lblContenidoArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoArchivo.Name = "lblContenidoArchivo";
            this.lblContenidoArchivo.Size = new System.Drawing.Size(144, 17);
            this.lblContenidoArchivo.TabIndex = 2;
            this.lblContenidoArchivo.Text = "Contenido del Archivo";
            // 
            // lblVariablesNoRecursivas
            // 
            this.lblVariablesNoRecursivas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVariablesNoRecursivas.AutoSize = true;
            this.lblVariablesNoRecursivas.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lblVariablesNoRecursivas.Location = new System.Drawing.Point(638, 94);
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
            this.lblGramaticaRecursiva.Location = new System.Drawing.Point(169, 93);
            this.lblGramaticaRecursiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGramaticaRecursiva.Name = "lblGramaticaRecursiva";
            this.lblGramaticaRecursiva.Size = new System.Drawing.Size(313, 22);
            this.lblGramaticaRecursiva.TabIndex = 18;
            this.lblGramaticaRecursiva.Text = "Información con gramática recursiva";
            // 
            // dgvVariablesRecursivas
            // 
            this.dgvVariablesRecursivas.AllowUserToAddRows = false;
            this.dgvVariablesRecursivas.AllowUserToDeleteRows = false;
            this.dgvVariablesRecursivas.AllowUserToResizeColumns = false;
            this.dgvVariablesRecursivas.AllowUserToResizeRows = false;
            this.dgvVariablesRecursivas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVariablesRecursivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariablesRecursivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaVariableRecursiva});
            this.dgvVariablesRecursivas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVariablesRecursivas.Location = new System.Drawing.Point(196, 151);
            this.dgvVariablesRecursivas.Name = "dgvVariablesRecursivas";
            this.dgvVariablesRecursivas.ReadOnly = true;
            this.dgvVariablesRecursivas.RowHeadersVisible = false;
            this.dgvVariablesRecursivas.Size = new System.Drawing.Size(104, 209);
            this.dgvVariablesRecursivas.TabIndex = 19;
            // 
            // ColumnaVariableRecursiva
            // 
            this.ColumnaVariableRecursiva.HeaderText = "Variable";
            this.ColumnaVariableRecursiva.Name = "ColumnaVariableRecursiva";
            this.ColumnaVariableRecursiva.ReadOnly = true;
            // 
            // dgvTerminalesRecursivas
            // 
            this.dgvTerminalesRecursivas.AllowUserToAddRows = false;
            this.dgvTerminalesRecursivas.AllowUserToDeleteRows = false;
            this.dgvTerminalesRecursivas.AllowUserToResizeColumns = false;
            this.dgvTerminalesRecursivas.AllowUserToResizeRows = false;
            this.dgvTerminalesRecursivas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTerminalesRecursivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerminalesRecursivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableTerminalRecursiva});
            this.dgvTerminalesRecursivas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTerminalesRecursivas.Location = new System.Drawing.Point(320, 151);
            this.dgvTerminalesRecursivas.Name = "dgvTerminalesRecursivas";
            this.dgvTerminalesRecursivas.ReadOnly = true;
            this.dgvTerminalesRecursivas.RowHeadersVisible = false;
            this.dgvTerminalesRecursivas.Size = new System.Drawing.Size(104, 209);
            this.dgvTerminalesRecursivas.TabIndex = 20;
            // 
            // VariableTerminalRecursiva
            // 
            this.VariableTerminalRecursiva.HeaderText = "Terminal";
            this.VariableTerminalRecursiva.Name = "VariableTerminalRecursiva";
            this.VariableTerminalRecursiva.ReadOnly = true;
            // 
            // dgvMatrizProduccionesSinRecursividad
            // 
            this.dgvMatrizProduccionesSinRecursividad.AllowUserToAddRows = false;
            this.dgvMatrizProduccionesSinRecursividad.AllowUserToDeleteRows = false;
            this.dgvMatrizProduccionesSinRecursividad.AllowUserToResizeColumns = false;
            this.dgvMatrizProduccionesSinRecursividad.AllowUserToResizeRows = false;
            this.dgvMatrizProduccionesSinRecursividad.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMatrizProduccionesSinRecursividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatrizProduccionesSinRecursividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizProduccionesSinRecursividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatrizProduccionesSinRecursividad.Location = new System.Drawing.Point(444, 399);
            this.dgvMatrizProduccionesSinRecursividad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatrizProduccionesSinRecursividad.Name = "dgvMatrizProduccionesSinRecursividad";
            this.dgvMatrizProduccionesSinRecursividad.ReadOnly = true;
            this.dgvMatrizProduccionesSinRecursividad.Size = new System.Drawing.Size(183, 211);
            this.dgvMatrizProduccionesSinRecursividad.TabIndex = 23;
            // 
            // dgvFuncionPrimera
            // 
            this.dgvFuncionPrimera.AllowUserToAddRows = false;
            this.dgvFuncionPrimera.AllowUserToDeleteRows = false;
            this.dgvFuncionPrimera.AllowUserToResizeColumns = false;
            this.dgvFuncionPrimera.AllowUserToResizeRows = false;
            this.dgvFuncionPrimera.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFuncionPrimera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionPrimera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionPrimera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionPrimera.Location = new System.Drawing.Point(650, 150);
            this.dgvFuncionPrimera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFuncionPrimera.Name = "dgvFuncionPrimera";
            this.dgvFuncionPrimera.ReadOnly = true;
            this.dgvFuncionPrimera.Size = new System.Drawing.Size(167, 211);
            this.dgvFuncionPrimera.TabIndex = 26;
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
            this.dgvFuncionSiguiente.Location = new System.Drawing.Point(840, 150);
            this.dgvFuncionSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFuncionSiguiente.Name = "dgvFuncionSiguiente";
            this.dgvFuncionSiguiente.ReadOnly = true;
            this.dgvFuncionSiguiente.Size = new System.Drawing.Size(167, 211);
            this.dgvFuncionSiguiente.TabIndex = 27;
            // 
            // lblFuncionPrimero
            // 
            this.lblFuncionPrimero.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFuncionPrimero.AutoSize = true;
            this.lblFuncionPrimero.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblFuncionPrimero.Location = new System.Drawing.Point(678, 131);
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
            this.lblFuncionSiguiente.Location = new System.Drawing.Point(865, 131);
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
            this.dgvTablaSimbolos.Location = new System.Drawing.Point(650, 399);
            this.dgvTablaSimbolos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
            this.dgvTablaSimbolos.ReadOnly = true;
            this.dgvTablaSimbolos.Size = new System.Drawing.Size(357, 211);
            this.dgvTablaSimbolos.TabIndex = 30;
            // 
            // lblTablaSimbolos
            // 
            this.lblTablaSimbolos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTablaSimbolos.AutoSize = true;
            this.tlpPrincipal.SetColumnSpan(this.lblTablaSimbolos, 3);
            this.lblTablaSimbolos.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTablaSimbolos.Location = new System.Drawing.Point(771, 380);
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
            this.ClientSize = new System.Drawing.Size(1036, 661);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalesSinRecursividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesSinRecursividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizProducciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariablesRecursivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerminalesRecursivas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizProduccionesSinRecursividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionPrimera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionSiguiente)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvMatrizProducciones;
        private System.Windows.Forms.Label lblGramaticaNoRecursiva;
        private System.Windows.Forms.TextBox txtGramaticaSinRecursividad;
        private System.Windows.Forms.Label lblVariablesNoRecursivas;
        private System.Windows.Forms.Label lblGramaticaRecursiva;
        private System.Windows.Forms.DataGridView dgvVariablesRecursivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVariableRecursiva;
        private System.Windows.Forms.DataGridView dgvTerminalesRecursivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableTerminalRecursiva;
        private System.Windows.Forms.DataGridView dgvMatrizProduccionesSinRecursividad;
        private System.Windows.Forms.DataGridView dgvTerminalesSinRecursividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgvVariablesSinRecursividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvFuncionSiguiente;
        private System.Windows.Forms.DataGridView dgvFuncionPrimera;
        private System.Windows.Forms.Label lblFuncionPrimero;
        private System.Windows.Forms.Label lblFuncionSiguiente;
        private System.Windows.Forms.DataGridView dgvTablaSimbolos;
        private System.Windows.Forms.Label lblTablaSimbolos;
    }
}

