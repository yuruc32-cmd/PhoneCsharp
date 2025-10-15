namespace _1121754
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button_mes_Click(object sender, EventArgs e)
        {

            Frm_mes f1 = new Frm_mes();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            timer1.Start();
            this.ActiveControl = button_cacular;//預設第一個選取

        }

        private void button_call_Click(object sender, EventArgs e)
        {
            FrmCall f1 = new FrmCall();//開啟call
            this.Hide();//把原本的先隱藏再關掉
            f1.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // 將時間顯示在 Label 上
            label_time.Text = currentTime;
        }

      
        private void button_cacular_Click(object sender, EventArgs e)
        {
            FrmCacular f1 = new FrmCacular();//開啟計算機
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button_note_Click(object sender, EventArgs e)
        {
            FrmThing f1= new FrmThing();//開記事本
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
