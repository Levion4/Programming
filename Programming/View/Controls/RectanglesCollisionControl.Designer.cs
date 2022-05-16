
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.HeightRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.YRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.XRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.IdRectanglePanelTextBox = new System.Windows.Forms.TextBox();
            this.HeightRectanglePanelLabel = new System.Windows.Forms.Label();
            this.WidthRectanglePanelLabel = new System.Windows.Forms.Label();
            this.YRectanglePanelLable = new System.Windows.Forms.Label();
            this.XRectanglePanelLabel = new System.Windows.Forms.Label();
            this.IdRectanglePanelLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectanglesButton = new System.Windows.Forms.Button();
            this.AddRectanglesButton = new System.Windows.Forms.Button();
            this.RectanglesPanelLabel = new System.Windows.Forms.Label();
            this.RectanglesPanelListBox = new System.Windows.Forms.ListBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(285, 10);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(475, 532);
            this.RectanglesPanel.TabIndex = 31;
            // 
            // HeightRectanglePanelTextBox
            // 
            this.HeightRectanglePanelTextBox.Location = new System.Drawing.Point(58, 387);
            this.HeightRectanglePanelTextBox.Name = "HeightRectanglePanelTextBox";
            this.HeightRectanglePanelTextBox.Size = new System.Drawing.Size(100, 23);
            this.HeightRectanglePanelTextBox.TabIndex = 30;
            this.HeightRectanglePanelTextBox.TextChanged += new System.EventHandler(this.HeightRectanglePanelTextBox_TextChanged);
            // 
            // WidthRectanglePanelTextBox
            // 
            this.WidthRectanglePanelTextBox.Location = new System.Drawing.Point(58, 357);
            this.WidthRectanglePanelTextBox.Name = "WidthRectanglePanelTextBox";
            this.WidthRectanglePanelTextBox.Size = new System.Drawing.Size(100, 23);
            this.WidthRectanglePanelTextBox.TabIndex = 29;
            this.WidthRectanglePanelTextBox.TextChanged += new System.EventHandler(this.WidthRectanglePanelTextBox_TextChanged);
            // 
            // YRectanglePanelTextBox
            // 
            this.YRectanglePanelTextBox.Location = new System.Drawing.Point(58, 328);
            this.YRectanglePanelTextBox.Name = "YRectanglePanelTextBox";
            this.YRectanglePanelTextBox.Size = new System.Drawing.Size(100, 23);
            this.YRectanglePanelTextBox.TabIndex = 28;
            this.YRectanglePanelTextBox.TextChanged += new System.EventHandler(this.YRectanglePanelTextBox_TextChanged);
            // 
            // XRectanglePanelTextBox
            // 
            this.XRectanglePanelTextBox.Location = new System.Drawing.Point(58, 299);
            this.XRectanglePanelTextBox.Name = "XRectanglePanelTextBox";
            this.XRectanglePanelTextBox.Size = new System.Drawing.Size(100, 23);
            this.XRectanglePanelTextBox.TabIndex = 27;
            this.XRectanglePanelTextBox.TextChanged += new System.EventHandler(this.XRectanglePanelTextBox_TextChanged);
            // 
            // IdRectanglePanelTextBox
            // 
            this.IdRectanglePanelTextBox.Location = new System.Drawing.Point(58, 270);
            this.IdRectanglePanelTextBox.Name = "IdRectanglePanelTextBox";
            this.IdRectanglePanelTextBox.ReadOnly = true;
            this.IdRectanglePanelTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdRectanglePanelTextBox.TabIndex = 26;
            // 
            // HeightRectanglePanelLabel
            // 
            this.HeightRectanglePanelLabel.AutoSize = true;
            this.HeightRectanglePanelLabel.Location = new System.Drawing.Point(6, 390);
            this.HeightRectanglePanelLabel.Name = "HeightRectanglePanelLabel";
            this.HeightRectanglePanelLabel.Size = new System.Drawing.Size(46, 15);
            this.HeightRectanglePanelLabel.TabIndex = 25;
            this.HeightRectanglePanelLabel.Text = "Height:";
            // 
            // WidthRectanglePanelLabel
            // 
            this.WidthRectanglePanelLabel.AutoSize = true;
            this.WidthRectanglePanelLabel.Location = new System.Drawing.Point(10, 360);
            this.WidthRectanglePanelLabel.Name = "WidthRectanglePanelLabel";
            this.WidthRectanglePanelLabel.Size = new System.Drawing.Size(42, 15);
            this.WidthRectanglePanelLabel.TabIndex = 24;
            this.WidthRectanglePanelLabel.Text = "Width:";
            // 
            // YRectanglePanelLable
            // 
            this.YRectanglePanelLable.AutoSize = true;
            this.YRectanglePanelLable.Location = new System.Drawing.Point(35, 331);
            this.YRectanglePanelLable.Name = "YRectanglePanelLable";
            this.YRectanglePanelLable.Size = new System.Drawing.Size(17, 15);
            this.YRectanglePanelLable.TabIndex = 23;
            this.YRectanglePanelLable.Text = "Y:";
            // 
            // XRectanglePanelLabel
            // 
            this.XRectanglePanelLabel.AutoSize = true;
            this.XRectanglePanelLabel.Location = new System.Drawing.Point(35, 302);
            this.XRectanglePanelLabel.Name = "XRectanglePanelLabel";
            this.XRectanglePanelLabel.Size = new System.Drawing.Size(17, 15);
            this.XRectanglePanelLabel.TabIndex = 22;
            this.XRectanglePanelLabel.Text = "X:";
            // 
            // IdRectanglePanelLabel
            // 
            this.IdRectanglePanelLabel.AutoSize = true;
            this.IdRectanglePanelLabel.Location = new System.Drawing.Point(32, 273);
            this.IdRectanglePanelLabel.Name = "IdRectanglePanelLabel";
            this.IdRectanglePanelLabel.Size = new System.Drawing.Size(20, 15);
            this.IdRectanglePanelLabel.TabIndex = 21;
            this.IdRectanglePanelLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(3, 249);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 20;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RemoveRectanglesButton
            // 
            this.RemoveRectanglesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveRectanglesButton.BackgroundImage")));
            this.RemoveRectanglesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RemoveRectanglesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectanglesButton.Location = new System.Drawing.Point(136, 209);
            this.RemoveRectanglesButton.Name = "RemoveRectanglesButton";
            this.RemoveRectanglesButton.Size = new System.Drawing.Size(28, 28);
            this.RemoveRectanglesButton.TabIndex = 19;
            this.RemoveRectanglesButton.UseVisualStyleBackColor = true;
            this.RemoveRectanglesButton.Click += new System.EventHandler(this.RemoveRectanglesButton_Click);
            // 
            // AddRectanglesButton
            // 
            this.AddRectanglesButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectanglesButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddRectanglesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectanglesButton.Location = new System.Drawing.Point(42, 209);
            this.AddRectanglesButton.Name = "AddRectanglesButton";
            this.AddRectanglesButton.Size = new System.Drawing.Size(28, 28);
            this.AddRectanglesButton.TabIndex = 18;
            this.AddRectanglesButton.UseVisualStyleBackColor = true;
            this.AddRectanglesButton.Click += new System.EventHandler(this.AddRectanglesButton_Click);
            // 
            // RectanglesPanelLabel
            // 
            this.RectanglesPanelLabel.AutoSize = true;
            this.RectanglesPanelLabel.Location = new System.Drawing.Point(3, 16);
            this.RectanglesPanelLabel.Name = "RectanglesPanelLabel";
            this.RectanglesPanelLabel.Size = new System.Drawing.Size(67, 15);
            this.RectanglesPanelLabel.TabIndex = 17;
            this.RectanglesPanelLabel.Text = "Rectangles:";
            // 
            // RectanglesPanelListBox
            // 
            this.RectanglesPanelListBox.FormattingEnabled = true;
            this.RectanglesPanelListBox.ItemHeight = 15;
            this.RectanglesPanelListBox.Location = new System.Drawing.Point(3, 34);
            this.RectanglesPanelListBox.Name = "RectanglesPanelListBox";
            this.RectanglesPanelListBox.Size = new System.Drawing.Size(276, 169);
            this.RectanglesPanelListBox.TabIndex = 16;
            this.RectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesPanel);
            this.Controls.Add(this.HeightRectanglePanelTextBox);
            this.Controls.Add(this.WidthRectanglePanelTextBox);
            this.Controls.Add(this.YRectanglePanelTextBox);
            this.Controls.Add(this.XRectanglePanelTextBox);
            this.Controls.Add(this.IdRectanglePanelTextBox);
            this.Controls.Add(this.HeightRectanglePanelLabel);
            this.Controls.Add(this.WidthRectanglePanelLabel);
            this.Controls.Add(this.YRectanglePanelLable);
            this.Controls.Add(this.XRectanglePanelLabel);
            this.Controls.Add(this.IdRectanglePanelLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RemoveRectanglesButton);
            this.Controls.Add(this.AddRectanglesButton);
            this.Controls.Add(this.RectanglesPanelLabel);
            this.Controls.Add(this.RectanglesPanelListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(763, 545);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.TextBox HeightRectanglePanelTextBox;
        private System.Windows.Forms.TextBox WidthRectanglePanelTextBox;
        private System.Windows.Forms.TextBox YRectanglePanelTextBox;
        private System.Windows.Forms.TextBox XRectanglePanelTextBox;
        private System.Windows.Forms.TextBox IdRectanglePanelTextBox;
        private System.Windows.Forms.Label HeightRectanglePanelLabel;
        private System.Windows.Forms.Label WidthRectanglePanelLabel;
        private System.Windows.Forms.Label YRectanglePanelLable;
        private System.Windows.Forms.Label XRectanglePanelLabel;
        private System.Windows.Forms.Label IdRectanglePanelLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Button RemoveRectanglesButton;
        private System.Windows.Forms.Button AddRectanglesButton;
        private System.Windows.Forms.Label RectanglesPanelLabel;
        private System.Windows.Forms.ListBox RectanglesPanelListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
