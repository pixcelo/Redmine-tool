using WinFormsRedmine.Models;

namespace WinFormsRedmine.Views
{
    public partial class DetailForm : Form
    {
        private readonly IssueViewModel viewModel;

        public DetailForm(Issue issue) : this()
        {
            this.viewModel = new IssueViewModel(issue);

            this.SetUp();
        }

        public DetailForm()
        {
            InitializeComponent();
        }

        private async void SetUp()
        {
            this.subjectTextBox.Text = $"{this.viewModel.Id} {this.viewModel.Subject}";

            //this.idLabel.Text = this.viewModel.Id.ToString();
            //this.subjectLabel.Text = this.viewModel.Subject;
            //this.trackerLabel.Text = this.viewModel.TrackerName;
            //this.statusLabel.Text = this.viewModel.StatusName;
            //this.assignedToLabel.Text = this.viewModel.AssignedName;
            //this.fixedVersionLabel.Text = this.viewModel.FixedVersion;
            this.descriptionTextBox.Text = this.viewModel.Description;
            //this.customFieldsTextBox.Text = this.viewModel.CustomFields;
        }

        /// <summary>
        /// クリップボードにコピーする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.subjectTextBox.Text);
        }
    }
}
