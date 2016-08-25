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
using dialoguecraetor;

namespace dialoguecraetor
{
    public delegate void setName(string name);
    public partial class MainWindow : Form
    {
        string narrator = "-";
        int inputPosition;
        Dictionary<string, int> charButton;
        Button setNameButton;

        public MainWindow()
        {
            InitializeComponent();
            charButton = new Dictionary<string, int>();
            charButton.Add("character1", 1);
            charButton.Add("character2", 2);
            charButton.Add("character3", 3);
            charButton.Add("character4", 4);
            charButton.Add("character5", 5);
            charButton.Add("character6", 6);
            charButton.Add("character7", 7);
            charButton.Add("character8", 8);
            charButton.Add("character9", 9);
            charButton.Add("character10", 0);
        }

        private void setButtonText(string text)
        {
            setNameButton.Text = text;
        }

        private void label_update(Label label, string filename)
        {
            label.Text = filename;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.D1))
            {
                narrator = character1.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D2))
            {
                narrator = character2.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D3))
            {
                narrator = character3.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D4))
            {
                narrator = character4.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D5))
            {
                narrator = character5.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D6))
            {
                narrator = character6.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D7))
            {
                narrator = character7.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D8))
            {
                narrator = character8.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D9))
            {
                narrator = character9.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D0))
            {
                narrator = character10.Text;
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.P))
            {
                narrator = "旁白";
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.A))
            {
                narrator = "众人";
                label_update(showCharacterName, "叙述者：" + narrator);
            }
            else if (keyData == (Keys.Control | Keys.D0))
            {
                narrator = " ";
                label_update(showCharacterName, "叙述者：(无)");
            }
            else if (keyData == (Keys.Control | Keys.Enter))
            {
                SendToPreview_Click(dialogueBox,new EventArgs());
            }
            return base.ProcessDialogKey(keyData);
        }

        private void previewBox_MouseLeave(object sender, EventArgs e)
        {
            inputPosition =  previewBox.SelectionStart;
        }

        private void open_Click(object sender, EventArgs e)
        {
            //create open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File (*.txt)|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //read contents
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                previewBox.Text = sr.ReadToEnd();
                //get file name
                string[] filePath = ofd.FileName.Split('\\');
                string text = "当前打开文本：" + filePath[filePath.Length - 1];
                //set label
                label_update(showFileName ,filePath[filePath.Length-1]);
                sr.Dispose();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //create save file dialog
            SaveFileDialog sfd = new SaveFileDialog();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(File.Create(sfd.FileName));
                sw.Write(previewBox.Text);
                sw.Dispose();
            }
        }

        private void SendToPreview_Click(object sender, EventArgs e)
        {
            if (narrator.Equals("-"))
                MessageBox.Show("忘记选角色了或者角色未命名哟。");
            else if (dialogueBox.Text.Equals("在这里输入对话~") || dialogueBox.Text.Equals(""))
                MessageBox.Show("还没写对话哟。");
            else
            {
                if (previewBox.Text.Equals("这里是预览，喵~"))
                    previewBox.Text = "";
                previewBox.Text = previewBox.Text.Insert(inputPosition, "[" + narrator + "]" + dialogueBox.Text);
            }
                
        }

        private void characterButton_Click(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            foreach(KeyValuePair<string,int> kvp in charButton)
            {
                if (self.Name.Equals(kvp.Key))
                {
                    setNameButton = self;
                    SetButtonName sbn = new SetButtonName(new setName(setButtonText),kvp.Value);
                    sbn.ShowDialog(this);
                    break;
                }

            }
        }

        private void dialogueBox_Click(object sender, EventArgs e)
        {
            if (dialogueBox.Text.Equals("在这里输入对话~"))
                dialogueBox.Text = "";
        }

        private void noThing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("这块我还没写 :P");
        }
    }
}
