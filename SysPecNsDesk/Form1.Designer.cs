﻿namespace SysPecNsDesk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnconfirma = new Button();
            txtNumero1 = new TextBox();
            lstresultado = new ListBox();
            cmbOperacao = new ComboBox();
            txtNumero2 = new TextBox();
            Operação = new Label();
            Numero1 = new Label();
            Numero2 = new Label();
            SuspendLayout();
            // 
            // btnconfirma
            // 
            btnconfirma.Enabled = false;
            btnconfirma.Location = new Point(100, 365);
            btnconfirma.Name = "btnconfirma";
            btnconfirma.Size = new Size(206, 23);
            btnconfirma.TabIndex = 0;
            btnconfirma.Text = "&Confirma";
            btnconfirma.UseVisualStyleBackColor = true;
            btnconfirma.Click += btnconfirma_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(100, 58);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += txtNumero1_TextChanged;
            // 
            // lstresultado
            // 
            lstresultado.FormattingEnabled = true;
            lstresultado.ItemHeight = 15;
            lstresultado.Location = new Point(100, 130);
            lstresultado.Name = "lstresultado";
            lstresultado.Size = new Size(206, 229);
            lstresultado.TabIndex = 2;
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Radiciação", "Logaritimos" });
            cmbOperacao.Location = new Point(100, 105);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(206, 23);
            cmbOperacao.TabIndex = 3;
            cmbOperacao.SelectedIndexChanged += cmbOperacao_SelectedIndexChanged;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(206, 58);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // Operação
            // 
            Operação.AutoSize = true;
            Operação.Location = new Point(173, 87);
            Operação.Name = "Operação";
            Operação.Size = new Size(58, 15);
            Operação.TabIndex = 5;
            Operação.Text = "Operação";
            // 
            // Numero1
            // 
            Numero1.AutoSize = true;
            Numero1.Location = new Point(100, 40);
            Numero1.Name = "Numero1";
            Numero1.Size = new Size(65, 15);
            Numero1.TabIndex = 6;
            Numero1.Text = "1° Numero";
            // 
            // Numero2
            // 
            Numero2.AutoSize = true;
            Numero2.Location = new Point(206, 40);
            Numero2.Name = "Numero2";
            Numero2.Size = new Size(65, 15);
            Numero2.TabIndex = 7;
            Numero2.Text = "2° Numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Numero2);
            Controls.Add(Numero1);
            Controls.Add(Operação);
            Controls.Add(txtNumero2);
            Controls.Add(cmbOperacao);
            Controls.Add(lstresultado);
            Controls.Add(txtNumero1);
            Controls.Add(btnconfirma);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconfirma;
        private TextBox txtNumero1;
        private ListBox lstresultado;
        private ComboBox cmbOperacao;
        private TextBox txtNumero2;
        private Label Operação;
        private Label Numero1;
        private Label Numero2;
    }
}
