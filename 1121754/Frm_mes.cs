using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1121754
{
    public partial class Frm_mes : Form
    {
        public Frm_mes()
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
        //給予變數來看是否textbox被按
        private bool TxtmesClick = false;
        private bool TxtpersonClick = false;
        private bool TxttitleClick = false;
        private void Frm_mes_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;//看啥鍵被按
            string key = button.Text;

            DateTime now = DateTime.Now;
            if (previousKey == key && (now - lastKeyPressTime).TotalSeconds < 1)//連續按同個的狀態
            {
                if (TxtmesClick == true)//看是哪個text被選取所以打那個text
                {
                    if (previousKey == key && textBox_mes.Text.Length > 0 && previousKey != "1" && previousKey != "#" && previousKey != "*")
                    {
                        textBox_mes.Text = textBox_mes.Text.Remove(textBox_mes.Text.Length - 1);
                    }
                    count++;
                    if (count >= keyMap[key].Length)
                    {
                        count = 0;
                    }
                }
                else if (TxtpersonClick == true)
                {
                    if (previousKey == key && textBox_person.Text.Length > 00 && previousKey != "1" && previousKey != "#" && previousKey != "*")
                    {
                        textBox_person.Text = textBox_person.Text.Remove(textBox_person.Text.Length - 1);
                    }
                    count++;
                    if (count >= keyMap[key].Length)
                    {
                        count = 0;
                    }
                }
                else if (TxttitleClick == true)
                {
                    if (previousKey == key && textBox_title.Text.Length > 00 && previousKey != "1" && previousKey != "#" && previousKey != "*")
                    {
                        textBox_title.Text = textBox_title.Text.Remove(textBox_title.Text.Length - 1);
                    }
                    count++;
                    if (count >= keyMap[key].Length)
                    {
                        count = 0;
                    }
                }
            }
            else
            {
                count = 0;
            }
            if (TxtmesClick == true)
            {
                currentInput = keyMap[key][count];
                textBox_mes.Text += currentInput;
                previousKey = key;
                lastKeyPressTime = now;//時間刷新
            }
            else if (TxtpersonClick == true)
            {
                currentInput = keyMap[key][count];
                textBox_person.Text += currentInput;
                previousKey = key;
                lastKeyPressTime = now;
            }
            else if (TxttitleClick == true)
            {
                currentInput = keyMap[key][count];
                textBox_title.Text += currentInput;
                previousKey = key;
                lastKeyPressTime = now;
            }
        }

      
        //看是哪個textbox被按
        private void textBox_mes_MouseDown(object sender, MouseEventArgs e)
        {
            TxtmesClick = true;
            TxtpersonClick = false;
            TxttitleClick = false;
        }

        private void textBox_title_MouseDown(object sender, MouseEventArgs e)
        {
            TxtmesClick = false;
            TxtpersonClick = false;
            TxttitleClick = true;
        }

        private void textBox_person_MouseDown(object sender, MouseEventArgs e)
        {
            TxtmesClick = false;
            TxtpersonClick = true;
            TxttitleClick = false;
        }

        //所有文字清空
        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_mes.Text = "";
            textBox_person.Text = "";
            textBox_title.Text = "";
        }

        private void button_send_Click(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // 將時間顯示在 Label 上
            label_time.Text = currentTime;
        }

        private void pictureBox_backspace_Click(object sender, EventArgs e)//刪除前一個字
        {

            if (TxtmesClick == true && textBox_mes.Text.Length > 0)
                textBox_mes.Text = textBox_mes.Text.Remove(textBox_mes.Text.Length - 1);
            else if (TxtpersonClick == true && textBox_person.Text.Length > 0)
                textBox_person.Text = textBox_person.Text.Remove(textBox_person.Text.Length - 1);
            else if (TxttitleClick == true && textBox_title.Text.Length > 0)
                textBox_title.Text = textBox_title.Text.Remove(textBox_title.Text.Length - 1);
        }



        private void button_ok_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_return_Click(object sender, EventArgs e)//回去上個畫面(主頁
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (textBox_mes.Text == "" || textBox_person.Text == "" || textBox_title.Text == "")
            {
                MessageBox.Show("Text box cannot be blank!", "Error", MessageBoxButtons.OK);//文字不能為空白
            }
            else
            {
                MessageBox.Show("Message sent successfully!", "Send", MessageBoxButtons.OK);//成功並清空本來文字
                textBox_mes.Text = "";
                textBox_person.Text = "";
                textBox_title.Text = "";
            }
        }
    }
}
