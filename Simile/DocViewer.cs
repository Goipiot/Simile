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
        public static Topic _nowtopic;
        public DocViewer()
        {
            InitializeComponent();
            axAcroPDF1.src =_nowtopic.Filename;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
