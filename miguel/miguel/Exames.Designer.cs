
namespace miguel
{
    partial class Exames
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
            this.box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Exame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Avançar = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.cBox_Exm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(22, 82);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(198, 225);
            this.box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exame: ";
            // 
            // txt_Exame
            // 
            this.txt_Exame.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Exame.Location = new System.Drawing.Point(341, 158);
            this.txt_Exame.Name = "txt_Exame";
            this.txt_Exame.Size = new System.Drawing.Size(174, 26);
            this.txt_Exame.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escreva o(s) exames que deseja que seja feito em seu Pet.";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(244, 242);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Avançar
            // 
            this.btn_Avançar.Location = new System.Drawing.Point(429, 242);
            this.btn_Avançar.Name = "btn_Avançar";
            this.btn_Avançar.Size = new System.Drawing.Size(75, 23);
            this.btn_Avançar.TabIndex = 6;
            this.btn_Avançar.Text = "Avançar";
            this.btn_Avançar.UseVisualStyleBackColor = true;
            this.btn_Avançar.Click += new System.EventHandler(this.btn_Avançar_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(341, 242);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 7;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // cBox_Exm
            // 
            this.cBox_Exm.FormattingEnabled = true;
            this.cBox_Exm.Items.AddRange(new object[] {
            "Ultrassom",
            "Raio-X",
            "Exame de Sangue",
            "Exame de Pele",
            "Eletrocardiograma",
            "Tomografia"});
            this.cBox_Exm.Location = new System.Drawing.Point(22, 338);
            this.cBox_Exm.Name = "cBox_Exm";
            this.cBox_Exm.Size = new System.Drawing.Size(121, 21);
            this.cBox_Exm.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exames que disponibilizamos em nossa Clínica";
            // 
            // Exames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBox_Exm);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Avançar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Exame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box);
            this.Name = "Exames";
            this.Text = "Exames";
            this.Load += new System.EventHandler(this.Exames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Exame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Avançar;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.ComboBox cBox_Exm;
        private System.Windows.Forms.Label label3;
    }
}