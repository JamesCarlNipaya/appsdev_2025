namespace SimpleFormsAppWithComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CuisineComboBox = new ComboBox();
            selectButton = new Button();
            addButton = new Button();
            removeButton = new Button();
            clearButton = new Button();
            FoodCheckedListBox = new CheckedListBox();
            FavoriteListBox = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.WindowFrame;
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(560, 34);
            label1.TabIndex = 0;
            label1.Text = "Simple Forms App With Combo Box ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(203, 88);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "Kinds Of Food";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(401, 88);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 3;
            label4.Text = "Favorite Foods";
            // 
            // CuisineComboBox
            // 
            CuisineComboBox.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CuisineComboBox.FormattingEnabled = true;
            CuisineComboBox.Location = new Point(32, 111);
            CuisineComboBox.Name = "CuisineComboBox";
            CuisineComboBox.Size = new Size(124, 26);
            CuisineComboBox.TabIndex = 4;
            CuisineComboBox.Text = "Choose:";
            CuisineComboBox.SelectedIndexChanged += CuisineComboBox_SelectedIndexChanged;
            // 
            // selectButton
            // 
            selectButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectButton.ForeColor = SystemColors.WindowFrame;
            selectButton.Location = new Point(32, 143);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(81, 28);
            selectButton.TabIndex = 5;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.WindowFrame;
            addButton.Location = new Point(243, 319);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 28);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeButton.ForeColor = SystemColors.WindowFrame;
            removeButton.Location = new Point(584, 143);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(83, 28);
            removeButton.TabIndex = 7;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearButton.ForeColor = SystemColors.WindowFrame;
            clearButton.Location = new Point(584, 177);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(83, 32);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear All";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // FoodCheckedListBox
            // 
            FoodCheckedListBox.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FoodCheckedListBox.FormattingEnabled = true;
            FoodCheckedListBox.Location = new Point(203, 111);
            FoodCheckedListBox.Name = "FoodCheckedListBox";
            FoodCheckedListBox.Size = new Size(168, 202);
            FoodCheckedListBox.TabIndex = 9;
            FoodCheckedListBox.SelectedIndexChanged += FoodCheckedListBox_SelectedIndexChanged;
            // 
            // FavoriteListBox
            // 
            FavoriteListBox.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FavoriteListBox.FormattingEnabled = true;
            FavoriteListBox.ItemHeight = 18;
            FavoriteListBox.Location = new Point(401, 111);
            FavoriteListBox.Name = "FavoriteListBox";
            FavoriteListBox.Size = new Size(177, 202);
            FavoriteListBox.TabIndex = 10;
            FavoriteListBox.SelectedIndexChanged += FavoriteListBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Location = new Point(187, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 378);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Location = new Point(387, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(8, 377);
            panel2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(762, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(FavoriteListBox);
            Controls.Add(FoodCheckedListBox);
            Controls.Add(clearButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(selectButton);
            Controls.Add(CuisineComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox CuisineComboBox;
        private Button selectButton;
        private Button addButton;
        private Button removeButton;
        private Button clearButton;
        private CheckedListBox FoodCheckedListBox;
        private ListBox FavoriteListBox;
        private Panel panel1;
        private Panel panel2;
    }
}
