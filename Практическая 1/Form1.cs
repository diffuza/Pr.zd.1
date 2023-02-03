namespace Практическая_1
{
    public partial class frmSumma : Form
    {
        public frmSumma()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // эта строка - ваш введенный код
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int summa = Int32.Parse(txtA.Text) +
               Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
            txtSumma.Text = summa.ToString();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}