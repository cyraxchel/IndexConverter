using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Resources;

namespace OldIndexConverter {
    public partial class Form1 : Form {

        string lastPath;

        public Form1() {
            if (Properties.Settings.Default.LastImagePath != "")
            {
                lastPath = Properties.Settings.Default.LastImagePath;
            } else
            {
                lastPath = "C:\\";// Environment.SpecialFolder.MyDocuments;
            }
            InitializeComponent();
        }

        /// <summary>
        /// Преобразовать текущий файл в HTML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void конвертироватьToolStripMenuItem_Click(object sender, EventArgs e) {
            string inputText = richTextBox1.Text;
            Litem[] tocArray;
            
            if (inputText == string.Empty) {
                MessageBox.Show("Текста нет.");
            } else {
                //parce text
                string[] delim = new string[] { "\r", "\n" };
                string[] lines = inputText.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                tocArray = new Litem[lines.Length];
                string newTOC = "";

                for (int i = 0; i < lines.Length; i++) {
                    //Debug.WriteLine();
                    Litem litem = new Litem(lines[i]);
                    tocArray[i] = litem;
                    newTOC += litem.GetHTMLView();
                }
                
                richTextBox1.Text = newTOC;
            }
        }

        /*
         DirectoryInfo d = new DirectoryInfo(@"D:\Test");//Assuming Test is your Folder
FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
string str = "";
foreach(FileInfo file in Files )
{
  str = str + ", " + file.Name;
}
             */

        protected class Litem {
            //Проверяет, надо ли удалить нумерацию.
            public static bool replaceNumeric;
            public static string headerTemplate = @"<br /><strong>{1}</strong><br />";
            public static string itemtemplate = @"<LI><A href=""{0}"">{1}</A></LI>";
            public static string imgExtention = "png";

            public static string HTM_EXT = "htm";
            public string Link;
            public string Text = "";
            public bool isHeader = false;

            public Litem(string line) {
                string[] delim = new string[] { "::" };
                string[] args = line.Split(delim, StringSplitOptions.None);
                //TODO detect is header
                if(args.Length < 2 || args[1].Contains("index")) {
                    isHeader = true;
                }

                Text = args[0];
                if(args.Length > 1) {
                    Link = args[1];
                }
                Link = CheckLink(Link);
            }

            private string CheckLink(string link) {
                if(link.Contains(HTM_EXT)) {
                    link = link.Replace(HTM_EXT, imgExtention);
                }
                return link;
            }

            public string GetHTMLView() {
                string result = isHeader ? headerTemplate : itemtemplate;
                result = String.Format(result, Link, Text);
                return result + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = lastPath;   //TODO set Last Path
            
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folderPath.Text = dialog.FileName;
                lastPath = dialog.FileName;
                Properties.Settings.Default.LastImagePath = lastPath;
                Properties.Settings.Default.Save();
            }
            
        }
    }
}
