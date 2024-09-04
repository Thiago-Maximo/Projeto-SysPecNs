namespace SysPecNsDesk
{
    partial class FrmFornecedores
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
            TabCtFornecedores = new TabControl();
            CadFornecedores = new TabPage();
            dgvFornecedor = new DataGridView();
            clnIdFornecedor = new DataGridViewTextBoxColumn();
            clnNomeFantasia = new DataGridViewTextBoxColumn();
            clnCnpj = new DataGridViewTextBoxColumn();
            clnEmailFornecedor = new DataGridViewTextBoxColumn();
            clnContatoFornecedor = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnTelefoneFornecedor = new DataGridViewTextBoxColumn();
            clnCategoriaFornecedor = new DataGridViewTextBoxColumn();
            lblCategoriaFornecedor = new Label();
            cmbCategoriaFornecedor = new ComboBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtContatoFornecedor = new TextBox();
            txtRazaoSocial = new TextBox();
            txtTelefoneFornecedor = new TextBox();
            txtEmailFornecedor = new TextBox();
            txtCnpj = new TextBox();
            txtNomeFantasia = new TextBox();
            txtIDFornecedor = new TextBox();
            lblFantasia = new Label();
            lblEmailFornecedor = new Label();
            lblTelefoneFornecedor = new Label();
            lblContatoFornecedor = new Label();
            lblCnpj = new Label();
            lblRazaoSocial = new Label();
            lblIDFornecedor = new Label();
            ListaFornecedores = new TabPage();
            txtBuscaFornecedor = new TextBox();
            TabCtFornecedores.SuspendLayout();
            CadFornecedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // TabCtFornecedores
            // 
            TabCtFornecedores.Controls.Add(CadFornecedores);
            TabCtFornecedores.Controls.Add(ListaFornecedores);
            TabCtFornecedores.Location = new Point(88, 42);
            TabCtFornecedores.Name = "TabCtFornecedores";
            TabCtFornecedores.SelectedIndex = 0;
            TabCtFornecedores.Size = new Size(574, 386);
            TabCtFornecedores.TabIndex = 0;
            // 
            // CadFornecedores
            // 
            CadFornecedores.Controls.Add(txtBuscaFornecedor);
            CadFornecedores.Controls.Add(dgvFornecedor);
            CadFornecedores.Controls.Add(lblCategoriaFornecedor);
            CadFornecedores.Controls.Add(cmbCategoriaFornecedor);
            CadFornecedores.Controls.Add(btnConsultar);
            CadFornecedores.Controls.Add(btnEditar);
            CadFornecedores.Controls.Add(btnAdicionar);
            CadFornecedores.Controls.Add(txtContatoFornecedor);
            CadFornecedores.Controls.Add(txtRazaoSocial);
            CadFornecedores.Controls.Add(txtTelefoneFornecedor);
            CadFornecedores.Controls.Add(txtEmailFornecedor);
            CadFornecedores.Controls.Add(txtCnpj);
            CadFornecedores.Controls.Add(txtNomeFantasia);
            CadFornecedores.Controls.Add(txtIDFornecedor);
            CadFornecedores.Controls.Add(lblFantasia);
            CadFornecedores.Controls.Add(lblEmailFornecedor);
            CadFornecedores.Controls.Add(lblTelefoneFornecedor);
            CadFornecedores.Controls.Add(lblContatoFornecedor);
            CadFornecedores.Controls.Add(lblCnpj);
            CadFornecedores.Controls.Add(lblRazaoSocial);
            CadFornecedores.Controls.Add(lblIDFornecedor);
            CadFornecedores.Location = new Point(4, 24);
            CadFornecedores.Name = "CadFornecedores";
            CadFornecedores.Padding = new Padding(3);
            CadFornecedores.Size = new Size(566, 358);
            CadFornecedores.TabIndex = 0;
            CadFornecedores.Text = "Cadastro de Fornecedores";
            CadFornecedores.UseVisualStyleBackColor = true;
            CadFornecedores.Click += CadFornecedores_Click;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { clnIdFornecedor, clnNomeFantasia, clnCnpj, clnEmailFornecedor, clnContatoFornecedor, clnRazaoSocial, clnTelefoneFornecedor, clnCategoriaFornecedor });
            dgvFornecedor.Location = new Point(49, 215);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.Size = new Size(456, 140);
            dgvFornecedor.TabIndex = 19;
            // 
            // clnIdFornecedor
            // 
            clnIdFornecedor.HeaderText = "ID";
            clnIdFornecedor.Name = "clnIdFornecedor";
            clnIdFornecedor.ReadOnly = true;
            clnIdFornecedor.Width = 60;
            // 
            // clnNomeFantasia
            // 
            clnNomeFantasia.HeaderText = "Nome Fantasia";
            clnNomeFantasia.Name = "clnNomeFantasia";
            clnNomeFantasia.ReadOnly = true;
            clnNomeFantasia.Width = 120;
            // 
            // clnCnpj
            // 
            clnCnpj.HeaderText = "CNPJ";
            clnCnpj.Name = "clnCnpj";
            clnCnpj.ReadOnly = true;
            clnCnpj.Width = 60;
            // 
            // clnEmailFornecedor
            // 
            clnEmailFornecedor.HeaderText = "Email";
            clnEmailFornecedor.Name = "clnEmailFornecedor";
            clnEmailFornecedor.ReadOnly = true;
            clnEmailFornecedor.Width = 80;
            // 
            // clnContatoFornecedor
            // 
            clnContatoFornecedor.HeaderText = "Contato";
            clnContatoFornecedor.Name = "clnContatoFornecedor";
            clnContatoFornecedor.ReadOnly = true;
            clnContatoFornecedor.Width = 80;
            // 
            // clnRazaoSocial
            // 
            clnRazaoSocial.HeaderText = "Razão Social";
            clnRazaoSocial.Name = "clnRazaoSocial";
            clnRazaoSocial.ReadOnly = true;
            clnRazaoSocial.Width = 120;
            // 
            // clnTelefoneFornecedor
            // 
            clnTelefoneFornecedor.HeaderText = "Telefone";
            clnTelefoneFornecedor.Name = "clnTelefoneFornecedor";
            clnTelefoneFornecedor.ReadOnly = true;
            // 
            // clnCategoriaFornecedor
            // 
            clnCategoriaFornecedor.HeaderText = "Categoria";
            clnCategoriaFornecedor.Name = "clnCategoriaFornecedor";
            clnCategoriaFornecedor.ReadOnly = true;
            // 
            // lblCategoriaFornecedor
            // 
            lblCategoriaFornecedor.AutoSize = true;
            lblCategoriaFornecedor.Location = new Point(385, 84);
            lblCategoriaFornecedor.Name = "lblCategoriaFornecedor";
            lblCategoriaFornecedor.Size = new Size(120, 15);
            lblCategoriaFornecedor.TabIndex = 18;
            lblCategoriaFornecedor.Text = "Categoria de Produto";
            // 
            // cmbCategoriaFornecedor
            // 
            cmbCategoriaFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaFornecedor.FormattingEnabled = true;
            cmbCategoriaFornecedor.Location = new Point(383, 102);
            cmbCategoriaFornecedor.Name = "cmbCategoriaFornecedor";
            cmbCategoriaFornecedor.Size = new Size(121, 23);
            cmbCategoriaFornecedor.TabIndex = 17;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(261, 148);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(155, 148);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Enabled = false;
            btnAdicionar.Location = new Point(49, 148);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtContatoFornecedor
            // 
            txtContatoFornecedor.Location = new Point(49, 102);
            txtContatoFornecedor.Name = "txtContatoFornecedor";
            txtContatoFornecedor.Size = new Size(98, 23);
            txtContatoFornecedor.TabIndex = 13;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(107, 38);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(100, 23);
            txtRazaoSocial.TabIndex = 12;
            // 
            // txtTelefoneFornecedor
            // 
            txtTelefoneFornecedor.Location = new Point(159, 102);
            txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            txtTelefoneFornecedor.Size = new Size(100, 23);
            txtTelefoneFornecedor.TabIndex = 11;
            // 
            // txtEmailFornecedor
            // 
            txtEmailFornecedor.Location = new Point(271, 102);
            txtEmailFornecedor.Name = "txtEmailFornecedor";
            txtEmailFornecedor.Size = new Size(100, 23);
            txtEmailFornecedor.TabIndex = 10;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(323, 38);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(100, 23);
            txtCnpj.TabIndex = 9;
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(215, 38);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(100, 23);
            txtNomeFantasia.TabIndex = 8;
            // 
            // txtIDFornecedor
            // 
            txtIDFornecedor.Location = new Point(49, 38);
            txtIDFornecedor.Name = "txtIDFornecedor";
            txtIDFornecedor.Size = new Size(50, 23);
            txtIDFornecedor.TabIndex = 7;
            // 
            // lblFantasia
            // 
            lblFantasia.AutoSize = true;
            lblFantasia.Location = new Point(216, 20);
            lblFantasia.Name = "lblFantasia";
            lblFantasia.Size = new Size(86, 15);
            lblFantasia.TabIndex = 6;
            lblFantasia.Text = "Nome Fantasia";
            // 
            // lblEmailFornecedor
            // 
            lblEmailFornecedor.AutoSize = true;
            lblEmailFornecedor.Location = new Point(271, 84);
            lblEmailFornecedor.Name = "lblEmailFornecedor";
            lblEmailFornecedor.Size = new Size(36, 15);
            lblEmailFornecedor.TabIndex = 5;
            lblEmailFornecedor.Text = "Email";
            // 
            // lblTelefoneFornecedor
            // 
            lblTelefoneFornecedor.AutoSize = true;
            lblTelefoneFornecedor.Location = new Point(155, 84);
            lblTelefoneFornecedor.Name = "lblTelefoneFornecedor";
            lblTelefoneFornecedor.Size = new Size(51, 15);
            lblTelefoneFornecedor.TabIndex = 4;
            lblTelefoneFornecedor.Text = "Telefone";
            // 
            // lblContatoFornecedor
            // 
            lblContatoFornecedor.AutoSize = true;
            lblContatoFornecedor.Location = new Point(51, 84);
            lblContatoFornecedor.Name = "lblContatoFornecedor";
            lblContatoFornecedor.Size = new Size(50, 15);
            lblContatoFornecedor.TabIndex = 3;
            lblContatoFornecedor.Text = "Contato";
            // 
            // lblCnpj
            // 
            lblCnpj.AutoSize = true;
            lblCnpj.Location = new Point(353, 20);
            lblCnpj.Name = "lblCnpj";
            lblCnpj.Size = new Size(34, 15);
            lblCnpj.TabIndex = 2;
            lblCnpj.Text = "CNPJ";
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(107, 20);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(72, 15);
            lblRazaoSocial.TabIndex = 1;
            lblRazaoSocial.Text = "Razão Social";
            // 
            // lblIDFornecedor
            // 
            lblIDFornecedor.AutoSize = true;
            lblIDFornecedor.Location = new Point(49, 20);
            lblIDFornecedor.Name = "lblIDFornecedor";
            lblIDFornecedor.Size = new Size(18, 15);
            lblIDFornecedor.TabIndex = 0;
            lblIDFornecedor.Text = "ID";
            // 
            // ListaFornecedores
            // 
            ListaFornecedores.Location = new Point(4, 24);
            ListaFornecedores.Name = "ListaFornecedores";
            ListaFornecedores.Padding = new Padding(3);
            ListaFornecedores.Size = new Size(566, 330);
            ListaFornecedores.TabIndex = 1;
            ListaFornecedores.Text = "Lista de Fornecedores";
            ListaFornecedores.UseVisualStyleBackColor = true;
            // 
            // txtBuscaFornecedor
            // 
            txtBuscaFornecedor.Location = new Point(49, 186);
            txtBuscaFornecedor.Name = "txtBuscaFornecedor";
            txtBuscaFornecedor.Size = new Size(455, 23);
            txtBuscaFornecedor.TabIndex = 20;
            txtBuscaFornecedor.TextChanged += txtBuscaFornecedor_TextChanged;
            // 
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabCtFornecedores);
            Name = "FrmFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFornecedores";
            Load += FrmFornecedores_Load;
            TabCtFornecedores.ResumeLayout(false);
            CadFornecedores.ResumeLayout(false);
            CadFornecedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabCtFornecedores;
        private TabPage CadFornecedores;
        private TabPage ListaFornecedores;
        private Label lblContatoFornecedor;
        private Label lblCnpj;
        private Label lblRazaoSocial;
        private Label lblIDFornecedor;
        private Label lblFantasia;
        private Label lblEmailFornecedor;
        private Label lblTelefoneFornecedor;
        private TextBox txtContatoFornecedor;
        private TextBox txtRazaoSocial;
        private TextBox txtTelefoneFornecedor;
        private TextBox txtEmailFornecedor;
        private TextBox txtCnpj;
        private TextBox txtNomeFantasia;
        private TextBox txtIDFornecedor;
        private Label lblCategoriaFornecedor;
        private ComboBox cmbCategoriaFornecedor;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private DataGridView dgvFornecedor;
        private DataGridViewTextBoxColumn clnIdFornecedor;
        private DataGridViewTextBoxColumn clnNomeFantasia;
        private DataGridViewTextBoxColumn clnCnpj;
        private DataGridViewTextBoxColumn clnEmailFornecedor;
        private DataGridViewTextBoxColumn clnContatoFornecedor;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnTelefoneFornecedor;
        private DataGridViewTextBoxColumn clnCategoriaFornecedor;
        private TextBox txtBuscaFornecedor;
    }
}