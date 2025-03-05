namespace BusyBeezApplication
{
    public partial class frmMainView : Form
    {
        private void frmMainView_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear(); // Clear on load
        }
        public frmMainView()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtbxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                checkedListBox1.Items.Add(txtTask.Text, false); // Add unchecked task
                txtTask.Clear(); // Clear input box
            }
            else
            {
                MessageBox.Show("Enter a task before adding!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
