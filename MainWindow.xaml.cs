using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp7
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            PropertyChanged += (sender, e) => { };
            //Password = "";
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; PropertyChanged(this, new PropertyChangedEventArgs("Password")); }
        }
        private string _Password = "";

        public string Password2
        {
            get { return _Password2; }
            set { _Password2 = value; PropertyChanged(this, new PropertyChangedEventArgs("Password2")); }
        }
        private string _Password2 = "";

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Password = null;
        }
    }
}
