using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trab1805
{
    public partial class Frm_Compp : Form
    {
        public Frm_Compp()
        {
            InitializeComponent();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            if (combox_TipoComp.SelectedItem == null)
            {
                MessageBox.Show("Você precisa selecionar o tipo que deseja converter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Metro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 100);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Quilômetro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 100000);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Milha")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 160934);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Centímetro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 100);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Quilômetro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 60);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Milha")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 1609);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Centímetro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 100000);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Metro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 1000);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Milha")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI / 1.609);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Centímetro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 160934);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Metro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 1609);
            }
            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Quilômetro")
            {
                double tempI;
                tempI = Convert.ToDouble(txt_N1.Text);
                txt_N2.Text = Convert.ToString(tempI * 1.609);
            }
            
        }

        private void cBox_Inverter_CheckedChanged(object sender, EventArgs e)
        {
            if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Metro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[3];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Quilômetro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[7];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Milha")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[9];
            }



            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Centímetro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[0];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Quilômetro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[6];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Milha")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[10];
            }



            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Centímetro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[4];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Metro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[1];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Milha")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[11];
            }




            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Centímetro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[2];
            }


            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Metro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[5];
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Quilômetro")
            {
                cBox_Inverter.Checked = false;
                combox_TipoComp.SelectedItem = combox_TipoComp.Items[8];
            }

        }

        private void combox_TipoComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Metro")
            {
                lbl_Form.Text = "x / 100 = y";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Quilômetro")
            {
                lbl_Form.Text = "x / 100000 = y";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Centímetro p Milha")
            {
                lbl_Form.Text = "Para um resultado aproximado, divida o valor por 86400";
            }



            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Centímetro")
            {
                lbl_Form.Text = "x * 100 = y";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Quilômetro")
            {
                lbl_Form.Text = "x / 1000 = y";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Metro p Milha")
            {
                lbl_Form.Text = "Para um resultado aproximado, divida o valor por 1609";
            }



            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Centímetro")
            {
                lbl_Form.Text = "x * 100000 = y";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Metro")
            {
                lbl_Form.Text = "x * 1000 = y";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Quilômetro p Milha")
            {
                lbl_Form.Text = "Para um resultado aproximado, divida o valor por 1,609";
            }



            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Centímetro")
            {
                lbl_Form.Text = "Para um resultado aproximado, multiplique o valor por 160934";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Metro")
            {
                lbl_Form.Text = "Para um resultado aproximado, multiplique o valor por 1609";
            }

            else if (combox_TipoComp.SelectedItem.ToString() == "Milha p Quilômetro")
            {
                lbl_Form.Text = "Para um resultado aproximado, multiplique o valor por 1,609";
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
