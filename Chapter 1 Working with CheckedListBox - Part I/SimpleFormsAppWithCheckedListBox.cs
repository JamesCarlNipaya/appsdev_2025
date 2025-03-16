namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Avengers", "Spiderman", "The Odyssey" };
            checkListBox.Items.AddRange(movies);

            checkListBox.CheckOnClick = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkListBox.Items)
            {

                bool isSelected = checkListBox.GetItemChecked(checkListBox.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies))
                {
                    listBox.Items.Add(movies);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
