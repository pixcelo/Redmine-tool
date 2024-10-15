using WinFormsRedmine.Classes;
using WinFormsRedmine.Enums;
using WinFormsRedmine.Models;
using WinFormsRedmine.Views;

namespace WinFormsRedmine
{
    public partial class MainForm : Form
    {
        private readonly IApiAccessor apiAccessor;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="apiAccessor"></param>
        public MainForm(IApiAccessor apiAccessor) : this()
        {
            this.apiAccessor = apiAccessor;

            this.SetUp();

            // �����\��
            this.FetchIssues();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �R���g���[���̏����ݒ�
        /// </summary>
        private void SetUp()
        {
            // Enum�̒l���R���{�{�b�N�X�Ƀo�C���h����
            //this.statusComboBox.DataSource = Enum.GetValues(typeof(TicketStatus));

            // �N���X�̒l���R���{�{�b�N�X�Ƀo�C���h����
            this.statusComboBox.DataSource = new IssueStatuses().List;
            this.statusComboBox.DisplayMember = "Name";
            this.statusComboBox.ValueMember = "Id";
        }

        /// <summary>
        /// �`�P�b�g�����擾����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void fetchButton_Click(object sender, EventArgs e)
        {
            this.FetchIssues();
        }

        /// <summary>
        /// �O���b�h�r���[�̃Z�����_�u���N���b�N���ꂽ�ꍇ�A�ڍ׉�ʂ�\������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void issuesDataGridView_CellContentDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var issueViewModel = (IssueViewModel)this.issuesDataGridView.Rows[e.RowIndex].DataBoundItem;
                var id = issueViewModel.Id.Replace("#", "");
                var issue = await this.apiAccessor.FetchIssue(id);

                using (var form = new DetailForm(issue))
                {
                    form.ShowDialog(this);
                }
            }
        }

        private async void FetchIssues()
        {
            var issueRequest = new IssueRequest()
            {
                TicketId = this.issueIdTextBox.Text,
                TicketStatusId = this.statusComboBox.SelectedValue?.ToString(),
                AssignedTo = "me"
            };

            var issueViewModels = new List<IssueViewModel>();

            if (string.IsNullOrEmpty(issueRequest.TicketId))
            {
                var issues = await this.apiAccessor.FetchIssues(issueRequest);
                issueViewModels.AddRange(issues.Select(issue => new IssueViewModel(issue)));
            }
            else
            {
                var issue = await this.apiAccessor.FetchIssue(issueRequest.TicketId);
                issueViewModels.Add(new IssueViewModel(issue));
            }

            // DataGridView�Ƀo�C���h����
            this.issuesDataGridView.DataSource = issueViewModels;

            // ��̕���������������
            this.issuesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // TODO:         
        // �S���҂��w�肵�Ď擾����
        // ���Ԃ��w�肵�Ď擾����
        // �`�P�b�g�ԍ����w�肵�Ď擾����
        // �e�`�P�b�g�Ɋ֘A���āA�q�`�P�b�g���擾����
        // �`�P�b�g�ꗗ�̍��v���o��
        // �w�肵�����̍H���������`�P�b�g�ꗗ���擾����
    }
}
