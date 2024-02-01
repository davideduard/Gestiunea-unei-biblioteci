namespace Gestiune_Biblioteca
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.InregistrareButton = new System.Windows.Forms.Button();
            this.EroareUsername = new System.Windows.Forms.Label();
            this.EroareParola = new System.Windows.Forms.Label();
            this.Unhide = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InapoiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(264, 188);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(173, 20);
            this.UsernameTextBox.TabIndex = 0;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(180, 189);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(78, 19);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(264, 214);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(173, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // parola
            // 
            this.parola.AutoSize = true;
            this.parola.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(205, 215);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(53, 19);
            this.parola.TabIndex = 3;
            this.parola.Text = "Parola";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(264, 240);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(61, 33);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // InregistrareButton
            // 
            this.InregistrareButton.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InregistrareButton.Location = new System.Drawing.Point(331, 241);
            this.InregistrareButton.Name = "InregistrareButton";
            this.InregistrareButton.Size = new System.Drawing.Size(106, 33);
            this.InregistrareButton.TabIndex = 5;
            this.InregistrareButton.Text = "Inregistrare";
            this.InregistrareButton.UseVisualStyleBackColor = true;
            this.InregistrareButton.Click += new System.EventHandler(this.InregistrareButton_Click);
            // 
            // EroareUsername
            // 
            this.EroareUsername.AutoSize = true;
            this.EroareUsername.ForeColor = System.Drawing.Color.Red;
            this.EroareUsername.Location = new System.Drawing.Point(443, 191);
            this.EroareUsername.Name = "EroareUsername";
            this.EroareUsername.Size = new System.Drawing.Size(0, 13);
            this.EroareUsername.TabIndex = 6;
            // 
            // EroareParola
            // 
            this.EroareParola.AutoSize = true;
            this.EroareParola.ForeColor = System.Drawing.Color.Red;
            this.EroareParola.Location = new System.Drawing.Point(483, 219);
            this.EroareParola.Name = "EroareParola";
            this.EroareParola.Size = new System.Drawing.Size(0, 13);
            this.EroareParola.TabIndex = 7;
            // 
            // Unhide
            // 
            this.Unhide.FlatAppearance.BorderSize = 0;
            this.Unhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unhide.Image = ((System.Drawing.Image)(resources.GetObject("Unhide.Image")));
            this.Unhide.Location = new System.Drawing.Point(443, 215);
            this.Unhide.Name = "Unhide";
            this.Unhide.Size = new System.Drawing.Size(34, 20);
            this.Unhide.TabIndex = 31;
            this.Unhide.UseVisualStyleBackColor = true;
            this.Unhide.Click += new System.EventHandler(this.Unhide_Click);
            // 
            // Hide
            // 
            this.Hide.FlatAppearance.BorderSize = 0;
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide.Image = ((System.Drawing.Image)(resources.GetObject("Hide.Image")));
            this.Hide.Location = new System.Drawing.Point(443, 215);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(34, 20);
            this.Hide.TabIndex = 30;
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 72);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bine ati venit!";
            // 
            // InapoiButton
            // 
            this.InapoiButton.BackColor = System.Drawing.Color.Transparent;
            this.InapoiButton.FlatAppearance.BorderSize = 0;
            this.InapoiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InapoiButton.Image = ((System.Drawing.Image)(resources.GetObject("InapoiButton.Image")));
            this.InapoiButton.Location = new System.Drawing.Point(12, 18);
            this.InapoiButton.Name = "InapoiButton";
            this.InapoiButton.Size = new System.Drawing.Size(37, 30);
            this.InapoiButton.TabIndex = 33;
            this.InapoiButton.UseVisualStyleBackColor = false;
            this.InapoiButton.Click += new System.EventHandler(this.InapoiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Exit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InapoiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unhide);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.EroareParola);
            this.Controls.Add(this.EroareUsername);
            this.Controls.Add(this.InregistrareButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.UsernameTextBox);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label parola;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button InregistrareButton;
        private System.Windows.Forms.Label EroareUsername;
        private System.Windows.Forms.Label EroareParola;
        private System.Windows.Forms.Button Unhide;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InapoiButton;
        private System.Windows.Forms.Label label2;
    }
}

