using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNsDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtEmailLogin.Text != string.Empty && txtSenhaLogin.Text != string.Empty)
            {
                var usuario = Usuario.EfetuarLogin(txtEmailLogin.Text, txtSenhaLogin.Text);
                if (usuario.Id > 0)
                {
                    if (usuario.Ativo) //Posteriormente tentar realizar um Login com Nivel
                    {
                        Program.UsuarioLogado = usuario;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Seu Usuario está Inativo, \n Procure a Gerencia.");
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Inválidos, ou Inexistentes. \n Procure a Gerência");
                }
            }
            else
            {
                MessageBox.Show("Você Deve Preencher Todos os Campos");
                txtEmailLogin.Focus();
            }


        }
    }
}
