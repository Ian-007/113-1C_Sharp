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
            string FullName; //�ܼƤ@�w�n���ŧi���A��A�~�i�H�ϥ�
            string FristName;
            string LastName;

            FristName = txtFristName.Text;
            LastName = txtLastName.Text;
            FullName = LastName+""+ FristName;

            lblShow.Text = FullName;    
        }
    }
}
