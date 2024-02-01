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

namespace Gestiune_Biblioteca.formulare
{
    public partial class StergereFromAdmin : Form
    {
        List<List<string>> user;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);

        public StergereFromAdmin()
        {
            InitializeComponent();
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            EroareStergere.Text = "";

            var split = NumeCautatText.Text.Split(' ');
            string query = "Select * from Utilizatori WHERE Nume = '" + split[0] + "';";
            user = DbManagement.Query(query);
            if (user.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Sunteti sigur/a ca vreti sa stergeti utilizatorul cu numele: " + NumeCautatText.Text + " ?", "Atentie!" , MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<List<string>> imprumut;
                    query = "SELECT * FROM Imprumut WHERE id_client = '" + user[0][0] + "' AND data_returnata IS NULL OR data_returnata = ' ';";
                    imprumut = DbManagement.Query(query);

                    if (imprumut.Count == 0)
                    {
                        query = "DELETE FROM Imprumut WHERE id_client = '" + user[0][0] + "';";
                        DbManagement.NonQuery(query);
                        query = "DELETE FROM Utilizatori WHERE id = '" + user[0][0] + "';";
                        DbManagement.NonQuery(query);
                        MessageBox.Show("Utilizatorul a fost sters cu succes!");
                        refresh_lista();
                    }
                    else
                    {
                        MessageBox.Show("Utilizatorul nu a returnat toate cartile!");
                    }
                    
                }
            }
            else
                EroareStergere.Text = "Utilozatorul cautat nu exista!";
        }

        private void StergereFromAdmin_Load(object sender, EventArgs e)
        {
            refresh_lista();
            EroareStergere.Text = "";
        }
    }
}
