namespace SysPecNsDesk
{
    partial class FrmCliente
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
            btnDeletar = new Button();
            btnEditar = new Button();
            lblDataNasc = new Label();
            txtCpf = new TextBox();
            chkAtivo = new CheckBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            txtId = new TextBox();
            btnInserir = new Button();
            lblCpf = new Label();
            lblTelefone = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTelefone = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnCancelar = new Button();
            ControlePagina = new TabControl();
            CadCleinte = new TabPage();
            txtBuscaCliente = new TextBox();
            dgvClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataNasc = new DataGridViewTextBoxColumn();
            DataCad = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            CadEndereco = new TabPage();
            btnCancelarEndereco = new Button();
            btnDeletarEndereco = new Button();
            txtBuscaEndereco = new TextBox();
            dgvEnderecos = new DataGridView();
            IdCliente = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            CPFCliente = new DataGridViewTextBoxColumn();
            TelefoneCliente = new DataGridViewTextBoxColumn();
            EmailCliente = new DataGridViewTextBoxColumn();
            btnEditarEndereco = new Button();
            btnInserirEndereco = new Button();
            txtTipoEndereco = new TextBox();
            txtUf = new TextBox();
            txtCidade = new TextBox();
            txtComplemento = new TextBox();
            txtNumeroEndereco = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            txtCep = new TextBox();
            txtIDEndereco = new TextBox();
            txtIDCliente = new TextBox();
            lblTipoEndereco = new Label();
            lbluUF = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblComplemento = new Label();
            lblNumero = new Label();
            lblLogradouro = new Label();
            lblCep = new Label();
            lblClienteId = new Label();
            lblID = new Label();
            ControlePagina.SuspendLayout();
            CadCleinte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            CadEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(192, 168);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(80, 23);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(105, 168);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(391, 40);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 30;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(16, 140);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 3;
            txtCpf.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(178, 140);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 27;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(126, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(76, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(16, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 23;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(13, 168);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 23);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(16, 122);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(202, 69);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 20;
            lblTelefone.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 69);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 22);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(158, 87);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(95, 23);
            txtTelefone.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(279, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 23);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ControlePagina
            // 
            ControlePagina.Controls.Add(CadCleinte);
            ControlePagina.Controls.Add(CadEndereco);
            ControlePagina.Location = new Point(35, 12);
            ControlePagina.Name = "ControlePagina";
            ControlePagina.SelectedIndex = 0;
            ControlePagina.Size = new Size(661, 401);
            ControlePagina.TabIndex = 32;
            // 
            // CadCleinte
            // 
            CadCleinte.BackColor = Color.Silver;
            CadCleinte.Controls.Add(txtBuscaCliente);
            CadCleinte.Controls.Add(dgvClientes);
            CadCleinte.Controls.Add(dateTimePicker1);
            CadCleinte.Controls.Add(btnCancelar);
            CadCleinte.Controls.Add(label1);
            CadCleinte.Controls.Add(label2);
            CadCleinte.Controls.Add(txtTelefone);
            CadCleinte.Controls.Add(label3);
            CadCleinte.Controls.Add(btnDeletar);
            CadCleinte.Controls.Add(lblTelefone);
            CadCleinte.Controls.Add(btnEditar);
            CadCleinte.Controls.Add(lblCpf);
            CadCleinte.Controls.Add(lblDataNasc);
            CadCleinte.Controls.Add(btnInserir);
            CadCleinte.Controls.Add(txtCpf);
            CadCleinte.Controls.Add(txtId);
            CadCleinte.Controls.Add(chkAtivo);
            CadCleinte.Controls.Add(txtNome);
            CadCleinte.Controls.Add(txtEmail);
            CadCleinte.Location = new Point(4, 24);
            CadCleinte.Name = "CadCleinte";
            CadCleinte.Padding = new Padding(3);
            CadCleinte.Size = new Size(653, 373);
            CadCleinte.TabIndex = 0;
            CadCleinte.Text = "Cadastro de Cliente";
            // 
            // txtBuscaCliente
            // 
            txtBuscaCliente.Location = new Point(6, 197);
            txtBuscaCliente.Name = "txtBuscaCliente";
            txtBuscaCliente.Size = new Size(641, 23);
            txtBuscaCliente.TabIndex = 33;
            txtBuscaCliente.TextChanged += txtBuscaCliente_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, CPF, Telefone, Email, DataNasc, DataCad, Ativo });
            dgvClientes.Location = new Point(6, 226);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(641, 141);
            dgvClientes.TabIndex = 32;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // ID
            // 
            ID.Frozen = true;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 80;
            // 
            // Nome
            // 
            Nome.Frozen = true;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 80;
            // 
            // CPF
            // 
            CPF.Frozen = true;
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            CPF.Width = 70;
            // 
            // Telefone
            // 
            Telefone.Frozen = true;
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 70;
            // 
            // Email
            // 
            Email.Frozen = true;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 80;
            // 
            // DataNasc
            // 
            DataNasc.Frozen = true;
            DataNasc.HeaderText = "Data de Nascimento";
            DataNasc.Name = "DataNasc";
            DataNasc.ReadOnly = true;
            // 
            // DataCad
            // 
            DataCad.Frozen = true;
            DataCad.HeaderText = "Data de Cadastro";
            DataCad.Name = "DataCad";
            DataCad.ReadOnly = true;
            // 
            // Ativo
            // 
            Ativo.Frozen = true;
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Width = 55;
            // 
            // CadEndereco
            // 
            CadEndereco.BackColor = Color.Silver;
            CadEndereco.Controls.Add(btnCancelarEndereco);
            CadEndereco.Controls.Add(btnDeletarEndereco);
            CadEndereco.Controls.Add(txtBuscaEndereco);
            CadEndereco.Controls.Add(dgvEnderecos);
            CadEndereco.Controls.Add(btnEditarEndereco);
            CadEndereco.Controls.Add(btnInserirEndereco);
            CadEndereco.Controls.Add(txtTipoEndereco);
            CadEndereco.Controls.Add(txtUf);
            CadEndereco.Controls.Add(txtCidade);
            CadEndereco.Controls.Add(txtComplemento);
            CadEndereco.Controls.Add(txtNumeroEndereco);
            CadEndereco.Controls.Add(txtBairro);
            CadEndereco.Controls.Add(txtLogradouro);
            CadEndereco.Controls.Add(txtCep);
            CadEndereco.Controls.Add(txtIDEndereco);
            CadEndereco.Controls.Add(txtIDCliente);
            CadEndereco.Controls.Add(lblTipoEndereco);
            CadEndereco.Controls.Add(lbluUF);
            CadEndereco.Controls.Add(lblCidade);
            CadEndereco.Controls.Add(lblBairro);
            CadEndereco.Controls.Add(lblComplemento);
            CadEndereco.Controls.Add(lblNumero);
            CadEndereco.Controls.Add(lblLogradouro);
            CadEndereco.Controls.Add(lblCep);
            CadEndereco.Controls.Add(lblClienteId);
            CadEndereco.Controls.Add(lblID);
            CadEndereco.Location = new Point(4, 24);
            CadEndereco.Name = "CadEndereco";
            CadEndereco.Padding = new Padding(3);
            CadEndereco.Size = new Size(653, 373);
            CadEndereco.TabIndex = 1;
            CadEndereco.Text = "Cadastro de Endereço";
            CadEndereco.Click += CadEndereco_Click;
            // 
            // btnCancelarEndereco
            // 
            btnCancelarEndereco.Location = new Point(289, 166);
            btnCancelarEndereco.Name = "btnCancelarEndereco";
            btnCancelarEndereco.Size = new Size(63, 23);
            btnCancelarEndereco.TabIndex = 24;
            btnCancelarEndereco.Text = "&Cancelar";
            btnCancelarEndereco.UseVisualStyleBackColor = true;
            btnCancelarEndereco.Click += btnCancelarEndereco_Click;
            // 
            // btnDeletarEndereco
            // 
            btnDeletarEndereco.Location = new Point(208, 166);
            btnDeletarEndereco.Name = "btnDeletarEndereco";
            btnDeletarEndereco.Size = new Size(75, 23);
            btnDeletarEndereco.TabIndex = 23;
            btnDeletarEndereco.Text = "&Deletar";
            btnDeletarEndereco.UseVisualStyleBackColor = true;
            // 
            // txtBuscaEndereco
            // 
            txtBuscaEndereco.Location = new Point(12, 198);
            txtBuscaEndereco.Name = "txtBuscaEndereco";
            txtBuscaEndereco.Size = new Size(535, 23);
            txtBuscaEndereco.TabIndex = 22;
            txtBuscaEndereco.TextChanged += txtBuscaEndereco_TextChanged;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { IdCliente, NomeCliente, CPFCliente, TelefoneCliente, EmailCliente });
            dgvEnderecos.Location = new Point(12, 224);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(535, 143);
            dgvEnderecos.TabIndex = 21;
            dgvEnderecos.CellContentClick += dgvEnderecos_CellContentClick;
            // 
            // IdCliente
            // 
            IdCliente.Frozen = true;
            IdCliente.HeaderText = "ID Do Cliente";
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // NomeCliente
            // 
            NomeCliente.HeaderText = "Nome";
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            // 
            // CPFCliente
            // 
            CPFCliente.HeaderText = "CPF";
            CPFCliente.Name = "CPFCliente";
            CPFCliente.ReadOnly = true;
            // 
            // TelefoneCliente
            // 
            TelefoneCliente.HeaderText = "Telefone";
            TelefoneCliente.Name = "TelefoneCliente";
            TelefoneCliente.ReadOnly = true;
            TelefoneCliente.Width = 120;
            // 
            // EmailCliente
            // 
            EmailCliente.HeaderText = "Email";
            EmailCliente.Name = "EmailCliente";
            EmailCliente.ReadOnly = true;
            EmailCliente.Width = 112;
            // 
            // btnEditarEndereco
            // 
            btnEditarEndereco.Location = new Point(92, 166);
            btnEditarEndereco.Name = "btnEditarEndereco";
            btnEditarEndereco.Size = new Size(110, 23);
            btnEditarEndereco.TabIndex = 20;
            btnEditarEndereco.Text = "&Editar Endereço";
            btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnInserirEndereco
            // 
            btnInserirEndereco.Location = new Point(11, 166);
            btnInserirEndereco.Name = "btnInserirEndereco";
            btnInserirEndereco.Size = new Size(75, 23);
            btnInserirEndereco.TabIndex = 19;
            btnInserirEndereco.Text = "&Inserir";
            btnInserirEndereco.UseVisualStyleBackColor = true;
            btnInserirEndereco.Click += btnInserirEndereco_Click;
            // 
            // txtTipoEndereco
            // 
            txtTipoEndereco.Location = new Point(69, 125);
            txtTipoEndereco.Name = "txtTipoEndereco";
            txtTipoEndereco.Size = new Size(98, 23);
            txtTipoEndereco.TabIndex = 18;
            // 
            // txtUf
            // 
            txtUf.Location = new Point(11, 125);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(47, 23);
            txtUf.TabIndex = 17;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(179, 80);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(75, 23);
            txtCidade.TabIndex = 16;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(69, 80);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(100, 23);
            txtComplemento.TabIndex = 15;
            // 
            // txtNumeroEndereco
            // 
            txtNumeroEndereco.Location = new Point(11, 80);
            txtNumeroEndereco.Name = "txtNumeroEndereco";
            txtNumeroEndereco.Size = new Size(48, 23);
            txtNumeroEndereco.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(264, 80);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(88, 23);
            txtBairro.TabIndex = 13;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(226, 27);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(100, 23);
            txtLogradouro.TabIndex = 12;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(158, 27);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(51, 23);
            txtCep.TabIndex = 11;
            // 
            // txtIDEndereco
            // 
            txtIDEndereco.Enabled = false;
            txtIDEndereco.Location = new Point(11, 27);
            txtIDEndereco.Name = "txtIDEndereco";
            txtIDEndereco.ReadOnly = true;
            txtIDEndereco.Size = new Size(47, 23);
            txtIDEndereco.TabIndex = 10;
            txtIDEndereco.TextChanged += txtIDEndereco_TextChanged;
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(70, 27);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(72, 23);
            txtIDCliente.TabIndex = 10;
            // 
            // lblTipoEndereco
            // 
            lblTipoEndereco.AutoSize = true;
            lblTipoEndereco.Location = new Point(66, 109);
            lblTipoEndereco.Name = "lblTipoEndereco";
            lblTipoEndereco.Size = new Size(98, 15);
            lblTipoEndereco.TabIndex = 9;
            lblTipoEndereco.Text = "Tipo de Endereço";
            // 
            // lbluUF
            // 
            lbluUF.AutoSize = true;
            lbluUF.Location = new Point(12, 109);
            lbluUF.Name = "lbluUF";
            lbluUF.Size = new Size(21, 15);
            lbluUF.TabIndex = 8;
            lbluUF.Text = "UF";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(179, 62);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 7;
            lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(264, 62);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(69, 62);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 5;
            lblComplemento.Text = "Complemento";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 62);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Numero";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(226, 9);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(69, 15);
            lblLogradouro.TabIndex = 3;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(158, 9);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 2;
            lblCep.Text = "Cep";
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new Point(67, 9);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(75, 15);
            lblClienteId.TabIndex = 1;
            lblClienteId.Text = "ID do Cliente";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(11, 9);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // FrmCliente
            // 
            AcceptButton = btnCancelarEndereco;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 450);
            Controls.Add(ControlePagina);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ControlePagina.ResumeLayout(false);
            CadCleinte.ResumeLayout(false);
            CadCleinte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            CadEndereco.ResumeLayout(false);
            CadEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeletar;
        private Button btnEditar;
        private Label lblDataNasc;
        private TextBox txtCpf;
        private CheckBox chkAtivo;
        private TextBox txtEmail;
        private TextBox txtNome;
        private TextBox txtId;
        private Button btnInserir;
        private Label lblCpf;
        private Label lblTelefone;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTelefone;
        private DateTimePicker dateTimePicker1;
        private Button btnCancelar;
        private TabControl ControlePagina;
        private TabPage CadCleinte;
        private TabPage CadEndereco;
        private Label lblBairro;
        private Label lblComplemento;
        private Label lblNumero;
        private Label lblLogradouro;
        private Label lblCep;
        private Label lblClienteId;
        private Label lblID;
        private Label lblTipoEndereco;
        private Label lbluUF;
        private Label lblCidade;
        private TextBox txtTipoEndereco;
        private TextBox txtUf;
        private TextBox txtCidade;
        private TextBox txtComplemento;
        private TextBox txtNumeroEndereco;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private TextBox txtCep;
        private TextBox txtIDEndereco;
        private TextBox txtIDCliente;
        private Button btnDeletarEndereco;
        private TextBox txtBuscaEndereco;
        private DataGridView dgvEnderecos;
        private Button btnEditarEndereco;
        private Button btnInserirEndereco;
        private Button btnCancelarEndereco;
        private DataGridView dgvClientes;
        private TextBox txtBuscaCliente;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNasc;
        private DataGridViewTextBoxColumn DataCad;
        private DataGridViewTextBoxColumn Ativo;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn CPFCliente;
        private DataGridViewTextBoxColumn TelefoneCliente;
        private DataGridViewTextBoxColumn EmailCliente;
    }
}