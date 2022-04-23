using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly System.Drawing.Color _normalColor = System.Drawing.Color.White;

        private readonly System.Drawing.Color _errorColor = System.Drawing.Color.LightPink;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle = new Rectangle();

        private Movie[] _movie;

        private Movie _currentMovie = new Movie();

        private string[] _movies = new string[] {"Captain America: The First Avenger",
            "Captain Marvel", "Iron Man", "Iron Man 2", "The Incredible Hulk",
            "Thor", "The Avengers", "Shang-Chi and the Legend of the Ten Rings",
            "Iron Man 3", "Thor: The Dark World", "Captain America: The Winter Soldier",
            "Guardians of the Galaxy", "Guardians of the Galaxy 2",
            "Avengers: Age of Ultron", "Ant-Man", "Captain America: Civil War",
            "Black Widow", "Black Panther", "Spider-Man: Homecoming", "Doctor Strange",
            "Thor: Ragnarok", "Avengers: Infinity War", "Ant-Man and The Wasp",
            "Avengers: Endgame", "Spider-Man: Far From Home", "Eternals",
            "Spider-Man: No Way Home", "Doctor Strange in the Multiverse of Madness",
            "Thor: Love and Thunder", "Black Panther: Wakanda Forever" };

        private void InitRectangles()
        {
            _rectangles = new Rectangle[5];
            Random random = new Random();
            int lengthColor = Enum.GetNames(typeof(Model.Enums.Color)).Length;
            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(
                    Math.Round(random.NextDouble() * 100, 1),
                    Math.Round(random.NextDouble() * 100, 1),
                    ((Model.Enums.Color)random.Next(lengthColor)).ToString(),
                    new Point2D(Math.Round(random.NextDouble() * 100, 1),
                    Math.Round(random.NextDouble() * 100, 1)));
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
        }

        private void InitMovies()
        {
            _movie = new Movie[5];
            Random random = new Random();
            int lengthGenre = Enum.GetNames(typeof(Genre)).Length;
            for (var i = 0; i < 5; i++)
            {
                _movie[i] = new Movie(
                    random.Next(0, 421),
                    random.Next(1900, DateTime.Now.Year),
                    Math.Round(random.NextDouble() * 10, 1),
                    _movies[random.Next(0, _movies.Length)],
                    ((Genre)random.Next(lengthGenre)).ToString());
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var value in Enum.GetValues(typeof(TimeOfYear)))
            {
                SeasonHandleСomboBox.Items.Add(value);
            }
            SeasonHandleСomboBox.SelectedIndex = 0;
            EnumsListBox.SelectedIndex = 0;
            RectanglesListBox.SelectedIndex = 0;
            MoviesListBox.SelectedIndex = 0;
        }

        public MainForm()
        {
            InitializeComponent();
            InitRectangles();
            InitMovies();
        }

        private int FindMovieWithMaxRating(Model.Classes.Movie[] movies)
        {
            var maxIndex = 0;
            var maxValues = movies[maxIndex].Rating;
            for (var i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxValues)
                {
                    maxValues = movies[i].Rating;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            var maxIndex = 0;
            var maxValues = rectangles[maxIndex].Width;
            for (var i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxValues)
                {
                    maxValues = rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            ValuesListBox.Items.Clear(); 
            var item = EnumsListBox.SelectedItem; 
            Array enumValues = null;
            switch (item)
            {
                case "Color":
                    enumValues = Enum.GetValues(typeof(Model.Enums.Color));
                    break;
                case "Genre":
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;
                case "SmartphoneManufacturers":
                    enumValues = Enum.GetValues(typeof(SmartphoneManufactures));
                    break;
                case "StudentsFormOfStudy":
                    enumValues = Enum.GetValues(typeof(StudentsFormOfStudy));
                    break;
                case "TimeOfYear":
                    enumValues = Enum.GetValues(typeof(TimeOfYear));
                    break;
                case "Weekday":
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;
            }
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString(); 
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            if(Enum.TryParse(typeof(Weekday), WeekdayParsingTextBox.Text, out object result))
            {
                ResultParseTextBox.Text = $"Это день недели ({result} = {(int)result})";
            }
            else
            {
                ResultParseTextBox.Text = $"Нет такого дня недели";
            }
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            var item = SeasonHandleСomboBox.SelectedItem;
            var value = (TimeOfYear)item;
            switch (value)
            {
                case TimeOfYear.Winter:
                    this.BackColor = System.Drawing.Color.Blue;
                    MessageBox.Show($"Зима уже наступила!");
                    break;
                case TimeOfYear.Spring:
                    this.BackColor = System.Drawing.Color.Green;
                    MessageBox.Show($"Зима уже прошла!");
                    break;
                case TimeOfYear.Summer:
                    this.BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show($"До зимы еще далеко!");
                    break;
                case TimeOfYear.Autumn:
                    this.BackColor = System.Drawing.Color.Orange;
                    MessageBox.Show($"Зима близко!");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            CenterXTextBox.Text = _currentRectangle.Center.X.ToString();
            CenterYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
                LenghtTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(LenghtTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(LenghtTextBox, exception.Message);
                LenghtTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(ColorTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(ColorTextBox, exception.Message);
                ColorTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(TitleTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(TitleTextBox, exception.Message);
                TitleTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(GenreTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(GenreTextBox, exception.Message);
                GenreTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationInMinutes = Convert.ToInt32(DurationInMinutesTextBox.Text);
                DurationInMinutesTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(DurationInMinutesTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(DurationInMinutesTextBox, exception.Message);
                DurationInMinutesTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void YearOfReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.YearOfRelease = Convert.ToInt32(YearOfReleaseTextBox.Text);
                YearOfReleaseTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(YearOfReleaseTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(YearOfReleaseTextBox, exception.Message);
                YearOfReleaseTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = _normalColor;
                ToolTip.SetToolTip(RatingTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(RatingTextBox, exception.Message);
                RatingTextBox.BackColor = _errorColor;
                return;
            }
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movie);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movie[MoviesListBox.SelectedIndex];
            TitleTextBox.Text = _currentMovie.Title;
            GenreTextBox.Text = _currentMovie.Genre;
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearOfReleaseTextBox.Text = _currentMovie.YearOfRelease.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }
    }
}
