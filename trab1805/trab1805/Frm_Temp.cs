using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trab1805
{
    public partial class Frm_Temp : Form
    {
        public Frm_Temp()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {

            if(this.cbox_TipoTemp.SelectedItem == null)
            {
                MessageBox.Show("Você precisa selecionar o tipo que deseja converter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbox_TipoTemp.SelectedItem.ToString() == "C para K")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI + 273.15);
            }
            else if (this.cbox_TipoTemp.SelectedItem.ToString() == "K para C")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI - 273.15);
            }
            else if (this.cbox_TipoTemp.SelectedItem.ToString() == "C para F")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString((tempI * 9 / 5) + 32);
            }
            else if (this.cbox_TipoTemp.SelectedItem.ToString() == "F para C")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString((tempI - 32) * 5 / 9);
            }
            else if (this.cbox_TipoTemp.SelectedItem.ToString() == "K para F")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString((tempI - 273.15) * 9 / 5 + 32);
            }
            else if (this.cbox_TipoTemp.SelectedItem.ToString() == "F para K")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString((tempI - 32) * 5 / 9 + 273.15);
            }
           
        }

        private void cbox_TipoTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_TipoTemp.SelectedItem.ToString() == "C para K")
            {
                lbl_Form.Text = "x°C + 273.15 = yK";
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "K para C")
            {
                lbl_Form.Text = "xK - 273.15 = y°C";
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "C para F")
            {
                lbl_Form.Text = "(x°C × 9/5) + 32 = y°F";
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "F para C")
            {
                lbl_Form.Text = "(x°F − 32) * 5/9 = y°C";
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "K para F")
            {
                lbl_Form.Text = "(xK − 273,15) * 9/5 + 32 = y°F";
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "F para K")
            {
                lbl_Form.Text = "(x°F − 32) * 5/9 + 273,15 = yK";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saida frmSaida = new Saida();

            DialogResult dr = frmSaida.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string value = frmSaida.GetValue();
                if (value == "Sair")
                {
                    Environment.Exit(0);
                }
                else if (value == "Pagina Inicial")
                {
                    Frm_Calc frmCalc = new Frm_Calc();
                    frmCalc.Show();
                    this.Hide();
                }
            }
        }

        private void cBox_Inverter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_TipoTemp.SelectedItem.ToString() == "C para K")
            {
                cBox_Inverter.Checked = false;
                cbox_TipoTemp.SelectedItem = cbox_TipoTemp.Items[1];
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "K para C")
            {
                cBox_Inverter.Checked = false;
                cbox_TipoTemp.SelectedItem = cbox_TipoTemp.Items[0];
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "C para F")
            {
                cBox_Inverter.Checked = false;
                cbox_TipoTemp.SelectedItem = cbox_TipoTemp.Items[3];
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "F para C")
            {
                cBox_Inverter.Checked = false;
                cbox_TipoTemp.SelectedItem = cbox_TipoTemp.Items[2];
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "K para F")
            {
                cBox_Inverter.Checked = false;
                cbox_TipoTemp.SelectedItem = cbox_TipoTemp.Items[5];
            }
            else if (cbox_TipoTemp.SelectedItem.ToString() == "F para K")
            {
                cBox_Inverter.Checked = false;
                cbox_TipoTemp.SelectedItem = cbox_TipoTemp.Items[4];
            }
        }
    }
}
