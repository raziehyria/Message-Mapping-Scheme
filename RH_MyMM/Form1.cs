using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
/* The code below will print the words Hello World
*H
* AUTHOR :   Razie Hyria        START DATE :    APRIL 13th 2023
* FILENAME :        Message Mapping Scheme 
* COURSE NAME:      CMPSC 472 Section 001: Operating Systems
* SEMESTER:         SPRING 2023
*
* DESCRIPTION :
*    A Windows Form App using C#, .NET, and Visual Studio to store text messages in an efficient method.  
The goal is to not store the same word twice, from all of the messages
*
*
* FUNCTIONS USED:  dictionary, lists, ToLower, ToUpper, StreamReader
*
*
*H

to the screen, and it is amazing */
namespace RH_MyMM
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
            // making input, #msgs, #words, and #uwords boxes read only
            fileInputBox.ReadOnly = true;
            totmsgsTxtBox.ReadOnly = true;
            totWordsTxtBox.ReadOnly = true;
            numUnqWrdsTxtBox.ReadOnly = true;
            fileInputBox.ForeColor = _defaultColor; // setting default placeholder text
            fileInputBox.Font = _defaultFont;

        }

        // setting default text font/color
        private Font _defaultFont = new Font("Verd", 8, FontStyle.Italic);
        private Color _defaultColor = Color.LightGray;


        // creating the global file openFile object instance
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        // creating global dictionary for storing parsed lines
        private Dictionary<int, List<int>> sentencesDict = new Dictionary<int, List<int>>();

        // creating global unique words list
        private List<string> uniqueWords = new List<string>();

        private void myForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void duckyPicCaption_Click(object sender, EventArgs e)
        {

        }

        private void totNumMsgsLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formheaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void inputFileLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectMsgLabel_Click(object sender, EventArgs e)
        {

        }

        private void reassmMsgLabel_Click(object sender, EventArgs e)
        {

        }

        private void totNumWordsLabel_Click(object sender, EventArgs e)
        {

        }

        private void uniqWordFounLabel_Click(object sender, EventArgs e)
        {

        }

        // changing the functions of the select file box
        private void fileInputBox_Enter(object sender, EventArgs e)
        {
            //fileInputBox.Enabled = true;

        }

        private void fileInputBox_Leave(object sender, EventArgs e)
        {

        }

        // file input settings
        private void fileInputBox_TextChanged(object sender, EventArgs e)
        {

            if (fileInputBox.Text != fileInputBox.PlaceholderText)
            {
                fileInputBox.ForeColor = Color.SteelBlue; // change text color
                fileInputBox.Font = new Font("Verdana", 12f, FontStyle.Regular);
            }
            else
            {
                // setting default placeholder text
                fileInputBox.ForeColor = _defaultColor;
                fileInputBox.Font = _defaultFont;
                fileInputBox.Text = fileInputBox.PlaceholderText;
            }

        }

        private void fileInputBox_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Text Files (*.txt)|*.txt"; //limiting to .txt files only

            // if the user selects a valid file and hit "ok"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // updated the words in the fileInputBox with the name and ext of the file chosen
                string fileName = Path.GetFileName(openFileDialog.FileName); // store name of file
                fileInputBox.Text = fileName;
                submitfileBtn.Enabled = true; // enable the submit button
            }
        }

        //submit button pressed
        private void submitfileBtn_Click(object sender, EventArgs e)
        {
            // declare variables
            int tot_msgs = 1;
            int tot_words = 0;
            int tot_unique = uniqueWords.Count;

            // Parse the selected file
            string filePath = openFileDialog.FileName;

            // Disable submit button after click
            submitfileBtn.Enabled = !submitfileBtn.Enabled;

            // reset placeholder
            fileInputBox.Text = fileInputBox.PlaceholderText;

            // reset output fields
            listofUniqMsgBox.Items.Clear();
            uniqueWords.Clear();
            sentencesDict.Clear();

            // Show message to let user know file is being processed
            //MessageBox.Show("Processing file. Please wait...");

            // read file and parse sentences
            using (StreamReader sr = new StreamReader(filePath))
            {
                //reads one line of text from the file and assigns it to the line variable.
                string line;
                while ((line = sr.ReadLine()) != null) //as long as there is more text to read
                {
                    //splits the line string into separate words using the space character
                    List<string> words = line.ToLower().Split(' ').ToList();

                    // store the index of the word in the uniqueWord list
                    List<int> indexes = new List<int>();
                    // add unique words to list
                    foreach (string word in words)
                    {
                        //remove the punctuation marks from the end of words
                        //string trimmedWord = word.TrimEnd('.', ',', '!', '?', ';', ':', '-', '—');
                        if (!uniqueWords.Contains(word))
                        {
                            //add to unique words
                            uniqueWords.Add(word);
                        }
                        // get the index from the unique word list
                        int index = uniqueWords.IndexOf(word);
                        indexes.Add(index);
                    }
                    // add key and index to dictionary
                    sentencesDict.Add(tot_msgs, indexes);

                    //update values
                    tot_msgs++;
                    tot_words += words.Count;
                }

                // update listbox to display all uniqueWords
                foreach (string word in uniqueWords)
                {
                    listofUniqMsgBox.Items.Add(word);
                }

                //displaying info to all text boxes
                int tt_msgs = tot_msgs - 1;
                totmsgsTxtBox.Text = tt_msgs.ToString();
                totWordsTxtBox.Text = tot_words.ToString();
                numUnqWrdsTxtBox.Text = uniqueWords.Count.ToString();
                msgNumList.Minimum = 1;
                msgNumList.Maximum = tt_msgs;

            }
            //MessageBox.Show("File processed successfully!");

        }

        // list of numbers settings
        private void msgNumList_ValueChanged(object sender, EventArgs e)
        {

        }

        // msg output settings 
        private void ressembledMsgOutput_TextChanged(object sender, EventArgs e)
        {

        }

        // number of messages settings
        private void totmsgsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        // number of words settings
        private void totWordsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        // number of unique words settings
        private void numUnqWrdsTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        // listbox of words settings
        private void listofUniqMsgBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // used to close app
            System.Windows.Forms.Application.Exit();
        }

        private void submitMsgNumBox_Click(object sender, EventArgs e)
        {
            // get the value from the up-down down control
            int msgNum = (int)msgNumList.Value;

            // check to make sure its a key in the dictionary
            if (sentencesDict.ContainsKey(msgNum))
            {
                // retrieve the list of indexes
                string ressembledMsg = "";
                //iterate over each index, retrieve the corresponding word from the uniqueWords list,
                foreach (int index in sentencesDict[msgNum])
                {
                    //capitalizing the first word of each sentence
                    string word = uniqueWords[index];
                    if (index == sentencesDict[msgNum][0])
                    {
                        word = char.ToUpper(word[0]) + word.Substring(1);
                    }
                    //append it to the ressembledMsg string
                    ressembledMsg += word + " ";
                }
                // trim any whitespace, and set the ressembledMsgOutput box to the message
                ressembledMsgOutput.Text = ressembledMsg.Trim();
            }
        }
    }
}