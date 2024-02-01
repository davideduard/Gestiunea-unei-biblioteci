using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestiune_Biblioteca
{
    public partial class AdaugareFromAdmin : Form 
    {
        public AdaugareFromAdmin()
        {
            InitializeComponent();
        }
       
        private void InregistrareFrmButton_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string query;
            string dn;
            bool isadmin = false;
            int tip = 1;

            NumeNecompletat.Text = "";
            PrenumeNecompletat.Text = "";
            CnpNecompletat.Text = "";
            EmailNecompletat.Text = "";
            UsernameNecompletat.Text = "";
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

            if (LunaCmb.Text == "" || ZiCmb.Text == "" || AnCmb.Text == "")
            {
                DataNasteriiNecompletat.Text = "*Introduceti data nasterii";
                ok = false;
            }

            if (ok == true)
            {
                if (isadmin == true)
                    tip = 2;
                dn = LunaCmb.Text + "/" + ZiCmb.Text + "/" + AnCmb.Text;
                query = "INSERT INTO Utilizatori (nume,prenume,cnp,data_nasterii,email,username,parola,tip) VALUES ('" + NumeRegText.Text + "',";
                query += "'" + PrenumeRegText.Text + "','" + CnpRegText.Text + "','" + dn + "','" + EmailRegText.Text + "',";
                query += "'" + UsernameRegText.Text + "','parola','" + tip + "');";
                DbManagement.NonQuery(query);
                MessageBox.Show("Inregistrarea a fost facuta cu succes!");
            }

        }

        private void AdaugareFromAdmin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NumeRegText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

