using System;
using System.Data;
using System.Data.SqlClient;

namespace MaciejKopinskiLab2ZadDom.Database
{
    class Repository
    {

        private readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// Function to return all movies from movies table
        /// </summary>
        /// <returns></returns>
        public DataTable GetMovies()
        {
            string query = "SELECT Movies.Id, Movies.Title, Movies.ReleaseDate, Genres.Name FROM Movies JOIN Genres ON Movies.GenreId = Genres.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all users from Users table
        /// </summary>
        /// <returns></returns>
        public DataTable GetUsers()
        {
            string query = "SELECT Users.Id, Users.Login FROM Users; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all orders from Orders table
        /// </summary>
        /// <returns></returns>
        public DataTable GetOrders()
        {
            string query = "SELECT Orders.Status, Users.Login AS Użytkownik, Seances.Date, Seances.Hour, " +
                "Movies.Title FROM Orders JOIN Users ON Orders.IdU = Users.Id JOIN Seances ON Orders.IdS = Seances.Id JOIN Movies ON Seances.IdM = Movies.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all tickets from Tickets table
        /// </summary>
        /// <returns></returns>
        public DataTable GetTickets()
        {
            string query = "SELECT Tickets.Discount, Seats.IdH, Seats.Place, Seats.Row, Seances.Date, Seances.Hour, Movies.Title, " +
                "Users.Login AS Użytkownik FROM Tickets JOIN Seats ON Tickets.IdS = Seats.Id " +
                "JOIN Orders ON Tickets.IdO = Orders.Id JOIN Seances On Orders.IdS = Seances.Id JOIN Movies ON Seances.IdM = Movies.Id JOIN Users ON Orders.IdU = Users.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all seances from Seances table
        /// </summary>
        /// <returns></returns>
        public DataTable GetSeances()
        {
            string query = "SELECT Seances.IdH, Seances.Subtitles, Seances.Length, Seances.Date, Seances.Hour, Movies.Title FROM Seances JOIN " +
                "Movies ON Seances.IdM = Movies.Id JOIN Halls ON Seances.IdH = Halls.Id; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all halls from Halls table
        /// </summary>
        /// <returns></returns>
        public DataTable GetHalls()
        {
            string query = "SELECT Halls.* FROM Halls; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all seats from Seats table
        /// </summary>
        /// <returns></returns>
        public DataTable GetSeats()
        {
            string query = "SELECT Seats.IdH, Seats.Place, Seats.Row FROM Seats; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function returning all genres from Genres table
        /// </summary>
        /// <returns></returns>
        public DataTable GetGenres()
        {
            string query = "SELECT Genres.Name FROM Genres; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Function to add a new movie
        /// </summary>
        /// <param name="title"></param>
        /// <param name="releaseDate"></param>
        /// <param name="genre"></param>
        public void AddMovie(string title, string releaseDate, string genre)
        {
            string queryGetGenreId = "SELECT Id FROM Genres WHERE Name='" + genre + "';";
            //open connection
            connection.Open();

            SqlCommand commandGetGenreId = new SqlCommand(queryGetGenreId, connection);
            int genreId = (int)commandGetGenreId.ExecuteScalar();

            string insertMovieQuery = "INSERT INTO Movies VALUES ('" + title + "'," + "cast('" + releaseDate + "'as date)," + genreId + ");";
            SqlCommand commandInsertBook = new SqlCommand(insertMovieQuery, connection);
            commandInsertBook.ExecuteNonQuery();
            //close connection
            connection.Close();
        }

        /// <summary>
        /// Function to delete a movie
        /// </summary>
        /// <param name="movieId"></param>
        public void DeleteMovie(int movieId)
        {
            string queryDeleteBook = "DELETE FROM Books WHERE Id=" + movieId;
            //open connection
            connection.Open();

            SqlCommand commandDeleteBook = new SqlCommand(queryDeleteBook, connection);
            commandDeleteBook.ExecuteNonQuery();
            //close connection
            connection.Close();
        }

        /// <summary>
        /// Function to edit a movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="title"></param>
        /// <param name="releaseDate"></param>
        /// <param name="genre"></param>
        public void EditMovie(int movieId, string title, string releaseDate, string genre)
        {
            string queryGetGenreId = "SELECT Id from Genres WHERE Name='" + genre + "';";
            //open connection
            connection.Open();

            SqlCommand commandGetGenreId = new SqlCommand(queryGetGenreId, connection);
            int genreId = (int)commandGetGenreId.ExecuteScalar();

            string updateBookQuery = "UPDATE Movies SET Title='" + title + "',ReleaseDate=cast('" + releaseDate + "'as date), GenreId=" + genreId + " WHERE Id=" + movieId + ";";
            SqlCommand commandInsertBook = new SqlCommand(updateBookQuery, connection);
            commandInsertBook.ExecuteNonQuery();
            //close connection
            connection.Close();
        }

        /// <summary>
        /// Method to check if user is able to log in
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string login, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Login='" + login + "' AND Password='" + password + "';";
            //open connection
            connection.Open();

            SqlCommand comm = new SqlCommand(query, connection);
            int foundUsers = (int)comm.ExecuteScalar();
            //close connection
            connection.Close();

            return foundUsers >= 1;
        }

    }
}
