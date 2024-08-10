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
            this.fetchButton = new Button();
            this.statusComboBox = new ComboBox();
            this.issuesDataGridView = new DataGridView();
            this.issueIdTextBox = new TextBox();
            this.issueIdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)this.issuesDataGridView).BeginInit();
            this.SuspendLayout();
            // 
            // fetchButton
            // 
            this.fetchButton.Location = new Point(23, 51);
            this.fetchButton.Margin = new Padding(3, 4, 3, 4);
            this.fetchButton.Name = "fetchButton";
            this.fetchButton.Size = new Size(86, 31);
            this.fetchButton.TabIndex = 0;
            this.fetchButton.Text = "fetch";
            this.fetchButton.UseVisualStyleBackColor = true;
            this.fetchButton.Click += this.fetchButton_Click;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new Point(139, 51);
            this.statusComboBox.Margin = new Padding(3, 4, 3, 4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new Size(109, 28);
            this.statusComboBox.TabIndex = 1;
            // 
            // issuesDataGridView
            // 
            this.issuesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuesDataGridView.Dock = DockStyle.Bottom;
            this.issuesDataGridView.Location = new Point(0, 109);
            this.issuesDataGridView.Margin = new Padding(3, 4, 3, 4);
            this.issuesDataGridView.Name = "issuesDataGridView";
            this.issuesDataGridView.RowHeadersWidth = 51;
            this.issuesDataGridView.Size = new Size(885, 400);
            this.issuesDataGridView.TabIndex = 2;
            this.issuesDataGridView.CellContentDoubleClick += this.issuesDataGridView_CellContentDoubleClick;
            // 
            // issueIdTextBox
            // 
            this.issueIdTextBox.Location = new Point(272, 53);
            this.issueIdTextBox.Name = "issueIdTextBox";
            this.issueIdTextBox.Size = new Size(125, 27);
            this.issueIdTextBox.TabIndex = 3;
            // 
            // issueIdLabel
            // 
            this.issueIdLabel.AutoSize = true;
            this.issueIdLabel.Location = new Point(272, 30);
            this.issueIdLabel.Name = "issueIdLabel";
            this.issueIdLabel.Size = new Size(24, 20);
            this.issueIdLabel.TabIndex = 4;
            this.issueIdLabel.Text = "ID";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(885, 509);
            this.Controls.Add(this.issueIdLabel);
            this.Controls.Add(this.issueIdTextBox);
            this.Controls.Add(this.issuesDataGridView);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.fetchButton);
            this.Margin = new Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)this.issuesDataGridView).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button fetchButton;
        private ComboBox statusComboBox;
        private DataGridView issuesDataGridView;
        private TextBox issueIdTextBox;
        private Label issueIdLabel;
    }
}
