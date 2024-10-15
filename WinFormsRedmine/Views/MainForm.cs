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

            // 初期表示
            this.FetchIssues();
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
            // Enumの値をコンボボックスにバインドする
            //this.statusComboBox.DataSource = Enum.GetValues(typeof(TicketStatus));

            // クラスの値をコンボボックスにバインドする
            this.statusComboBox.DataSource = new IssueStatuses().List;
            this.statusComboBox.DisplayMember = "Name";
            this.statusComboBox.ValueMember = "Id";
        }

        /// <summary>
        /// チケット情報を取得する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void fetchButton_Click(object sender, EventArgs e)
        {
            this.FetchIssues();
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

            // DataGridViewにバインドする
            this.issuesDataGridView.DataSource = issueViewModels;

            // 列の幅を自動調整する
            this.issuesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        // TODO:         
        // 担当者を指定して取得する
        // 期間を指定して取得する
        // チケット番号を指定して取得する
        // 親チケットに関連して、子チケットを取得する
        // チケット一覧の合計を出す
        // 指定した日の工数がついたチケット一覧を取得する
    }
}
