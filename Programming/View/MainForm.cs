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

namespace Programming
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
            foreach (var colour in enumValues)
            {
                ValuesListBox.Items.Add(colour);
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
                ResultParseTextBox.Text = $"Это день недели ({result.ToString()} = {(int)result})";
            }
            else
            {
                ResultParseTextBox.Text = $"Нет такого дня недели";
            }
        }
    }
}
