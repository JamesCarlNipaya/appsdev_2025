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
            // You can implement functionality for label click here if needed.
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Check if the TextBox is not empty or just whitespace and if the item doesn't already exist in the ListBox
            if (!string.IsNullOrWhiteSpace(txtBox.Text) && !listBox.Items.Contains(txtBox.Text))
            {
                // Add the item from TextBox to the ListBox
                listBox.Items.Add(txtBox.Text);
            }
        }

        private void removeBox_Click(object sender, EventArgs e)
        {
            // Remove the selected item from the ListBox
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            // Clear all items from the ListBox
            listBox.Items.Clear();
        }
    }
}
