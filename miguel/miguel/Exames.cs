using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miguel
{
    public partial class Exames : Form
    {
        public Exames()
        {
            InitializeComponent();
        }

        private void Exames_Load(object sender, EventArgs e)
        {

        }

        private void btn_Avançar_Click(object sender, EventArgs e)
        {
            if (this.box.Items.Count == 0)
            {
                MessageBox.Show("Insira ao menos um exame", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Terms f3 = new Terms();
                f3.Show();
                this.Hide();
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            this.box.Items.Add(txt_Exame.Text);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            this.box.Items.Clear();
        }
    }
}
