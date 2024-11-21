namespace Ux
{
    partial class EditExamForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelChoices;
        private System.Windows.Forms.Button buttonSave;

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
            this.panelChoices = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelChoices
            // 
            this.panelChoices.AutoScroll = true;
            this.panelChoices.Location = new System.Drawing.Point(12, 12);
            this.panelChoices.Name = "panelChoices";
            this.panelChoices.Size = new System.Drawing.Size(760, 400);
            this.panelChoices.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(697, 418);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // EditExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelChoices);
            this.Name = "EditExamForm";
            this.Text = "Edit Exam";
            this.ResumeLayout(false);
        }
    }
}
