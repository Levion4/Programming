using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            EnumsListBox.SelectedIndex = 0;          
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e) //при изменении варианта в первом ListBox
        {
            ValuesListBox.Items.Clear(); //очистка значений во втором ListBox
            var item = EnumsListBox.SelectedItem; //значение в первом ListBox
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
            SeasonHandleСomboBox.SelectedItem = Enum.Parse(typeof(TimeOfYear), "0");
        }
    }
}
