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
using Microsoft.Office.Interop.Word;

namespace Simile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Addbutton1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            if(openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = openFile1.FileName;
                string outfile = "E\\file.pdf";
                string extension = System.IO.Path.GetExtension(file);
                if(extension == ".doc"|| extension == ".docx")
                {
                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Document doc = null;
                    doc = app.Documents.Open(file, Type.Missing, false);

                    doc.ExportAsFixedFormat(outfile, WdExportFormat.wdExportFormatPDF);
                    doc.Close(false, Type.Missing, Type.Missing);
                    app.Quit(false, false, false);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(app);

                }
                AxAcroPDF1.scr = outfile;
            }
        }
    }
}
