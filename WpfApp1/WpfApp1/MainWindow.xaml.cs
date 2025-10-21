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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBaseContext db = new DataBaseContext();
      List users = db.Users.ToList();
        public MainWindow()
        {
            InitializeComponent();
        }

        public  bool CheckUserFromNull()
        {
            if (NameBox.Text == null || SerNameBox.Text == null || AgeBox.Text == null ||PhoneNumberBox.Text == null)
                return true;
            return false;
        }

        public void CreateUser()
        {
            if (CheckUserFromNull())
            {
                throw new Exception();
            }

            User user = new User(NameBox.Text, SerNameBox.Text,int.Parse(AgeBox.Text), float.Parse(PhoneNumberBox.Text));
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
