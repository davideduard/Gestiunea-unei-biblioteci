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
    public partial class AdaugaCarteAdmin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> autor;
        List<List<string>> gen;

        public AdaugaCarteAdmin()
        {
            InitializeComponent();
        }

        private void incarcare_gen()
        {
            string query = "Select * From GenCarte";
            gen = DbManagement.Query(query);
            for (int i = 0; i < gen.Count; i++)
                GenCmb.Items.Add(gen[i][1]); 
        }

        private void refresh_lista()
        {

            SqlCommand cmd = new SqlCommand("Select prenume,nume from Autor", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


            while (dr.Read())
            {
                mycollection.Add(String.Format("{0} {1}", dr.GetString(0), dr.GetString(1)));

            }

            AutorText.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutorText.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        private void AdaugareCarteButton_Click(object sender, EventArgs e)
        {
            string query;
            bool ok = true;

            TitluGresit.Text = "";
            AutorGresit.Text = "";
            CotaGresita.Text = "";
            IsbnGresit.Text = "";
            GenGresit.Text = "";


            if (TitluText.Text == "")
            {
                TitluGresit.Text = "*Introduceti titlul";
                ok = false;
            }
            if (AutorText.Text == "")
            {
                AutorGresit.Text = "*Autor introdus gresit";
                ok = false; 
            }
            if (CotaText.Text == "")
            {
                CotaGresita.Text = "*Introduceti cota";
                ok = false;
            }
            if (IsbnText.Text == "")
            {
                IsbnGresit.Text = "*Introduceti ISBN-ul";
                ok = false;
            }
            if (GenCmb.Text == "")
            {
                GenGresit.Text = "*Selectati o optiune";
                ok = false;
            }

            if (ok == true)
            {
                bool ok_final = false;
                int id_autor = 0;
                int id_gen;
                var split = AutorText.Text.Split(' ');
                query = "Select Id From autor where Nume = '" + split[1] + "' AND prenume = '" + split[0] + "';";
                autor = DbManagement.Query(query);
                if (autor.Count == 1)
                {
                    ok_final = true;
                    id_autor = Convert.ToInt32(autor[0][0]);
                }
                else
                {
                    
                    DialogResult dialogResult = MessageBox.Show("Autorul nu exista. Doriti sa il adaugati?", "Atentie!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Form AdaugareAutor = new AdaugareAutor();
                        AdaugareAutor.ShowDialog();
                    }
                    else
                        ok_final = false;
                }

                if (ok_final == true)
                {
                    query = "Select id From GenCarte Where gen = '" + GenCmb.Text + "';";
                    gen = DbManagement.Query(query);
                  
                    id_gen = Convert.ToInt32(gen[0][0]);

                    query = "SELECT * FROM Carti WHERE isbn = '" + IsbnText.Text + "';";
                    List<List<string>> carti;
                    carti = DbManagement.Query(query);
                    if (carti.Count == 0)
                    {
                        int stoc = 1;
                        string queryStoc = "INSERT INTO Stoc (isbn_carte,stoc_carte) VALUES ('" + IsbnText.Text + "','" + stoc + "');";
                        DbManagement.NonQuery(queryStoc);

                    }
                    else
                    {
                        int stoc = carti.Count + 1;
                        string queryStoc = "UPDATE Stoc SET stoc_carte = '" + stoc + "' WHERE isbn_carte = '" + carti[0][4] + "';";
                        DbManagement.NonQuery(queryStoc);
                    }

                    query = "Insert Into Carti ( titlu, id_autor, cota, isbn, id_gen) Values ('";
                    query += TitluText.Text + "',";
                    query += "'" + id_autor + "','" + CotaText.Text + "','" + IsbnText.Text + "','" + id_gen + "');";

                    DbManagement.NonQuery(query);
                    MessageBox.Show("Cartea a fost adaugata cu succes!");
                    
                }

            }
        }

        private void AdaugaCarteAdmin_Load(object sender, EventArgs e)
        {
            TitluGresit.Text = "";
            AutorGresit.Text = "";
            CotaGresita.Text = "";
            IsbnGresit.Text = "";
            GenGresit.Text = "";
            refresh_lista();
            incarcare_gen();
        }
    }
}
