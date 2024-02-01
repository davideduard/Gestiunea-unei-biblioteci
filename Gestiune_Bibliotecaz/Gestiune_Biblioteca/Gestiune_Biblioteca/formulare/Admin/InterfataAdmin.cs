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
using Gestiune_Biblioteca.formulare;

namespace Gestiune_Biblioteca
{
    public partial class InterfataAdmin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbConn);


        public InterfataAdmin()
        {            
            InitializeComponent();
            AscundeSubmeniuri_initial();
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
        }

        private Form activeForm = null;

        public void DeschideFormCopil(Form FormularCopil)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = FormularCopil;
            FormularCopil.TopLevel = false;
            FormularCopil.FormBorderStyle = FormBorderStyle.None;
            FormularCopil.Dock = DockStyle.Fill;
            PanouCopil.Controls.Add(FormularCopil);
            PanouCopil.Tag = FormularCopil;
            FormularCopil.Show();
        }

        private void AscundeSubmeniuri_initial()
        {
            SubmeniuCarti.Visible = false;
            SubmeniuUtilizatori.Visible = false;
            SubmeniuImprumut.Visible = false;
        }

        private void AscundeSubmeniu(Panel submeniu)
        {
            if (submeniu.Visible == true)
                submeniu.Visible = false;
        }

        private void AfiseazaSubmeniu(Panel submeniu)
        {
            if (submeniu.Visible == false)
            {
               // AscundeSubmeniuri_initial();
                submeniu.Visible = true;
            }
        }



        private void CartiButton_Click(object sender, EventArgs e)
        {
            if (SubmeniuCarti.Visible == false)
                AfiseazaSubmeniu(SubmeniuCarti);
            else
                AscundeSubmeniu(SubmeniuCarti);
        }

        private void ImprumutButton_Click(object sender, EventArgs e)
        {
            if (SubmeniuImprumut.Visible == false)
                AfiseazaSubmeniu(SubmeniuImprumut);
            else
                AscundeSubmeniu(SubmeniuImprumut);
        }

        private void UtilizatoriButton_Click_1(object sender, EventArgs e)
        {
            if (SubmeniuUtilizatori.Visible == false)
                AfiseazaSubmeniu(SubmeniuUtilizatori);
            else
                AscundeSubmeniu(SubmeniuUtilizatori);
        }

        public void NrUtilizatori()
        {
            string query = "SELECT COUNT(*) FROM Utilizatori";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int NumarUtilizatori = Convert.ToInt32(cmd.ExecuteScalar());
            NumarUtilizatoriText.Text = Convert.ToString(NumarUtilizatori);
            conn.Close();
        }

        public void NrCarti()
        {
            conn.Open();
            string query = "SELECT COUNT (*) FROM Carti";
            SqlCommand cmd = new SqlCommand(query, conn);
            int NumarCarti = Convert.ToInt32(cmd.ExecuteScalar());
            NumarCartiText.Text = Convert.ToString(NumarCarti);
            conn.Close();
        }

        private void InterfataAdmin_Load(object sender, EventArgs e)
        {
            NrUtilizatori();
            NrCarti();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            
            //Form frm = new LoginForm();
            //frm.ShowDialog();
            this.Close();
            
        }

        private void AdaugareUtilizatorButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new AdaugareFromAdmin());
        }

        private void ModificareUtilizatorButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new ModificareClientAdmin());
        }


        private void StergereUtilizatorButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new StergereFromAdmin());
        }

        private void PanouCopil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdaugareCarteButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new AdaugaCarteAdmin());
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            NrCarti();
            NrUtilizatori();
        }

        private void ModificareCarteButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new ModificareCarteAdmin());
        }

        private void StergereCarteButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new StergereCarteAdmin());
        }

        private void ImprumutNouButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new ImprumutNouAdmin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new ListaImprumutUtilizator());
        }

        private void ReturnareImprumut_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new Return());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NrCarti();
            NrUtilizatori();
        }
    }
}
