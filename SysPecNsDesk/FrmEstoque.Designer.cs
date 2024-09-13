namespace SysPecNsDesk
{
    partial class FrmEstoque
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
            lblQuantidadeEstoque = new Label();
            lblProduto_IdEstoque = new Label();
            txtProduto_IdEstoque = new TextBox();
            txtQuantidadeEstoque = new TextBox();
            btnAdicionarEstoque = new Button();
            grpEstoque = new GroupBox();
            tabEstoque = new TabControl();
            tabPageEstoque = new TabPage();
            txtNomeProdutoEstoque = new TextBox();
            lblNomeProdutoEstoque = new Label();
            txtConsultaEstoque = new TextBox();
            label1 = new Label();
            btnCancelarEstoque = new Button();
            btnAlterarEstoque = new Button();
            dgvEstoque = new DataGridView();
            clnProduto_id = new DataGridViewTextBoxColumn();
            clnNomeProdutoEstoque = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnData_ultimo_movimento = new DataGridViewTextBoxColumn();
            tabPageListaEstoque = new TabPage();
            dataGridView1 = new DataGridView();
            lbltextoEstoque1 = new Label();
            grpEstoque.SuspendLayout();
            tabEstoque.SuspendLayout();
            tabPageEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            tabPageListaEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblQuantidadeEstoque
            // 
            lblQuantidadeEstoque.AutoSize = true;
            lblQuantidadeEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblQuantidadeEstoque.Location = new Point(29, 71);
            lblQuantidadeEstoque.Name = "lblQuantidadeEstoque";
            lblQuantidadeEstoque.Size = new Size(80, 17);
            lblQuantidadeEstoque.TabIndex = 11;
            lblQuantidadeEstoque.Text = "Quantidade";
            // 
            // lblProduto_IdEstoque
            // 
            lblProduto_IdEstoque.AutoSize = true;
            lblProduto_IdEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblProduto_IdEstoque.Location = new Point(29, 10);
            lblProduto_IdEstoque.Name = "lblProduto_IdEstoque";
            lblProduto_IdEstoque.Size = new Size(77, 17);
            lblProduto_IdEstoque.TabIndex = 9;
            lblProduto_IdEstoque.Text = "Produto_ID";
            // 
            // txtProduto_IdEstoque
            // 
            txtProduto_IdEstoque.Location = new Point(29, 30);
            txtProduto_IdEstoque.Name = "txtProduto_IdEstoque";
            txtProduto_IdEstoque.Size = new Size(77, 23);
            txtProduto_IdEstoque.TabIndex = 1;
            txtProduto_IdEstoque.Leave += txtProduto_IdEstoque_Leave;
            // 
            // txtQuantidadeEstoque
            // 
            txtQuantidadeEstoque.Location = new Point(29, 91);
            txtQuantidadeEstoque.Name = "txtQuantidadeEstoque";
            txtQuantidadeEstoque.Size = new Size(80, 23);
            txtQuantidadeEstoque.TabIndex = 3;
            // 
            // btnAdicionarEstoque
            // 
            btnAdicionarEstoque.BackColor = Color.White;
            btnAdicionarEstoque.FlatAppearance.BorderSize = 0;
            btnAdicionarEstoque.FlatStyle = FlatStyle.Flat;
            btnAdicionarEstoque.Image = Properties.Resources.Add;
            btnAdicionarEstoque.Location = new Point(29, 162);
            btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            btnAdicionarEstoque.Size = new Size(110, 47);
            btnAdicionarEstoque.TabIndex = 5;
            btnAdicionarEstoque.Text = "&Adicionar";
            btnAdicionarEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionarEstoque.UseVisualStyleBackColor = false;
            btnAdicionarEstoque.Click += btnAdicionarEstoque_Click;
            // 
            // grpEstoque
            // 
            grpEstoque.Controls.Add(tabEstoque);
            grpEstoque.Location = new Point(71, 43);
            grpEstoque.Name = "grpEstoque";
            grpEstoque.Size = new Size(599, 382);
            grpEstoque.TabIndex = 0;
            grpEstoque.TabStop = false;
            grpEstoque.Text = "Estoque";
            // 
            // tabEstoque
            // 
            tabEstoque.Controls.Add(tabPageEstoque);
            tabEstoque.Controls.Add(tabPageListaEstoque);
            tabEstoque.Location = new Point(6, 22);
            tabEstoque.Name = "tabEstoque";
            tabEstoque.SelectedIndex = 0;
            tabEstoque.Size = new Size(587, 354);
            tabEstoque.TabIndex = 0;
            // 
            // tabPageEstoque
            // 
            tabPageEstoque.Controls.Add(txtNomeProdutoEstoque);
            tabPageEstoque.Controls.Add(lblNomeProdutoEstoque);
            tabPageEstoque.Controls.Add(txtConsultaEstoque);
            tabPageEstoque.Controls.Add(label1);
            tabPageEstoque.Controls.Add(btnCancelarEstoque);
            tabPageEstoque.Controls.Add(btnAlterarEstoque);
            tabPageEstoque.Controls.Add(dgvEstoque);
            tabPageEstoque.Controls.Add(lblProduto_IdEstoque);
            tabPageEstoque.Controls.Add(btnAdicionarEstoque);
            tabPageEstoque.Controls.Add(lblQuantidadeEstoque);
            tabPageEstoque.Controls.Add(txtQuantidadeEstoque);
            tabPageEstoque.Controls.Add(txtProduto_IdEstoque);
            tabPageEstoque.Location = new Point(4, 24);
            tabPageEstoque.Name = "tabPageEstoque";
            tabPageEstoque.Padding = new Padding(3);
            tabPageEstoque.Size = new Size(579, 326);
            tabPageEstoque.TabIndex = 0;
            tabPageEstoque.Text = "Estoque";
            tabPageEstoque.UseVisualStyleBackColor = true;
            // 
            // txtNomeProdutoEstoque
            // 
            txtNomeProdutoEstoque.Location = new Point(115, 30);
            txtNomeProdutoEstoque.Name = "txtNomeProdutoEstoque";
            txtNomeProdutoEstoque.Size = new Size(114, 23);
            txtNomeProdutoEstoque.TabIndex = 2;
            // 
            // lblNomeProdutoEstoque
            // 
            lblNomeProdutoEstoque.AutoSize = true;
            lblNomeProdutoEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblNomeProdutoEstoque.Location = new Point(115, 10);
            lblNomeProdutoEstoque.Name = "lblNomeProdutoEstoque";
            lblNomeProdutoEstoque.Size = new Size(119, 17);
            lblNomeProdutoEstoque.TabIndex = 10;
            lblNomeProdutoEstoque.Text = "Nome do Produto";
            // 
            // txtConsultaEstoque
            // 
            txtConsultaEstoque.Location = new Point(115, 91);
            txtConsultaEstoque.Name = "txtConsultaEstoque";
            txtConsultaEstoque.Size = new Size(114, 23);
            txtConsultaEstoque.TabIndex = 4;
            txtConsultaEstoque.TextChanged += txtConsultaEstoque_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 71);
            label1.Name = "label1";
            label1.Size = new Size(114, 17);
            label1.TabIndex = 0;
            label1.Text = "Procurar Produto";
            // 
            // btnCancelarEstoque
            // 
            btnCancelarEstoque.BackColor = Color.White;
            btnCancelarEstoque.FlatAppearance.BorderSize = 0;
            btnCancelarEstoque.FlatStyle = FlatStyle.Flat;
            btnCancelarEstoque.Image = Properties.Resources.Cancel;
            btnCancelarEstoque.Location = new Point(289, 162);
            btnCancelarEstoque.Name = "btnCancelarEstoque";
            btnCancelarEstoque.Size = new Size(110, 47);
            btnCancelarEstoque.TabIndex = 7;
            btnCancelarEstoque.Text = "C&ancelar";
            btnCancelarEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarEstoque.UseVisualStyleBackColor = false;
            // 
            // btnAlterarEstoque
            // 
            btnAlterarEstoque.BackColor = Color.White;
            btnAlterarEstoque.FlatAppearance.BorderSize = 0;
            btnAlterarEstoque.FlatStyle = FlatStyle.Flat;
            btnAlterarEstoque.Image = Properties.Resources.Edit;
            btnAlterarEstoque.Location = new Point(159, 162);
            btnAlterarEstoque.Name = "btnAlterarEstoque";
            btnAlterarEstoque.Size = new Size(110, 47);
            btnAlterarEstoque.TabIndex = 6;
            btnAlterarEstoque.Text = "&Confirmar Consulta";
            btnAlterarEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAlterarEstoque.UseVisualStyleBackColor = false;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnProduto_id, clnNomeProdutoEstoque, clnQuantidade, clnData_ultimo_movimento });
            dgvEstoque.Location = new Point(6, 215);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(551, 105);
            dgvEstoque.TabIndex = 8;
            // 
            // clnProduto_id
            // 
            clnProduto_id.Frozen = true;
            clnProduto_id.HeaderText = "Produto ID";
            clnProduto_id.Name = "clnProduto_id";
            clnProduto_id.ReadOnly = true;
            // 
            // clnNomeProdutoEstoque
            // 
            clnNomeProdutoEstoque.Frozen = true;
            clnNomeProdutoEstoque.HeaderText = "Nome do Produto";
            clnNomeProdutoEstoque.Name = "clnNomeProdutoEstoque";
            clnNomeProdutoEstoque.ReadOnly = true;
            clnNomeProdutoEstoque.Width = 150;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quantidade";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            // 
            // clnData_ultimo_movimento
            // 
            clnData_ultimo_movimento.Frozen = true;
            clnData_ultimo_movimento.HeaderText = "Data Da Ultima Alteração";
            clnData_ultimo_movimento.Name = "clnData_ultimo_movimento";
            clnData_ultimo_movimento.ReadOnly = true;
            clnData_ultimo_movimento.Width = 200;
            // 
            // tabPageListaEstoque
            // 
            tabPageListaEstoque.Controls.Add(dataGridView1);
            tabPageListaEstoque.Location = new Point(4, 24);
            tabPageListaEstoque.Name = "tabPageListaEstoque";
            tabPageListaEstoque.Padding = new Padding(3);
            tabPageListaEstoque.Size = new Size(579, 326);
            tabPageListaEstoque.TabIndex = 1;
            tabPageListaEstoque.Text = "Lista de Estoque";
            tabPageListaEstoque.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(563, 310);
            dataGridView1.TabIndex = 0;
            // 
            // lbltextoEstoque1
            // 
            lbltextoEstoque1.AutoSize = true;
            lbltextoEstoque1.Font = new Font("Felix Titling", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbltextoEstoque1.Location = new Point(295, 9);
            lbltextoEstoque1.Name = "lbltextoEstoque1";
            lbltextoEstoque1.Size = new Size(156, 34);
            lbltextoEstoque1.TabIndex = 7;
            lbltextoEstoque1.Text = "Estoque";
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbltextoEstoque1);
            Controls.Add(grpEstoque);
            Name = "FrmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Estoque";
            Load += FrmEstoque_Load;
            grpEstoque.ResumeLayout(false);
            tabEstoque.ResumeLayout(false);
            tabPageEstoque.ResumeLayout(false);
            tabPageEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            tabPageListaEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuantidadeEstoque;
        private Label lblProduto_IdEstoque;
        private TextBox txtProduto_IdEstoque;
        private TextBox txtQuantidadeEstoque;
        private Button btnAdicionarEstoque;
        private GroupBox grpEstoque;
        private TabControl tabEstoque;
        private TabPage tabPageEstoque;
        private TabPage tabPageListaEstoque;
        private Button btnCancelarEstoque;
        private Button btnAlterarEstoque;
        private DataGridView dgvEstoque;
        private DataGridView dataGridView1;
        private Label lbltextoEstoque1;
        private TextBox txtConsultaEstoque;
        private Label label1;
        private TextBox txtNomeProdutoEstoque;
        private Label lblNomeProdutoEstoque;
        private DataGridViewTextBoxColumn clnProduto_id;
        private DataGridViewTextBoxColumn clnNomeProdutoEstoque;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnData_ultimo_movimento;
    }
}