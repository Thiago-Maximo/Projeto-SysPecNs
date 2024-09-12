namespace SysPecNsDesk
{
    partial class FrmBuscaCliente
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
            dgvBuscaClientes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            DataNasc = new DataGridViewTextBoxColumn();
            DataCad = new DataGridViewTextBoxColumn();
            Ativo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBuscaClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvBuscaClientes
            // 
            dgvBuscaClientes.AllowUserToAddRows = false;
            dgvBuscaClientes.AllowUserToDeleteRows = false;
            dgvBuscaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBuscaClientes.Columns.AddRange(new DataGridViewColumn[] { ID, Nome, CPF, Telefone, Email, DataNasc, DataCad, Ativo });
            dgvBuscaClientes.Dock = DockStyle.Fill;
            dgvBuscaClientes.Location = new Point(0, 0);
            dgvBuscaClientes.Name = "dgvBuscaClientes";
            dgvBuscaClientes.ReadOnly = true;
            dgvBuscaClientes.RowHeadersVisible = false;
            dgvBuscaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBuscaClientes.Size = new Size(800, 450);
            dgvBuscaClientes.TabIndex = 33;
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
            DataNasc.Width = 150;
            // 
            // DataCad
            // 
            DataCad.Frozen = true;
            DataCad.HeaderText = "Data de Cadastro";
            DataCad.Name = "DataCad";
            DataCad.ReadOnly = true;
            DataCad.Width = 150;
            // 
            // Ativo
            // 
            Ativo.Frozen = true;
            Ativo.HeaderText = "Ativo";
            Ativo.Name = "Ativo";
            Ativo.ReadOnly = true;
            Ativo.Width = 70;
            // 
            // FrmBuscaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBuscaClientes);
            Name = "FrmBuscaCliente";
            Text = "FrmBuscaCliente";
            Load += FrmBuscaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBuscaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvBuscaClientes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DataNasc;
        private DataGridViewTextBoxColumn DataCad;
        private DataGridViewTextBoxColumn Ativo;
    }
}