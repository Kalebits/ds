
namespace trab1805
{
    partial class Saida
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
            this.rdb_Sair = new System.Windows.Forms.RadioButton();
            this.rdb_PagI = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Sair
            // 
            this.rdb_Sair.AutoSize = true;
            this.rdb_Sair.ForeColor = System.Drawing.Color.White;
            this.rdb_Sair.Location = new System.Drawing.Point(46, 47);
            this.rdb_Sair.Name = "rdb_Sair";
            this.rdb_Sair.Size = new System.Drawing.Size(44, 19);
            this.rdb_Sair.TabIndex = 0;
            this.rdb_Sair.TabStop = true;
            this.rdb_Sair.Text = "Sair";
            this.rdb_Sair.UseVisualStyleBackColor = true;
            this.rdb_Sair.CheckedChanged += new System.EventHandler(this.rdb_Sair_CheckedChanged);
            // 
            // rdb_PagI
            // 
            this.rdb_PagI.AutoSize = true;
            this.rdb_PagI.ForeColor = System.Drawing.Color.White;
            this.rdb_PagI.Location = new System.Drawing.Point(151, 47);
            this.rdb_PagI.Name = "rdb_PagI";
            this.rdb_PagI.Size = new System.Drawing.Size(95, 19);
            this.rdb_PagI.TabIndex = 1;
            this.rdb_PagI.TabStop = true;
            this.rdb_PagI.Text = "Pagina Inicial";
            this.rdb_PagI.UseVisualStyleBackColor = true;
            this.rdb_PagI.CheckedChanged += new System.EventHandler(this.rdb_PagI_CheckedChanged);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(46, 100);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(180, 99);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(294, 166);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rdb_PagI);
            this.Controls.Add(this.rdb_Sair);
            this.Name = "Saida";
            this.Text = "Saida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Sair;
        private System.Windows.Forms.RadioButton rdb_PagI;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}