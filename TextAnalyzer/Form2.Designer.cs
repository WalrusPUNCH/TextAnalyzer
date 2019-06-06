namespace TextAnalyzer
{
    partial class Form2
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
            this.FirstTextGridView = new System.Windows.Forms.DataGridView();
            this.SecondTextGridView = new System.Windows.Forms.DataGridView();
            this.Word2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counter2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Counter1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTextGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTextGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstTextGridView
            // 
            this.FirstTextGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstTextGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word1,
            this.Counter1});
            this.FirstTextGridView.Location = new System.Drawing.Point(36, 43);
            this.FirstTextGridView.Name = "FirstTextGridView";
            this.FirstTextGridView.RowTemplate.Height = 24;
            this.FirstTextGridView.Size = new System.Drawing.Size(322, 395);
            this.FirstTextGridView.TabIndex = 0;
            // 
            // SecondTextGridView
            // 
            this.SecondTextGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondTextGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word2,
            this.Counter2});
            this.SecondTextGridView.Location = new System.Drawing.Point(418, 43);
            this.SecondTextGridView.Name = "SecondTextGridView";
            this.SecondTextGridView.RowTemplate.Height = 24;
            this.SecondTextGridView.Size = new System.Drawing.Size(344, 395);
            this.SecondTextGridView.TabIndex = 1;
            // 
            // Word2
            // 
            this.Word2.HeaderText = "Слово";
            this.Word2.Name = "Word2";
            // 
            // Counter2
            // 
            this.Counter2.HeaderText = "Кількість";
            this.Counter2.Name = "Counter2";
            // 
            // Word1
            // 
            this.Word1.HeaderText = "Слово";
            this.Word1.Name = "Word1";
            // 
            // Counter1
            // 
            this.Counter1.HeaderText = "Кількість";
            this.Counter1.Name = "Counter1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оригінальний текст:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст на перевірку:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondTextGridView);
            this.Controls.Add(this.FirstTextGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.FirstTextGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTextGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FirstTextGridView;
        private System.Windows.Forms.DataGridView SecondTextGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}