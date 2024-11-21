using System;
using System.Windows.Forms;

namespace Ux
{
    public partial class InsertAnswerForm : Form
    {
        public InsertAnswerForm()
        {
            InitializeComponent();
        }
        private void course_code_TextChanged(object sender, EventArgs e)
        {

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
                {
                    ColumnCount = 2,
                    RowCount = 10,
                    Dock = DockStyle.Fill,
                    AutoSize = true
                };

                for (int i = 0; i < 2; i++)
                {
                    Label questionLabel = new Label
                    {
                        Text = $"Question {i + 1}:",
                        AutoSize = true
                    };
                    TextBox questionTextBox = new TextBox
                    {
                        Name = $"questionTextBox{i + 1}",
                        Width = 200
                    };

                    Label answerLabel = new Label
                    {
                        Text = $"Answer {i + 1}:",
                        AutoSize = true
                    };
                    TextBox answerTextBox = new TextBox
                    {
                        Name = $"answerTextBox{i + 1}",
                        Width = 200
                    };

                    tableLayoutPanel.Controls.Add(questionLabel, 0, i * 2);
                    tableLayoutPanel.Controls.Add(questionTextBox, 1, i * 2);
                    tableLayoutPanel.Controls.Add(answerLabel, 0, i * 2 + 1);
                    tableLayoutPanel.Controls.Add(answerTextBox, 1, i * 2 + 1);
                }

                panel_Insert.Controls.Add(tableLayoutPanel);
            }
        }
}
