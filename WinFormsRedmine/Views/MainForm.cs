using WinFormsRedmine.Classes;

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
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
