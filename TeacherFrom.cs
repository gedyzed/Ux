namespace Ux
{
    public partial class TeacherFrom : Form
    {
        public TeacherFrom()
        {
            InitializeComponent();
            this.Text = "Teacher Page";
            LoadFormIntoPanel(new CreateExamForm());
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new CreateExamForm());
        }
        private void LoadFormIntoPanel(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(form);
            form.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new EditExamForm("CS101")); // Pass the required 'courseCode' parameter
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFormIntoPanel(new InsertAnswerForm());

        }
    }
}
