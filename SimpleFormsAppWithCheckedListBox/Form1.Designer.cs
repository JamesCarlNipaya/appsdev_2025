namespace SimpleFormsAppWithCheckedListBox
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
            listBox = new ListBox();
            checkListBox = new CheckedListBox();
            label1 = new Label();
            addButton = new Button();
            removeButton = new Button();
            clearAll = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.BorderStyle = BorderStyle.FixedSingle;
            listBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 19;
            listBox.Location = new Point(251, 62);
            listBox.Name = "listBox";
            listBox.Size = new Size(195, 173);
            listBox.TabIndex = 0;
            // 
            // checkListBox
            // 
            checkListBox.BorderStyle = BorderStyle.FixedSingle;
            checkListBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkListBox.FormattingEnabled = true;
            checkListBox.Location = new Point(61, 62);
            checkListBox.Name = "checkListBox";
            checkListBox.Size = new Size(184, 170);
            checkListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(431, 23);
            label1.TabIndex = 2;
            label1.Text = "SimpleFormsAppWithCheckedListBox";
            // 
            // addButton
            // 
            addButton.BackColor = Color.Goldenrod;
            addButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.Location = new Point(114, 238);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Goldenrod;
            removeButton.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeButton.Location = new Point(452, 78);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(78, 32);
            removeButton.TabIndex = 4;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // clearAll
            // 
            clearAll.BackColor = Color.Goldenrod;
            clearAll.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearAll.Location = new Point(452, 116);
            clearAll.Name = "clearAll";
            clearAll.Size = new Size(78, 36);
            clearAll.TabIndex = 5;
            clearAll.Text = "Clear All";
            clearAll.UseVisualStyleBackColor = false;
            clearAll.Click += clearAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(542, 362);
            Controls.Add(clearAll);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(label1);
            Controls.Add(checkListBox);
            Controls.Add(listBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private CheckedListBox checkListBox;
        private Label label1;
        private Button addButton;
        private Button removeButton;
        private Button clearAll;
    }
}
