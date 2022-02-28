
namespace Programming
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
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultParseTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.ValueParsingLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnamsTabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.EnamsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsTabPage.Size = new System.Drawing.Size(874, 595);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ResultParseTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ValueParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(8, 396);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(485, 196);
            this.WeekdayParsingGroupBox.TabIndex = 4;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ResultParseTextBox
            // 
            this.ResultParseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultParseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultParseTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ResultParseTextBox.Location = new System.Drawing.Point(35, 105);
            this.ResultParseTextBox.Name = "ResultParseTextBox";
            this.ResultParseTextBox.Size = new System.Drawing.Size(315, 20);
            this.ResultParseTextBox.TabIndex = 3;
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.WeekdayParsingButton.Location = new System.Drawing.Point(356, 72);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(94, 27);
            this.WeekdayParsingButton.TabIndex = 2;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // ValueParsingLabel
            // 
            this.ValueParsingLabel.AutoSize = true;
            this.ValueParsingLabel.Location = new System.Drawing.Point(31, 49);
            this.ValueParsingLabel.Name = "ValueParsingLabel";
            this.ValueParsingLabel.Size = new System.Drawing.Size(158, 20);
            this.ValueParsingLabel.TabIndex = 1;
            this.ValueParsingLabel.Text = "Type value for parsing:";
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(32, 72);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(318, 27);
            this.WeekdayParsingTextBox.TabIndex = 0;
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesLabel);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsLabel);
            this.EnumerationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(8, 4);
            this.EnumerationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(858, 385);
            this.EnumerationsGroupBox.TabIndex = 3;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(467, 45);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(68, 20);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(250, 45);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(100, 20);
            this.ValuesLabel.TabIndex = 4;
            this.ValuesLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(32, 45);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(149, 20);
            this.EnumsLabel.TabIndex = 3;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(468, 69);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.Size = new System.Drawing.Size(114, 27);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(250, 69);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(212, 284);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colour",
            "Genre",
            "SmartphoneManufacturers",
            "StudentsFormOfStudy",
            "TimeOfYear",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(32, 69);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(212, 284);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnamsTabControl
            // 
            this.EnamsTabControl.Controls.Add(this.EnumsTabPage);
            this.EnamsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnamsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnamsTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnamsTabControl.Name = "EnamsTabControl";
            this.EnamsTabControl.SelectedIndex = 0;
            this.EnamsTabControl.Size = new System.Drawing.Size(882, 628);
            this.EnamsTabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 628);
            this.Controls.Add(this.EnamsTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.EnumsTabPage.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.EnumerationsGroupBox.PerformLayout();
            this.EnamsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TabControl EnamsTabControl;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label ValueParsingLabel;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.Button WeekdayParsingButton;
        private System.Windows.Forms.TextBox ResultParseTextBox;
    }
}

