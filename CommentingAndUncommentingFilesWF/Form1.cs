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
using static System.Windows.Forms.ListView;

namespace CommentingAndUncommentingFilesWF
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private string selectedPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFolder()
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog.SelectedPath;
                richTextBoxSelectedFolder.Text = folderBrowserDialog.SelectedPath;

                var files = Directory.GetFiles(selectedPath, "*.cs");

                textBoxAllFilesCount.Text = files.Length.ToString();

                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    listBoxFiles.Items.Add(fileName);
                }
            }
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            int commented = 0;
            foreach (var selectedFile in this.listBoxFiles.SelectedItems)
            {
                var fullFileName = Path.Combine(selectedPath, selectedFile.ToString());
                var allLines = File.ReadAllLines(fullFileName);

                if (!allLines[0].StartsWith("//COMMENTED BY DONCHO\u2122"))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("//COMMENTED BY DONCHO\u2122");
                    foreach (var line in allLines)
                    {
                        sb.AppendLine("//" + line);
                    }

                    File.WriteAllText(fullFileName, sb.ToString());
                    commented++;
                }
            }

            MessageBox.Show($"Commented files: {commented}");
        }

        private void buttonUncomment_Click(object sender, EventArgs e)
        {
            int uncommented = 0;
            foreach (var selectedFile in this.listBoxFiles.SelectedItems)
            {
                var fullFileName = Path.Combine(selectedPath, selectedFile.ToString());
                var allLines = File.ReadAllLines(fullFileName);

                if (allLines[0].StartsWith("//COMMENTED BY DONCHO\u2122"))
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < allLines.Length; i++)
                    {
                        if (allLines[i].StartsWith("//"))
                        {
                            sb.AppendLine(allLines[i].Substring(2));
                        }
                        else
                        {
                            sb.AppendLine(allLines[i]);
                        }
                    }

                    File.WriteAllText(fullFileName, sb.ToString());
                    uncommented++;
                }
            }

            MessageBox.Show($"Uncommented files: {uncommented}");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listBoxFiles.Items.Count; i++)
            {
                this.listBoxFiles.SetSelected(i, true);
            }
        }
    }
}
