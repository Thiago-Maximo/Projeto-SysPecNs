using SysPecNSLib;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private  void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNome.Text,
                txtEmail.Text,
                txtCpf.Text,
                txtTelefone.Text,
               // Convert.ToDateTime (monthcalendarDataNasc.DataContext)
               dateTimePicker1.Value
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                txtId.Text = cliente.Id.ToString();
                MessageBox.Show($"O Usuario {cliente.Nome}, foi gravado " +
                    $"com sucesso, com o ID {cliente.Id}");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtNome.Focus();
                FrmCliente_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao Grava Usuario!");
            }
        }
    }
}
