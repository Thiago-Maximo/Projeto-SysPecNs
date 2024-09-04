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
            ListaFornecedores = new TabPage();
            TabCtFornecedores.SuspendLayout();
            SuspendLayout();
            // 
            // TabCtFornecedores
            // 
            TabCtFornecedores.Controls.Add(CadFornecedores);
            TabCtFornecedores.Controls.Add(ListaFornecedores);
            TabCtFornecedores.Location = new Point(88, 42);
            TabCtFornecedores.Name = "TabCtFornecedores";
            TabCtFornecedores.SelectedIndex = 0;
            TabCtFornecedores.Size = new Size(574, 358);
            TabCtFornecedores.TabIndex = 0;
            // 
            // CadFornecedores
            // 
            CadFornecedores.Location = new Point(4, 24);
            CadFornecedores.Name = "CadFornecedores";
            CadFornecedores.Padding = new Padding(3);
            CadFornecedores.Size = new Size(566, 330);
            CadFornecedores.TabIndex = 0;
            CadFornecedores.Text = "Cadastro de Fornecedores";
            CadFornecedores.UseVisualStyleBackColor = true;
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
            // FrmFornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabCtFornecedores);
            Name = "FrmFornecedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmFornecedores";
            TabCtFornecedores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabCtFornecedores;
        private TabPage CadFornecedores;
        private TabPage ListaFornecedores;
    }
}