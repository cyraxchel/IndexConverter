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
using System.IO;

namespace OldIndexConverter {
    public partial class Form1 : Form {

        string lastPath;
        string preHTML = @"<!doctype html><html><head><meta charset=""utf-8""><title>{0}</title></head><body><div id=""contenttable""><h3>{1}</h3><ol id=""listTOC"" style=""list-style-type:none"">";
        //20190619-10-44-28
        string afterHTML = @"</ol><div id=""UID"" class=""hided"" style=""display:none;"">{0}   #</div></div></body></html>";

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
            List<string> verticalFiles = new List<string>();
            if (folderPath.Text == "")
            {
                MessageBox.Show("Не выбрана папка с изображениями.\nПарсер не отработает вертикальные изображения!");
            } else
            {
                verticalFiles = GetVerticals(folderPath.Text);
            }

            string inputText = richTextBox1.Text;
            Litem[] tocArray;
            
            if (inputText == string.Empty) {
                MessageBox.Show("Текста нет.");
            } else {
                //parce text
                string[] delim = new string[] { "\r", "\n" };
                string[] lines = inputText.Split(delim, StringSplitOptions.RemoveEmptyEntries);
                tocArray = new Litem[lines.Length];
                string newTOC = String.Format(preHTML,projectNameBox.Text, projectNameBox.Text) + Environment.NewLine;

                for (int i = 0; i < lines.Length; i++) {
                    Litem litem = new Litem(lines[i]);
                    litem.Check(verticalFiles);
                    tocArray[i] = litem;
                    newTOC += litem.GetHTMLView();
                }

                newTOC += String.Format(afterHTML, DateTime.Now.ToString());
                richTextBox1.Text = newTOC;
            }
        }

        private List<string> GetVerticals(string path)
        {
            List<string> files = new List<string>();
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
            string sfx = "b";
            foreach (FileInfo file in Files)
            {
                //if(file.Extension == Litem.imgExtention) { }
                string shortName = file.Name.Substring(0, file.Name.LastIndexOf(file.Extension));
                FileInfo fb = new FileInfo(Path.Combine(path, shortName + sfx + file.Extension));
                Debug.WriteLine(fb.FullName);
                if (fb.Extension != Litem.HTM_EXT && fb.Exists)
                {
                    Debug.WriteLine("EXIST!!");
                    files.Add(file.Name);
                }
            }

            return files;
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
            public static string imgExtention = ".png";

            public static string HTM_EXT = ".htm";
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

            public void Check(List<string> bfiles)
            {
                foreach (string bfile in bfiles)
                {
                    if(bfile == Link) {
                        Link += ":vert";
                    }
                }
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

        private void сохранитьTochtmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Properties.Settings.Default.LastImagePath;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "htm files (*.htm)|*.htm";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }
    }
}
