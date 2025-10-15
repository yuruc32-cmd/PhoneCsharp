using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1121754
{
    public partial class FrmThing : Form
    {
        public FrmThing()
        {
            InitializeComponent();
        }
        string mes = "";
        private Dictionary<string, string[]> keyMap = new Dictionary<string, string[]>//每個鍵對應的字母
        {
            { "1", new string[]{"1"} },
            { "0",new string[]{"0"} },
            {"#",new string[]{"#"} },
            {"*",new string[]{"*"} },
            { "2", new string[] { "a", "b", "c","2" } },
            { "3", new string[] { "d", "e", "f" ,"3"} },
            { "4", new string[] { "g", "h", "i", "4" } },
            { "5", new string[] { "j", "k", "l", "5" } },
            { "6", new string[] { "m", "n", "o", "6" } },
            { "7", new string[] { "p", "q", "r", "s" , "7" } },
            { "8", new string[] { "t", "u", "v", "8" } },
            { "9", new string[] { "w", "x", "y", "z", "9" } },
        };
        private string currentInput = "";
        private string previousKey = "";
        private int count = 0;
        private DateTime lastKeyPressTime;
        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)//改字型
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;//看啥鍵被按
            string key = button.Text;

            DateTime now = DateTime.Now;
            if (previousKey == key && (now - lastKeyPressTime).TotalSeconds < 1)//連續按同個的狀態
            {

                if (previousKey == key && richTextBox1.Text.Length > 0 && previousKey != "1" && previousKey != "#" && previousKey != "*")
                {
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                }
                count++;
                if (count >= keyMap[key].Length)
                {
                    count = 0;
                }
            }
            else
            {
                count = 0;
            }
            currentInput = keyMap[key][count];
            richTextBox1.Text += currentInput;
            previousKey = key;
            lastKeyPressTime = now;
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }

        private void 取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = false;
        }



        private void 文字底色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }



        private void 字體顏色ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // 將時間顯示在 Label 上
            label_time.Text = currentTime;
        }

        private void FrmThing_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_return_Click(object sender, EventArgs e)//回上一個頁面(主頁
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }



        private void pictureBox_backspace_Click(object sender, EventArgs e)//刪除前一個字
        {

            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
        }

       
        private string filename;
        private void button_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "富文本格式 (*.rtf)|*.rtf|所有檔案 (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;//只能開一個
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                string extension = Path.GetExtension(filename).ToLower();

                if (extension == ".rtf")
                {
                    richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
                }
                else
                {
                    MessageBox.Show("Unsupported file format");
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "富文本格式 (*.rtf)|*.rtf|所有檔案 (*.*)|*.*";
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.AddExtension = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                string extension = Path.GetExtension(filePath).ToLower();

                if (extension == ".rtf")
                {
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                
                else
                {
                    MessageBox.Show("Unsupported file format.");
                    return;
                }

                MessageBox.Show("Text has been successfully saved to the file.");
            }
        }
    }
}
