namespace Gestiune_Biblioteca.formulare
{
    partial class StergereFromAdmin
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
            this.EroareStergere = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.NumeCautatText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.EroareStergere);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.NumeCautatText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 485);
            this.panel1.TabIndex = 0;
            // 
            // EroareStergere
            // 
            this.EroareStergere.AutoSize = true;
            this.EroareStergere.ForeColor = System.Drawing.Color.Red;
            this.EroareStergere.Location = new System.Drawing.Point(241, 202);
            this.EroareStergere.Name = "EroareStergere";
            this.EroareStergere.Size = new System.Drawing.Size(140, 13);
            this.EroareStergere.TabIndex = 79;
            this.EroareStergere.Text = "Utilozatorul cautat nu exista!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 78;
            this.label7.Text = "Introduceti numele";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(435, 163);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 28);
            this.searchButton.TabIndex = 77;
            this.searchButton.Text = "Cauta";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // NumeCautatText
            // 
            this.NumeCautatText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NumeCautatText.BackColor = System.Drawing.Color.White;
            this.NumeCautatText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumeCautatText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.NumeCautatText.Location = new System.Drawing.Point(193, 169);
            this.NumeCautatText.Name = "NumeCautatText";
            this.NumeCautatText.Size = new System.Drawing.Size(236, 18);
            this.NumeCautatText.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(196, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stergere Utilizator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StergereFromAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(594, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StergereFromAdmin";
            this.Text = "StergereFromAdmin";
            this.Load += new System.EventHandler(this.StergereFromAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox NumeCautatText;
        private System.Windows.Forms.Label EroareStergere;
    }
}