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
    public partial class ImprumutNouAdmin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> client;
        List<List<string>> carte;


        public ImprumutNouAdmin()
        {
            InitializeComponent();
        }

        private void refresh_lista()
        {
            SqlCommand cmd = new SqlCommand("Select Nume,Prenume from Utilizatori", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


            while (dr.Read())
            {
                mycollection.Add(String.Format("{0} {1}", dr.GetString(0),dr.GetString(1)));

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
                mycollection.Add(String.Format("{0}",  dr.GetString(0)));
            }

            CarteTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
            CarteTxt.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        private void ImprumutNouAdmin_Load(object sender, EventArgs e)
        {
            refresh_lista();
            refresh_carti();
            EroareNume.Text = "";
            EroareCarte.Text = "";
            DateGresite.Text = "";
        }

        private void AdaugaButton_Click(object sender, EventArgs e)
        {
            refresh_carti();
            refresh_lista();
            EroareNume.Text = "";
            EroareCarte.Text = "";
            DateGresite.Text = "";
            int id_client;
            int id_carte;

            var split = UtilizatorText.Text.Split(' ');
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

                string dn;
                DateTime dr;

                string queryClient = "SELECT id FROM Utilizatori WHERE Nume = '" + split[0] + "' AND  Prenume = '" + split[1] + "';";
                client = DbManagement.Query(queryClient);
                id_client = Convert.ToInt32(client[0][0]);

                string queryCarte = "SELECT id,isbn FROM Carti WHERE Titlu = '" + CarteTxt.Text + "';";
                carte = DbManagement.Query(queryCarte);

                string queryStoc = "SELECT stoc_carte FROM Stoc WHERE isbn_carte = '" + carte[0][1] + "';";
                List<List<string>> stoc;
                stoc = DbManagement.Query(queryStoc);
                int stocV = Convert.ToInt32(stoc[0][0]);

                id_carte = Convert.ToInt32(carte[0][0]);

                string query = "INSERT INTO Imprumut(id_client, id_carte, data_imprumut, data_retur) VALUES ('" + id_client + "','"; 
                query += id_carte + "','";

                dn = LunaCmb.Text + "/" + ZiCombo.Text + "/" + AnCmb.Text;
                query += dn + "','";

                dr = Convert.ToDateTime(dn);
                dr = dr.AddDays(7);
                string dFin = Convert.ToString(dr);
                query += dr + "');";


                if (stocV == 0)
                {
                    MessageBox.Show("Cartea nu este in stoc");
                }
                else
                {
                    stocV--;
                    queryStoc = "UPDATE Stoc SET stoc_carte = '" + stocV + "' WHERE isbn_carte = '" + carte[0][1] + "';";
                    DbManagement.NonQuery(query);
                    DbManagement.NonQuery(queryStoc);
                    MessageBox.Show("Imprumutul a fost inregistrat cu succes");
                }
                
            }
           
        }
    }
}
