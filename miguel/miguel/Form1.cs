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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {
            bool empty = false;

            var txt = groupBox3.Controls.OfType<TextBox>().ToArray();

            foreach (TextBox t in txt)
            {
                if (t.Text == "")
                    empty = true;
            }

            if (rdb_Can.Checked == false && rdb_Fel.Checked == false)
            {
                empty = true;
            }

            if (rdb_Masc.Checked == false && rdb_Fem.Checked == false)
            {
                empty = true;
            }

            if (empty)
            {
                MessageBox.Show("Existem informações vazias", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Exames f2 = new Exames();
                f2.Show();
                this.Hide();
            }

        }
    }
}
