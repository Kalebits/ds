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
            this.combox_TipoComp.Hide();
            this.combox_TipoTempo.Hide();
            this.cbox_TipoTemp.Hide();
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {

            if (combox_TipoComp.Visible)
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
            

            if (this.cbox_TipoTemp.Visible)
            {
                if (this.cbox_TipoTemp.SelectedItem == null)
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

            if (combox_TipoTempo.Visible)
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
            
            
            
            
            
            

        }

        private void cBox_Inverter_CheckedChanged(object sender, EventArgs e)
        {
            if (combox_TipoComp.Visible)
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

            if (cbox_TipoTemp.Visible)
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

                if (combox_TipoTempo.Visible)
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

        private void combox_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (combox_Tipo.SelectedItem.ToString() == "Comprimento")
            {
                this.combox_TipoComp.Show();
                this.combox_TipoTempo.Hide();
                this.cbox_TipoTemp.Hide();
                lbl_Form.Text = "";
            }

            else if (combox_Tipo.SelectedItem.ToString() == "Tempo")
            {
                this.combox_TipoTempo.Show();
                this.cbox_TipoTemp.Hide();
                this.combox_TipoComp.Hide();
                lbl_Form.Text = "";
            }

            else if (combox_Tipo.SelectedItem.ToString() == "Temperatura")
            {
                this.cbox_TipoTemp.Show();
                this.combox_TipoTempo.Hide();
                this.combox_TipoComp.Hide();
                lbl_Form.Text = "";
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
    }
}
