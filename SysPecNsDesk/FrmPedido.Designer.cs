namespace SysPecNsDesk
{
    partial class FrmPedido
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
            grpIdentificacao = new GroupBox();
            btnBuscaIDCliente = new Button();
            txtIDCliente = new TextBox();
            btnInsere = new Button();
            txtNomeCliente = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            grpItens = new GroupBox();
            label4 = new Label();
            txtTotal = new TextBox();
            label3 = new Label();
            lblDesconto = new Label();
            lblQuant = new Label();
            lblValorUnit = new Label();
            lblDescricao = new Label();
            lblCodBarr = new Label();
            txtDescontoItem = new TextBox();
            txtDescricao = new TextBox();
            txtCodBar = new TextBox();
            txtValorUnit = new TextBox();
            txtQuantidade = new TextBox();
            btnAddItem = new Button();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clndescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            lbltextoPedido = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            txtIdPedido = new TextBox();
            txtSubTotal = new TextBox();
            txtDescontoItens = new TextBox();
            txtDescontoPedido = new TextBox();
            btnFechar = new Button();
            txtValorFinal = new TextBox();
            lblSubTotal = new Label();
            lblDescontoItens = new Label();
            lblDescontoPedido = new Label();
            lblTotalPedido = new Label();
            grpIdentificacao.SuspendLayout();
            grpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grpIdentificacao
            // 
            grpIdentificacao.Controls.Add(btnBuscaIDCliente);
            grpIdentificacao.Controls.Add(txtIDCliente);
            grpIdentificacao.Controls.Add(btnInsere);
            grpIdentificacao.Controls.Add(txtNomeCliente);
            grpIdentificacao.Controls.Add(label2);
            grpIdentificacao.Controls.Add(txtUsuario);
            grpIdentificacao.Location = new Point(117, 75);
            grpIdentificacao.Name = "grpIdentificacao";
            grpIdentificacao.Size = new Size(465, 133);
            grpIdentificacao.TabIndex = 0;
            grpIdentificacao.TabStop = false;
            grpIdentificacao.Text = "Identificação";
            // 
            // btnBuscaIDCliente
            // 
            btnBuscaIDCliente.FlatAppearance.BorderSize = 0;
            btnBuscaIDCliente.FlatStyle = FlatStyle.Flat;
            btnBuscaIDCliente.Image = Properties.Resources.User;
            btnBuscaIDCliente.Location = new Point(6, 67);
            btnBuscaIDCliente.Name = "btnBuscaIDCliente";
            btnBuscaIDCliente.Size = new Size(106, 37);
            btnBuscaIDCliente.TabIndex = 5;
            btnBuscaIDCliente.Text = "Cliente";
            btnBuscaIDCliente.TextAlign = ContentAlignment.MiddleRight;
            btnBuscaIDCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscaIDCliente.UseVisualStyleBackColor = true;
            btnBuscaIDCliente.Click += btnBuscaIDCliente_Click;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(113, 75);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(60, 23);
            txtIDCliente.TabIndex = 4;
            // 
            // btnInsere
            // 
            btnInsere.FlatAppearance.BorderColor = Color.White;
            btnInsere.FlatAppearance.BorderSize = 0;
            btnInsere.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnInsere.FlatStyle = FlatStyle.Popup;
            btnInsere.Location = new Point(360, 74);
            btnInsere.Name = "btnInsere";
            btnInsere.Size = new Size(75, 23);
            btnInsere.TabIndex = 3;
            btnInsere.Text = "&Abrir";
            btnInsere.UseVisualStyleBackColor = true;
            btnInsere.Click += btnInsere_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(179, 75);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(175, 23);
            txtNomeCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 38);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(113, 35);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(241, 23);
            txtUsuario.TabIndex = 0;
            // 
            // grpItens
            // 
            grpItens.Controls.Add(label4);
            grpItens.Controls.Add(txtTotal);
            grpItens.Controls.Add(label3);
            grpItens.Controls.Add(lblDesconto);
            grpItens.Controls.Add(lblQuant);
            grpItens.Controls.Add(lblValorUnit);
            grpItens.Controls.Add(lblDescricao);
            grpItens.Controls.Add(lblCodBarr);
            grpItens.Controls.Add(txtDescontoItem);
            grpItens.Controls.Add(txtDescricao);
            grpItens.Controls.Add(txtCodBar);
            grpItens.Controls.Add(txtValorUnit);
            grpItens.Controls.Add(txtQuantidade);
            grpItens.Controls.Add(btnAddItem);
            grpItens.Controls.Add(dgvItensPedido);
            grpItens.Enabled = false;
            grpItens.Location = new Point(71, 214);
            grpItens.Name = "grpItens";
            grpItens.Size = new Size(559, 297);
            grpItens.TabIndex = 1;
            grpItens.TabStop = false;
            grpItens.Text = "Itens";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(392, 81);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 14;
            label4.Text = "R$";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = SystemColors.MenuHighlight;
            txtTotal.Location = new Point(446, 259);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 26);
            txtTotal.TabIndex = 13;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(360, 260);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 12;
            label3.Text = "Total R$";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(390, 38);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(57, 15);
            lblDesconto.TabIndex = 11;
            lblDesconto.Text = "Desconto";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Location = new Point(342, 38);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(43, 15);
            lblQuant.TabIndex = 10;
            lblQuant.Text = "Quant.";
            // 
            // lblValorUnit
            // 
            lblValorUnit.AutoSize = true;
            lblValorUnit.Location = new Point(278, 38);
            lblValorUnit.Name = "lblValorUnit";
            lblValorUnit.Size = new Size(58, 15);
            lblValorUnit.TabIndex = 9;
            lblValorUnit.Text = "Valor Unit";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(115, 38);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // lblCodBarr
            // 
            lblCodBarr.AutoSize = true;
            lblCodBarr.Location = new Point(6, 38);
            lblCodBarr.Name = "lblCodBarr";
            lblCodBarr.Size = new Size(97, 15);
            lblCodBarr.TabIndex = 7;
            lblCodBarr.Text = "Código de Barras";
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(392, 56);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(73, 23);
            txtDescontoItem.TabIndex = 6;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(112, 56);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(160, 23);
            txtDescricao.TabIndex = 5;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(6, 56);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(100, 23);
            txtCodBar.TabIndex = 4;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(278, 56);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(58, 23);
            txtValorUnit.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(342, 56);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(44, 23);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.Text = "1";
            txtQuantidade.TextAlign = HorizontalAlignment.Right;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // btnAddItem
            // 
            btnAddItem.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnAddItem.FlatStyle = FlatStyle.Popup;
            btnAddItem.Location = new Point(471, 55);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clndescricao, clnValorUnit, clnQuantidade, clnDesconto, clnTotalItem });
            dgvItensPedido.Location = new Point(6, 99);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.Size = new Size(540, 150);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod Barra";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 85;
            // 
            // clndescricao
            // 
            clndescricao.Frozen = true;
            clndescricao.HeaderText = "Descrição";
            clndescricao.Name = "clndescricao";
            clndescricao.ReadOnly = true;
            clndescricao.Width = 120;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 81;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant.";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 60;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            clnDesconto.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.HeaderText = "Total Item";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            clnTotalItem.Width = 85;
            // 
            // lbltextoPedido
            // 
            lbltextoPedido.AutoSize = true;
            lbltextoPedido.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbltextoPedido.ForeColor = Color.Black;
            lbltextoPedido.Location = new Point(296, 10);
            lbltextoPedido.Name = "lbltextoPedido";
            lbltextoPedido.Size = new Size(125, 36);
            lbltextoPedido.TabIndex = 2;
            lbltextoPedido.Text = "Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(562, 10);
            label1.Name = "label1";
            label1.Size = new Size(93, 22);
            label1.TabIndex = 3;
            label1.Text = "Numero:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(658, 28);
            textBox1.MaximumSize = new Size(0, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 23);
            textBox1.TabIndex = 4;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(661, 9);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 5;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(648, 278);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 6;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(648, 321);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 7;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(648, 365);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 8;
            txtDescontoPedido.Text = "0,00";
            txtDescontoPedido.TextChanged += txtDescontoPedido_TextChanged;
            txtDescontoPedido.Enter += txtDescontoPedido_Enter;
            // 
            // btnFechar
            // 
            btnFechar.Cursor = Cursors.Hand;
            btnFechar.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Location = new Point(648, 463);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(100, 47);
            btnFechar.TabIndex = 10;
            btnFechar.Text = "&Confirmar Pedido";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtValorFinal
            // 
            txtValorFinal.Location = new Point(648, 419);
            txtValorFinal.Name = "txtValorFinal";
            txtValorFinal.ReadOnly = true;
            txtValorFinal.Size = new Size(100, 23);
            txtValorFinal.TabIndex = 9;
            txtValorFinal.TextChanged += txtValorFinal_TextChanged;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(673, 260);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(55, 15);
            lblSubTotal.TabIndex = 11;
            lblSubTotal.Text = "Sub Total";
            // 
            // lblDescontoItens
            // 
            lblDescontoItens.AutoSize = true;
            lblDescontoItens.Location = new Point(648, 304);
            lblDescontoItens.Name = "lblDescontoItens";
            lblDescontoItens.Size = new Size(101, 15);
            lblDescontoItens.TabIndex = 11;
            lblDescontoItens.Text = "Desconto Itens R$";
            // 
            // lblDescontoPedido
            // 
            lblDescontoPedido.AutoSize = true;
            lblDescontoPedido.Location = new Point(648, 348);
            lblDescontoPedido.Name = "lblDescontoPedido";
            lblDescontoPedido.Size = new Size(113, 15);
            lblDescontoPedido.TabIndex = 11;
            lblDescontoPedido.Text = "Desconto Pedido R$";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTotalPedido.Location = new Point(648, 396);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(63, 20);
            lblTotalPedido.TabIndex = 11;
            lblTotalPedido.Text = "Total R$";
            // 
            // FrmPedido
            // 
            AcceptButton = btnFechar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 541);
            Controls.Add(lblTotalPedido);
            Controls.Add(lblDescontoPedido);
            Controls.Add(lblDescontoItens);
            Controls.Add(lblSubTotal);
            Controls.Add(btnFechar);
            Controls.Add(txtValorFinal);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtSubTotal);
            Controls.Add(txtIdPedido);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lbltextoPedido);
            Controls.Add(grpItens);
            Controls.Add(grpIdentificacao);
            Name = "FrmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            grpIdentificacao.ResumeLayout(false);
            grpIdentificacao.PerformLayout();
            grpItens.ResumeLayout(false);
            grpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpIdentificacao;
        private GroupBox grpItens;
        private Label lbltextoPedido;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtIdPedido;
        private TextBox txtNomeCliente;
        private Button btnInsere;
        private TextBox txtIDCliente;
        private TextBox txtDescricao;
        private TextBox txtCodBar;
        private TextBox txtValorUnit;
        private TextBox txtQuantidade;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label lblDesconto;
        private Label lblQuant;
        private Label lblValorUnit;
        private Label lblDescricao;
        private Label lblCodBarr;
        private TextBox txtDescontoItem;
        private TextBox txtTotal;
        private Label label3;
        private TextBox txtSubTotal;
        private TextBox txtDescontoItens;
        private TextBox txtDescontoPedido;
        private Button btnFechar;
        private TextBox txtValorFinal;
        private Label lblSubTotal;
        private Label lblDescontoItens;
        private Label lblDescontoPedido;
        private Label lblTotalPedido;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clndescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Label label4;
        private Button btnBuscaIDCliente;
    }
}