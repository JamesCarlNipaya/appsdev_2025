namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstNameValue = FirstName.Text;
            string middleNameValue = MiddleName.Text;
            string lastNameValue = LastName.Text;
            string suffixValue = suffix.Text;


            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                MessageBox.Show($" Hello There! {firstNameValue} {middleNameValue} {lastNameValue} {suffixValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Aight!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
