using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdb_Saque_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            bool empty = false;

            var txt = groupBox1.Controls.OfType<TextBox>().ToArray();

            foreach (TextBox t in txt)
            {
                if (t.Text == "")
                    empty = true;
            }

            var txt2 = groupBox2.Controls.OfType<TextBox>().ToArray();

            foreach (TextBox t in txt2)
            {
                if (t.Text == "")
                    empty = true;
            }

            var txt3 = groupBox3.Controls.OfType<TextBox>().ToArray();

            foreach (TextBox t in txt3)
            {
                if (t.Text == "")
                    empty = true;
            }

            if (rdb_Deposito.Checked == false && rdb_Saque.Checked == false)
            {
                empty = true;
            }

            if (empty)
            {
                MessageBox.Show("Existem informações vazias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cli = new Cliente();
                cli.nome = txt_Nome.Text;
                cli.sobrenome = txt_Sobrenome.Text;
                cli.cpf = txt_CPF.Text;

                Conta cc = new Conta(cli);

                cc.numero = Convert.ToInt32(txt_Numero.Text);
                cc.limite = Convert.ToDouble(txt_Limite.Text);
                cc.saldo = Convert.ToDouble(txt_Saldo.Text);

                if (rdb_Saque.Checked == true)
                {
                    cc.sacar(Convert.ToDouble(txt_Valor.Text));
                }
                else if (rdb_Deposito.Checked == true)
                {
                    cc.depositar(Convert.ToDouble(txt_Valor.Text));
                }
              
                MessageBox.Show(Convert.ToString(cc.saldo), "Novo Saldo", MessageBoxButtons.YesNo);
                txt_Saldo.Text = Convert.ToString(cc.saldo);
            }


        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voce deseja mesmo sair ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

        }

        private void lbl_Saldo_Click(object sender, EventArgs e)
        {

        }
    }
}
