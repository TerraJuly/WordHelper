using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WordHelper
{
    public partial class ReplaceInFiles : Form
    {
        public ReplaceInFiles()
        {
            InitializeComponent();
            textBox_folderPath.Text = Properties.Settings.Default.sourceFolder;
            textBox_result.Text = Properties.Settings.Default.resultFolder;
            textBox_originText.Text = Properties.Settings.Default.searchText;
            textBox_replaceText.Text = Properties.Settings.Default.replaceText;
        }
        public struct ReplaceFileInfo
        {
            public ReplaceInFiles mainForm;
            public string sourceFolder;
            public string resultFolder;
            public List<string> files;
            public string searchText;
            public string replaceText;
        }

        private void button_selectFolder_Click(object sender, EventArgs e)
        {
            CustomizedFolderBrowserDialog dialog = new CustomizedFolderBrowserDialog();
            dialog.Title = "请选择存放word文件的文件夹";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textBox_folderPath.Text = "";
                textBox_folderPath.Text = dialog.SelectedPath;
                Properties.Settings.Default.sourceFolder = textBox_folderPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button_selectResult_Click(object sender, EventArgs e)
        {
            CustomizedFolderBrowserDialog dialog = new CustomizedFolderBrowserDialog();
            dialog.Title = "请选择存放word结果文件的文件夹";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                textBox_result.Text = "";
                textBox_result.Text = dialog.SelectedPath;
                Properties.Settings.Default.resultFolder = textBox_result.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void ReplaceInFiles_Load(object sender, EventArgs e)
        {

        }

        private void button_selectall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_files.Items.Count; i++)
            {
                checkedListBox_files.SetItemChecked(i, true);
            }
        }

        private void button_disselectall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_files.Items.Count; i++)
            {
                checkedListBox_files.SetItemChecked(i, false);
            }
        }

        private void textBox_folderPath_TextChanged(object sender, EventArgs e)
        {
            checkedListBox_files.Items.Clear();
            string folderPath = textBox_folderPath.Text;
            if (folderPath != "")
            {
                string[] docx_files = Directory.GetFiles(folderPath, "*.docx");
                string[] doc_files = Directory.GetFiles(folderPath, "*.doc").Where(t => t.ToLower().EndsWith(".doc")).ToArray() ;//pattern 为3个字符时行为不同
                string[] files = docx_files.Concat(doc_files).ToArray();
                foreach (string file in files)
                {
                    if (!file.Contains("~$"))//排除临时文件
                    {
                        checkedListBox_files.Items.Add(file);
                    }
                }

            }
        }
        delegate void SetText(string text);
        public void SetRichBoxText(string text)
        {
            if (richTextBox_status.InvokeRequired)
            {
                SetText objSet = new SetText(SetRichBoxText);
                richTextBox_status.Invoke(objSet, new object[] { text });
            }
            else
            {
                if (text.Contains("警告"))
                {
                    richTextBox_status.SelectionColor = Color.Red;
                }
                richTextBox_status.AppendText(text+"\n");
                richTextBox_status.SelectionStart = richTextBox_status.TextLength;
                richTextBox_status.ScrollToCaret();
            }
        }
        private ReplaceFileInfo GetInfo()
        {
            ReplaceFileInfo info = new ReplaceFileInfo();
            info.mainForm = this;
            info.sourceFolder = textBox_folderPath.Text;
            info.files = new List<string>();
            foreach (var item in checkedListBox_files.CheckedItems)
            {
                info.files.Add(item.ToString());
            }
            info.searchText = textBox_originText.Text;
            info.replaceText = textBox_replaceText.Text;
            info.resultFolder = textBox_result.Text;
            return info;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SetStatus(false);
            richTextBox_status.Text = "";
            ReplaceFileInfo info = GetInfo();
            if (!check(info))
            {
                return;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(ReplaceInFilesFunction.FindString));
            thread.Start(info);
        }
        private void button_replace_Click(object sender, EventArgs e)
        {
            SetStatus(false);
            richTextBox_status.Text = "";
            ReplaceFileInfo info = GetInfo();
            if (!check(info))
            {
                return;
            }
            if (info.resultFolder == "")
            {
                SetRichBoxText("警告：您还未设置结果文件夹！");
                return;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(ReplaceInFilesFunction.ReplaceString));
            thread.Start(info);
        }
        public bool check(ReplaceFileInfo info)
        {
            if (info.sourceFolder=="")
            {
                SetRichBoxText("警告：您还未选择word文件夹！");
                return false;
            }
            if (info.files.Count==0)
            {
                SetRichBoxText("警告：请至少选择一个word文件！");
                return false;
            }
            if (info.searchText=="")
            {
                SetRichBoxText("警告：查找字符串不能为空！");
                return false;
            }
            return true;
        }



        private void textBox_originText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.searchText = textBox_originText.Text;
            Properties.Settings.Default.Save();
        }

        private void textBox_replaceText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.replaceText = textBox_replaceText.Text;
            Properties.Settings.Default.Save();
        }
        delegate void SafeSetEnable(bool status);
        public void SetStatus(bool status)
        {
            if (this.InvokeRequired)
            {
                SafeSetEnable objSet = new SafeSetEnable(SetStatus);
                this.Invoke(objSet, new object[] { status });
            }
            else
            {
                groupBox_set.Enabled = status;
            }
        }
    }
}
