using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dialoguecraetor;

namespace dialoguecraetor
{
    public partial class SetButtonName : Form
    {
        private setName setName = null;
        

        public SetButtonName(setName set, int buttonNum)
        {
            InitializeComponent();
            setNote(buttonNum);
            this.setName = set;
        }

        private void setNote(int buttonNum)
        {
            note.Text = "正在修改" + buttonNum + "号按钮";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setName(nameText.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
