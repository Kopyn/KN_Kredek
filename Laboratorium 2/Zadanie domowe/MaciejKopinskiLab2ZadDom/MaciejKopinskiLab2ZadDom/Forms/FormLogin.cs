using System;
using System.Windows.Forms;
using MaciejKopinskiLab2ZadDom.Database;

namespace MaciejKopinskiLab2ZadDom.Forms
{
    public partial class FormLogin : Form
    {
        private readonly Repository _repository = new Repository();

        /// <summary>
        /// Login window construdtor
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();

            //Displaying window in center of screen
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Function called when login button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            //getting data from textboxes
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            //checking if user exists
            bool logged = _repository.Login(login, password);
            //log in when user exists
            if (logged)
            {
                Program.Logged = true;
                Close();
            }
            //display message when user doesn't exist
            MessageBox.Show("Niepoprawny login lub hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
