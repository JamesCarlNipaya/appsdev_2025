namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !listBox.Items.Contains(txtBox.Text));
            {
                listBox.Items.Add(txtBox.Text);
            }
        }

        private void removeBox_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
