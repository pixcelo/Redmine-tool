namespace WinFormsRedmine
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fetchButton = new Button();
            statusComboBox = new ComboBox();
            issuesDataGridView = new DataGridView();
            issueIdTextBox = new TextBox();
            issueIdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)issuesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // fetchButton
            // 
            fetchButton.Location = new Point(20, 38);
            fetchButton.Name = "fetchButton";
            fetchButton.Size = new Size(75, 23);
            fetchButton.TabIndex = 0;
            fetchButton.Text = "fetch";
            fetchButton.UseVisualStyleBackColor = true;
            fetchButton.Click += fetchButton_Click;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(122, 38);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(96, 23);
            statusComboBox.TabIndex = 1;
            // 
            // issuesDataGridView
            // 
            issuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            issuesDataGridView.Dock = DockStyle.Bottom;
            issuesDataGridView.Location = new Point(0, 88);
            issuesDataGridView.Name = "issuesDataGridView";
            issuesDataGridView.RowHeadersWidth = 51;
            issuesDataGridView.Size = new Size(898, 518);
            issuesDataGridView.TabIndex = 2;
            issuesDataGridView.CellContentDoubleClick += issuesDataGridView_CellContentDoubleClick;
            // 
            // issueIdTextBox
            // 
            issueIdTextBox.Location = new Point(238, 40);
            issueIdTextBox.Margin = new Padding(3, 2, 3, 2);
            issueIdTextBox.Name = "issueIdTextBox";
            issueIdTextBox.Size = new Size(110, 23);
            issueIdTextBox.TabIndex = 3;
            // 
            // issueIdLabel
            // 
            issueIdLabel.AutoSize = true;
            issueIdLabel.Location = new Point(238, 22);
            issueIdLabel.Name = "issueIdLabel";
            issueIdLabel.Size = new Size(18, 15);
            issueIdLabel.TabIndex = 4;
            issueIdLabel.Text = "ID";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 606);
            Controls.Add(issueIdLabel);
            Controls.Add(issueIdTextBox);
            Controls.Add(issuesDataGridView);
            Controls.Add(statusComboBox);
            Controls.Add(fetchButton);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)issuesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fetchButton;
        private ComboBox statusComboBox;
        private DataGridView issuesDataGridView;
        private TextBox issueIdTextBox;
        private Label issueIdLabel;
    }
}
