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
            var allColour = Enum.GetValues(typeof(Colour));
            var allGenre = Enum.GetValues(typeof(Genre));
            var allManufactures = Enum.GetValues(typeof(SmartphoneManufactures));
            var allFormOfStudy = Enum.GetValues(typeof(StudentsFormOfStudy));
            var allTimeOfYear = Enum.GetValues(typeof(TimeOfYear));
            var allWeekday = Enum.GetValues(typeof(Weekday));
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

            }
            foreach (var colour in enumValues)
            {
                ValuesListBox.Items.Add(colour);
            }
        }
    }
}
