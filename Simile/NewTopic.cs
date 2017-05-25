using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simile
{
    public partial class NewTopic : Form
    {

        public static User _usernow;

        public NewTopic()
        {
            InitializeComponent();
        }

        private void NewTopic_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = openFile1.FileName;               
                //if (openFile1.OpenFile() != null)
                //{
                //    if (!Directory.Exists("@\\D\\docs"))
                //        Directory.CreateDirectory("@\\D\\docs");
                //    string destFile = Path.Combine("@\\D\\docs", openFile1.FileName);
                //    File.Copy(openFile1.FileName, destFile, true);
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Topic newtop=new Topic(textBox1.Text, label1.Text, _usernow);
            MainWindow._topicList.Add(newtop);
            MessageBox.Show("Ваш топик успешно добавлен");
        }
    }
}
