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
            string FullName; //變數一定要先宣告型態後，才可以使用
            string FristName;
            string LastName;

            FristName = txtFristName.Text;
            LastName = txtLastName.Text;
            FullName = LastName+""+ FristName;

            lblShow.Text = FullName;    
        }
    }
}
