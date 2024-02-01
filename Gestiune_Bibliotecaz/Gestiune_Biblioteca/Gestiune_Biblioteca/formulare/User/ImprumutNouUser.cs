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
    public partial class ImprumutNouUser : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> carte;
        bool ok;
        int userId;

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

        public ImprumutNouUser()
        {
            InitializeComponent();
        }

        private void AdaugaButton_Click(object sender, EventArgs e)
        {
            ok = true;
            refresh_carti();
            EroareCarte.Text = "";
            DateGresite.Text = "";

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
                bool imprumutat = false;
                List<List<string>> titlu_imprumut;

                string queryCarte = "SELECT id,isbn FROM Carti WHERE Titlu = '" + CarteTxt.Text + "';";
                carte = DbManagement.Query(queryCarte);

                string queryStoc = "SELECT stoc_carte FROM Stoc WHERE isbn_carte = '" + carte[0][1] + "';";
                List<List<string>> stoc;
                stoc = DbManagement.Query(queryStoc);
                int stocV = Convert.ToInt32(stoc[0][0]);
                int id_carte = Convert.ToInt32(carte[0][0]);

                string queryImprumut = "SELECT * FROM Imprumut WHERE id_carte = '" + id_carte + "' AND id_client = '" + userId + "' AND data_returnata IS NULL;";
                titlu_imprumut = DbManagement.Query(queryImprumut);

                if (titlu_imprumut.Count != 0)
                {
                    EroareCarte.Text = "Ati imprumutat deja un exemplar!";
                }
                else
                {
                    

                    string query = "INSERT INTO Imprumut(id_client, id_carte, data_imprumut, data_retur) VALUES ('" + userId + "','" + id_carte + "','";

                    dn = LunaCmb.Text + "/" + ZiCombo.Text + "/" + AnCmb.Text;
                    query += dn + "','";

                    DateTime dr = Convert.ToDateTime(dn);
                    dr = dr.AddDays(7);
                    string dFin = Convert.ToString(dr);
                    query += dFin + "');";

                    if (stocV == 0)
                    {
                       EroareCarte.Text = "Cartea nu este in stoc";
                    }
                    else
                    {
                        stocV--;
                        queryStoc = "UPDATE Stoc SET stoc_carte = '" + stocV + "' WHERE isbn_carte = '" + carte[0][1] + "';";
                        DbManagement.NonQuery(query);
                        DbManagement.NonQuery(queryStoc);
                        MessageBox.Show("Imprumutul a fost inregistrat cu succes! Va asteptam in cel mai scurt timp sa ridicati cartea");
                    }
                }
                
            }
        }

        private void ImprumutNouUser_Load(object sender, EventArgs e)
        {
            refresh_carti();
            EroareCarte.Text = "";
            DateGresite.Text = "";
            userId = LoginForm.UserId;
        }
    }
}
