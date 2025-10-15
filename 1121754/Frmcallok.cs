using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1121754
{
    public partial class Frmcallok : Form
    {
        string a;
        public Frmcallok(string textBoxCallValue)//接收撥打的號碼文字
        {
            InitializeComponent();
            a = textBoxCallValue;
        }

        private void Frmcallok_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = a;//顯示撥打的號碼

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox_stopcall_Click(object sender, EventArgs e)//回上一個頁面(撥號頁面
        {

            FrmCall f1 = new FrmCall();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // 將時間顯示在 Label 上
            label_time.Text = currentTime;
        }
    }
}
