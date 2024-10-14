namespace WinFormsApp1
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lgnButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.LoginName = unameBox.Text;
            employee.Password = pwdBox.Text;
            if (employee.Login(employee.LoginName, employee.Password))
            {
                MessageBox.Show("Login Berhasil, ID anda adalah " + employee.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
