namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foodCuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            CuisineComboBox.Items.AddRange(foodCuisine);
            CuisineComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CuisineComboBox.SelectedItem = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FoodCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FavoriteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CuisineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var item in FoodCheckedListBox.Items)
            {
                bool isSelected = FoodCheckedListBox.GetItemChecked(FoodCheckedListBox.Items.IndexOf(item));
                if (isSelected && !FavoriteListBox.Items.Contains(item))
                {
                    FavoriteListBox.Items.Add(item);
                }

            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (FavoriteListBox.Items.Count >= 1)
            {
                FavoriteListBox.Items.Remove(FavoriteListBox.SelectedItem);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            FavoriteListBox.Items.Clear();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string[] FilipinoFood = { "Adobo", "Sinigang", "Kare-kare", "Pancit" };
            string[] JapaneseFood = { "Sushi", "Omurice" , "Ramen", "Tempura" };
            string[] ChineseFood = { "dumplings", "Kung Pao chicken", "Hot Pot", "Ma Po Tofu" };
            string[] KoreanFood = { "Jjigae", "Jinju Kang", "Kimchi", "Tteokbokki" };

            FoodCheckedListBox.Items.Clear();

            if (CuisineComboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                FoodCheckedListBox.Items.AddRange(FilipinoFood);
            }
            else if (CuisineComboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                FoodCheckedListBox.Items.AddRange(JapaneseFood);
            }
            else if (CuisineComboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                FoodCheckedListBox.Items.AddRange(ChineseFood);
            }
            else if (CuisineComboBox.SelectedItem.ToString().Contains("Korean"))
            {
                FoodCheckedListBox.Items.AddRange(KoreanFood);
            }
        }
    }
}
    

