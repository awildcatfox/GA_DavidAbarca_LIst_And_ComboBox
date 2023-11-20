using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace GA_DavidAbarca_LIst_And_ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> firstNames = new List<string> { "John", "Jane", "Doe", "Mary", "Bob" };
        List<string> lastNames = new List<string> { "Smith", "Doe", "Johnson", "Taylor", "Brown" };
       
        public MainWindow()
        {
            InitializeComponent();
            cmbFirstName.ItemsSource = firstNames; // Assign our list to the combo box
            lbLastNames.ItemsSource = lastNames;
        }

        private void btnDisplayName_Click(object sender, RoutedEventArgs e)
        {
            // Getting selected index from combo box
            int firstNameIndex = cmbFirstName.SelectedIndex;

            // Getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            // Using the index to get the first name from the list
            string firstName = firstNames[firstNameIndex];

            // Using the index to get the last name from the list
            string lastName = lastNames[lastNameIndex];

            // Concatenating a full name
            string fullName = firstName + " " + lastName;

            MessageBox.Show(fullName); // Display Full Name
        }

        private void btnAddNames_Click(object sender, RoutedEventArgs e)
        {
            string firstName = txtFirstName.Text; // Users first name input

            string lastName = txtLastName.Text; // Users last name input

            firstNames.Add(firstName); // Adding first name to first name list
            lastNames.Add(lastName); // Adding last name to last name list

            // Refresh each of the Boxes to show the newly added names to the list

            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();
        }

        private void btnRemoveStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            // Getting selected index from combo box
            int firstNameIndex = cmbFirstName.SelectedIndex;
            // Getting selected index from list box
            int lastNameIndex = lbLastNames.SelectedIndex;

            firstNames.RemoveAt(firstNameIndex); // Removing first name
            lastNames.RemoveAt(lastNameIndex); // Removing last name


            // Refresh each of the Boxes to show the newly added names to the list

            cmbFirstName.Items.Refresh();
            lbLastNames.Items.Refresh();
        }

        private void lbLastNames1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbFirstName.SelectedIndex = lbLastNames.SelectedIndex;
        }
    }
}
