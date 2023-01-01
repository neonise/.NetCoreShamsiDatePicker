namespace RMDP.WinTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            faDatePicker1.Text = "";
            faDatePicker1.SelectedDateTime = DateTime.Now.AddDays(-5);
        }

        private void faDatePicker1_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            MessageBox.Show(faDatePicker1.SelectedDateTime.ToString());
        }
    }
}