namespace RH_MyMM
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
            fileInputBox.ReadOnly = true; // making input box read only

        }

        private Dictionary<int, List<string>> sentencesDict = new Dictionary<int, List<string>>(); // for storing parsed lines
        private List<string> uniqueWords = new List<string>(); //list of unique words
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
            //fileInputBox.Enabled = true;
        }
        // file input settings
        private void fileInputBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void fileInputBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //creating a new openFile object instance
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //limiting to .txt files only

            // if the user selects a valid file and hit "ok"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // updated the words in the fileInputBox with the name and ext of the file chosen
                string fileName = Path.GetFileName(openFileDialog1.FileName); // store name of file
                fileInputBox.Text = fileName;
                submitfileBtn.Enabled = true; // enable the submit button
            }
            else
            {
                fileInputBox.Text = fileInputBox.PlaceholderText;
            }
        }

        // prompt system file input settings
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        //submit button pressed
        private void submitfileBtn_Click(object sender, EventArgs e)
        {
            // Show message to let user know file is being processed
            MessageBox.Show("Processing file. Please wait...");

            // Disable submit button
            submitfileBtn.Enabled = !submitfileBtn.Enabled;

            int tot_msgs = 0; //total number of lines parsed
            int tot_words = 0; //total number of words in the dictionary


            // Parse the selected file
            string filePath = openFileDialog1.FileName;
            string[] lines = File.ReadAllLines(filePath);

            // reset the dictionary
            sentencesDict.Clear();

            // Store each sentence as a list of words in the dictionary
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //increment tot_msgs
                        tot_msgs++;

                        //parse sentence and store it in dictionary
                        List<string> wordsList = line.Split(' ').ToList();
                        sentencesDict.Add(tot_msgs - 1, wordsList);

                        //increment tot_words
                        tot_words += wordsList.Count;

                        //add unique words to list
                        foreach (string word in wordsList)
                        {
                            if (!uniqueWords.Contains(word))
                            {
                                uniqueWords.Add(word);
                            }
                        }
                    }
                }

                MessageBox.Show("File processed successfully!");

            }
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
            Application.Exit();
        }
    }
}