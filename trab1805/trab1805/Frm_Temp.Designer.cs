
namespace trab1805
{
    partial class Frm_Temp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Temp));
            this.txt_N1 = new System.Windows.Forms.TextBox();
            this.txt_N2 = new System.Windows.Forms.TextBox();
            this.cbox_TipoTemp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calca = new System.Windows.Forms.Button();
            this.lbl_Form = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cBox_Inverter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_N1
            // 
            this.txt_N1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_N1.Location = new System.Drawing.Point(38, 113);
            this.txt_N1.Name = "txt_N1";
            this.txt_N1.Size = new System.Drawing.Size(100, 35);
            this.txt_N1.TabIndex = 0;
            // 
            // txt_N2
            // 
            this.txt_N2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_N2.Location = new System.Drawing.Point(361, 113);
            this.txt_N2.Name = "txt_N2";
            this.txt_N2.ReadOnly = true;
            this.txt_N2.Size = new System.Drawing.Size(100, 35);
            this.txt_N2.TabIndex = 1;
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
            this.cbox_TipoTemp.Location = new System.Drawing.Point(38, 31);
            this.cbox_TipoTemp.Name = "cbox_TipoTemp";
            this.cbox_TipoTemp.Size = new System.Drawing.Size(137, 23);
            this.cbox_TipoTemp.TabIndex = 2;
            this.cbox_TipoTemp.Tag = "";
            this.cbox_TipoTemp.Text = "Tipo de Temperatura";
            this.cbox_TipoTemp.SelectedIndexChanged += new System.EventHandler(this.cbox_TipoTemp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // btn_Calca
            // 
            this.btn_Calca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Calca.FlatAppearance.BorderSize = 2;
            this.btn_Calca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calca.ForeColor = System.Drawing.Color.White;
            this.btn_Calca.Location = new System.Drawing.Point(386, 173);
            this.btn_Calca.Name = "btn_Calca";
            this.btn_Calca.Size = new System.Drawing.Size(75, 36);
            this.btn_Calca.TabIndex = 4;
            this.btn_Calca.Text = "Calcular";
            this.btn_Calca.UseVisualStyleBackColor = false;
            this.btn_Calca.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // lbl_Form
            // 
            this.lbl_Form.AutoSize = true;
            this.lbl_Form.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Form.ForeColor = System.Drawing.Color.White;
            this.lbl_Form.Location = new System.Drawing.Point(38, 187);
            this.lbl_Form.Name = "lbl_Form";
            this.lbl_Form.Size = new System.Drawing.Size(0, 25);
            this.lbl_Form.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(425, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 62);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBox_Inverter
            // 
            this.cBox_Inverter.AutoSize = true;
            this.cBox_Inverter.ForeColor = System.Drawing.Color.White;
            this.cBox_Inverter.Location = new System.Drawing.Point(38, 155);
            this.cBox_Inverter.Name = "cBox_Inverter";
            this.cBox_Inverter.Size = new System.Drawing.Size(66, 19);
            this.cBox_Inverter.TabIndex = 7;
            this.cBox_Inverter.Text = "Inverter";
            this.cBox_Inverter.UseVisualStyleBackColor = true;
            this.cBox_Inverter.CheckedChanged += new System.EventHandler(this.cBox_Inverter_CheckedChanged);
            // 
            // Frm_Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(503, 221);
            this.Controls.Add(this.cBox_Inverter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Form);
            this.Controls.Add(this.btn_Calca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox_TipoTemp);
            this.Controls.Add(this.txt_N2);
            this.Controls.Add(this.txt_N1);
            this.Name = "Frm_Temp";
            this.Text = "Frm_Temp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_N1;
        private System.Windows.Forms.TextBox txt_N2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calca;
        public System.Windows.Forms.ComboBox cbox_TipoTemp;
        private System.Windows.Forms.Label lbl_Form;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cBox_Inverter;
    }
}