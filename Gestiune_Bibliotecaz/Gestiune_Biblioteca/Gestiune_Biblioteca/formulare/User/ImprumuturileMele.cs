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

    public partial class ImprumuturileMele : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);
        List<List<string>> imprumuturi;
        List<List<string>> carti;
        public static int UserId;

        private void Incarcare_cmb()
        {
            string query = "SELECT id_carte FROM Imprumut WHERE id_client = '" + UserId + "';";
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

        }

        private void Incarcare_GridView(int client_id)
        {
            DataSet dataset = new DataSet();
            using (conn = new SqlConnection(Properties.Settings.Default.dbConn))
            {
                SqlCommand cmd = new SqlCommand("SelectImprumuturiByUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id_client", SqlDbType.Int).Value = client_id;
                cmd.Parameters.Add("@data_imprumut", SqlDbType.Date).Value = DateTime.Today.Date;
                cmd.Parameters.Add("@data_retur", SqlDbType.Date).Value = DateTime.Today.Date;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataset);
            }

            gridImprumuturi.DataSource = dataset.Tables[0];
        }

        public ImprumuturileMele()
        {
            InitializeComponent();
        }

        private void ImprumuturileMele_Load(object sender, EventArgs e)
        {
            UserId = LoginForm.UserId;
            Incarcare_cmb();
            Incarcare_GridView(UserId);
            
        }

        private void load_date()
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
        }

        private void AfiseazaButton_Click(object sender, EventArgs e)
        {
            ZiCmb.Items.Clear();
            ZiRCmb.Items.Clear();
            LunaCmb.Items.Clear();
            LunaRCmb.Items.Clear();
            AnCmb.Items.Clear();
            AnRCmb.Items.Clear();

            string queyCarte = "SELECT id FROM Carti WHERE titlu = '" + ImprumuturiCmb.Text + "';";
            carti = DbManagement.Query(queyCarte);

            string query = "SELECT data_imprumut,data_retur FROM Imprumut WHERE id_client = '" + UserId + "' AND id_carte ='" + carti[0][0] + "';";
            imprumuturi = DbManagement.Query(query);

            load_date();
            
        
        }
    }
}
