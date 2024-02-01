using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Biblioteca
{
    public partial class InterfataUser : Form
    {
        private Form activeForm = null;
        public static int UserClient;
        List<List<string>> client;

        public InterfataUser()
        {
            InitializeComponent();
            AscundeSubmeniuri_initial();
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
        }

        public void DeschideFormCopil(Form FormularCopil)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = FormularCopil;
            FormularCopil.TopLevel = false;
            FormularCopil.FormBorderStyle = FormBorderStyle.None;
            FormularCopil.Dock = DockStyle.Fill;
            PanouChild.Controls.Add(FormularCopil);
            PanouChild.Tag = FormularCopil;
            FormularCopil.Show();
        }

        private void AscundeSubmeniuri_initial()
        {
            SubmeniuUtilizatori.Visible = false;
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

        private void LogOutButton_Click(object sender, EventArgs e)
        {

            //Form frm = new LoginForm();
            //frm.Show();
            this.Close();

        }

        private void AdaugareUtilizatorButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new ImprumutNouUser());
        }

        private void ListaImprumuturiButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new ImprumuturileMele());
        }

        private void ProfilButton_Click(object sender, EventArgs e)
        {
            if (SubmeniuUtilizatori.Visible == false)
                SubmeniuUtilizatori.Visible = true;
            else
                SubmeniuUtilizatori.Visible = false;
        }

        private void InterfataUser_Load(object sender, EventArgs e)
        {
            
            UserClient = LoginForm.UserId;
            string query = "SELECT Nume,Prenume,parola FROM Utilizatori WHERE id = '" + UserClient + "';";
            client = DbManagement.Query(query);
            WelcomeText.Text = "Bine ai revenit, " + Convert.ToString(client[0][0]) + " " + Convert.ToString(client[0][1]) + "!";
            if (Convert.ToString(client[0][2]) == "parola")
            {
                MessageBox.Show("Bine ati venit pe platforma noastra! Va rugam sa va schimbati parola prestabilita cat mai repede din sectiunea setari profil.");
            }

        }

        private void SetariButton_Click(object sender, EventArgs e)
        {
            DeschideFormCopil(new SetariProfil());
        }
    }
}
