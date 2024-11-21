namespace Ux
{
    public partial class CreateExamForm : Form
    {
        private int QuestionIndex = 0;
        private int numberOfQuestions = 0;

        public CreateExamForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (QuestionIndex < numberOfQuestions)
            {
                QuestionIndex++;
                MessageBox.Show("Successfully Created!");
            }
            else
            {
                MessageBox.Show("All questions have been created.");
            }
        }

        private void numberOfChoiceTextbox_TextChanged(object sender, EventArgs e)
        {
            int numberOfChoices = 2;
            numberOfChoices = int.Parse(numberOfChoiceTextbox.Text.ToString());
            if (numberOfChoices < 2 || numberOfChoices > 6)
            {
                MessageBox.Show("Number of choices must be between 2 and 6");
                return;
            }

            numberOfQuestions = int.Parse(numberOfQuestionsTextbox.Text.ToString());
          

            // Clear existing controls
            panelChoices.Controls.Clear();

            // Create a TableLayoutPanel to arrange controls in a grid
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 2,
                RowCount = numberOfChoices,
                AutoSize = true
            };

            // Create a new Label for the question number
            Label questionLabel = new Label
            {
                Text = $"Question {QuestionIndex + 1}:",
                Anchor = AnchorStyles.Right,
                AutoSize = true
            };

            // Create a new TextBox for the corresponding input
            TextBox questionTextBox = new TextBox
            {
                Name = $"txtQuestion{QuestionIndex + 1}",
                Anchor = AnchorStyles.Left,
                PlaceholderText = $"Enter question {QuestionIndex + 1}",
                Width = 400 // Set the width to enlarge the TextBox
            };

            // Add the controls to the TableLayoutPanel
            tableLayoutPanel.Controls.Add(questionLabel, 0, 0);
            tableLayoutPanel.Controls.Add(questionTextBox, 1, 0);

            for (int i = 0; i < numberOfChoices; i++)
            {
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
            }

            // Center the TableLayoutPanel within the panel
            tableLayoutPanel.Anchor = AnchorStyles.None;
            tableLayoutPanel.Location = new Point(
                (panelChoices.ClientSize.Width - tableLayoutPanel.PreferredSize.Width) / 2,
                (panelChoices.ClientSize.Height - tableLayoutPanel.PreferredSize.Height) / 2
            );

            // Add the TableLayoutPanel to the panel
            panelChoices.Controls.Add(tableLayoutPanel);
        }
    }
}
