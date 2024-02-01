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
    public partial class StergereCarteAdmin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> carte;

        public StergereCarteAdmin()
        {
            InitializeComponent();
        }

        private void StergereCarteAdmin_Load(object sender, EventArgs e)
        {
            EroareStergere.Text = "";
            refresh_lista();
        }

        private void refresh_lista()
        {
            SqlCommand cmd = new SqlCommand("Select Titlu from Carti", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();


            while (dr.Read())
            {
                mycollection.Add(String.Format("{0}", dr.GetString(0)));

            }

            TitluCautatText.AutoCompleteMode = AutoCompleteMode.Suggest;
            TitluCautatText.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            refresh_lista();
            string query = "SELECT * FROM Carti WHERE Titlu = '" + TitluCautatText.Text + "';";
            carte = DbManagement.Query(query);
            
            if (carte.Count != 0)
            {
                List<List<string>> imprumutata;
                query = "SELECT * FROM Imprumut WHERE id_carte ='" + carte[0][0] + "';";
                imprumutata = DbManagement.Query(query);

                if (imprumutata.Count != 0)
                {
                    EroareStergere.Text = "Cartea este folosita intr-un imprumut activ";
                }
                else
                {
                    string isbn = carte[0][4];
                    MessageBox.Show(isbn);
                    query = "DELETE FROM Carti WHERE isbn ='" + isbn + "';";
                    string queryStoc = "DELETE FROM Stoc WHERE isbn_carte = '" + isbn + "';";


                    DialogResult dialogresult = MessageBox.Show("Sunteti sigur/a ca vreti sa stergeti acesta carte?", "Atentie!", MessageBoxButtons.YesNo);
                    if (dialogresult == DialogResult.Yes)
                    {

                        DbManagement.NonQuery(query);
                        DbManagement.NonQuery(queryStoc);
                        MessageBox.Show("Cartea " + carte[0][1] + " a fost stearsa cu succes!");
                    }
                }

                
            }
            else    
               EroareStergere.Text = "Cartea nu exista";

        }
    }
}
