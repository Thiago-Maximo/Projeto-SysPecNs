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
            monthcalendarDataNasc = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(424, 385);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 32;
            btnDeletar.Text = "&Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(343, 385);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 31;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(313, 160);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 30;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(262, 129);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 28;
            txtCpf.UseSystemPasswordChar = true;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(424, 129);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 27;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(126, 23);
            txtEmail.TabIndex = 25;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(322, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(177, 23);
            txtNome.TabIndex = 24;
            // 
            // txtId
            // 
            txtId.Location = new Point(262, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 23;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(257, 385);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(80, 23);
            btnInserir.TabIndex = 22;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(262, 111);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "CPF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(448, 58);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 20;
            lblTelefone.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 58);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 19;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 11);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 11);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(404, 76);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(95, 23);
            txtTelefone.TabIndex = 33;
            // 
            // monthcalendarDataNasc
            // 
            monthcalendarDataNasc.Location = new Point(262, 184);
            monthcalendarDataNasc.Name = "monthcalendarDataNasc";
            monthcalendarDataNasc.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(501, 254);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 35;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthcalendarDataNasc);
            Controls.Add(txtTelefone);
            Controls.Add(btnDeletar);
            Controls.Add(btnEditar);
            Controls.Add(lblDataNasc);
            Controls.Add(txtCpf);
            Controls.Add(chkAtivo);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(btnInserir);
            Controls.Add(lblCpf);
            Controls.Add(lblTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "FrmCliente";
            Load += FrmCliente_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private MonthCalendar monthcalendarDataNasc;
        private DateTimePicker dateTimePicker1;
    }
}