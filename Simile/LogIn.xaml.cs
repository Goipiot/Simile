﻿using System;
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
using System.Windows.Shapes;

namespace Simile
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        List<User> UserList = new List<User>();

        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User(nameBox.ToString(), passBox.ToString());
            foreach (User user in UserList)
            {
                if (newUser == user)
                {
                    MainWindow._usernow = newUser;
                    break;
                }                    
            }
            MainWindow._usernow = newUser;
            NewTopic._usernow = newUser;
            UserList.Add(newUser);            
            var mWindow = new MainWindow();
            Hide();
            Close();
            mWindow.ShowDialog();
            
            //if (mWindow.Backbutton.IsEnabled == true || mWindow.IsEnabled == true)
            //{
            //    Show();
            //    nameBox.Text = null;
            //    passBox.Text = null;
            //}
            //else if (mWindow.IsEnabled == false || mWindow.Backbutton.IsEnabled == false)
            //{
            //    Close();
            //}

        }
    }
}
