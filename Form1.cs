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

namespace OldIndexConverter {
    public partial class Form1 : Form {
        public Form1() {
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
        protected class Litem {
            //Проверяет, надо ли удалить нумерацию.
            public static bool replaceNumeric;
            public static string headerTemplate = @"<br /><strong>{1}</strong><br />";
            public static string itemtemplate = @"<LI><A href=""{0}"">{1}</A></LI>";

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
                CheckLink(out Link);
            }

            private void CheckLink(out string link) {
                if(link.Contains("htm")) {

                }
            }

            public string GetHTMLView() {
                string result = isHeader ? headerTemplate : itemtemplate;
                result = String.Format(result, Link, Text);
                /*if (isHeader) {
                    result = String.Format(result, Text);
                } else {
                    result = String.Format(result, Link, Text);
                }/**/
                
                return result + Environment.NewLine;
            }
        }
    }
}
