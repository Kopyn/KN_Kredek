
namespace MaciejKopinskiLab2ZadDom.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAllTables = new System.Windows.Forms.DataGridView();
            this.labelDisplayedTable = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.buttonEditMovie = new System.Windows.Forms.Button();
            this.buttonClearTextBoxes = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonGenres = new System.Windows.Forms.Button();
            this.buttonSeances = new System.Windows.Forms.Button();
            this.buttonHalls = new System.Windows.Forms.Button();
            this.buttonSeats = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTables)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllTables
            // 
            this.dataGridViewAllTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllTables.Location = new System.Drawing.Point(12, 43);
            this.dataGridViewAllTables.Name = "dataGridViewAllTables";
            this.dataGridViewAllTables.Size = new System.Drawing.Size(776, 198);
            this.dataGridViewAllTables.TabIndex = 0;
            // 
            // labelDisplayedTable
            // 
            this.labelDisplayedTable.AutoSize = true;
            this.labelDisplayedTable.Location = new System.Drawing.Point(13, 13);
            this.labelDisplayedTable.Name = "labelDisplayedTable";
            this.labelDisplayedTable.Size = new System.Drawing.Size(30, 13);
            this.labelDisplayedTable.TabIndex = 1;
            this.labelDisplayedTable.Text = "Filmy";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(16, 264);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(16, 302);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Tytuł:";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Location = new System.Drawing.Point(16, 340);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(75, 13);
            this.labelReleaseDate.TabIndex = 4;
            this.labelReleaseDate.Text = "Data premiery:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(16, 378);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(51, 13);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Gatunek:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(98, 261);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(98, 299);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.Location = new System.Drawing.Point(98, 337);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleaseDate.TabIndex = 8;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(98, 375);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 9;
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(204, 261);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(94, 23);
            this.buttonDeleteMovie.TabIndex = 10;
            this.buttonDeleteMovie.Text = "Usuń film";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // buttonEditMovie
            // 
            this.buttonEditMovie.Location = new System.Drawing.Point(204, 296);
            this.buttonEditMovie.Name = "buttonEditMovie";
            this.buttonEditMovie.Size = new System.Drawing.Size(94, 23);
            this.buttonEditMovie.TabIndex = 11;
            this.buttonEditMovie.Text = "Edytuj film";
            this.buttonEditMovie.UseVisualStyleBackColor = true;
            this.buttonEditMovie.Click += new System.EventHandler(this.buttonEditMovie_Click);
            // 
            // buttonClearTextBoxes
            // 
            this.buttonClearTextBoxes.Location = new System.Drawing.Point(204, 334);
            this.buttonClearTextBoxes.Name = "buttonClearTextBoxes";
            this.buttonClearTextBoxes.Size = new System.Drawing.Size(94, 23);
            this.buttonClearTextBoxes.TabIndex = 12;
            this.buttonClearTextBoxes.Text = "Wyczyść pola";
            this.buttonClearTextBoxes.UseVisualStyleBackColor = true;
            this.buttonClearTextBoxes.Click += new System.EventHandler(this.buttonClearTextBoxes_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(204, 373);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(94, 23);
            this.buttonAddMovie.TabIndex = 13;
            this.buttonAddMovie.Text = "Dodaj film";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.Location = new System.Drawing.Point(75, 8);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(75, 23);
            this.buttonMovies.TabIndex = 14;
            this.buttonMovies.Text = "Filmy";
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonGenres
            // 
            this.buttonGenres.Location = new System.Drawing.Point(161, 8);
            this.buttonGenres.Name = "buttonGenres";
            this.buttonGenres.Size = new System.Drawing.Size(75, 23);
            this.buttonGenres.TabIndex = 15;
            this.buttonGenres.Text = "Gatunki";
            this.buttonGenres.UseVisualStyleBackColor = true;
            this.buttonGenres.Click += new System.EventHandler(this.buttonGenres_Click);
            // 
            // buttonSeances
            // 
            this.buttonSeances.Location = new System.Drawing.Point(247, 8);
            this.buttonSeances.Name = "buttonSeances";
            this.buttonSeances.Size = new System.Drawing.Size(75, 23);
            this.buttonSeances.TabIndex = 16;
            this.buttonSeances.Text = "Seanse";
            this.buttonSeances.UseVisualStyleBackColor = true;
            this.buttonSeances.Click += new System.EventHandler(this.buttonSeances_Click);
            // 
            // buttonHalls
            // 
            this.buttonHalls.Location = new System.Drawing.Point(333, 8);
            this.buttonHalls.Name = "buttonHalls";
            this.buttonHalls.Size = new System.Drawing.Size(75, 23);
            this.buttonHalls.TabIndex = 17;
            this.buttonHalls.Text = "Sale";
            this.buttonHalls.UseVisualStyleBackColor = true;
            this.buttonHalls.Click += new System.EventHandler(this.buttonHalls_Click);
            // 
            // buttonSeats
            // 
            this.buttonSeats.Location = new System.Drawing.Point(419, 8);
            this.buttonSeats.Name = "buttonSeats";
            this.buttonSeats.Size = new System.Drawing.Size(75, 23);
            this.buttonSeats.TabIndex = 18;
            this.buttonSeats.Text = "Miejsca";
            this.buttonSeats.UseVisualStyleBackColor = true;
            this.buttonSeats.Click += new System.EventHandler(this.buttonSeats_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.Location = new System.Drawing.Point(505, 8);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(75, 23);
            this.buttonTickets.TabIndex = 19;
            this.buttonTickets.Text = "Bilety";
            this.buttonTickets.UseVisualStyleBackColor = true;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(591, 8);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(75, 23);
            this.buttonOrders.TabIndex = 20;
            this.buttonOrders.Text = "Zamówienia";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(677, 8);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonUsers.TabIndex = 21;
            this.buttonUsers.Text = "Użytkownicy";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonTickets);
            this.Controls.Add(this.buttonSeats);
            this.Controls.Add(this.buttonHalls);
            this.Controls.Add(this.buttonSeances);
            this.Controls.Add(this.buttonGenres);
            this.Controls.Add(this.buttonMovies);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonClearTextBoxes);
            this.Controls.Add(this.buttonEditMovie);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxReleaseDate);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelReleaseDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelDisplayedTable);
            this.Controls.Add(this.dataGridViewAllTables);
            this.Name = "FormMain";
            this.Text = "Kino";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllTables;
        private System.Windows.Forms.Label labelDisplayedTable;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelReleaseDate;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Button buttonEditMovie;
        private System.Windows.Forms.Button buttonClearTextBoxes;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Button buttonGenres;
        private System.Windows.Forms.Button buttonSeances;
        private System.Windows.Forms.Button buttonHalls;
        private System.Windows.Forms.Button buttonSeats;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonUsers;
    }
}