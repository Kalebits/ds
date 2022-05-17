using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trab1805
{
    public partial class Frm_Tempo : Form
    {
        public Frm_Tempo()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {

            if (combox_TipoTempo.SelectedItem == null)
            {
                MessageBox.Show("Você precisa selecionar o tipo que deseja converter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Minuto")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 60);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Hora")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 3600);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Dia")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 86400);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Segundo")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 60);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Hora")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 60);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Dia")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 1440);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Minuto")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 60);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Segundo")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 3600);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Dia")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 24);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Segundo")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 86400);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Minuto")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 1440);
            }
            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Hora")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 24);
            }

        }

       



       

        private void cBox_Inverter_CheckedChanged_1(object sender, EventArgs e)
        {
            if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Minuto")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[3];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Hora")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[7];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Dia")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[9];
            }



            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Segundo")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[0];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Hora")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[6];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Dia")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[10];
            }



            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Minuto")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[4];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Segundo")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[1];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Dia")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[11];
            }



            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Segundo")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[2];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Minuto")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[5];
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Hora")
            {
                cBox_Inverter.Checked = false;
                combox_TipoTempo.SelectedItem = combox_TipoTempo.Items[8];
            }
        }

        private void combox_TipoTempo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Minuto")
            {
                lbl_Form.Text = "x / 60 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Hora")
            {
                lbl_Form.Text = "x / 3600 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Segundo p Dia")
            {
                lbl_Form.Text = "x / 86400 = y";
            }



            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Segundo")
            {
                lbl_Form.Text = "x * 60 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Hora")
            {
                lbl_Form.Text = "x / 60 * y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Minuto p Dia")
            {
                lbl_Form.Text = "x / 1440 = y";
            }



            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Minuto")
            {
                lbl_Form.Text = "x * 60 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Segundo")
            {
                lbl_Form.Text = "x * 3600 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Hora p Dia")
            {
                lbl_Form.Text = "x / 24 = y";
            }



            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Segundo")
            {
                lbl_Form.Text = "x * 86400 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Minuto")
            {
                lbl_Form.Text = "x * 1440 = y";
            }

            else if (combox_TipoTempo.SelectedItem.ToString() == "Dia p Hora")
            {
                lbl_Form.Text = "x * 24 = y";
            }

        }

        private void btn_Sair_Click(object sender, EventArgs e)
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
    }
}
