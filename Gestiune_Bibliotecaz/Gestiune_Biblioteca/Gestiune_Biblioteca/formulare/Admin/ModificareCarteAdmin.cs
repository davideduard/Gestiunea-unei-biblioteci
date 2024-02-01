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
    public partial class ModificareCarteAdmin : Form
    {
        List<List<string>> gen;
        List<List<string>> carti;
        List<List<string>> autor;

        string nume_autor;

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);


        public ModificareCarteAdmin()
        {
            InitializeComponent();
        }

        private void refresh_lista_autori()
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

        private void incarcare_gen()
        {
            string query = "Select * From GenCarte";
            gen = DbManagement.Query(query);
            for (int i = 0; i < gen.Count; i++)
                GenCmb.Items.Add(gen[i][1]);
        }

        private void ModificareCarteAdmin_Load(object sender, EventArgs e)
        {
            incarcare_gen();
            refresh_lista();
            refresh_lista_autori();
            TitluNecompletat.Text = "";
            CotaNecompletat.Text = "";
            AutorNecompletat.Text = "";
            IsbnNecompletat.Text = "";
            GenNecompletat.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            refresh_lista_autori();

            string query = "SELECT * FROM Carti WHERE Titlu = '" + TitluCautatText.Text + "';";
            carti = DbManagement.Query(query);


            query = "SELECT Nume,Prenume FROM Autor where Id = '" + carti[0][2] + "';";
            autor = DbManagement.Query(query);
            nume_autor = autor[0][1] + " " + autor[0][0];
            
            string genselect;
            query = "Select gen FROM GenCarte WHERE id = '" + carti[0][5] + "';";
            gen = DbManagement.Query(query);
            genselect = gen[0][0];

            if (carti.Count == 1)
            {
                TitluText.Text = carti[0][1];
                AutorText.Text = nume_autor;
                CotaText.Text = carti[0][3];
                IsbnText.Text = carti[0][4];
                GenCmb.Text = genselect;
            }
            else
                MessageBox.Show("Cartea cautata nu exista");

        }

        private void ModificareButton_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Carti SET";
            bool ok = true;
            bool editat = false;

            TitluNecompletat.Text = "";
            CotaNecompletat.Text = "";
            AutorNecompletat.Text = "";
            IsbnNecompletat.Text = "";
            GenNecompletat.Text = "";

            if (TitluText.Text == "")
            {
                TitluNecompletat.Text = "*Introduceti titlul";
                ok = false;
            }
            
            if(AutorText.Text == "")
            {
                ok = false;
                AutorNecompletat.Text = "*Introduceti un autor";
            }

            if (CotaText.Text == "" || (CotaText.Text.Contains("BZ") == false && CotaText.Text.Contains("RO")))
            {
                CotaNecompletat.Text = "*Introduceti cota";
                ok = false;
            }
            if (IsbnText.Text == "")
            {
                IsbnNecompletat.Text = "*Introduceti ISBN-ul";
                ok = false;
            }
            if (GenCmb.Text == "")
            {
                GenNecompletat.Text = "*Introduceti genul cartii";
                ok = false;
            }

            if (ok == true)
            {
                bool ok_final = true;

                if (TitluText.Text != carti[0][1])
                {
                    editat = true;
                    query += " Titlu = '" + TitluText.Text + "',";
                }

                if (AutorText.Text != nume_autor)
                {
                    var split = AutorText.Text.Split(' ');
                    editat = true;
                    string queryautor = "SELECT id FROM Autor WHERE Nume = '" + split[1] + "' AND Prenume = '" + split[0] + "';";
                    List<List<string>> autorselect;
                    autorselect = DbManagement.Query(queryautor);
                    if (autorselect.Count == 1)
                    {
                        query += " id_autor ='" + autorselect[0][0] + "',";
                    }
                    else
                    {
                        DialogResult dialogresult = MessageBox.Show("Autorul introdus nu exista! Doresti sa il adaugi?", "Atentie!", MessageBoxButtons.YesNo);
                        if (dialogresult == DialogResult.Yes)
                        {
                            Form AdaugareAutor = new AdaugareAutor();
                            AdaugareAutor.ShowDialog();
                        }
                        else
                            ok_final = false;
                    }
                }

                if (CotaText.Text != carti[0][3])
                {
                    editat = true;
                    query += " Cota = '" + CotaText.Text + "',";
                }
                if (IsbnText.Text != carti[0][4])
                {
                    editat = true;
                    query += " isbn = '" + IsbnText.Text + "',";
                }
                if (GenCmb.Text != Convert.ToString(gen[0][0]))
                {
                    editat = true;
                    string querygen = "SELECT id FROM GenCarte WHERE Gen = '" + GenCmb.Text + "';";
                    List<List<string>> genmod;
                    genmod = DbManagement.Query(querygen);
                    query += " id_gen = '" + Convert.ToInt32(genmod[0][0]) + "',";
                }
                
                if (editat == true && ok_final == true)
                {
                    query = query.Substring(0, query.Length - 1);
                    query += " WHERE id = '" + carti[0][0] + "';";
                    DbManagement.NonQuery(query);
                    MessageBox.Show("Modificarea a fost facuta cu succes!");
                    refresh_lista();
                    refresh_lista_autori();
                }
                else
                {
                    if (editat == false)
                        MessageBox.Show("Nu au fost efectuate modificari!");
                    if (ok_final == false)
                        MessageBox.Show("Autorul selectat nu exista!");
                }

            }
        }
    }
}
