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
    public partial class ModificareClientAdmin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> user;
        bool editat = false;
        bool ok = true;
        string luna_initial, zi_initial, an_initial;

        public ModificareClientAdmin()
        {
            InitializeComponent();
        }

        private void load_datan()
        {
            string dn;
            dn = Convert.ToString(user[0][4]);
            var split = dn.Split('/');
            LunaCmb.Text = split[0];
            luna_initial = split[0];
            ZiCmb.Text = split[1];
            zi_initial = split[1];

            string an = split[2];
            split = an.Split(' ');
            AnCmb.Text = split[0];
            an_initial = split[0];

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           
                var split = NumeCautatText.Text.Split(' ');
                string query = "Select * from Utilizatori WHERE Nume = '" + split[0] + "';";
                user = DbManagement.Query(query);
                if (user.Count > 0)
                {
                    NumeModText.Text = user[0][1];
                    PrenumeModText.Text = user[0][2];
                    CnpModText.Text = user[0][3];
                    load_datan();
                    EmailModText.Text = user[0][5];
                    UsernameModText.Text = user[0][6];
                    if (Convert.ToInt32(user[0][8]) == 1)
                        AdminDaNu.Text = "Nu";
                    else
                        AdminDaNu.Text = "Da";

                }
                else
                    MessageBox.Show("Clientul/Utilizatorul nu exista");
            
        }
            
        private void refresh_lista()
        {
            SqlCommand cmd = new SqlCommand("Select nume,prenume from Utilizatori", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


            while (dr.Read())
            {
                mycollection.Add(String.Format("{0} {1}", dr.GetString(0), dr.GetString(1)));

            }

            NumeCautatText.AutoCompleteMode = AutoCompleteMode.Suggest;
            NumeCautatText.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        private void ModificareClientAdmin_Load(object sender, EventArgs e)
        {
            refresh_lista();
        }

        private void ModificareButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Utilizatori SET ";
            int admin;
            var split = NumeCautatText.Text.Split(' ');


            NumeNecompletat.Text = "";
            PrenumeNecompletat.Text = "";
            CnpNecompletat.Text = "";
            EmailNecompletat.Text = "";
            UsernameNecompletat.Text = "";
            DataNasteriiNecompletat.Text = "";
             
            if (NumeModText.Text == "")
            {
                NumeNecompletat.Text = "*Introduceti numele";
                ok = false;
            }
            if (PrenumeModText.Text == "")
            {
                PrenumeNecompletat.Text = "*Introduceti prenumele";
                ok = false;
            }

            if (CnpModText.Text == "" || CnpModText.Text.Length != 13)
            {
                CnpNecompletat.Text = "*Introduceti CNP-ul / CNP gresit";
                ok = false;
            }
            if (EmailModText.Text == "")
            {
                EmailNecompletat.Text = "*Introduceti emailul";
                ok = false;
            }
            if (UsernameModText.Text == "")
            {
                UsernameNecompletat.Text = "*Introduceti numele de utilizator";
                ok = false;
            }

            if (LunaCmb.Text == "" || AnCmb.Text == "" || ZiCmb.Text == "")
            {
                ok = false;
                DataNasteriiNecompletat.Text = "*Introduceti Data nasterii";
            }

            if (ok == true)
            {
                if (NumeModText.Text != user[0][1])
                {
                    query += "nume = '" + NumeModText.Text + "',";
                    editat = true;
                }
                if (PrenumeModText.Text != user[0][2])
                {
                    editat = true;
                    query += "prenume = '" + PrenumeModText.Text + "',";
                }                    
                if (CnpModText.Text != user[0][3])
                {
                    editat = true;
                    query += "cnp = '" + CnpModText.Text + "',";
                }
                if (EmailModText.Text != user[0][5])
                {
                    editat = true;
                    query += "email = '" + EmailModText.Text + "',";
                }

                if (UsernameModText.Text != user[0][6])
                {
                    editat = true;
                    query += "username = '" + UsernameModText.Text + "',";
                }

                if (AdminDaNu.Text == "Da")
                {
                    admin = 2;
                    editat = true;
                }
                else
                {
                    admin = 1;
                    editat = true;
                }
                if (admin != Convert.ToInt32(user[0][8]))
                    query += "tip = '" + admin + "',";

                query = query.Substring(0, query.Length - 1);
                query += " WHERE id = '" + user[0][0] + "';";

                if (editat == true)
                {
                    DbManagement.NonQuery(query);
                    MessageBox.Show("Modificarea a fost efectuata cu succes");
                }
                else
                    MessageBox.Show("Nu au fost efectuate modificari");

                refresh_lista();
            }
                       
        }

        private void Modificare(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            editat = true;
        }
    }
}
