using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordHelper
{
    public partial class WordHelper : Form
    {
        public WordHelper()
        {
            InitializeComponent();
        }

        private void button_replaceAll_Click(object sender, EventArgs e)
        {
            ReplaceInFiles replaceFilesWindow = new ReplaceInFiles();

            replaceFilesWindow.ShowDialog();
        }
    }
}
