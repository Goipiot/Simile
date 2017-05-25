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
    public partial class Создание : Form
    {

        //public static User _usernow;
        Topic _nowtopic;
        public Topic NewTop
        {
            get
            {
                return _nowtopic;
            }
        }
        public Создание()
        {
            InitializeComponent();
        }

        private void NewTopic_Load(object sender, EventArgs e)
        {

        }

        private void filebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filelabel.Text = openFile1.FileName;               
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            int var;
            if (string.IsNullOrWhiteSpace(namebox.Text))
            {

                MessageBox.Show("Имя топика введено некорректно");
                namebox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(infoBox.Text))
            {
                MessageBox.Show("Информация введена некорректно");
                namebox.Focus();
                return;
            }

            if (!int.TryParse(varBox.Text, out var))
            {
                MessageBox.Show("Вариант введен некорректно");
                varBox.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(filelabel.Text))
            {

                MessageBox.Show("Фаил не выбран или выбран неправльно");
                namebox.Focus();
                return;
            }
            _nowtopic=new Topic(namebox.Text, filelabel.Text, infoBox.Text, var/*, _usernow.Name,_usernow.Password*/);
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
