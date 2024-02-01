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
    public partial class SetariProfil : Form
    {
        bool Mod_parola = false;
        public static int userId;
        List<List<string>> user;
        bool editat = false;

        string zi_initial;
        string luna_initial;
        string an_initial;

        public SetariProfil()
        {
            InitializeComponent();
        }

        private void SchimbareParola_Click(object sender, EventArgs e)
        {
            if (ParolaModText.Visible == false)
            {
                ConfirmareParolaModText.Visible = true;
                ParolaModText.Visible = true;
                ParolaMod.Visible = true;
                ConfirmareParolaMod.Visible = true;
                Mod_parola = true;
            }
            else
            {
                ConfirmareParolaModText.Visible = false;
                ParolaModText.Visible = false;
                ParolaMod.Visible = false;
                ConfirmareParolaMod.Visible = false;
                Mod_parola = false;
                EroareParola.Text = "";
                EroareConfirmareParola.Text = "";
            }
            
        }

        private void SetariProfil_Load(object sender, EventArgs e)
        {
            ParolaModText.Visible = false;
            ConfirmareParolaModText.Visible = false;
            ParolaMod.Visible = false;
            ConfirmareParolaMod.Visible = false;
            userId = LoginForm.UserId;

            string query = "SELECT * FROM Utilizatori WHERE id = '" + userId + "';";
            user = DbManagement.Query(query);

            NumeModText.Text = user[0][1];
            PrenumeModText.Text = user[0][2];
            CnpModText.Text = user[0][3];
            load_datan();
            EmailModText.Text = user[0][5];
            UsernameModText.Text = user[0][6];

            Clear_Erori();
           

        }

        private void Clear_Erori()
        {
            EroareNume.Text = "";
            EroarePrenume.Text = "";
            EroareCnp.Text = "";
            EroareDataNasterii.Text = "";
            EroareEmail.Text = "";
            EroareUsername.Text = "";
            EroareParola.Text = "";
            EroareConfirmareParola.Text = "";
        }

        private void load_datan()
        {
            string dn;
            dn = Convert.ToString(user[0][4]);
            var split = dn.Split('/');
            LunaCmb.Text = split[0];
            luna_initial = split[0];
            ZiCmb.Text = split[1];
            zi_initial = split[1];

            string an = split[2];
            split = an.Split(' ');
            AnCmb.Text = split[0];
            an_initial = split[0];

        }

        private void ModificareButton_Click(object sender, EventArgs e)
        {

            bool ok = true;
            Clear_Erori();

            if (NumeModText.Text == "")
            {
                ok = false;
                EroareNume.Text = "*Introduceti numele";
            }

            if (PrenumeModText.Text == "")
            {
                ok = false;
                EroarePrenume.Text = "*Introduceti prenumele";
            }

            if (CnpModText.Text == "")
            {
                ok = false;
                EroareCnp.Text = "*Introduceti CNP-ul";
            }

            if (LunaCmb.Text == "" || AnCmb.Text == "" || ZiCmb.Text == "")
            {
                ok = false;
                EroareDataNasterii.Text = "*Introduceti Data nasterii";
            }

            if (EmailModText.Text == "")
            {
                ok = false;
                EroareEmail.Text = "*Introduceti email-ul";
            }

            if (UsernameModText.Text == "")
            {
                ok = false;
                EroareUsername.Text = "*Introduceti username-ul";
            }
            if (Mod_parola == true)
            {
                if (ParolaModText.Text == "")
                {
                    ok = false;
                    EroareParola.Text = "*Introduceti parola";

                }

                if (ConfirmareParolaModText.Text == "" || ConfirmareParolaModText.Text != ParolaModText.Text)
                {
                    ok = false;
                    EroareConfirmareParola.Text = "*Parola introdusa gresit";
                }
            }
            

            if (ok == true)
            {
                string query = "UPDATE Utilizatori SET ";

                if (NumeModText.Text != user[0][1])
                {
                    editat = true;
                    query += "nume = '" + NumeModText.Text + "',";
                }
                if (PrenumeModText.Text != user[0][2])
                {
                    editat = true;
                    query += "prenume = '" + PrenumeModText.Text + "',";
                }
                if (CnpModText.Text != user[0][3])
                {
                    editat = true;
                    query += "cnp = '" + CnpModText.Text + "',";
                }
                if (LunaCmb.Text != luna_initial || ZiCmb.Text != zi_initial || AnCmb.Text != an_initial)
                {
                    editat = true;
                    query += "data_nasterii = '" + LunaCmb.Text + "/" + ZiCmb.Text + "/" + AnCmb.Text + "',";
                }
                if (EmailModText.Text != user[0][5])
                {
                    editat = true;
                    query += "email = '" + EmailModText.Text + "',";
                }
                if (UsernameModText.Text != user[0][6])
                {
                    editat = true;
                    query += "username = '" + UsernameModText.Text + "',";
                }
                if (Mod_parola == true)
                {
                    if (ParolaModText.Text != user[0][7] && ConfirmareParolaModText.Text == ParolaModText.Text)
                    {
                        editat = true;
                        query += "parola ='" + ParolaModText.Text + "',";
                    }
                }

                query = query.Substring(0, query.Length - 1);
                query += " WHERE id = '" + userId + "';";

                if (editat == true)
                {
                    DbManagement.NonQuery(query);
                    MessageBox.Show("Modificarile au fost efectuate cu succes!");

                }
                else
                    MessageBox.Show("Nu au fost efectuate modificari");
            }

            

        }
    }
}
