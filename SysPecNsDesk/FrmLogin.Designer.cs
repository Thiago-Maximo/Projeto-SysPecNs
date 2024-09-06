namespace SysPecNsDesk
{
    partial class FrmLogin
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
            Button btnEntrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblSenhaLogin = new Label();
            lblEmailLogin = new Label();
            txtSenhaLogin = new TextBox();
            txtEmailLogin = new TextBox();
            btnCancelar = new Button();
            lblTextoLogin = new Label();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.BackgroundImageLayout = ImageLayout.Center;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Location = new Point(144, 186);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(76, 28);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "&Entrar";
            btnEntrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblSenhaLogin
            // 
            lblSenhaLogin.AutoSize = true;
            lblSenhaLogin.Location = new Point(144, 139);
            lblSenhaLogin.Name = "lblSenhaLogin";
            lblSenhaLogin.Size = new Size(39, 15);
            lblSenhaLogin.TabIndex = 5;
            lblSenhaLogin.Text = "Senha";
            // 
            // lblEmailLogin
            // 
            lblEmailLogin.AutoSize = true;
            lblEmailLogin.Location = new Point(144, 85);
            lblEmailLogin.Name = "lblEmailLogin";
            lblEmailLogin.Size = new Size(37, 15);
            lblEmailLogin.TabIndex = 4;
            lblEmailLogin.Text = "Login";
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Cursor = Cursors.Hand;
            txtSenhaLogin.Location = new Point(144, 157);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.Size = new Size(163, 23);
            txtSenhaLogin.TabIndex = 1;
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Cursor = Cursors.Hand;
            txtEmailLogin.Location = new Point(144, 103);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(163, 23);
            txtEmailLogin.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(226, 186);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 28);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTextoLogin
            // 
            lblTextoLogin.AutoSize = true;
            lblTextoLogin.Font = new Font("Stencil", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTextoLogin.Location = new Point(161, 24);
            lblTextoLogin.Name = "lblTextoLogin";
            lblTextoLogin.Size = new Size(125, 44);
            lblTextoLogin.TabIndex = 6;
            lblTextoLogin.Text = "Login";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 255);
            ControlBox = false;
            Controls.Add(lblTextoLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(btnCancelar);
            Controls.Add(lblSenhaLogin);
            Controls.Add(lblEmailLogin);
            Controls.Add(btnEntrar);
            Controls.Add(txtEmailLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenhaLogin;
        private Label lblEmailLogin;
        private TextBox txtSenhaLogin;
        private TextBox txtEmailLogin;
        private Button btnEntrar;
        private Button btnCancelar;
        private Label lblTextoLogin;
    }
}