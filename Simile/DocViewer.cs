using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simile
{
    public partial class DocViewer : Form
    {
        public DocViewer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = openFile1.FileName;
            }
        }
    }
}
