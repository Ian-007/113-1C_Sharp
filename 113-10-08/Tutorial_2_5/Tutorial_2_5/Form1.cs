namespace Tutorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void ptxBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;
            ptxFront.Visible = false;
        }

        private void ptxFront_Click(object sender, EventArgs e)
        {
            ptxFront.Visible = true;
            ptxBack.Visible = false;
        }

        private void btnShowBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true; //�]�wVisible�ݩʬ���
            ptxFront.Visible = false;
        }
        //��ܼ��J�P����
        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxFront.Visible = true;
            ptxBack.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
