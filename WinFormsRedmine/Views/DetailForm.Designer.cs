namespace WinFormsRedmine.Views
{
    partial class DetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            descriptionTextBox = new TextBox();
            subjectTextBox = new TextBox();
            copyButton = new Button();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(73, 192);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(540, 338);
            descriptionTextBox.TabIndex = 0;
            // 
            // subjectTextBox
            // 
            subjectTextBox.Location = new Point(73, 39);
            subjectTextBox.Name = "subjectTextBox";
            subjectTextBox.Size = new Size(540, 23);
            subjectTextBox.TabIndex = 1;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(619, 38);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(75, 23);
            copyButton.TabIndex = 2;
            copyButton.Text = "copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // DetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(copyButton);
            Controls.Add(subjectTextBox);
            Controls.Add(descriptionTextBox);
            Name = "DetailForm";
            Text = "DetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionTextBox;
        private TextBox subjectTextBox;
        private Button copyButton;
    }
}