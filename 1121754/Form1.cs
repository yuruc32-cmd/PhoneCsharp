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
            this.ActiveControl = button_cacular;//�w�]�Ĥ@�ӿ��

        }

        private void button_call_Click(object sender, EventArgs e)
        {
            FrmCall f1 = new FrmCall();//�}��call
            this.Hide();//��쥻�������æA����
            f1.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            // �N�ɶ���ܦb Label �W
            label_time.Text = currentTime;
        }

      
        private void button_cacular_Click(object sender, EventArgs e)
        {
            FrmCacular f1 = new FrmCacular();//�}�ҭp���
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button_note_Click(object sender, EventArgs e)
        {
            FrmThing f1= new FrmThing();//�}�O�ƥ�
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
