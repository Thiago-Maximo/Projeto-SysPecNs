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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(textBox1.Text, textBox2.Text);
            nivel.inserir();
            MessageBox.Show("Nível gravado com sucesso!!!!!!");
            button1.Enabled = false;
        }
    }
}
