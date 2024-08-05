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
            issuesDataGridView.Location = new Point(0, 82);
            issuesDataGridView.Name = "issuesDataGridView";
            issuesDataGridView.Size = new Size(774, 300);
            issuesDataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 382);
            Controls.Add(issuesDataGridView);
            Controls.Add(statusComboBox);
            Controls.Add(fetchButton);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)issuesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button fetchButton;
        private ComboBox statusComboBox;
        private DataGridView issuesDataGridView;
    }
}
