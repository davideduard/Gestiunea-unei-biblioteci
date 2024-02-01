using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Biblioteca
{
    public partial class LoginForm : Form
    {
        public static int UserId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            EroareUsername.Text = "";
            EroareParola.Text = "";
            List<List<string>> user;
            Form frm;
            string query = "Select * from Utilizatori WHERE username = '" + UsernameTextBox.Text.Trim() + "'";
            query += "AND parola = '" + PasswordTextBox.Text.Trim() + "';";

            user = DbManagement.Query(query);
            if (user.Count == 1)
            {
                if (Convert.ToInt32(user[0][8]) == 2)
                {
                    frm = new InterfataAdmin();
                }
                else
                {
                    UserId = Convert.ToInt32(user[0][0]);
                    frm = new InterfataUser();
                    
                }
                
                
                frm.ShowDialog();
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
                UsernameTextBox.Focus();
                //this.Close();
            }
            else
            {
                if (UsernameTextBox.Text == "")
                {
                    EroareUsername.Text = "*Introduceti un nume de utilizator";
                }
                if (PasswordTextBox.Text == "")
                {
                    EroareParola.Text = "*Introduceti parola";
                }
                if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
                { 
                    UsernameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    UsernameTextBox.Focus();
                    EroareUsername.Text = "Eroare la autentificare";
                }

            }
                    
        }

        private void InregistrareButton_Click(object sender, EventArgs e)
        {
            Form frm = new RegisterForm();
            frm.ShowDialog();
            //this.close()
        }

        private void Unhide_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '*')
            {
                Hide.BringToFront();
                PasswordTextBox.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.PasswordChar == '\0')
            {
                Unhide.BringToFront();
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void InapoiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

