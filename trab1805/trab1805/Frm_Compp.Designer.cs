
namespace trab1805
{
    partial class Frm_Compp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Compp));
            this.combox_TipoComp = new System.Windows.Forms.ComboBox();
            this.txt_N1 = new System.Windows.Forms.TextBox();
            this.txt_N2 = new System.Windows.Forms.TextBox();
            this.cBox_Inverter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Form = new System.Windows.Forms.Label();
            this.combox_Tipo = new System.Windows.Forms.ComboBox();
            this.cbox_TipoTemp = new System.Windows.Forms.ComboBox();
            this.combox_TipoTempo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // combox_TipoComp
            // 
            this.combox_TipoComp.FormattingEnabled = true;
            this.combox_TipoComp.Items.AddRange(new object[] {
            "Centímetro p Metro",
            "Centímetro p Quilômetro",
            "Centímetro p Milha",
            "Metro p Centímetro",
            "Metro p Quilômetro",
            "Metro p Milha",
            "Quilômetro p Centímetro",
            "Quilômetro p Metro",
            "Quilômetro p Milha",
            "Milha p Centímetro",
            "Milha p Metro",
            "Milha p Quilômetro"});
            this.combox_TipoComp.Location = new System.Drawing.Point(38, 51);
            this.combox_TipoComp.Name = "combox_TipoComp";
            this.combox_TipoComp.Size = new System.Drawing.Size(144, 23);
            this.combox_TipoComp.TabIndex = 1;
            this.combox_TipoComp.Text = "Conversor";
            this.combox_TipoComp.SelectedIndexChanged += new System.EventHandler(this.combox_TipoComp_SelectedIndexChanged);
            // 
            // txt_N1
            // 
            this.txt_N1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_N1.Location = new System.Drawing.Point(38, 113);
            this.txt_N1.Name = "txt_N1";
            this.txt_N1.Size = new System.Drawing.Size(100, 35);
            this.txt_N1.TabIndex = 2;
            // 
            // txt_N2
            // 
            this.txt_N2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_N2.Location = new System.Drawing.Point(361, 113);
            this.txt_N2.Name = "txt_N2";
            this.txt_N2.Size = new System.Drawing.Size(100, 35);
            this.txt_N2.TabIndex = 3;
            // 
            // cBox_Inverter
            // 
            this.cBox_Inverter.AutoSize = true;
            this.cBox_Inverter.ForeColor = System.Drawing.Color.White;
            this.cBox_Inverter.Location = new System.Drawing.Point(38, 154);
            this.cBox_Inverter.Name = "cBox_Inverter";
            this.cBox_Inverter.Size = new System.Drawing.Size(66, 19);
            this.cBox_Inverter.TabIndex = 9;
            this.cBox_Inverter.Text = "Inverter";
            this.cBox_Inverter.UseVisualStyleBackColor = true;
            this.cBox_Inverter.CheckedChanged += new System.EventHandler(this.cBox_Inverter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // btn_Calc
            // 
            this.btn_Calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Calc.FlatAppearance.BorderSize = 2;
            this.btn_Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calc.ForeColor = System.Drawing.Color.White;
            this.btn_Calc.Location = new System.Drawing.Point(386, 173);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 36);
            this.btn_Calc.TabIndex = 11;
            this.btn_Calc.Text = "Calcular";
            this.btn_Calc.UseVisualStyleBackColor = false;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.Location = new System.Drawing.Point(425, 12);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(66, 62);
            this.btn_Sair.TabIndex = 12;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_Form
            // 
            this.lbl_Form.AutoSize = true;
            this.lbl_Form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Form.ForeColor = System.Drawing.Color.White;
            this.lbl_Form.Location = new System.Drawing.Point(38, 229);
            this.lbl_Form.Name = "lbl_Form";
            this.lbl_Form.Size = new System.Drawing.Size(0, 21);
            this.lbl_Form.TabIndex = 13;
            // 
            // combox_Tipo
            // 
            this.combox_Tipo.FormattingEnabled = true;
            this.combox_Tipo.Items.AddRange(new object[] {
            "Comprimento",
            "Tempo",
            "Temperatura"});
            this.combox_Tipo.Location = new System.Drawing.Point(38, 22);
            this.combox_Tipo.Name = "combox_Tipo";
            this.combox_Tipo.Size = new System.Drawing.Size(144, 23);
            this.combox_Tipo.TabIndex = 14;
            this.combox_Tipo.Text = "Tipo";
            this.combox_Tipo.SelectedIndexChanged += new System.EventHandler(this.combox_Tipo_SelectedIndexChanged);
            // 
            // cbox_TipoTemp
            // 
            this.cbox_TipoTemp.FormattingEnabled = true;
            this.cbox_TipoTemp.Items.AddRange(new object[] {
            "C para K",
            "K para C",
            "C para F",
            "F para C",
            "K para F",
            "F para K"});
            this.cbox_TipoTemp.Location = new System.Drawing.Point(38, 51);
            this.cbox_TipoTemp.Name = "cbox_TipoTemp";
            this.cbox_TipoTemp.Size = new System.Drawing.Size(144, 23);
            this.cbox_TipoTemp.TabIndex = 15;
            this.cbox_TipoTemp.Tag = "";
            this.cbox_TipoTemp.Text = "Conversor";
            this.cbox_TipoTemp.SelectedIndexChanged += new System.EventHandler(this.cbox_TipoTemp_SelectedIndexChanged);
            // 
            // combox_TipoTempo
            // 
            this.combox_TipoTempo.FormattingEnabled = true;
            this.combox_TipoTempo.Items.AddRange(new object[] {
            "Segundo p Minuto",
            "Segundo p Hora",
            "Segundo p Dia",
            "Minuto p Segundo",
            "Minuto p Hora",
            "Minuto p Dia",
            "Hora p Minuto",
            "Hora p Segundo",
            "Hora p Dia",
            "Dia p Segundo",
            "Dia p Minuto",
            "Dia p Hora",
            ""});
            this.combox_TipoTempo.Location = new System.Drawing.Point(38, 51);
            this.combox_TipoTempo.Name = "combox_TipoTempo";
            this.combox_TipoTempo.Size = new System.Drawing.Size(144, 23);
            this.combox_TipoTempo.TabIndex = 16;
            this.combox_TipoTempo.Text = "Conversor";
            this.combox_TipoTempo.SelectedIndexChanged += new System.EventHandler(this.combox_TipoTempo_SelectedIndexChanged);
            // 
            // Frm_Compp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(548, 274);
            this.Controls.Add(this.combox_TipoTempo);
            this.Controls.Add(this.cbox_TipoTemp);
            this.Controls.Add(this.combox_Tipo);
            this.Controls.Add(this.lbl_Form);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_Inverter);
            this.Controls.Add(this.txt_N2);
            this.Controls.Add(this.txt_N1);
            this.Controls.Add(this.combox_TipoComp);
            this.Name = "Frm_Compp";
            this.Text = "Frm_Compp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combox_TipoComp;
        private System.Windows.Forms.TextBox txt_N1;
        private System.Windows.Forms.TextBox txt_N2;
        private System.Windows.Forms.CheckBox cBox_Inverter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Form;
        private System.Windows.Forms.ComboBox combox_Tipo;
        public System.Windows.Forms.ComboBox cbox_TipoTemp;
        private System.Windows.Forms.ComboBox combox_TipoTempo;
    }
}