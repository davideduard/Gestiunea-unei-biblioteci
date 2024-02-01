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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void InregistrareFrmButton_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string query;
            string dn;
            int tip = 1;

            NumeNecompletat.Text = "";
            PrenumeNecompletat.Text = "";
            CnpNecompletat.Text = "";
            EmailNecompletat.Text = "";
            UsernameNecompletat.Text = "";
            ParolaNecompletat.Text = "";
            ConfirmareParolaNecompletat.Text = "";
            DataNasteriiNecompletat.Text = "";

            if (NumeRegText.Text == "")
            {
                NumeNecompletat.Text = "*Introduceti numele";
                ok = false;
            }
            if (PrenumeRegText.Text == "")
            {
                PrenumeNecompletat.Text = "*Introduceti prenumele";
                ok = false;
            }

            if (CnpRegText.Text == "" || CnpRegText.Text.Length != 13)
            {
                CnpNecompletat.Text = "*Introduceti CNP-ul / CNP gresit";
                ok = false;
            }
            if (EmailRegText.Text == "")
            {
                EmailNecompletat.Text = "*Introduceti emailul";
                ok = false;
            }
            if (UsernameRegText.Text == "")
            {
                UsernameNecompletat.Text = "*Introduceti numele de utilizator";
                ok = false;
            }
            if (ParolaRegText.Text == "")
            {
                ParolaNecompletat.Text = "*Introduceti parola";
                ok = false;
            }
            if (ParolaRegText.Text != CParolaRegText.Text)
            {
                ConfirmareParolaNecompletat.Text = "*Parolele nu coincid";
                ok = false;
            }

            if (LunaCmb.Text == "" || ZiCmb.Text == "" || AnCmb.Text == "")
            {
                DataNasteriiNecompletat.Text = "*Introduceti data nasterii";
                ok = false;
            }
           
            if (ok == true)
            {
                query = "SELECT * FROM Utilizatori WHERE username ='" + UsernameRegText.Text + "' AND nume ='" + NumeRegText.Text + "' AND Prenume = '" + PrenumeRegText.Text + "' AND Cnp = '" + CnpRegText.Text + "';";
                List<List<string>> user;
                user = DbManagement.Query(query);
                if (user.Count != 0)
                {
                    MessageBox.Show("Acest Utilizator A fost deja inregistrat");
                }
                else
                {
                    dn = LunaCmb.Text + "/" + ZiCmb.Text + "/" + AnCmb.Text;
                    query = "INSERT INTO Utilizatori (nume,prenume,cnp,data_nasterii,email,username,parola,tip) VALUES ('" + NumeRegText.Text + "',";
                    query += "'" + PrenumeRegText.Text + "','" + CnpRegText.Text + "','" + dn + "','" + EmailRegText.Text + "',";
                    query += "'" + UsernameRegText.Text + "','" + ParolaRegText.Text + "','" + tip + "');";
                    DbManagement.NonQuery(query);
                    MessageBox.Show("Inregistrarea a fost facuta cu succes!");
                }
                
            }

            
        }

        private void Unhide_Click(object sender, EventArgs e)
        {
            if (ParolaRegText.PasswordChar == '*' && CParolaRegText.PasswordChar == '*')
            {
                Hide.BringToFront();
                ParolaRegText.PasswordChar = '\0';
                CParolaRegText.PasswordChar = '\0';
            }
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (ParolaRegText.PasswordChar == '\0' && CParolaRegText.PasswordChar == '\0')
            {
                Unhide.BringToFront();
                ParolaRegText.PasswordChar = '*';
                CParolaRegText.PasswordChar = '*';
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
