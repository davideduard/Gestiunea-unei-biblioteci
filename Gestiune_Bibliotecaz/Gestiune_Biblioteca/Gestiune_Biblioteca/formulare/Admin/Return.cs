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
    public partial class Return : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> client;
        List<List<string>> carte;


        private void refresh_lista()
        {
            SqlCommand cmd = new SqlCommand("Select Nume,Prenume from Utilizatori", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


            while (dr.Read())
            {
                mycollection.Add(String.Format("{0} {1}", dr.GetString(0), dr.GetString(1)));

            }

            UtilizatorText.AutoCompleteMode = AutoCompleteMode.Suggest;
            UtilizatorText.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        private void refresh_carti()
        {
            SqlCommand cmd = new SqlCommand("Select Titlu from Carti", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


            while (dr.Read())
            {
                mycollection.Add(String.Format("{0}", dr.GetString(0)));
            }

            CarteTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            CarteTxt.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            refresh_lista();
            refresh_carti();
            EroareNume.Text = "";
            EroareCarte.Text = "";
            DateGresite.Text = "";
        }

        private void Confirma_Click(object sender, EventArgs e)
        {
            refresh_lista();
            refresh_carti();
            EroareNume.Text = "";
            EroareCarte.Text = "";
            DateGresite.Text = "";
            bool ok = true;

            if (UtilizatorText.Text == "")
            {
                ok = false;
                EroareNume.Text = "*Introduceti numele";
            }
            if (CarteTxt.Text == "")
            {
                ok = false;
                EroareCarte.Text = "*Introduceti o carte";
            }
            if (AnCmb.Text == "" || LunaCmb.Text == "" || ZiCombo.Text == "")
            {
                ok = false;
                DateGresite.Text = "*Introduceti datele";
            }

            if (ok == true)
            {
                string dr;
                int id_client;
                var split = UtilizatorText.Text.Split(' ');

                string queryCarte = "SELECT id,isbn FROM Carti WHERE Titlu = '" + CarteTxt.Text + "';";
                carte = DbManagement.Query(queryCarte);
                int id_carte = Convert.ToInt32(carte[0][0]);

                string queryClient = "SELECT id FROM Utilizatori WHERE Nume = '" + split[0] + "' AND  Prenume = '" + split[1] + "';";
                client = DbManagement.Query(queryClient);
                id_client = Convert.ToInt32(client[0][0]);

                string queryStoc = "SELECT stoc_carte FROM Stoc WHERE isbn_carte = '" + carte[0][1] + "';";
                List<List<string>> stoc;
                stoc = DbManagement.Query(queryStoc);
                int stocV = Convert.ToInt32(stoc[0][0]);

                List<List<string>> imprumut;
                string queryImprumut = "SELECT * FROM Imprumut WHERE id_client = '" + id_client + "' AND id_carte = '" + id_carte;
                queryImprumut += "' AND data_returnata IS NULL OR data_returnata = ' ';";
                imprumut = DbManagement.Query(queryImprumut);

                if (imprumut.Count != 0)
                {
                    string query = "UPDATE Imprumut SET data_returnata = '";
                   
                    dr = LunaCmb.Text + "/" + ZiCombo.Text + "/" + AnCmb.Text;
                    query += dr + "';";

                    DbManagement.NonQuery(query);
                   
                    stocV++;
                    query = "UPDATE Stoc SET Stoc_carte = '" + stocV + "' WHERE isbn_carte = '" + carte[0][1] + "';";
                    DbManagement.NonQuery(query);
                    MessageBox.Show("Cartea a fost returnata cu succes!");
                }
                else
                {
                    MessageBox.Show("Imprumutul nu exista!");
                }

                
            }
        }
    }
}
