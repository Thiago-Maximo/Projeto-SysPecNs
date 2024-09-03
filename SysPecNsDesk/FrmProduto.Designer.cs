namespace SysPecNsDesk
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            GpProdutos = new GroupBox();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            txtDesconto = new TextBox();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            nmrEstoque = new NumericUpDown();
            txtUnidadeVenda = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBarras = new TextBox();
            txtID = new TextBox();
            lblDesconto = new Label();
            lblCategoriaProduto = new Label();
            lblDescricaoProduto = new Label();
            lblEstoque = new Label();
            lblUnidadeVenda = new Label();
            lblValorUnitario = new Label();
            lblCodigoBarra = new Label();
            lblIdProduto = new Label();
            dgvProdutos = new DataGridView();
            clnID = new DataGridViewTextBoxColumn();
            clnCodbarras = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnUnidadeVenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMin = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDataCad = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            txtProdutos = new TextBox();
            GpProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // GpProdutos
            // 
            GpProdutos.Controls.Add(btnConsultar);
            GpProdutos.Controls.Add(btnEditar);
            GpProdutos.Controls.Add(btnAdicionar);
            GpProdutos.Controls.Add(txtDesconto);
            GpProdutos.Controls.Add(cmbCategoria);
            GpProdutos.Controls.Add(txtDescricao);
            GpProdutos.Controls.Add(nmrEstoque);
            GpProdutos.Controls.Add(txtUnidadeVenda);
            GpProdutos.Controls.Add(txtValorUnit);
            GpProdutos.Controls.Add(txtCodBarras);
            GpProdutos.Controls.Add(txtID);
            GpProdutos.Controls.Add(lblDesconto);
            GpProdutos.Controls.Add(lblCategoriaProduto);
            GpProdutos.Controls.Add(lblDescricaoProduto);
            GpProdutos.Controls.Add(lblEstoque);
            GpProdutos.Controls.Add(lblUnidadeVenda);
            GpProdutos.Controls.Add(lblValorUnitario);
            GpProdutos.Controls.Add(lblCodigoBarra);
            GpProdutos.Controls.Add(lblIdProduto);
            GpProdutos.Location = new Point(119, 43);
            GpProdutos.Name = "GpProdutos";
            GpProdutos.Size = new Size(535, 229);
            GpProdutos.TabIndex = 0;
            GpProdutos.TabStop = false;
            GpProdutos.Text = "Cadastro de Produtos";
            // 
            // btnConsultar
            // 
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.Location = new Point(416, 155);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(102, 42);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Location = new Point(307, 155);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 42);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Image = Properties.Resources.Add;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(198, 155);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(102, 42);
            btnAdicionar.TabIndex = 16;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(92, 166);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 15;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(302, 122);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(208, 23);
            cmbCategoria.TabIndex = 14;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(92, 122);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(199, 23);
            txtDescricao.TabIndex = 13;
            // 
            // nmrEstoque
            // 
            nmrEstoque.Location = new Point(415, 76);
            nmrEstoque.Name = "nmrEstoque";
            nmrEstoque.Size = new Size(93, 23);
            nmrEstoque.TabIndex = 12;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnidadeVenda.ForeColor = Color.FromArgb(64, 64, 64);
            txtUnidadeVenda.Location = new Point(300, 76);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.Size = new Size(104, 23);
            txtUnidadeVenda.TabIndex = 11;
            txtUnidadeVenda.Text = "Ex: Pacote";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(196, 76);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(93, 23);
            txtValorUnit.TabIndex = 10;
            // 
            // txtCodBarras
            // 
            txtCodBarras.Location = new Point(92, 76);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(93, 23);
            txtCodBarras.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(92, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(93, 23);
            txtID.TabIndex = 8;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(92, 148);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 7;
            lblDesconto.Text = "Desconto";
            // 
            // lblCategoriaProduto
            // 
            lblCategoriaProduto.AutoSize = true;
            lblCategoriaProduto.Location = new Point(299, 104);
            lblCategoriaProduto.Name = "lblCategoriaProduto";
            lblCategoriaProduto.Size = new Size(58, 15);
            lblCategoriaProduto.TabIndex = 6;
            lblCategoriaProduto.Text = "Categoria";
            // 
            // lblDescricaoProduto
            // 
            lblDescricaoProduto.AutoSize = true;
            lblDescricaoProduto.Location = new Point(91, 104);
            lblDescricaoProduto.Name = "lblDescricaoProduto";
            lblDescricaoProduto.Size = new Size(58, 15);
            lblDescricaoProduto.TabIndex = 5;
            lblDescricaoProduto.Text = "Descrição";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(416, 58);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(94, 15);
            lblEstoque.TabIndex = 4;
            lblEstoque.Text = "Estoque Mínimo";
            // 
            // lblUnidadeVenda
            // 
            lblUnidadeVenda.AutoSize = true;
            lblUnidadeVenda.Location = new Point(297, 58);
            lblUnidadeVenda.Name = "lblUnidadeVenda";
            lblUnidadeVenda.Size = new Size(102, 15);
            lblUnidadeVenda.TabIndex = 3;
            lblUnidadeVenda.Text = "Unidade de Venda";
            // 
            // lblValorUnitario
            // 
            lblValorUnitario.AutoSize = true;
            lblValorUnitario.Location = new Point(202, 58);
            lblValorUnitario.Name = "lblValorUnitario";
            lblValorUnitario.Size = new Size(78, 15);
            lblValorUnitario.TabIndex = 2;
            lblValorUnitario.Text = "Valor Unitário";
            // 
            // lblCodigoBarra
            // 
            lblCodigoBarra.AutoSize = true;
            lblCodigoBarra.Location = new Point(88, 58);
            lblCodigoBarra.Name = "lblCodigoBarra";
            lblCodigoBarra.Size = new Size(97, 15);
            lblCodigoBarra.TabIndex = 1;
            lblCodigoBarra.Text = "Código de Barras";
            // 
            // lblIdProduto
            // 
            lblIdProduto.AutoSize = true;
            lblIdProduto.Location = new Point(89, 14);
            lblIdProduto.Name = "lblIdProduto";
            lblIdProduto.Size = new Size(18, 15);
            lblIdProduto.TabIndex = 0;
            lblIdProduto.Text = "ID";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnID, clnCodbarras, clnValorUnit, clnUnidadeVenda, clnCategoria, clnEstoqueMin, clnDesconto, clnDataCad, clnDescricao });
            dgvProdutos.Location = new Point(119, 289);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(535, 149);
            dgvProdutos.TabIndex = 1;
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            clnID.Width = 70;
            // 
            // clnCodbarras
            // 
            clnCodbarras.HeaderText = "Código de Barras";
            clnCodbarras.Name = "clnCodbarras";
            clnCodbarras.ReadOnly = true;
            clnCodbarras.Width = 130;
            // 
            // clnValorUnit
            // 
            clnValorUnit.HeaderText = "Valor Unitário";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 120;
            // 
            // clnUnidadeVenda
            // 
            clnUnidadeVenda.HeaderText = "Unidade de Venda";
            clnUnidadeVenda.Name = "clnUnidadeVenda";
            clnUnidadeVenda.ReadOnly = true;
            clnUnidadeVenda.Width = 130;
            // 
            // clnCategoria
            // 
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            clnCategoria.Width = 120;
            // 
            // clnEstoqueMin
            // 
            clnEstoqueMin.HeaderText = "Estoque Mínimo";
            clnEstoqueMin.Name = "clnEstoqueMin";
            clnEstoqueMin.ReadOnly = true;
            clnEstoqueMin.Width = 120;
            // 
            // clnDesconto
            // 
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnDataCad
            // 
            clnDataCad.HeaderText = "Data de Cadastro";
            clnDataCad.Name = "clnDataCad";
            clnDataCad.ReadOnly = true;
            clnDataCad.Width = 130;
            // 
            // clnDescricao
            // 
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // txtProdutos
            // 
            txtProdutos.BackColor = SystemColors.Control;
            txtProdutos.BorderStyle = BorderStyle.None;
            txtProdutos.Font = new Font("Snap ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProdutos.Location = new Point(315, 12);
            txtProdutos.Name = "txtProdutos";
            txtProdutos.Size = new Size(161, 35);
            txtProdutos.TabIndex = 2;
            txtProdutos.Text = "Produtos";
            txtProdutos.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProdutos);
            Controls.Add(dgvProdutos);
            Controls.Add(GpProdutos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            Load += FrmProduto_Load;
            GpProdutos.ResumeLayout(false);
            GpProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GpProdutos;
        private TextBox txtValorUnit;
        private TextBox txtCodBarras;
        private TextBox txtID;
        private Label lblDesconto;
        private Label lblCategoriaProduto;
        private Label lblDescricaoProduto;
        private Label lblEstoque;
        private Label lblUnidadeVenda;
        private Label lblValorUnitario;
        private Label lblCodigoBarra;
        private Label lblIdProduto;
        private TextBox txtUnidadeVenda;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private TextBox txtDesconto;
        private ComboBox cmbCategoria;
        private TextBox txtDescricao;
        private NumericUpDown nmrEstoque;
        private DataGridView dgvProdutos;
        private TextBox txtProdutos;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnCodbarras;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnUnidadeVenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMin;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDataCad;
        private DataGridViewTextBoxColumn clnDescricao;
    }
}