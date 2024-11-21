namespace Ux
{
    public partial class EditExamForm : Form
    {
        private int numberOfQuestions = 0;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SaveButton;
        private Panel panelEdit;
        private Label label1;
        private Label label2;
        private TextBox courseCodeTextbox;
        private TextBox numberTextbox;
        private string courseCode;


        public EditExamForm(string courseCode)
        {
            InitializeComponent();
            this.courseCode = courseCode;
        }

        private void InitializeComponent()
        {
            panelChoices = new Panel();
            SaveButton = new Button();
            panelEdit = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            courseCodeTextbox = new TextBox();
            numberTextbox = new TextBox();
            buttonSave = new Button();
            panelChoices.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelChoices
            // 
            panelChoices.Controls.Add(SaveButton);
            panelChoices.Controls.Add(panelEdit);
            panelChoices.Controls.Add(tableLayoutPanel1);
            panelChoices.Location = new Point(12, 12);
            panelChoices.Name = "panelChoices";
            panelChoices.Size = new Size(776, 397);
            panelChoices.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(458, 318);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // panelEdit
            // 
            panelEdit.Location = new Point(133, 101);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(373, 185);
            panelEdit.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(courseCodeTextbox, 1, 0);
            tableLayoutPanel1.Controls.Add(numberTextbox, 1, 1);
            tableLayoutPanel1.Location = new Point(135, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(242, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "Question Number";
            // 
            // courseCodeTextbox
            // 
            courseCodeTextbox.Location = new Point(124, 3);
            courseCodeTextbox.Name = "courseCodeTextbox";
            courseCodeTextbox.Size = new Size(115, 23);
            courseCodeTextbox.TabIndex = 2;
            // 
            // numberTextbox
            // 
            numberTextbox.Location = new Point(124, 48);
            numberTextbox.Name = "numberTextbox";
            numberTextbox.Size = new Size(115, 23);
            numberTextbox.TabIndex = 3;
            numberTextbox.TextChanged += numberTextbox_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(713, 415);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // EditExamForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(panelChoices);
            Name = "EditExamForm";
            panelChoices.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelChoices;
        private System.Windows.Forms.Button buttonSave;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Saved!");
        }

        private void numberTextbox_TextChanged(object sender, EventArgs e)
        {
            string courseCode = courseCodeTextbox.Text.ToString();
            int number = int.Parse(numberTextbox.Text.ToString());
            int i = 0;


            if (!string.IsNullOrEmpty(courseCode) && number > 0)
            {
                // Clear existing controls
                panelEdit.Controls.Clear();

                // Create a TableLayoutPanel to arrange controls in a grid
                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
                {
                    ColumnCount = 2,
                    RowCount = 1,
                    AutoSize = true
                };

                // Create a new Label for the question number
                Label questionLabel = new Label
                {
                    Text = $"Question {number}:",
                    Anchor = AnchorStyles.Right,
                    AutoSize = true
                };

                // Create a new TextBox for the corresponding input
                TextBox questionTextBox = new TextBox
                {
                    Name = $"txtQuestion{number}",
                    Anchor = AnchorStyles.Left,
                    PlaceholderText = $"Enter question {number}",
                    Width = 400 // Set the width to enlarge the TextBox
                };

                // Add the controls to the TableLayoutPanel
                tableLayoutPanel.Controls.Add(questionLabel, 0, 0);
                tableLayoutPanel.Controls.Add(questionTextBox, 1, 0);

                // Determine the letter for the choice (A, B, C, etc.)
                char choiceLetter = (char)('A' + i);

                // Create a new Label for the choice letter
                Label choiceLabel = new Label
                {
                    Text = $"{choiceLetter}:",
                    Anchor = AnchorStyles.Right,
                    AutoSize = true
                };

                // Create a new TextBox for the corresponding input
                TextBox choiceTextBox = new TextBox
                {
                    Name = $"txtChoice{choiceLetter}",
                    Anchor = AnchorStyles.Left,
                    PlaceholderText = $"Enter choice {choiceLetter}",
                    Width = 400 // Set the width to enlarge the TextBox
                };

                // Add the controls to the TableLayoutPanel
                tableLayoutPanel.Controls.Add(choiceLabel, 0, i + 1);
                tableLayoutPanel.Controls.Add(choiceTextBox, 1, i + 1);


                // Center the TableLayoutPanel within the panel
                tableLayoutPanel.Anchor = AnchorStyles.None;
                tableLayoutPanel.Location = new Point(
                    (panelEdit.ClientSize.Width - tableLayoutPanel.PreferredSize.Width) / 2,
                    (panelEdit.ClientSize.Height - tableLayoutPanel.PreferredSize.Height) / 2
                );

                // Add the TableLayoutPanel to the panel
                panelEdit.Controls.Add(tableLayoutPanel);

            }

        }

        // Rest of the code...
    }


}
