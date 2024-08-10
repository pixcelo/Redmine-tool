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
                TicketId = this.issueIdTextBox.Text,
                TicketStatus = this.statusComboBox.Text,
                AssignedTo = "me"
            };

            var issues = await this.apiAccessor.FetchIssues(issueRequest);
            var issueViewModels = issues.Select(issue => new IssueViewModel(issue)).ToList();

            // DataGridViewにバインドする
            this.issuesDataGridView.DataSource = issueViewModels;
        }

        /// <summary>
        /// グリッドビューのセルがダブルクリックされた場合、詳細画面を表示する
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
                    form.ShowDialog();
                }
            }
        }

        // TODO: 
        // ステータスを指定して取得する
        // 担当者を指定して取得する
        // 期間を指定して取得する
        // チケット番号を指定して取得する
        // 親チケットに関連して、子チケットを取得する
        // チケット一覧の合計を出す
    }
}
