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
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            groupBox2 = new GroupBox();
            lbltextoPedido = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Location = new Point(71, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Identificação";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(113, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 23);
            textBox4.TabIndex = 2;
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
            txtUsuario.Size = new Size(175, 23);
            txtUsuario.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(71, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 168);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens";
            // 
            // lbltextoPedido
            // 
            lbltextoPedido.AutoSize = true;
            lbltextoPedido.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbltextoPedido.ForeColor = Color.Black;
            lbltextoPedido.Location = new Point(212, 9);
            lbltextoPedido.Name = "lbltextoPedido";
            lbltextoPedido.Size = new Size(125, 36);
            lbltextoPedido.TabIndex = 2;
            lbltextoPedido.Text = "Pedido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 35);
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
            // textBox2
            // 
            textBox2.Location = new Point(569, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 594);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lbltextoPedido);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbltextoPedido;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox textBox2;
        private TextBox textBox4;
    }
}