using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNsDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();

            //frmUsuario.ShowDialog(); o showdialog é para deixar este formulario como "Principal"
            //nenhum outro formulario será exibido enquanto este formulario estiver em execução


        }


        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmcliente = new();
            frmcliente.MdiParent = this;
            frmcliente.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Deseja Sair ?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (msg == DialogResult.Yes) Application.Exit();

        }
    }
}
