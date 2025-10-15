using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _1121754
{
    public partial class FrmCall : Form
    {
        public FrmCall()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string key = button.Text;
            textBox_call.Text += key;
        }

        private void FrmCall_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // 將時間顯示在 Label 上
            label_time.Text = currentTime;
        }

        private void pictureBox_backspace_Click(object sender, EventArgs e)//刪除前一個字
        {
            if (textBox_call.Text.Length > 0)
                textBox_call.Text = textBox_call.Text.Remove(textBox_call.Text.Length - 1);
        }

        private void pictureBox_return_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void textBox_call_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_call_Click(object sender, EventArgs e)//撥號
        {
            if (textBox_call.Text == "")//沒文字
            {
                MessageBox.Show("Text box cannot be blank!", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Frmcallok f1 = new Frmcallok(textBox_call.Text);//把撥打的號碼傳去撥號from
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
