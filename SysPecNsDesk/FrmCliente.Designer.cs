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
            CadEndereco = new TabPage();
            ControlePagina.SuspendLayout();
            CadCleinte.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(349, 325);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(80, 23);
            btnDeletar.TabIndex = 7;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(262, 325);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 23);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(264, 166);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 30;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(213, 135);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 3;
            txtCpf.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(375, 135);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 27;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(213, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(126, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(273, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(213, 35);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 23;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(170, 325);
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
            lblCpf.Location = new Point(213, 117);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(399, 64);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 20;
            lblTelefone.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 64);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 17);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 17);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(355, 82);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(95, 23);
            txtTelefone.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(229, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(436, 325);
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
            ControlePagina.Location = new Point(1, 0);
            ControlePagina.Name = "ControlePagina";
            ControlePagina.SelectedIndex = 0;
            ControlePagina.Size = new Size(787, 453);
            ControlePagina.TabIndex = 32;
            // 
            // CadCleinte
            // 
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
            CadCleinte.Size = new Size(779, 425);
            CadCleinte.TabIndex = 0;
            CadCleinte.Text = "Cadastro de Cliente";
            CadCleinte.UseVisualStyleBackColor = true;
            // 
            // CadEndereco
            // 
            CadEndereco.Location = new Point(4, 24);
            CadEndereco.Name = "CadEndereco";
            CadEndereco.Padding = new Padding(3);
            CadEndereco.Size = new Size(779, 425);
            CadEndereco.TabIndex = 1;
            CadEndereco.Text = "Cadastro de Endereço";
            CadEndereco.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
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
    }
}