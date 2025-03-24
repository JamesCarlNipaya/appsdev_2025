namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] cartoons = { "SpongeBob", "Patrick", "Mr. Krabs", "Sandy" };
            comboBox1.Items.AddRange(cartoons);
            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select cartoon character first");
                return;

            }
            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)

            {

                case "SpongeBob":

                    pictureBox1.Image = Image.FromFile("C:/Users/USER/Pictures/Camera Roll/download (3).jpg");
                    break;

                case "Patrick":
                    pictureBox1.Image = Image.FromFile("C:/Users/USER/Pictures/Camera Roll/download (2).jpg ");
                    break;

                case "Mr. Krabs":
                    pictureBox1.Image = Image.FromFile("C:/Users/USER/Pictures/Camera Roll/download.jpg");
                    break;

                case "Sandy":
                    pictureBox1.Image = Image.FromFile("C:/Users/USER/Pictures/Camera Roll/download (1).jpg");
                    break;

                default:
                    pictureBox1.Image = null;
                    break;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
