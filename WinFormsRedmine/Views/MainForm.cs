using System.Linq;
using WinFormsRedmine.Classes;
using WinFormsRedmine.Enums;
using WinFormsRedmine.Models;

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
            this.statusComboBox.DataSource = Enum.GetValues(typeof(TicketStatus));
        }

        /// <summary>
        /// �`�P�b�g�����擾����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void fetchButton_Click(object sender, EventArgs e)
        {
            var issueRequest = new IssueRequest()
            {
                TicketStatus = this.statusComboBox.Text,
                AssignedTo = "me"
            };

            var issues = await this.apiAccessor.Fetch(issueRequest);
            
            var issueViewModels = issues.Select(
                issue => new IssueViewModel(
                    issue.Id,
                    issue.Subject,
                    issue.Tracker,
                    issue.Status,
                    issue.AssignedTo,
                    issue.FixedVersion,
                    issue.Description,
                    issue.CustomFields
            )).ToList();

            // DataGridView�Ƀo�C���h����
            this.issuesDataGridView.DataSource = issueViewModels;
        }

        // TODO: 
        // �X�e�[�^�X���w�肵�Ď擾����
        // �S���҂��w�肵�Ď擾����
        // ���Ԃ��w�肵�Ď擾����
        // �`�P�b�g�ԍ����w�肵�Ď擾����
        // �e�`�P�b�g�Ɋ֘A���āA�q�`�P�b�g���擾����
    }
}
