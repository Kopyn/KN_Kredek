using MaciejKopinskiLab2ZadDom.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaciejKopinskiLab2ZadDom.Forms
{
    public partial class FormMain : Form
    {
        private readonly Repository repository = new Repository();

        /// <summary>
        /// Main window constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //update data in DataGridView
            RefreshDataGridView("movies");

            CustomizeMovies();
        }

        /// <summary>
        /// Function to clear TextBoxes
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxId.Text = "";
            textBoxTitle.Text = "";
            textBoxReleaseDate.Text = "";
            textBoxGenre.Text = "";
        }

        /// <summary>
        /// Function to refresh data in DataGridView
        /// </summary>
        /// <param name="table"></param>
        private void RefreshDataGridView(string table)
        {
            DataTable dataTable = null;

            //get data depending on the string passed to method and customize the table
            switch (table)
            {
                //get movies table
                case "movies":
                    dataTable = repository.GetMovies();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeMovies();
                    break;
                //get users table
                case "users":
                    dataTable = repository.GetUsers();
                    dataGridViewAllTables.DataSource = dataTable;
                    break;
                //get orders table
                case "orders":
                    dataTable = repository.GetOrders();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeOrders();
                    break;
                //get tickets table
                case "tickets":
                    dataTable = repository.GetTickets();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeTickets();
                    break;
                //get seats table
                case "seats":
                    dataTable = repository.GetSeats();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeSeats();
                    break;
                //get halls table
                case "halls":
                    dataTable = repository.GetHalls();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeHalls();
                    break;
                //get seances table
                case "seances":
                    dataTable = repository.GetSeances();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeSeances();
                    break;
                //get genres table
                case "genres":
                    dataTable = repository.GetGenres();
                    dataGridViewAllTables.DataSource = dataTable;
                    CustomizeGenres();
                    break;
            }
        }

        /// <summary>
        /// Method to rename columns in movies table
        /// </summary>
        private void CustomizeMovies()
        {
            dataGridViewAllTables.Columns["Title"].HeaderText = "Tytuł";
            dataGridViewAllTables.Columns["ReleaseDate"].HeaderText = "Data premiery";
            dataGridViewAllTables.Columns["Name"].HeaderText = "Gatunek";
        }

        /// <summary>
        /// Method to rename columns in orders table
        /// </summary>
        private void CustomizeOrders()
        {
            dataGridViewAllTables.Columns["Date"].HeaderText = "Data";
            dataGridViewAllTables.Columns["Hour"].HeaderText = "Godzina";
            dataGridViewAllTables.Columns["Title"].HeaderText = "Tytuł";
        }

        /// <summary>
        /// Method to rename columns in tickets table
        /// </summary>
        private void CustomizeTickets()
        {
            dataGridViewAllTables.Columns["IdH"].HeaderText = "Sala";
            dataGridViewAllTables.Columns["Place"].HeaderText = "Miejsce";
            dataGridViewAllTables.Columns["Row"].HeaderText = "Rząd";
            dataGridViewAllTables.Columns["Discount"].HeaderText = "Zniżka";
            dataGridViewAllTables.Columns["Date"].HeaderText = "Data";
            dataGridViewAllTables.Columns["Hour"].HeaderText = "Godzina";
            dataGridViewAllTables.Columns["Title"].HeaderText = "Film";
        }

        /// <summary>
        /// Method to rename columns in seats table
        /// </summary>
        private void CustomizeSeats()
        {
            dataGridViewAllTables.Columns["IdH"].HeaderText = "Sala";
            dataGridViewAllTables.Columns["Place"].HeaderText = "Miejsce";
            dataGridViewAllTables.Columns["Row"].HeaderText = "Rząd";
        }

        /// <summary>
        /// Method to rename columns in halls table
        /// </summary>
        private void CustomizeHalls()
        {
            dataGridViewAllTables.Columns["Id"].HeaderText = "Numer sali";
            dataGridViewAllTables.Columns["Seats"].HeaderText = "Ilość miejsc";
        }

        /// <summary>
        /// Method to rename columns in seances table
        /// </summary>
        private void CustomizeSeances()
        {
            dataGridViewAllTables.Columns["IdH"].HeaderText = "Sala";
            dataGridViewAllTables.Columns["Subtitles"].HeaderText = "Napisy";
            dataGridViewAllTables.Columns["Length"].HeaderText = "Długość";
            dataGridViewAllTables.Columns["Date"].HeaderText = "Data";
            dataGridViewAllTables.Columns["Hour"].HeaderText = "Godzina";
            dataGridViewAllTables.Columns["Title"].HeaderText = "Film";
        }

        /// <summary>
        /// Method to rename columns in genres table
        /// </summary>
        private void CustomizeGenres()
        {
            dataGridViewAllTables.Columns["Name"].HeaderText = "Gatunek";
        }

        /// <summary>
        /// Method called after clicking delete movie button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            //getting data from textbox
            int movieId = int.Parse(textBoxId.Text);
            //deleting a movie
            repository.DeleteMovie(movieId);
            ClearTextBoxes();
            RefreshDataGridView("movies");
        }

        /// <summary>
        /// Method called after clicking edit movie button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditMovie_Click(object sender, EventArgs e)
        {
            //getting data from textboxes
            int movieId = int.Parse(textBoxId.Text);
            string movieTitle = textBoxTitle.Text;
            string movieReleaseDate = textBoxReleaseDate.Text;
            string movieGenre = textBoxGenre.Text;
            //updating movie data
            repository.EditMovie(movieId, movieTitle, movieReleaseDate, movieGenre);
            ClearTextBoxes();
            RefreshDataGridView("movies");
        }

        /// <summary>
        /// Method called after clicking clear text boxes button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearTextBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        /// <summary>
        /// Method called after clicking movie add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            //getting data from textboxes
            string movieTitle = textBoxTitle.Text;
            string movieReleaseDate = textBoxReleaseDate.Text;
            string movieGenre = textBoxGenre.Text;
            //adding a movie
            repository.AddMovie(movieTitle, movieReleaseDate, movieGenre);
            ClearTextBoxes();
            RefreshDataGridView("movies");
        }

        /// <summary>
        /// Method to show movies table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Filmy";
            RefreshDataGridView("movies");
        }

        /// <summary>
        /// Method to show genres table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenres_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Gatunki";
            RefreshDataGridView("genres");
        }

        /// <summary>
        /// Method to show seances table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeances_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Seanse";
            RefreshDataGridView("seances");
        }

        /// <summary>
        /// Method to show halls table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHalls_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Sale";
            RefreshDataGridView("halls");
        }

        /// <summary>
        /// Method to show seats table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSeats_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Miejsca";
            RefreshDataGridView("seats");
        }

        /// <summary>
        /// Method to show tickets table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTickets_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Bilety";
            RefreshDataGridView("tickets");
        }

        /// <summary>
        /// Method to show orders table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Rezerwacje";
            RefreshDataGridView("orders");
        }

        /// <summary>
        /// Method to show users table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            labelDisplayedTable.Text = "Użytkownicy";
            RefreshDataGridView("users");
        }

    }
}
