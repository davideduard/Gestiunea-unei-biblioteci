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
    public partial class AdaugareAutor : Form
    {
        public AdaugareAutor()
        {
            InitializeComponent();
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
        }

        private void AdaugareAutorButton_Click(object sender, EventArgs e)
        {

            NumeAutorNecompletat.Text = "";
            PrenumeAutorNecompletat.Text = "";
            DataNasteriiAutorNecompletat.Text = "";

            string query;
            string dn;
            string dd = "";
            bool cl = false;
            bool deces = false;
            bool ok = true;
            query = "INSERT INTO Autor (Nume,Prenume,Data_nastere";



            if (NumeAutorText.Text == "")
            {
                ok = false;
                NumeAutorNecompletat.Text = "*Introduceti numele";
            }
            if (PrenumeAutorText.Text == "")
            {
                ok = false;
                PrenumeAutorNecompletat.Text = "*Introduceti prenumele";
            }
            if (LunaNCmb.Text == "" || ZiNCmb.Text == "" || AnNCmb.Text == "")
            {
                ok = false;
                DataNasteriiAutorNecompletat.Text = "*Introduceti data nasterii";
            }
            
            if (ok == true)
            {
                dn = LunaNCmb.Text + "/" + ZiNCmb.Text + "/" + AnNCmb.Text;
                if (LunaDCmb.Text != "" && ZiDCmb.Text!= "" && AnDCmb.Text != "")
                {
                    dd = LunaDCmb.Text + "/" + ZiDCmb.Text + "/" + AnDCmb.Text;
                    deces = true;
                    query += ",data_deces";
                }

                if (CurentLiterarText.Text != "")
                {
                    cl = true;
                    query += ",curent_literar";
                }

                query += ") VALUES ('" + NumeAutorText.Text + "','" + PrenumeAutorText.Text + "','" + dn + "'";
                if (deces == true)
                    query += ",'" + dd + "'";
                if (cl == true)
                    query += ",'" + CurentLiterarText.Text + "'";
                query += ");";

                DbManagement.NonQuery(query);
                MessageBox.Show("Inregistrare efectuata cu succes");
                this.Close();
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
