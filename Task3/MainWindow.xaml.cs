using System.Windows;

namespace Task3
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
    }
}