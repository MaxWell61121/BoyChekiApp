namespace BoyÇeki
{
    partial class Frm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBoy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbKilo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.yekun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy(sm)";
            // 
            // lbBoy
            // 
            this.lbBoy.Location = new System.Drawing.Point(102, 30);
            this.lbBoy.Name = "lbBoy";
            this.lbBoy.Size = new System.Drawing.Size(102, 22);
            this.lbBoy.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çəki(kq)";
            // 
            // LbKilo
            // 
            this.LbKilo.Location = new System.Drawing.Point(102, 58);
            this.LbKilo.Name = "LbKilo";
            this.LbKilo.Size = new System.Drawing.Size(102, 22);
            this.LbKilo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yaş";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(102, 22);
            this.textBox3.TabIndex = 5;
            // 
            // yekun
            // 
            this.yekun.Location = new System.Drawing.Point(102, 113);
            this.yekun.Name = "yekun";
            this.yekun.Size = new System.Drawing.Size(102, 42);
            this.yekun.TabIndex = 6;
            this.yekun.Text = "Hesbla";
            this.yekun.UseVisualStyleBackColor = true;
            this.yekun.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 198);
            this.Controls.Add(this.yekun);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbKilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBoy);
            this.Controls.Add(this.label1);
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiyÇeki İdexi";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbBoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LbKilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button yekun;
    }
}

