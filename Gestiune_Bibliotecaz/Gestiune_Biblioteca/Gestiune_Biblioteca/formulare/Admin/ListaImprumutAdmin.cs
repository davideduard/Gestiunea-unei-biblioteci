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
    public partial class ListaImprumutUtilizator : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> client;
        List<List<string>> imprumuturi;
        List<List<string>> carti;

        public ListaImprumutUtilizator()
        {
            InitializeComponent();
        }

        private void Incarcare_cmb()
        {
            
            string query = "SELECT id_carte FROM Imprumut WHERE id_client = '" + client[0][0] + "';";
            imprumuturi = DbManagement.Query(query);

            if (imprumuturi.Count != 0)
            {
                for (int i = 0; i < imprumuturi.Count; i++)
                {
                    string queryTitlu = "SELECT Titlu FROM Carti WHERE id= '" + imprumuturi[i][0] + "';";
                    carti = DbManagement.Query(queryTitlu);
                    ImprumuturiCmb.Items.Add(carti[0][0]);
                }

            }

            ImprumuturiCmb.SelectedIndex = 0;

        }

        private void incarcare_date()
        {
            string di;
            string dr;
            di = Convert.ToString(imprumuturi[0][0]);
            dr = Convert.ToString(imprumuturi[0][1]);
            var split = di.Split('/');
            var split2 = dr.Split('/');
            LunaCmb.Text = split[0];
            LunaCmb.Items.Add(split[0]);
            LunaRCmb.Text = split2[0];
            LunaRCmb.Items.Add(split2[0]);
            ZiCmb.Text = split[1];
            ZiCmb.Items.Add(split[1]);
            ZiRCmb.Text = split2[1];
            ZiRCmb.Items.Add(split2[1]);

            string an_i = split[2];
            string an_r = split2[2];
            split = an_i.Split(' ');
            split2 = an_r.Split(' ');
            AnCmb.Text = split[0];
            AnCmb.Items.Add(split[0]);
            AnRCmb.Text = split2[0];
            AnRCmb.Items.Add(split2[0]);

            ZiCmb.SelectedIndex = 0;
            AnCmb.SelectedIndex = 0;
            LunaCmb.SelectedIndex = 0;
            ZiRCmb.SelectedIndex = 0;
            AnRCmb.SelectedIndex = 0;
            LunaRCmb.SelectedIndex = 0;

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

            NumeBeneficiarText.AutoCompleteMode = AutoCompleteMode.Suggest;
            NumeBeneficiarText.AutoCompleteCustomSource = mycollection;
            conn.Close();
        }

        private void ModificareImprumutAdmin_Load(object sender, EventArgs e)
        {

            refresh_lista();
            EroareNume.Text = "";
        }

        private void AfiseazaButton_Click(object sender, EventArgs e)
        {
            ZiCmb.Items.Clear();
            ZiRCmb.Items.Clear();
            LunaCmb.Items.Clear();
            LunaRCmb.Items.Clear();
            AnCmb.Items.Clear();
            AnRCmb.Items.Clear();
            ImprumuturiCmb.Items.Clear();

            var split = NumeBeneficiarText.Text.Split(' ');
            string queryclient = "SELECT id FROM UTILIZATORI WHERE Nume = '" + split[0] + "' AND Prenume = '" + split[1] + "';";
            client = DbManagement.Query(queryclient);

            Incarcare_cmb();

        }

        private void cautareDate_Click(object sender, EventArgs e)
        {
            if (client.Count != 0)
            {
                ZiCmb.Items.Clear();
                ZiRCmb.Items.Clear();
                LunaCmb.Items.Clear();
                LunaRCmb.Items.Clear();
                AnCmb.Items.Clear();
                AnRCmb.Items.Clear();

                string queyCarte = "SELECT id FROM Carti WHERE titlu = '" + ImprumuturiCmb.Text + "';";
                carti = DbManagement.Query(queyCarte);

                string query = "SELECT data_imprumut,data_retur FROM Imprumut WHERE id_client = '" + client[0][0] + "' AND id_carte ='" + carti[0][0] + "';";
                imprumuturi = DbManagement.Query(query);

                incarcare_date();
            }
            else
            {
                MessageBox.Show("Nu ati cautat un utilizator");
            }
            
        }
    }
}
