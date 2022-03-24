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

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle[] _rectangles;

        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();

        public MainForm()
        {
            InitializeComponent();
            _rectangles = new Model.Classes.Rectangle[5];
            Random random = new Random();
            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1,100), random.Next(1,100), "White");
                RectanglesListBox.Items.Add($"Rectangle {i+1}");
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            ValuesListBox.Items.Clear(); 
            var item = EnumsListBox.SelectedItem; 
            Array enumValues = null;
            switch (item)
            {
                case "Colour":
                    enumValues = Enum.GetValues(typeof(Colour));
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
                    this.BackColor = Color.Blue;
                    MessageBox.Show($"Зима уже наступила!");
                    break;
                case TimeOfYear.Spring:
                    this.BackColor = Color.Green;
                    MessageBox.Show($"Зима уже прошла!");
                    break;
                case TimeOfYear.Summer:
                    this.BackColor = Color.Yellow;
                    MessageBox.Show($"До зимы еще далеко!");
                    break;
                case TimeOfYear.Autumn:
                    this.BackColor = Color.Orange;
                    MessageBox.Show($"Зима близко!");
                    break;
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
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LenghtTextBox.Text);
                LenghtTextBox.BackColor = Color.White;
                ToolTip.SetToolTip(LenghtTextBox, "");
            }
            catch(Exception exception)
            {
                ToolTip.SetToolTip(LenghtTextBox, exception.Message);
                LenghtTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = Color.White;
                ToolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = ColorTextBox.Text;
                ColorTextBox.BackColor = Color.White;
                ToolTip.SetToolTip(ColorTextBox, "");
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(ColorTextBox, exception.Message);
                ColorTextBox.BackColor = Color.LightPink;
                return;
            }
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            var maxIndex = 0;
            var maxValues = rectangles[maxIndex].Width;
            for(var i=0; i<rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxValues)
                {
                    maxValues = rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
