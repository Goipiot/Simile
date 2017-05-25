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
using System.Windows.Forms;


namespace Simile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static User _usernow;
        public static  List<Topic> _topicList = new List<Topic>();

        public MainWindow()
        {
            InitializeComponent();
           
            _topicList.Add(new Topic("Ivan Ivanov", "", _usernow));
            RefreshListBox();
        }

        private void Addbutton1_Click(object sender, RoutedEventArgs e)
        {


        }
        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            var Form = new DocViewer();
            Form.ShowDialog();

        }

        private void Deletebutton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                _topicList.RemoveAt(listBox.SelectedIndex);
                RefreshListBox();
            }

        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Deletebutton.IsEnabled = listBox.SelectedIndex != -1;
        }
        private void RefreshListBox()
        {
            listBox.ItemsSource = null;
            listBox.ItemsSource = _topicList;
            //foreach (Topic newtopic in _topicList)
            //{
            //    listBox.Items.Add(newtopic.Name);
            //}
        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            var NewTopic = new NewTopic();
            NewTopic.ShowDialog();
        }



        //private void Backbutton_Click(object sender, RoutedEventArgs e)
        //{
        //    Close();
        //}

    }
}
