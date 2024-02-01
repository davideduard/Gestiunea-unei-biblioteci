namespace Gestiune_Biblioteca
{
    partial class ImprumutNouAdmin
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
            this.DateGresite = new System.Windows.Forms.Label();
            this.EroareCarte = new System.Windows.Forms.Label();
            this.EroareNume = new System.Windows.Forms.Label();
            this.AdaugaButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.AnCmb = new System.Windows.Forms.ComboBox();
            this.ZiCombo = new System.Windows.Forms.ComboBox();
            this.ZiCmb = new System.Windows.Forms.ComboBox();
            this.LunaCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarteTxt = new System.Windows.Forms.TextBox();
            this.CarteText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UtilizatorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.DateGresite);
            this.panel1.Controls.Add(this.EroareCarte);
            this.panel1.Controls.Add(this.EroareNume);
            this.panel1.Controls.Add(this.AdaugaButton);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.AnCmb);
            this.panel1.Controls.Add(this.ZiCombo);
            this.panel1.Controls.Add(this.ZiCmb);
            this.panel1.Controls.Add(this.LunaCmb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CarteTxt);
            this.panel1.Controls.Add(this.CarteText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UtilizatorText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 485);
            this.panel1.TabIndex = 0;
            // 
            // DateGresite
            // 
            this.DateGresite.AutoSize = true;
            this.DateGresite.ForeColor = System.Drawing.Color.Red;
            this.DateGresite.Location = new System.Drawing.Point(398, 225);
            this.DateGresite.Name = "DateGresite";
            this.DateGresite.Size = new System.Drawing.Size(35, 13);
            this.DateGresite.TabIndex = 85;
            this.DateGresite.Text = "label5";
            // 
            // EroareCarte
            // 
            this.EroareCarte.AutoSize = true;
            this.EroareCarte.ForeColor = System.Drawing.Color.Red;
            this.EroareCarte.Location = new System.Drawing.Point(398, 194);
            this.EroareCarte.Name = "EroareCarte";
            this.EroareCarte.Size = new System.Drawing.Size(35, 13);
            this.EroareCarte.TabIndex = 80;
            this.EroareCarte.Text = "label5";
            // 
            // EroareNume
            // 
            this.EroareNume.AutoSize = true;
            this.EroareNume.ForeColor = System.Drawing.Color.Red;
            this.EroareNume.Location = new System.Drawing.Point(398, 162);
            this.EroareNume.Name = "EroareNume";
            this.EroareNume.Size = new System.Drawing.Size(35, 13);
            this.EroareNume.TabIndex = 79;
            this.EroareNume.Text = "label4";
            // 
            // AdaugaButton
            // 
            this.AdaugaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.AdaugaButton.FlatAppearance.BorderSize = 0;
            this.AdaugaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdaugaButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugaButton.ForeColor = System.Drawing.Color.White;
            this.AdaugaButton.Location = new System.Drawing.Point(242, 259);
            this.AdaugaButton.Name = "AdaugaButton";
            this.AdaugaButton.Size = new System.Drawing.Size(103, 27);
            this.AdaugaButton.TabIndex = 78;
            this.AdaugaButton.Text = "Adauga";
            this.AdaugaButton.UseVisualStyleBackColor = false;
            this.AdaugaButton.Click += new System.EventHandler(this.AdaugaButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 61;
            this.label8.Text = "Data Imprumutului ";
            // 
            // AnCmb
            // 
            this.AnCmb.BackColor = System.Drawing.Color.White;
            this.AnCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnCmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.AnCmb.FormattingEnabled = true;
            this.AnCmb.Items.AddRange(new object[] {
            "2021"});
            this.AnCmb.Location = new System.Drawing.Point(305, 218);
            this.AnCmb.Name = "AnCmb";
            this.AnCmb.Size = new System.Drawing.Size(87, 25);
            this.AnCmb.TabIndex = 60;
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
            this.ZiCombo.Location = new System.Drawing.Point(189, 219);
            this.ZiCombo.Name = "ZiCombo";
            this.ZiCombo.Size = new System.Drawing.Size(48, 25);
            this.ZiCombo.TabIndex = 59;
            // 
            // ZiCmb
            // 
            this.ZiCmb.BackColor = System.Drawing.Color.White;
            this.ZiCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ZiCmb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ZiCmb.FormattingEnabled = true;
            this.ZiCmb.Items.AddRange(new object[] {
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
            this.ZiCmb.Location = new System.Drawing.Point(188, 218);
            this.ZiCmb.Name = "ZiCmb";
            this.ZiCmb.Size = new System.Drawing.Size(48, 25);
            this.ZiCmb.TabIndex = 59;
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
            this.LunaCmb.Location = new System.Drawing.Point(242, 218);
            this.LunaCmb.Name = "LunaCmb";
            this.LunaCmb.Size = new System.Drawing.Size(57, 25);
            this.LunaCmb.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carte";
            // 
            // CarteTxt
            // 
            this.CarteTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CarteTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CarteTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CarteTxt.Location = new System.Drawing.Point(189, 188);
            this.CarteTxt.Name = "CarteTxt";
            this.CarteTxt.Size = new System.Drawing.Size(204, 25);
            this.CarteTxt.TabIndex = 6;
            // 
            // CarteText
            // 
            this.CarteText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CarteText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CarteText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CarteText.Location = new System.Drawing.Point(188, 187);
            this.CarteText.Name = "CarteText";
            this.CarteText.Size = new System.Drawing.Size(204, 25);
            this.CarteText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(137, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nume";
            // 
            // UtilizatorText
            // 
            this.UtilizatorText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.UtilizatorText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.UtilizatorText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.UtilizatorText.Location = new System.Drawing.Point(188, 156);
            this.UtilizatorText.Name = "UtilizatorText";
            this.UtilizatorText.Size = new System.Drawing.Size(204, 25);
            this.UtilizatorText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imprumut nou";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImprumutNouAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(594, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImprumutNouAdmin";
            this.Text = "ImprumutNouAdmin";
            this.Load += new System.EventHandler(this.ImprumutNouAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UtilizatorText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox AnCmb;
        private System.Windows.Forms.ComboBox ZiCmb;
        private System.Windows.Forms.ComboBox LunaCmb;
        private System.Windows.Forms.Button AdaugaButton;
        private System.Windows.Forms.Label EroareCarte;
        private System.Windows.Forms.Label EroareNume;
        private System.Windows.Forms.TextBox CarteText;
        private System.Windows.Forms.ComboBox ZiCombo;
        private System.Windows.Forms.TextBox CarteTxt;
        private System.Windows.Forms.Label DateGresite;
    }
}