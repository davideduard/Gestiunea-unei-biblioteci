namespace Gestiune_Biblioteca
{
    partial class Return
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Confirma = new System.Windows.Forms.Button();
            this.DateGresite = new System.Windows.Forms.Label();
            this.EroareCarte = new System.Windows.Forms.Label();
            this.EroareNume = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AnCmb = new System.Windows.Forms.ComboBox();
            this.ZiCombo = new System.Windows.Forms.ComboBox();
            this.LunaCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarteTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UtilizatorText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.Confirma);
            this.panel1.Controls.Add(this.DateGresite);
            this.panel1.Controls.Add(this.EroareCarte);
            this.panel1.Controls.Add(this.EroareNume);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AnCmb);
            this.panel1.Controls.Add(this.ZiCombo);
            this.panel1.Controls.Add(this.LunaCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CarteTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UtilizatorText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 485);
            this.panel1.TabIndex = 0;
            // 
            // Confirma
            // 
            this.Confirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.Confirma.FlatAppearance.BorderSize = 0;
            this.Confirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirma.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirma.ForeColor = System.Drawing.Color.White;
            this.Confirma.Location = new System.Drawing.Point(241, 275);
            this.Confirma.Name = "Confirma";
            this.Confirma.Size = new System.Drawing.Size(103, 27);
            this.Confirma.TabIndex = 79;
            this.Confirma.Text = "Confirma";
            this.Confirma.UseVisualStyleBackColor = false;
            this.Confirma.Click += new System.EventHandler(this.Confirma_Click);
            // 
            // DateGresite
            // 
            this.DateGresite.AutoSize = true;
            this.DateGresite.ForeColor = System.Drawing.Color.Red;
            this.DateGresite.Location = new System.Drawing.Point(397, 242);
            this.DateGresite.Name = "DateGresite";
            this.DateGresite.Size = new System.Drawing.Size(35, 13);
            this.DateGresite.TabIndex = 88;
            this.DateGresite.Text = "label5";
            // 
            // EroareCarte
            // 
            this.EroareCarte.AutoSize = true;
            this.EroareCarte.ForeColor = System.Drawing.Color.Red;
            this.EroareCarte.Location = new System.Drawing.Point(397, 211);
            this.EroareCarte.Name = "EroareCarte";
            this.EroareCarte.Size = new System.Drawing.Size(35, 13);
            this.EroareCarte.TabIndex = 87;
            this.EroareCarte.Text = "label5";
            // 
            // EroareNume
            // 
            this.EroareNume.AutoSize = true;
            this.EroareNume.ForeColor = System.Drawing.Color.Red;
            this.EroareNume.Location = new System.Drawing.Point(397, 180);
            this.EroareNume.Name = "EroareNume";
            this.EroareNume.Size = new System.Drawing.Size(35, 13);
            this.EroareNume.TabIndex = 86;
            this.EroareNume.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(82, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Data returnata";
            // 
            // AnCmb
            // 
            this.AnCmb.BackColor = System.Drawing.Color.White;
            this.AnCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnCmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.AnCmb.FormattingEnabled = true;
            this.AnCmb.Items.AddRange(new object[] {
            "2021"});
            this.AnCmb.Location = new System.Drawing.Point(304, 235);
            this.AnCmb.Name = "AnCmb";
            this.AnCmb.Size = new System.Drawing.Size(87, 25);
            this.AnCmb.TabIndex = 68;
            // 
            // ZiCombo
            // 
            this.ZiCombo.BackColor = System.Drawing.Color.White;
            this.ZiCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZiCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ZiCombo.FormattingEnabled = true;
            this.ZiCombo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.ZiCombo.Location = new System.Drawing.Point(186, 235);
            this.ZiCombo.Name = "ZiCombo";
            this.ZiCombo.Size = new System.Drawing.Size(48, 25);
            this.ZiCombo.TabIndex = 67;
            // 
            // LunaCmb
            // 
            this.LunaCmb.BackColor = System.Drawing.Color.White;
            this.LunaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LunaCmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LunaCmb.FormattingEnabled = true;
            this.LunaCmb.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.LunaCmb.Location = new System.Drawing.Point(241, 235);
            this.LunaCmb.Name = "LunaCmb";
            this.LunaCmb.Size = new System.Drawing.Size(57, 25);
            this.LunaCmb.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Carte";
            // 
            // CarteTxt
            // 
            this.CarteTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CarteTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CarteTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CarteTxt.Location = new System.Drawing.Point(186, 205);
            this.CarteTxt.Name = "CarteTxt";
            this.CarteTxt.Size = new System.Drawing.Size(205, 25);
            this.CarteTxt.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nume";
            // 
            // UtilizatorText
            // 
            this.UtilizatorText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UtilizatorText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UtilizatorText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.UtilizatorText.Location = new System.Drawing.Point(186, 173);
            this.UtilizatorText.Name = "UtilizatorText";
            this.UtilizatorText.Size = new System.Drawing.Size(205, 25);
            this.UtilizatorText.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carte Returnata";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(594, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AnCmb;
        private System.Windows.Forms.ComboBox ZiCombo;
        private System.Windows.Forms.ComboBox LunaCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CarteTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UtilizatorText;
        private System.Windows.Forms.Label DateGresite;
        private System.Windows.Forms.Label EroareCarte;
        private System.Windows.Forms.Label EroareNume;
        private System.Windows.Forms.Button Confirma;
    }
}