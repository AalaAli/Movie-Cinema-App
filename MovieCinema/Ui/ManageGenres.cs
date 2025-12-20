using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ui
{
    public partial class ManageGenres : Form
    {
        private readonly string _connectionString;
        private readonly IRepository<GenreComponent> _genreReposiry;
        private readonly GenreService _genreService;
        public ManageGenres()
        {
            InitializeComponent();
            _connectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            _genreReposiry = new GenreRepository(_connectionString);
            _genreService = new GenreService(_genreReposiry);

        }

        private void ManageGenres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moviesDBDataSet3.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.moviesDBDataSet3.Genres);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int?parentId=0;

            string genreName = txtGenreName.Text;
            //validate parent id
            if(txtParentId.Text.Length==0)
            { 
                MessageBox.Show("Are you sure you want to add a genre without a Parent Id?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                parentId = null;
            }

            GenreComponent newGenre = new Genre(0, genreName, parentId);
            _genreService.Add(newGenre);
            MessageBox.Show("Genre added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshGenreTable();
            ClearForm();
        }

  
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void RefreshGenreTable()
        {
            this.genresTableAdapter.Fill(this.moviesDBDataSet3.Genres);
            genreTable.DataSource = this.moviesDBDataSet3.Genres;
        }
        private void ClearForm()
        {
            txtGenreName.Text = "";
            txtParentIdlabel.Text = "";
        }

        private void genreTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
