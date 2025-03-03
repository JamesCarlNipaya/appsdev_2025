namespace SimpleFormsApp
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
            firstName = new TextBox();
            lastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ClickButton = new Button();
            middleName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.BackColor = SystemColors.ScrollBar;
            firstName.Location = new Point(65, 151);
            firstName.Name = "firstName";
            firstName.Size = new Size(173, 23);
            firstName.TabIndex = 0;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // lastName
            // 
            lastName.BackColor = SystemColors.ScrollBar;
            lastName.Location = new Point(65, 263);
            lastName.Name = "lastName";
            lastName.Size = new Size(173, 23);
            lastName.TabIndex = 1;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 130);
            label1.Name = "label1";
            label1.Size = new Size(104, 18);
            label1.TabIndex = 4;
            label1.Text = "FirstName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 242);
            label2.Name = "label2";
            label2.Size = new Size(97, 18);
            label2.TabIndex = 5;
            label2.Text = "LastName:";
            // 
            // ClickButton
            // 
            ClickButton.BackColor = Color.MediumSlateBlue;
            ClickButton.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ClickButton.Location = new Point(66, 311);
            ClickButton.Name = "ClickButton";
            ClickButton.Size = new Size(96, 34);
            ClickButton.TabIndex = 8;
            ClickButton.Text = "Submit";
            ClickButton.UseVisualStyleBackColor = false;
            ClickButton.Click += clickButton_Click;
            // 
            // middleName
            // 
            middleName.BackColor = SystemColors.ScrollBar;
            middleName.Location = new Point(65, 207);
            middleName.Name = "middleName";
            middleName.Size = new Size(173, 23);
            middleName.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 186);
            label3.Name = "label3";
            label3.Size = new Size(122, 18);
            label3.TabIndex = 10;
            label3.Text = "MiddleName:";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(middleName);
            Controls.Add(ClickButton);
            Controls.Add(label2);
            Controls.Add(firstName);
            Controls.Add(lastName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private TextBox lastName;
        private Label label1;
        private Label label2;
        private Button ClickButton;
        private TextBox middleName;
        private Label label3;
    }
}
