using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trab1805
{
    public partial class Frm_Calc : Form
    {

        public Frm_Calc()
        {
            InitializeComponent();
            Calculos calc = new Calculos();
            calc.dados = new string[99];
        }

        private void btn_N1_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "1";
        }

        private void btn_N2_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "2";
        }

        private void btn_N3_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "3";
        }

        private void btn_N4_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "4";
        }

        private void btn_N5_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "5";
        }

        private void btn_N6_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "6";
        }

        private void btn_N7_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "7";
        }

        private void btn_N8_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "8";
        }

        private void btn_N9_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "9";
        }

        private void btn_N0_Click(object sender, EventArgs e)
        {
            txt_Num.Text += "0";
        }

        private void btn_Virgula_Click(object sender, EventArgs e)
        {
            txt_Num.Text += ".";
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {
            txt_Num.Text += " / ";
        }

        private void btn_Mult_Click(object sender, EventArgs e)
        {
            txt_Num.Text += " * ";
        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            txt_Num.Text += " - ";
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            txt_Num.Text += " + ";
        }

        private void btn_Pow_Click(object sender, EventArgs e)
        {
            txt_Num.Text += " * " + txt_Num.Text;
            string[] ola = new String[99];
            ola[0] = txt_Num.Text;

            DataTable dt = new DataTable();

            var v = dt.Compute(ola[0], "");

            txt_Num.Text = Convert.ToString(v);
        }

        private void btn_Par1_Click(object sender, EventArgs e)
        {
            txt_Num.Text += " (";
        }

        private void btn_Par2_Click(object sender, EventArgs e)
        {
            txt_Num.Text += ") ";
        }

        private void btn_Raiz_Click(object sender, EventArgs e)
        {
            
            string[] ola = new String[99];
            ola[0] = txt_Num.Text;
            DataTable dt = new DataTable();

            var v = Math.Sqrt(Convert.ToDouble(ola[0]));
            txt_Num.Text = Convert.ToString(v);


            this.x.Items.Add("√" +Convert.ToString(ola[0]) + " = " + v);


        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            string[] ola = new String[99];
            ola[0] = txt_Num.Text;
            
            DataTable dt = new DataTable();
            var v = dt.Compute(ola[0], "");

            txt_Num.Text = Convert.ToString(v);


            this.x.Items.Add(ola[0]+ " = " + v);

        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Num.Text = "";
            string[] ola = new String[99];
            ola[0] = "";
        }

        private void btn_ConvTemp_Click(object sender, EventArgs e)
        {
            Frm_Temp frmTemp = new Frm_Temp();
            frmTemp.Show();
            this.Hide();
        }

        private void btn_ConvComp_Click(object sender, EventArgs e)
        {
            Frm_Compp frmComp = new Frm_Compp();
            frmComp.Show();
            this.Hide();
        }

        private void btn_ConvTempo_Click(object sender, EventArgs e)
        {
            Frm_Tempo frmTempo = new Frm_Tempo();
            frmTempo.Show();
            this.Hide();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja mesmo sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
