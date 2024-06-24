using System.Windows;
using System.Windows.Controls;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>()
            {
                new User{Id=1, Login="Kiryusha", Password="2281337"},
                new User{Id=2, Login="KirillKyn", Password="1337228"},
                new User{Id=3, Login="Kirill", Password="SuperDead256"},
                new User{Id=4, Login="Kirka", Password="OH! Diamonds!"},
                new User{Id=5, Login="Kiriewka", Password="XRYSTeam"},
            };
            ListBox.ItemsSource = users;
            ComboBox.ItemsSource = users;
            ListView.ItemsSource = users;


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)ComboBox.SelectedItem;
            ComboLable.Content = $"{user.Id} {user.Login} {user.Password}";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in ListBox.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            ListBLable.Content = users;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in ListView.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            ListVLable.Content = users;
        }
    }
}