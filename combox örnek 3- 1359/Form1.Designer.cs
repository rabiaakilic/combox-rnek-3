namespace combox_örnek_3__1359
{
    partial class Form1
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
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAdlar
            // 
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.Items.AddRange(new object[] {
            "rabia ",
            "deniz",
            "ayşe",
            "fatma",
            "kader",
            "hira",
            "zeynep",
            "esma",
            "sükeyna ",
            "kübra ",
            "hayrunisa",
            ""});
            this.lbAdlar.Location = new System.Drawing.Point(37, 72);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(200, 316);
            this.lbAdlar.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(162, 43);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(37, 43);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(100, 20);
            this.txtAranan.TabIndex = 2;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(53, 409);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(49, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "...kişi var";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lbAdlar);
            this.Name = "Form1";
            this.Text = "\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAdlar;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblSonuc;
    }
}

