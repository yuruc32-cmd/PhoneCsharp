using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1121754
{
    public partial class FrmCacular : Form
    {
        public FrmCacular()
        {
            InitializeComponent();
        }
        double num1 = 0, num2, result;
        //為了知道加減乘除誰被按設的
        private bool plus = false;
        private bool reduce = false;
        private bool mult = false;
        private bool divi = false;
        private bool total = false;
        private void FrmCacular_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // 將時間顯示在 Label 上
            label_time.Text = currentTime;
        }

        private void button1_Click(object sender, EventArgs e)//按的數字顯示在labe_result上
        {
            Button button = (Button)sender;
            if (total == true)
            {
                label_result.Text = button.Text;
                total= false;
            }
            else
            {
                label_result.Text += button.Text;
            }
            
        }


        //可直接連續按符號計算
        private void pictureBox_plus_Click(object sender, EventArgs e)//+法
        {
            if (label_process.Text == "" && label_result.Text == "")//兩個都沒有東西就沒任何事發生
            {

            }
            else if (label_process.Text == "")//沒兩個東西可算的情況
            {
                label_process.Text = label_result.Text;
                label_result.Text = "";
                plus = true;
            }
            else if (label_result.Text == "")//只是單純改變+-*/的狀況
            {
                plus = true;
                reduce = false;
                mult = false;
                divi = false;
            }
            else if (plus == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 + num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
            }
            //要先把前一個按得算完
            else if (reduce == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 - num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                reduce = false;
                plus = true;
            }
            else if (divi == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 / num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                divi = false;
                plus = true;
            }
            else if (mult == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 * num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                mult = false;
                plus = true;
            }

        }

        private void pictureBox_reduce_Click(object sender, EventArgs e)
        {
            if (label_process.Text == "" && label_result.Text == "")//兩個都沒有東西就沒任何事發生
            {

            }
            else if (label_process.Text == "")
            {
                label_process.Text = label_result.Text;
                label_result.Text = "";
                reduce = true;
            }
            else if (label_result.Text == "")//只是單純改變+-*/的狀況
            {
                reduce = true;
                plus = false;
                mult = false;
                divi = false;
            }
            else if (reduce == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 - num2;
                label_process.Text = result.ToString();
                label_result.Text = "";

            }
            else if (plus == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 + num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                plus = false;
                reduce = true;
            }
            else if (divi == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 / num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                divi = false;
                reduce = true;
            }
            else if (mult == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 * num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                mult = false;
                reduce = true;
            }

        }

        private void pictureBox_mult_Click(object sender, EventArgs e)
        {
            if (label_process.Text == "" && label_result.Text == "")//兩個都沒有東西就沒任何事發生
            {

            }
            else if (label_process.Text == "")
            {
                label_process.Text = label_result.Text;
                label_result.Text = "";
                mult = true;
            }
            else if (label_result.Text == "")
            {
                mult = true;
                reduce = false;
                plus = false;
                divi = false;
            }
            else if (mult == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 * num2;
                label_process.Text = result.ToString();
                label_result.Text = "";

            }
            else if (plus == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 + num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                plus = false;
                mult = true;
            }
            else if (reduce == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 - num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                reduce = false;
                mult = true;
            }
            else if (divi == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 / num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                divi = false;
                mult = true;
            }

        }

        private void pictureBox_divi_Click(object sender, EventArgs e)
        {
            if (label_process.Text == "" && label_result.Text == "")//兩個都沒有東西就沒任何事發生
            {

            }
            else if (label_process.Text == "")
            {
                label_process.Text = label_result.Text;
                label_result.Text = "";
                divi = true;
            }
            else if (label_result.Text == "")
            {
                divi = true;
                reduce = false;
                mult = false;
                plus = false;
            }
            else if (divi == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 / num2;
                label_process.Text = result.ToString();
                label_result.Text = "";

            }
            else if (plus == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 + num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                plus = false;
                divi = true;
            }
            else if (reduce == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 - num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                reduce = false;
                divi = true;
            }
            else if (mult == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 * num2;
                label_process.Text = result.ToString();
                label_result.Text = "";
                mult = false;
                divi = true;
            }

        }

        private void pictureBox_total_Click(object sender, EventArgs e)//直接等號要直接顯示在label_result上
        {
            if (label_result.Text == "") { }
            else if (label_process.Text == "" && label_result.Text != "") { }
            else if (plus == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 + num2;
                label_process.Text = "";
                label_result.Text = result.ToString();
                total = true;
            }
            else if (reduce == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 - num2;
                label_result.Text = result.ToString();
                label_process.Text = "";
                total = true;
            }
            else if (divi == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 / num2;
                label_result.Text = result.ToString();
                label_process.Text = "";
                total = true;
            }
            else if (mult == true)
            {
                num1 = double.Parse(label_process.Text);
                num2 = double.Parse(label_result.Text);
                result = num1 * num2;
                label_result.Text = result.ToString();
                label_process.Text = "";
                total = true;
            }
        }
        private void pictureBox_backspace_Click(object sender, EventArgs e)//刪除前一個字
        {
            if (label_result.Text.Length > 0)
            {
                label_result.Text = label_result.Text.Remove(label_result.Text.Length - 1);
            }
        }

        private void pictureBox_clear_Click(object sender, EventArgs e)//清空
        {
            label_result.Text = "";
            label_process.Text = "";
        }

        private void pictureBox_return_Click(object sender, EventArgs e)//回上一個頁面(主頁
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
