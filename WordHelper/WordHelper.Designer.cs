namespace WordHelper
{
    partial class WordHelper
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_replaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_replaceAll
            // 
            this.button_replaceAll.Location = new System.Drawing.Point(34, 48);
            this.button_replaceAll.Name = "button_replaceAll";
            this.button_replaceAll.Size = new System.Drawing.Size(141, 23);
            this.button_replaceAll.TabIndex = 0;
            this.button_replaceAll.Text = "多文件全文替换";
            this.button_replaceAll.UseVisualStyleBackColor = true;
            this.button_replaceAll.Click += new System.EventHandler(this.button_replaceAll_Click);
            // 
            // WordHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 372);
            this.Controls.Add(this.button_replaceAll);
            this.Name = "WordHelper";
            this.Text = "Word小助手 by terra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_replaceAll;
    }
}

