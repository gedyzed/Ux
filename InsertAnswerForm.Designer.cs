namespace Ux
{
    partial class InsertAnswerForm
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
            panelInsert = new Panel();
            panel_Insert = new Panel();
            course_code = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            panelInsert.SuspendLayout();
            SuspendLayout();
            // 
            // panelInsert
            // 
            panelInsert.Controls.Add(panel_Insert);
            panelInsert.Controls.Add(course_code);
            panelInsert.Controls.Add(label1);
            panelInsert.Controls.Add(buttonSave);
            panelInsert.Location = new Point(12, 12);
            panelInsert.Name = "panelInsert";
            panelInsert.Size = new Size(776, 426);
            panelInsert.TabIndex = 0;
            // 
            // panel_Insert
            // 
            panel_Insert.Location = new Point(74, 166);
            panel_Insert.Name = "panel_Insert";
            panel_Insert.Size = new Size(272, 157);
            panel_Insert.TabIndex = 7;
            // 
            // course_code
            // 
            course_code.Location = new Point(185, 91);
            course_code.Name = "course_code";
            course_code.Size = new Size(103, 23);
            course_code.TabIndex = 6;
            course_code.TextChanged += course_code_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 99);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 5;
            label1.Text = "Course Code";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(685, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // InsertAnswerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 450);
            Controls.Add(panelInsert);
            Name = "InsertAnswerForm";
            Text = "Insert Answer";
            panelInsert.ResumeLayout(false);
            panelInsert.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Button buttonSave;
        private Panel panel_Insert;
        private TextBox course_code;
        private Label label1;
    }
}

