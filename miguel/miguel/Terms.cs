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
    public partial class Terms : Form
    {
        public Terms()
        {
            InitializeComponent();
        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {
            if (this.cckBox_Trms.Checked == false)
            {
                MessageBox.Show("Para avançar precisa-se concordar com os termos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Final f4 = new Final();
                f4.Show();
                this.Hide();
            }
        }
    }
}
