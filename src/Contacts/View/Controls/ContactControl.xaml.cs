using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Хранит свойство зависимости возможности редактирования.
        /// </summary>
        public static readonly DependencyProperty IsEditProperty = 
            DependencyProperty.Register(nameof(IsEdit), typeof(bool),
                typeof(ContactControl));

        /// <summary>
        /// Возвращает и задает возможность редактирования.
        /// </summary>
        public bool IsEdit
        {
            get => (bool)GetValue(IsEditProperty);
            set => SetValue(IsEditProperty, value);
        }

        public ContactControl()
        {
            InitializeComponent();
        }

        private void PhoneNumberTextBox_PreviewTextInput(
            object sender, TextCompositionEventArgs e)
        {
            e.Handled = Regex.IsMatch(e.Text, "[^0-9+()-]+$");
        }

        private void PhoneNumberTextBox_Pasting(
            object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (Regex.IsMatch(text, "[^0-9+()-]+$"))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
