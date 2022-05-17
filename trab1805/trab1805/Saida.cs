using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trab1805
{
    public partial class Saida : Form
    {
        private string _value { get; set; }
        public Saida()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();

        }

        private void rdb_Sair_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton radioButton = (RadioButton)sender;
            this._value = radioButton.Text;

        }

        public string GetValue()
        {
            return this._value;
        }

        private void rdb_PagI_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            this._value = radioButton.Text;
        }
    }
}
