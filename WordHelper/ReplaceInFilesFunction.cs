using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;
using System.IO;

namespace WordHelper
{
    public static class ReplaceInFilesFunction
    {
        static object Nothing = System.Reflection.Missing.Value;
        private enum WordAPPType
        {
            GET,
            NEW
        }
        private struct WordApp
        {
            public WordAPPType Type;
            public Word.Application APP;
        }
        private static WordApp GetWordApplication()
        {
            Word.Application winObj = null;
            WordAPPType type = WordAPPType.GET;
            try
            {
                winObj = (Word.Application)Marshal.GetActiveObject("Word.Application");
                type = WordAPPType.GET;

            }
            catch (Exception)
            {

                if (winObj == null)
                {
                    winObj = new Word.Application();
                    type = WordAPPType.NEW;
                }
            }
            WordApp wordApp = new WordApp();
            wordApp.Type = type;
            wordApp.APP = winObj;
            return wordApp;
        }
        public static void FindString(object info)
        {
            ReplaceInFiles.ReplaceFileInfo replaceFileInfo = (ReplaceInFiles.ReplaceFileInfo)info;
            WordApp app = GetWordApplication();
            foreach (string file in replaceFileInfo.files)
            {
                Word.Document doc = app.APP.Documents.Open(file, ref Nothing, true, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
                        ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                int foundCount = FindText(doc, replaceFileInfo.searchText);
                replaceFileInfo.mainForm.SetRichBoxText(string.Format("在文件【{0}】中找到【{1}】处【{2}】。 ", Path.GetFileName(file), foundCount, replaceFileInfo.searchText));
                doc.Saved = true;
                doc.Close();
            }
            if (app.Type == WordAPPType.NEW)
            {
                app.APP.Quit();
            }
            replaceFileInfo.mainForm.SetRichBoxText("查找结束！");
            replaceFileInfo.mainForm.SetStatus(true);
        }

        public static void ReplaceString(object info)
        {
            ReplaceInFiles.ReplaceFileInfo replaceFileInfo = (ReplaceInFiles.ReplaceFileInfo)info;
            WordApp app = GetWordApplication();
            foreach (string file in replaceFileInfo.files)
            {
                Word.Document doc = app.APP.Documents.Open(file, ref Nothing, true, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing,
                        ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                ReplaceAll(doc, replaceFileInfo.searchText,replaceFileInfo.replaceText);
                replaceFileInfo.mainForm.SetRichBoxText(string.Format("文件【{0}】替换成功。 ", Path.GetFileName(file)));
                string resultPath = Path.Combine(replaceFileInfo.resultFolder,Path.GetFileName(file));
                doc.SaveAs2(resultPath);
                doc.Close();
            }
            if (app.Type == WordAPPType.NEW)
            {
                app.APP.Quit();
            }
            replaceFileInfo.mainForm.SetRichBoxText(string.Format("替换结束！共计替换【{0}】个文件",replaceFileInfo.files.Count));
            replaceFileInfo.mainForm.SetStatus(true);
        }

        public static int FindText(Word.Document doc, string text)
        {
            int count = 0;
            Word.Find find = doc.Application.Selection.Find;
            find.ClearFormatting();
            find.Text = text;
            find.Replacement.Text = "";
            find.Forward = true;
            find.Wrap = Word.WdFindWrap.wdFindContinue;
            find.Format = false;
            find.MatchCase = true;
            find.MatchWholeWord = false;
            find.MatchByte = true;
            find.MatchWildcards = false;
            find.MatchSoundsLike = false;
            find.MatchAllWordForms = false;

            doc.Range(0, 0).Select();
            while (find.Execute())
            {
                count++;
            }
            return count;
        }
        /// <summary>
        /// 替换所有符合的text
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="text"></param>
        /// <param name="replaceText"></param>
        public static void ReplaceAll(Word.Document doc, string text, string replaceText)
        {
            Word.Find find = doc.Application.Selection.Find;
            find.ClearFormatting();
            find.Replacement.ClearFormatting();
            find.Text = text;
            find.Replacement.Text = replaceText;
            find.Forward = true;
            find.Wrap = Word.WdFindWrap.wdFindContinue;
            find.Format = false;
            find.MatchCase = true;
            find.MatchWholeWord = false;
            find.MatchByte = true;
            find.MatchWildcards = false;
            find.MatchSoundsLike = false;
            find.MatchAllWordForms = false;
            doc.Range(0, 0).Select();
            find.Execute(find.Text, find.MatchCase, find.MatchWholeWord, find.MatchWildcards, find.MatchSoundsLike, find.MatchAllWordForms,
                find.Forward, find.Wrap, find.Format, find.Replacement.Text, Word.WdReplace.wdReplaceAll, false, false, false, false);
        }
    }
}
