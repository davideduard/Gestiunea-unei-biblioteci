namespace Gestiune_Biblioteca
{
    partial class StergereCarteAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TitluCautatText = new System.Windows.Forms.TextBox();
            this.EroareStergere = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.EroareStergere);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TitluCautatText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 485);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sterge Carte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(389, 160);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 26);
            this.searchButton.TabIndex = 83;
            this.searchButton.Text = "Cauta";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 82;
            this.label2.Text = "Introduceti numele cartii";
            // 
            // TitluCautatText
            // 
            this.TitluCautatText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TitluCautatText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TitluCautatText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.TitluCautatText.Location = new System.Drawing.Point(182, 160);
            this.TitluCautatText.Name = "TitluCautatText";
            this.TitluCautatText.Size = new System.Drawing.Size(201, 25);
            this.TitluCautatText.TabIndex = 81;
            // 
            // EroareStergere
            // 
            this.EroareStergere.AutoSize = true;
            this.EroareStergere.ForeColor = System.Drawing.Color.Red;
            this.EroareStergere.Location = new System.Drawing.Point(228, 199);
            this.EroareStergere.Name = "EroareStergere";
            this.EroareStergere.Size = new System.Drawing.Size(125, 13);
            this.EroareStergere.TabIndex = 84;
            this.EroareStergere.Text = "Cartea cautata nu exista!";
            // 
            // StergereCarteAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(594, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StergereCarteAdmin";
            this.Text = "StergereCarteAdmin";
            this.Load += new System.EventHandler(this.StergereCarteAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitluCautatText;
        private System.Windows.Forms.Label EroareStergere;
    }
}