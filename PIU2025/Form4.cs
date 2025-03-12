using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIU2025
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5() { MdiParent = this }.Show();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var janela = new Form5() { MdiParent = this };
            janela.Show();
            janela.tabControl1.SelectTab(1);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show("Deseja realmente sair?",
                                "Sair",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }
    }
}
