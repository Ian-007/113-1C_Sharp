namespace HomeWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ptxFrist_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "���Q";
        }

        private void ptxSecond_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�®�6";
        }

        private void ptxThird_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "�®�ACE";
        }

        private void ptxForth_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "����7";
        }

        private void ptxFifth_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "����3";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
