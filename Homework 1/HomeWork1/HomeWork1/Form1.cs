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
            lblTranslation.Text = "¤è¶ôQ";
        }

        private void ptxSecond_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "¶Â®ç6";
        }

        private void ptxThird_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "¶Â®çACE";
        }

        private void ptxForth_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "±öªá7";
        }

        private void ptxFifth_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "¬õ¤ß3";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
