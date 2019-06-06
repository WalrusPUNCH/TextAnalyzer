namespace TextAnalyzer
{
    partial class Main
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
            this.ChooseFirstButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChooseSecondButton = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.FirstLeftButton = new System.Windows.Forms.Button();
            this.FirstRightButton = new System.Windows.Forms.Button();
            this.SecondRightButton = new System.Windows.Forms.Button();
            this.SecondLeftButton = new System.Windows.Forms.Button();
            this.FirstFilePathBox = new System.Windows.Forms.TextBox();
            this.SecondFilePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountWordsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFirstButton
            // 
            this.ChooseFirstButton.Location = new System.Drawing.Point(152, 537);
            this.ChooseFirstButton.Name = "ChooseFirstButton";
            this.ChooseFirstButton.Size = new System.Drawing.Size(191, 28);
            this.ChooseFirstButton.TabIndex = 0;
            this.ChooseFirstButton.Text = "ChooseFirst";
            this.ChooseFirstButton.UseVisualStyleBackColor = true;
            this.ChooseFirstButton.Click += new System.EventHandler(this.ChooseFirstButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "FileDialog";
            // 
            // ChooseSecondButton
            // 
            this.ChooseSecondButton.Location = new System.Drawing.Point(855, 537);
            this.ChooseSecondButton.Name = "ChooseSecondButton";
            this.ChooseSecondButton.Size = new System.Drawing.Size(182, 28);
            this.ChooseSecondButton.TabIndex = 1;
            this.ChooseSecondButton.Text = "ChooseSecond";
            this.ChooseSecondButton.UseVisualStyleBackColor = true;
            this.ChooseSecondButton.Click += new System.EventHandler(this.ChooseSecondButton_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "FileDialog";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(24, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 435);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(519, 511);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(140, 43);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Перевірка";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox2.Location = new System.Drawing.Point(658, 39);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(500, 435);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // FirstLeftButton
            // 
            this.FirstLeftButton.Location = new System.Drawing.Point(96, 508);
            this.FirstLeftButton.Name = "FirstLeftButton";
            this.FirstLeftButton.Size = new System.Drawing.Size(58, 23);
            this.FirstLeftButton.TabIndex = 5;
            this.FirstLeftButton.Text = "<";
            this.FirstLeftButton.UseVisualStyleBackColor = true;
            this.FirstLeftButton.Click += new System.EventHandler(this.FirstLeftButton_Click);
            // 
            // FirstRightButton
            // 
            this.FirstRightButton.Location = new System.Drawing.Point(342, 508);
            this.FirstRightButton.Name = "FirstRightButton";
            this.FirstRightButton.Size = new System.Drawing.Size(58, 23);
            this.FirstRightButton.TabIndex = 6;
            this.FirstRightButton.Text = ">";
            this.FirstRightButton.UseVisualStyleBackColor = true;
            this.FirstRightButton.Click += new System.EventHandler(this.FirstRightButton_Click);
            // 
            // SecondRightButton
            // 
            this.SecondRightButton.Location = new System.Drawing.Point(1041, 508);
            this.SecondRightButton.Name = "SecondRightButton";
            this.SecondRightButton.Size = new System.Drawing.Size(58, 23);
            this.SecondRightButton.TabIndex = 7;
            this.SecondRightButton.Text = ">";
            this.SecondRightButton.UseVisualStyleBackColor = true;
            this.SecondRightButton.Click += new System.EventHandler(this.SecondRightButton_Click);
            // 
            // SecondLeftButton
            // 
            this.SecondLeftButton.Location = new System.Drawing.Point(801, 508);
            this.SecondLeftButton.Name = "SecondLeftButton";
            this.SecondLeftButton.Size = new System.Drawing.Size(58, 23);
            this.SecondLeftButton.TabIndex = 8;
            this.SecondLeftButton.Text = "<";
            this.SecondLeftButton.UseVisualStyleBackColor = true;
            this.SecondLeftButton.Click += new System.EventHandler(this.SecondLeftButton_Click);
            // 
            // FirstFilePathBox
            // 
            this.FirstFilePathBox.Location = new System.Drawing.Point(67, 478);
            this.FirstFilePathBox.Name = "FirstFilePathBox";
            this.FirstFilePathBox.Size = new System.Drawing.Size(367, 22);
            this.FirstFilePathBox.TabIndex = 9;
            // 
            // SecondFilePathBox
            // 
            this.SecondFilePathBox.Location = new System.Drawing.Point(751, 480);
            this.SecondFilePathBox.Name = "SecondFilePathBox";
            this.SecondFilePathBox.Size = new System.Drawing.Size(382, 22);
            this.SecondFilePathBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Оригінальний текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текст на перевірку:";
            // 
            // CountWordsButton
            // 
            this.CountWordsButton.Location = new System.Drawing.Point(530, 420);
            this.CountWordsButton.Name = "CountWordsButton";
            this.CountWordsButton.Size = new System.Drawing.Size(122, 54);
            this.CountWordsButton.TabIndex = 14;
            this.CountWordsButton.Text = "Порахувати слова";
            this.CountWordsButton.UseVisualStyleBackColor = true;
            this.CountWordsButton.Click += new System.EventHandler(this.CountWordsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 575);
            this.Controls.Add(this.CountWordsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondFilePathBox);
            this.Controls.Add(this.FirstFilePathBox);
            this.Controls.Add(this.SecondLeftButton);
            this.Controls.Add(this.SecondRightButton);
            this.Controls.Add(this.FirstRightButton);
            this.Controls.Add(this.FirstLeftButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ChooseSecondButton);
            this.Controls.Add(this.ChooseFirstButton);
            this.Name = "Main";
            this.Text = "Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFirstButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChooseSecondButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button FirstLeftButton;
        private System.Windows.Forms.Button FirstRightButton;
        private System.Windows.Forms.Button SecondRightButton;
        private System.Windows.Forms.Button SecondLeftButton;
        private System.Windows.Forms.TextBox FirstFilePathBox;
        private System.Windows.Forms.TextBox SecondFilePathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CountWordsButton;
    }
}

