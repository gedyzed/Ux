namespace Ux
{
    partial class CreateExamForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            textBoxTitle = new TextBox();
            labelDescription = new Label();
            buttonCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            numberOfQuestionsTextbox = new TextBox();
            questionLabel = new Label();
            panel1 = new Panel();
            numberOfChoiceTextbox = new TextBox();
            NumberOfChoice = new Label();
            panelChoices = new FlowLayoutPanel();
            NumberOfChoicesLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(4, 0);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(70, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Department";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(116, 3);
            textBoxTitle.Margin = new Padding(4, 3, 4, 3);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(197, 23);
            textBoxTitle.TabIndex = 1;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(13, 150);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(0, 15);
            labelDescription.TabIndex = 2;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(584, 261);
            buttonCreate.Margin = new Padding(4, 3, 4, 3);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(88, 27);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 6;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Course Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 8;
            label3.Text = "Number of Questions";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.405407F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.5946F));
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBoxTitle, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(319, 82);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.0532532F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.9467468F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 0);
            tableLayoutPanel2.Controls.Add(numberOfQuestionsTextbox, 1, 1);
            tableLayoutPanel2.Location = new Point(350, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(338, 82);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 9;
            // 
            // numberOfQuestionsTextbox
            // 
            numberOfQuestionsTextbox.Location = new Point(135, 44);
            numberOfQuestionsTextbox.Name = "numberOfQuestionsTextbox";
            numberOfQuestionsTextbox.Size = new Size(199, 23);
            numberOfQuestionsTextbox.TabIndex = 10;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(26, 34);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(0, 15);
            questionLabel.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(numberOfChoiceTextbox);
            panel1.Controls.Add(NumberOfChoice);
            panel1.Controls.Add(panelChoices);
            panel1.Controls.Add(NumberOfChoicesLabel);
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(questionLabel);
            panel1.Location = new Point(12, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 288);
            panel1.TabIndex = 12;
            // 
            // numberOfChoiceTextbox
            // 
            numberOfChoiceTextbox.Location = new Point(460, 9);
            numberOfChoiceTextbox.Name = "numberOfChoiceTextbox";
            numberOfChoiceTextbox.Size = new Size(212, 23);
            numberOfChoiceTextbox.TabIndex = 19;
            numberOfChoiceTextbox.TextChanged += numberOfChoiceTextbox_TextChanged;
            // 
            // NumberOfChoice
            // 
            NumberOfChoice.AutoSize = true;
            NumberOfChoice.Location = new Point(338, 17);
            NumberOfChoice.Name = "NumberOfChoice";
            NumberOfChoice.Size = new Size(115, 15);
            NumberOfChoice.TabIndex = 18;
            NumberOfChoice.Text = "Number Of Choices ";
            // 
            // panelChoices
            // 
            panelChoices.Location = new Point(171, 50);
            panelChoices.Name = "panelChoices";
            panelChoices.Size = new Size(480, 193);
            panelChoices.TabIndex = 17;
            // 
            // NumberOfChoicesLabel
            // 
            NumberOfChoicesLabel.AutoSize = true;
            NumberOfChoicesLabel.Location = new Point(358, 10);
            NumberOfChoicesLabel.Name = "NumberOfChoicesLabel";
            NumberOfChoicesLabel.Size = new Size(0, 15);
            NumberOfChoicesLabel.TabIndex = 16;
            // 
            // CreateExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 400);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelDescription);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CreateExamForm";
            Text = "Create Exam";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonCreate;
        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TextBox numberOfQuestionsTextbox;
        private Label questionLabel;
        private Panel panel1;
        private Label NumberOfChoicesLabel;
        private FlowLayoutPanel panelChoices;
        private TextBox numberOfChoiceTextbox;
        private Label NumberOfChoice;
    }
}
