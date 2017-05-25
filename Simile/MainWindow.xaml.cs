using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.IO;


namespace Simile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Topic> _topicList = new List<Topic>();
        const string FileNamer = "topics.txt";
        //string _filename;
        bool key=true;
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                foreach (Topic rightTopic in _topicList)
                {
                    if ((listBox.SelectedValue).ToString() == rightTopic.Name)
                    {
                        var Forma = new DocViewer();
                        Forma.DocWindow.src = rightTopic.Filename;
                        Forma.nameLabel.Text = rightTopic.Info2;
                        Forma.ShowDialog();
                        
                        break;
                    }
                }
            }
        }

        private void Deletebutton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                foreach (Topic rightTopic in _topicList)
                {
                    if ((listBox.SelectedValue).ToString() == rightTopic.Name)
                    {
                        _topicList.Remove(rightTopic);
                        break;
                    }
                }

                SaveData();
                RefreshListBox();
            }
        }
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Deletebutton.IsEnabled = listBox.SelectedIndex != -1;
            InfoButton.IsEnabled = listBox.SelectedIndex != -1;

        }
        private void RefreshListBox()
        {

            listBox.Items.Clear();
            foreach(Topic topic in _topicList)
            {
                listBox.Items.Add(topic.Name);
            }
        }

        private void Addbutton_Click(object sender, RoutedEventArgs e)
        {
            var NewTopic = new Создание();
            NewTopic.ShowDialog();
            foreach (Topic exTopic in _topicList)
            {
                if (NewTopic.NewTop.Name == exTopic.Name)
                {
                    MessageBox.Show("Данное имя уже существует");
                    _topicList.Remove(NewTopic.NewTop);
                    key = false;
                    break;
                }
            }
            if (key == true)
            {
                MessageBox.Show("Ваш топик успешно добавлен");
                _topicList.Add(NewTopic.NewTop);
            }
            key = true;
            SaveData();
            RefreshListBox();
        }
        private void SaveData()
        {
            using (var sw = new StreamWriter(FileNamer))
            {
                foreach (var topic in _topicList)
                {
                    sw.WriteLine($"{topic.Name}#{topic.Filename}#{topic.Inform}#{topic.Variants}");
//:{topic.Auth.Name}:{topic.Auth.Password}");
                }
            }
        }


        private void LoadData()
        {
            try
            {
                _topicList = new List<Topic>();

                using (var sr = new StreamReader(FileNamer))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var parts = line.Split('#');
                        var topic = new Topic(parts[0], parts[1],parts[2],int.Parse(parts[3])/*, parts[3],parts[4]*/);
                        _topicList.Add(topic);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.MessageBox.Show("Ошибка чтения из файла");
            }
            RefreshListBox();
        }

        private void Findbutton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(findBox.Text))
            {
                System.Windows.Forms.MessageBox.Show("Имя топика не введено или введено неверно");
                findBox.Focus();
                return;
            }
            foreach (Topic rightTopic in _topicList)
            {
                if (rightTopic.Name == findBox.Text)
                {
                    listBox.Items.Clear();
                    listBox.Items.Add(rightTopic.Name);
                    key = false;
                    break;
                }
            }
            if (key == true) MessageBox.Show("Топик с данным именем не существует");
            key = true;
        }

        private void findBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshListBox();
        }

        //private void addVarButton_Click(object sender, RoutedEventArgs e)
        //{
        //    int var;
        //    if (!int.TryParse(addvarBox.Text, out var))
        //    {
        //        MessageBox.Show("Вариант введен некорректно");
        //        addvarBox.Focus();
        //        return;
        //    }
        //    foreach (Topic rightTopic in _topicList)
        //    {
        //        if (rightTopic.Name == findBox.Text)
        //        {
        //            rightTopic.Variants.Add(var);
        //            using (var sw = new StreamWriter(rightTopic.Name+"-vars.txt"))
        //            {
        //                foreach (int variant in rightTopic.Variants)
        //                {
        //                    sw.WriteLine(variant);
        //                }
        //            }
        //            break;
        //        }
        //        MessageBox.Show("Вариант успешно добавлен");
                

            //}
        }
    }

