namespace WordHelper
{
    partial class ReplaceInFiles
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
            this.button_selectFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_folderPath = new System.Windows.Forms.TextBox();
            this.checkedListBox_files = new System.Windows.Forms.CheckedListBox();
            this.button_disselectall = new System.Windows.Forms.Button();
            this.button_selectall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.richTextBox_status = new System.Windows.Forms.RichTextBox();
            this.textBox_originText = new System.Windows.Forms.TextBox();
            this.textBox_replaceText = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_selectResult = new System.Windows.Forms.Button();
            this.groupBox_set = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_set.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_selectFolder
            // 
            this.button_selectFolder.Location = new System.Drawing.Point(658, 25);
            this.button_selectFolder.Name = "button_selectFolder";
            this.button_selectFolder.Size = new System.Drawing.Size(75, 23);
            this.button_selectFolder.TabIndex = 0;
            this.button_selectFolder.Text = "选择";
            this.button_selectFolder.UseVisualStyleBackColor = true;
            this.button_selectFolder.Click += new System.EventHandler(this.button_selectFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word文件夹目录：";
            // 
            // textBox_folderPath
            // 
            this.textBox_folderPath.Location = new System.Drawing.Point(111, 25);
            this.textBox_folderPath.Name = "textBox_folderPath";
            this.textBox_folderPath.Size = new System.Drawing.Size(542, 21);
            this.textBox_folderPath.TabIndex = 2;
            this.textBox_folderPath.TextChanged += new System.EventHandler(this.textBox_folderPath_TextChanged);
            // 
            // checkedListBox_files
            // 
            this.checkedListBox_files.FormattingEnabled = true;
            this.checkedListBox_files.Location = new System.Drawing.Point(6, 98);
            this.checkedListBox_files.Name = "checkedListBox_files";
            this.checkedListBox_files.Size = new System.Drawing.Size(728, 292);
            this.checkedListBox_files.TabIndex = 3;
            // 
            // button_disselectall
            // 
            this.button_disselectall.Location = new System.Drawing.Point(658, 396);
            this.button_disselectall.Name = "button_disselectall";
            this.button_disselectall.Size = new System.Drawing.Size(75, 23);
            this.button_disselectall.TabIndex = 9;
            this.button_disselectall.Text = "DeselectAll";
            this.button_disselectall.UseVisualStyleBackColor = true;
            this.button_disselectall.Click += new System.EventHandler(this.button_disselectall_Click);
            // 
            // button_selectall
            // 
            this.button_selectall.Location = new System.Drawing.Point(566, 396);
            this.button_selectall.Name = "button_selectall";
            this.button_selectall.Size = new System.Drawing.Size(75, 23);
            this.button_selectall.TabIndex = 8;
            this.button_selectall.Text = "SelectAll";
            this.button_selectall.UseVisualStyleBackColor = true;
            this.button_selectall.Click += new System.EventHandler(this.button_selectall_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "源字符串：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "新字符串：";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(566, 428);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 48);
            this.button_search.TabIndex = 12;
            this.button_search.Text = "查找";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // richTextBox_status
            // 
            this.richTextBox_status.Location = new System.Drawing.Point(8, 20);
            this.richTextBox_status.Name = "richTextBox_status";
            this.richTextBox_status.ReadOnly = true;
            this.richTextBox_status.Size = new System.Drawing.Size(725, 167);
            this.richTextBox_status.TabIndex = 13;
            this.richTextBox_status.Text = "";
            // 
            // textBox_originText
            // 
            this.textBox_originText.Location = new System.Drawing.Point(77, 428);
            this.textBox_originText.Name = "textBox_originText";
            this.textBox_originText.Size = new System.Drawing.Size(468, 21);
            this.textBox_originText.TabIndex = 14;
            this.textBox_originText.TextChanged += new System.EventHandler(this.textBox_originText_TextChanged);
            // 
            // textBox_replaceText
            // 
            this.textBox_replaceText.Location = new System.Drawing.Point(77, 455);
            this.textBox_replaceText.Name = "textBox_replaceText";
            this.textBox_replaceText.Size = new System.Drawing.Size(468, 21);
            this.textBox_replaceText.TabIndex = 15;
            this.textBox_replaceText.TextChanged += new System.EventHandler(this.textBox_replaceText_TextChanged);
            // 
            // button_replace
            // 
            this.button_replace.Location = new System.Drawing.Point(658, 428);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(75, 48);
            this.button_replace.TabIndex = 16;
            this.button_replace.Text = "替换";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(111, 56);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(542, 21);
            this.textBox_result.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "结果文件夹目录：";
            // 
            // button_selectResult
            // 
            this.button_selectResult.Location = new System.Drawing.Point(658, 56);
            this.button_selectResult.Name = "button_selectResult";
            this.button_selectResult.Size = new System.Drawing.Size(75, 23);
            this.button_selectResult.TabIndex = 17;
            this.button_selectResult.Text = "选择";
            this.button_selectResult.UseVisualStyleBackColor = true;
            this.button_selectResult.Click += new System.EventHandler(this.button_selectResult_Click);
            // 
            // groupBox_set
            // 
            this.groupBox_set.Controls.Add(this.textBox_result);
            this.groupBox_set.Controls.Add(this.button_selectFolder);
            this.groupBox_set.Controls.Add(this.label4);
            this.groupBox_set.Controls.Add(this.label1);
            this.groupBox_set.Controls.Add(this.button_selectResult);
            this.groupBox_set.Controls.Add(this.textBox_folderPath);
            this.groupBox_set.Controls.Add(this.button_replace);
            this.groupBox_set.Controls.Add(this.checkedListBox_files);
            this.groupBox_set.Controls.Add(this.textBox_replaceText);
            this.groupBox_set.Controls.Add(this.button_selectall);
            this.groupBox_set.Controls.Add(this.textBox_originText);
            this.groupBox_set.Controls.Add(this.button_disselectall);
            this.groupBox_set.Controls.Add(this.label2);
            this.groupBox_set.Controls.Add(this.button_search);
            this.groupBox_set.Controls.Add(this.label3);
            this.groupBox_set.Location = new System.Drawing.Point(12, 4);
            this.groupBox_set.Name = "groupBox_set";
            this.groupBox_set.Size = new System.Drawing.Size(743, 480);
            this.groupBox_set.TabIndex = 20;
            this.groupBox_set.TabStop = false;
            this.groupBox_set.Text = "设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_status);
            this.groupBox1.Location = new System.Drawing.Point(12, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 197);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行";
            // 
            // ReplaceInFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReplaceInFiles";
            this.Text = "多文件字符串替换";
            this.Load += new System.EventHandler(this.ReplaceInFiles_Load);
            this.groupBox_set.ResumeLayout(false);
            this.groupBox_set.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_selectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_folderPath;
        private System.Windows.Forms.CheckedListBox checkedListBox_files;
        private System.Windows.Forms.Button button_disselectall;
        private System.Windows.Forms.Button button_selectall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.RichTextBox richTextBox_status;
        private System.Windows.Forms.TextBox textBox_originText;
        private System.Windows.Forms.TextBox textBox_replaceText;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_selectResult;
        private System.Windows.Forms.GroupBox groupBox_set;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}