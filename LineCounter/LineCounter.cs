using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCounter
{
    public partial class LineCounter : Form
    {
        private const string PREFIX = "-";
        private const int NUM_SPACES = 4;

        private string[] multilineSeparators;
        private string[] singlelineMarkers;

        public LineCounter()
        {
            InitializeComponent();
        }

        private void excludeComments_CheckedChanged(object sender, EventArgs e)
        {
            singleline.Enabled = multiline.Enabled = label6.Enabled = label5.Enabled = label1.Enabled
                = excludeComments.Checked;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            browserDialog.ShowNewFolderButton = false;
            if (browserDialog.ShowDialog(this) == DialogResult.OK)
                folderBox.Text = browserDialog.SelectedPath;
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            multilineSeparators = multiline.Text.Split(',');
            if (excludeComments.Checked && multiline.Text != "" && multilineSeparators.Count() % 2 != 0)
                throw new Exception("Invalid multiline separators!");
            singlelineMarkers = singleline.Text.Split(',');
            if (!useRecursive.Checked)
                output.AppendText("\r\nWarning: NOT searching subfolders for code files!");
            string folder = folderBox.Text;
            int lines = countLinesInFolder(folder, 0);
            output.AppendText("\r\nFound total of [ " + lines + " ] lines of code in project folder '" + folder + "'");
        }

        private int countLinesInFolder(string folder, int depth)
        {
            int folderLines = 0;
            foreach (string file in Directory.EnumerateFiles(folder))
            {
                int numLines = countLinesInFile(file, depth);
                folderLines += numLines;
            }
            if (useRecursive.Checked)
            {
                foreach (string directory in Directory.EnumerateDirectories(folder))
                {
                    string depthMod = new string(' ', depth * NUM_SPACES);
                    depthMod += PREFIX;
                    output.AppendText("\r\n" + depthMod + "Entering folder '" + directory.Replace(folderBox.Text, "\\") + "'");
                    int numLines = countLinesInFolder(directory, depth + 1);
                    folderLines += numLines;
                }
            }
            if (folder != folderBox.Text)
            {
                if (folderLines != 0)
                {
                    string localPath = folder.Replace(folderBox.Text, "\\");
                    string depthMod = "";
                    if (depth - 1 > 0)
                        depthMod = new string(' ', (depth - 1) * NUM_SPACES);
                    else
                        depthMod = new string(' ', depth * NUM_SPACES);
                    depthMod += PREFIX;
                    output.AppendText("\r\n" + depthMod + "Found [ " + folderLines + " ] lines of code in folder '" + localPath + "'");
                }
            }
            return folderLines;
        }

        private int countLinesInFile(string file, int depth)
        {
            int lines = 0;
            string[] path = file.Split('\\');
            string fileName = path[path.Count() - 1];
            string[] fileNameDiv = fileName.Split('.');
            string extension = "." + fileNameDiv[fileNameDiv.Count() - 1];
            string[] endings = fileEndings.Text.Split(',');

            string localPath = file.Replace(folderBox.Text, "\\");
            if (endings.Contains(extension))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string data = sr.ReadToEnd();
                        string newData = "";
                        if (excludeComments.Checked && multiline.Text != "")
                        {
                            newData = removeMultiLines(data);
                        }
                        else
                            newData = data;
                        string[] splitByLine = newData.Split('\n');
                        foreach (string line in splitByLine)
                        {
                            bool includeLine = true;

                            if (line == "\r" || line == "")
                                includeLine = false;
                            else
                            {
                                if (excludeComments.Checked)
                                {
                                    foreach (string str in singlelineMarkers)
                                    {
                                        if (line.StartsWith(str))
                                            includeLine = false;
                                    }
                                }
                            }
                            if (includeLine)
                                lines++;
                        }
                    }
                    string depthMod = new string(' ', depth * NUM_SPACES);
                    depthMod += PREFIX;
                    output.AppendText("\r\n" + depthMod + "Found [ " + lines + " ] lines of code in file '" + localPath + "'");
                }
                catch (IOException e)
                {
                    string depthMod = new string(' ', depth * NUM_SPACES);
                    depthMod += PREFIX;
                    output.AppendText("\r\n" + depthMod + "Could not open file '" + localPath + "'\r\nSkipping...");
                }
            }
            else
            {
                string depthMod = new string(' ', depth * NUM_SPACES);
                depthMod += PREFIX;
                output.AppendText("\r\n" + depthMod + "Ignoring file '" + localPath + "': Does not end in specified extensions.");
            }
            return lines;
        }

        private string removeMultiLines(string data)
        {
            string newData = data;
            for (int i = 0; i < multilineSeparators.Count(); i += 2)
            {
                string beginning = multilineSeparators[i];
                string end = multilineSeparators[i + 1];
                int startInd = newData.IndexOf(beginning);
                while (startInd != -1)
                {
                    int endInd = newData.IndexOf(end) + end.Length;
                    if (endInd == -1)
                        endInd = newData.Length - 1;
                    newData = newData.Remove(startInd, endInd - startInd);
                    startInd = newData.IndexOf(beginning);
                }
            }
            return newData;
        }

        private void singleline_TakesFocus(object sender, EventArgs e)
        {
            toolTip1.Show("Enter tokens separated by commas (,)", singleline);
        }

        private void multiline_TakesFocus(object sender, EventArgs e)
        {
            toolTip1.Show("Enter tokens separated by commas (,)", multiline);
        }

        private void fileEndings_TakesFocus(object sender, EventArgs e)
        {
            toolTip1.Show("Enter tokens separated by commas (,)", fileEndings);
        }

        private void LineCounter_Load(object sender, EventArgs e)
        {
            folderBox.Text = "C:\\Users\\Alpha Programmer\\Documents\\Visual Studio 2017\\Projects\\DungeonGame";
            fileEndings.Text = ".cs";
            useRecursive.Checked = true;
            excludeComments.Checked = true;
            singleline.Text = "//";
            multiline.Text = "/*,*/";
            output.Text = "Note: Does NOT count empty lines as lines of code!";

            toolTip1.SetToolTip(singleline, "Enter tokens separated by commas (,)");
            toolTip1.SetToolTip(multiline, "Enter tokens separated by commas (,)");
            toolTip1.SetToolTip(fileEndings, "Enter tokens separated by commas (,)");

            excludeComments_CheckedChanged(this, null);
        }
    }
}
