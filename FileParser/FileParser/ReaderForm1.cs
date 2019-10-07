// -----------------------------------------------
// File   : ReaderForm1.cs
// By     : Danica Weiler
// Date   : May 8, 2019
// Purpose: Code behind for main form of project
// -----------------------------------------------

using System;
using System.IO;
using System.Windows.Forms;

namespace FileReadParser
{
    public partial class FileReader : Form
    {
        public FileReader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// "open_btn_Click" button click event, uses a dialog box for user to select a text file
        /// </summary>
        private void open_btn_Click(object sender, EventArgs e)
        {
            //Open windows open file dialog box and get the file if one is chosen
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt"; //only allow txt files
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProcessFile(openFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// Process the file by opening and reading the contents
        /// </summary>
        /// <param name="filePath">path to file to open and process</param>
        private void ProcessFile(string filePath)
        {
            string fileContent = string.Empty;

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        fileContent = reader.ReadToEnd();
                    }

                    if (!string.IsNullOrEmpty(fileContent))
                    {
                        UpdateLabelwithData(fileContent, filePath);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error handling file.");
                }
            }
        }

        /// <summary>
        /// Call to the parser and update the label accordingly with the proper counts
        /// </summary>
        /// <param name="fileContent">Content of the file chose</param>
        /// <param name="filePath">full file path</param>
        private void UpdateLabelwithData(string fileContent, string filePath)
        {
            stats_lbl.Text = "File: ".PadRight(20) + filePath +
                              "\nLines: ".PadRight(19) + ParseContent.CountLines(filePath).ToString() +
                              "\nWords: ".PadRight(18) + ParseContent.CountWords(fileContent).ToString() +
                              "\nUpperCase: ".PadRight(14) + ParseContent.CountUpper(fileContent).ToString() +
                              "\nLowerCase: ".PadRight(14) + ParseContent.CountLower(fileContent).ToString() +
                              "\nNumbers: ".PadRight(16) + ParseContent.CountNumbers(fileContent).ToString() +
                              "\nOthers: ".PadRight(19) + ParseContent.CountOtherChar(fileContent).ToString();
        }
    }
}
