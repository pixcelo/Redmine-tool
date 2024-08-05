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
        /// コンストラクタ
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
        /// コントロールの初期設定
        /// </summary>
        private void SetUp()
        {
            this.statusComboBox.DataSource = Enum.GetValues(typeof(TicketStatus));
        }

        /// <summary>
        /// チケット情報を取得する
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

            // DataGridViewにバインドする
            this.issuesDataGridView.DataSource = issueViewModels;
        }

        // TODO: 
        // ステータスを指定して取得する
        // 担当者を指定して取得する
        // 期間を指定して取得する
        // チケット番号を指定して取得する
        // 親チケットに関連して、子チケットを取得する
    }
}
