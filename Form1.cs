using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showFileName_update("-");
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                previewBox.Text = sr.ReadToEnd();
                string[] filePath = ofd.FileName.Split('\\');
                showFileName_update(filePath[filePath.Length-1]);
            }
        }

        private void showFileName_update(string filename)
        {
            showFileName.Text = "当前打开文本：" + filename;
        }
    }
}
