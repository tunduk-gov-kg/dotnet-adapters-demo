namespace Consumer.XRoad_End
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.personDataPanel = new System.Windows.Forms.Panel();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.personPinTextBox = new System.Windows.Forms.TextBox();
            this.personBirthDateTextBox = new System.Windows.Forms.TextBox();
            this.personGenderTextBox = new System.Windows.Forms.TextBox();
            this.personPinLabel = new System.Windows.Forms.Label();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.personBirthDateLabel = new System.Windows.Forms.Label();
            this.personGenderLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personPhotoPictureBox)).BeginInit();
            this.personDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personDataPanel);
            this.groupBox1.Controls.Add(this.personPhotoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // personPhotoPictureBox
            // 
            this.personPhotoPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.personPhotoPictureBox.Location = new System.Drawing.Point(6, 25);
            this.personPhotoPictureBox.Name = "personPhotoPictureBox";
            this.personPhotoPictureBox.Size = new System.Drawing.Size(166, 255);
            this.personPhotoPictureBox.TabIndex = 0;
            this.personPhotoPictureBox.TabStop = false;
            // 
            // personDataPanel
            // 
            this.personDataPanel.Controls.Add(this.personGenderLabel);
            this.personDataPanel.Controls.Add(this.personBirthDateLabel);
            this.personDataPanel.Controls.Add(this.personNameLabel);
            this.personDataPanel.Controls.Add(this.personPinLabel);
            this.personDataPanel.Controls.Add(this.personGenderTextBox);
            this.personDataPanel.Controls.Add(this.personBirthDateTextBox);
            this.personDataPanel.Controls.Add(this.personPinTextBox);
            this.personDataPanel.Controls.Add(this.personNameTextBox);
            this.personDataPanel.Location = new System.Drawing.Point(178, 25);
            this.personDataPanel.Name = "personDataPanel";
            this.personDataPanel.Size = new System.Drawing.Size(267, 255);
            this.personDataPanel.TabIndex = 1;
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personNameTextBox.Location = new System.Drawing.Point(83, 86);
            this.personNameTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.ReadOnly = true;
            this.personNameTextBox.Size = new System.Drawing.Size(181, 26);
            this.personNameTextBox.TabIndex = 0;
            // 
            // personPinTextBox
            // 
            this.personPinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personPinTextBox.Location = new System.Drawing.Point(83, 20);
            this.personPinTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.personPinTextBox.Name = "personPinTextBox";
            this.personPinTextBox.ReadOnly = true;
            this.personPinTextBox.Size = new System.Drawing.Size(181, 26);
            this.personPinTextBox.TabIndex = 1;
            // 
            // personBirthDateTextBox
            // 
            this.personBirthDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personBirthDateTextBox.Location = new System.Drawing.Point(83, 152);
            this.personBirthDateTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.personBirthDateTextBox.Name = "personBirthDateTextBox";
            this.personBirthDateTextBox.ReadOnly = true;
            this.personBirthDateTextBox.Size = new System.Drawing.Size(181, 26);
            this.personBirthDateTextBox.TabIndex = 2;
            // 
            // personGenderTextBox
            // 
            this.personGenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personGenderTextBox.Location = new System.Drawing.Point(83, 218);
            this.personGenderTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.personGenderTextBox.Name = "personGenderTextBox";
            this.personGenderTextBox.ReadOnly = true;
            this.personGenderTextBox.Size = new System.Drawing.Size(181, 26);
            this.personGenderTextBox.TabIndex = 3;
            // 
            // personPinLabel
            // 
            this.personPinLabel.AutoSize = true;
            this.personPinLabel.Location = new System.Drawing.Point(3, 22);
            this.personPinLabel.Name = "personPinLabel";
            this.personPinLabel.Size = new System.Drawing.Size(35, 20);
            this.personPinLabel.TabIndex = 4;
            this.personPinLabel.Text = "PIN";
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Location = new System.Drawing.Point(3, 88);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(51, 20);
            this.personNameLabel.TabIndex = 5;
            this.personNameLabel.Text = "Name";
            // 
            // personBirthDateLabel
            // 
            this.personBirthDateLabel.AutoSize = true;
            this.personBirthDateLabel.Location = new System.Drawing.Point(3, 154);
            this.personBirthDateLabel.Name = "personBirthDateLabel";
            this.personBirthDateLabel.Size = new System.Drawing.Size(77, 20);
            this.personBirthDateLabel.TabIndex = 6;
            this.personBirthDateLabel.Text = "BirthDate";
            // 
            // personGenderLabel
            // 
            this.personGenderLabel.AutoSize = true;
            this.personGenderLabel.Location = new System.Drawing.Point(3, 220);
            this.personGenderLabel.Name = "personGenderLabel";
            this.personGenderLabel.Size = new System.Drawing.Size(63, 20);
            this.personGenderLabel.TabIndex = 7;
            this.personGenderLabel.Text = "Gender";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(12, 332);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(188, 26);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(206, 325);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(257, 40);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(475, 398);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Demo X-Road Consumer";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personPhotoPictureBox)).EndInit();
            this.personDataPanel.ResumeLayout(false);
            this.personDataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox personPhotoPictureBox;
        private System.Windows.Forms.Panel personDataPanel;
        private System.Windows.Forms.TextBox personNameTextBox;
        private System.Windows.Forms.TextBox personGenderTextBox;
        private System.Windows.Forms.TextBox personBirthDateTextBox;
        private System.Windows.Forms.TextBox personPinTextBox;
        private System.Windows.Forms.Label personPinLabel;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Label personBirthDateLabel;
        private System.Windows.Forms.Label personGenderLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

