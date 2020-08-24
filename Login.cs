using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace C868
{
    public partial class Login : Form
    {
        public string errorMessage = "The username and password are incorrect";
        public string exit = "Are you sure to exit this Application?";
        public Login()
        {
            InitializeComponent();

            //Language Check
            //Supports English or French Canadian (LCID=3084)
            if (CultureInfo.CurrentUICulture.LCID == 3084)
            {
                titleLabel.Text = "Veuillez vous connecter";
                usernameLabel.Text = "nom d'utilisateur";
                passwordLabel.Text = "Mot de passe";
                loginButton.Text = "Commencer la session";
                CancelButton.Text = "Annuler";
                errorMessage = "Le nom d'utilisateur et le mot de passe sont incorrects";
                exit = "Êtes - vous sûr de quitter cette application ? ";
            }
        }


        static public int FindUser(string userName, string password)
        {
            MySqlConnection C = new MySqlConnection(SqlUpdater.conString);
            C.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT userId FROM user WHERE userName = '{userName}' AND password = '{password}'", C);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                SqlUpdater.SetCurrentUserID(Convert.ToInt32(rdr[0]));
                SqlUpdater.SetCurrentUserName(userName);
                rdr.Close();
                return SqlUpdater.GetCurrentUserID();
            }
            return 0;

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {

            if (FindUser(Username.Text, Password.Text) != 0)
            {
                this.Hide();
                MainForm MainForm = new MainForm
                {
                    loginForm = this
                };
                Logger.WriteUserLoginLog(SqlUpdater.GetCurrentUserName());

                MainForm.Show();
            }
            else
            {
                MessageBox.Show(errorMessage);
                Password.Text = "";
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(exit, this.Text,
                             MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}