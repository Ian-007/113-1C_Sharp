namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            string FullName;
            string FristName;
            string LastName;

            FristName = txtFristName.Text;
            LastName = txtLastName.Text;
            FullNmae = LastName+""+ FullName;
        }
    }
}
