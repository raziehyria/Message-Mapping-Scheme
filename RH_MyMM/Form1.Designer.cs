namespace RH_MyMM
{
    partial class myForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myForm));
            listofUniqMsgBox = new ListBox();
            inputFileLabel = new Label();
            reassmMsgLabel = new Label();
            selectMsgLabel = new Label();
            totNumMsgsLabel = new Label();
            totNumWordsLabel = new Label();
            submitfileBtn = new Button();
            submitMsgNumBox = new Button();
            msgNumList = new NumericUpDown();
            fileInputBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            totWordsTxtBox = new TextBox();
            totmsgsTxtBox = new TextBox();
            uniqWordFounLabel = new Label();
            ressembledMsgOutput = new TextBox();
            formheaderLabel = new Label();
            duckPicture = new PictureBox();
            duckyPicCaption = new Label();
            numUniqueWordsLabel = new Label();
            numUnqWrdsTxtBox = new TextBox();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)msgNumList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)duckPicture).BeginInit();
            SuspendLayout();
            // 
            // listofUniqMsgBox
            // 
            listofUniqMsgBox.FormattingEnabled = true;
            listofUniqMsgBox.ItemHeight = 18;
            listofUniqMsgBox.Location = new Point(682, 81);
            listofUniqMsgBox.Name = "listofUniqMsgBox";
            listofUniqMsgBox.SelectionMode = SelectionMode.None;
            listofUniqMsgBox.Size = new Size(316, 418);
            listofUniqMsgBox.TabIndex = 0;
            listofUniqMsgBox.SelectedIndexChanged += listofUniqMsgBox_SelectedIndexChanged;
            // 
            // inputFileLabel
            // 
            inputFileLabel.AutoSize = true;
            inputFileLabel.Location = new Point(11, 217);
            inputFileLabel.Name = "inputFileLabel";
            inputFileLabel.Size = new Size(100, 18);
            inputFileLabel.TabIndex = 1;
            inputFileLabel.Text = "Upload File";
            inputFileLabel.Click += inputFileLabel_Click;
            // 
            // reassmMsgLabel
            // 
            reassmMsgLabel.AutoSize = true;
            reassmMsgLabel.Location = new Point(11, 472);
            reassmMsgLabel.Name = "reassmMsgLabel";
            reassmMsgLabel.Size = new Size(202, 18);
            reassmMsgLabel.TabIndex = 2;
            reassmMsgLabel.Text = "ReAssembled Message:";
            reassmMsgLabel.Click += reassmMsgLabel_Click;
            // 
            // selectMsgLabel
            // 
            selectMsgLabel.AutoSize = true;
            selectMsgLabel.Location = new Point(11, 339);
            selectMsgLabel.Name = "selectMsgLabel";
            selectMsgLabel.Size = new Size(204, 18);
            selectMsgLabel.TabIndex = 3;
            selectMsgLabel.Text = "Select Message Number";
            selectMsgLabel.Click += selectMsgLabel_Click;
            // 
            // totNumMsgsLabel
            // 
            totNumMsgsLabel.AutoSize = true;
            totNumMsgsLabel.Location = new Point(469, 81);
            totNumMsgsLabel.Name = "totNumMsgsLabel";
            totNumMsgsLabel.Size = new Size(160, 18);
            totNumMsgsLabel.TabIndex = 4;
            totNumMsgsLabel.Text = "Tot # Msgs Parsed";
            totNumMsgsLabel.Click += totNumMsgsLabel_Click;
            // 
            // totNumWordsLabel
            // 
            totNumWordsLabel.AutoSize = true;
            totNumWordsLabel.Location = new Point(469, 145);
            totNumWordsLabel.Name = "totNumWordsLabel";
            totNumWordsLabel.Size = new Size(109, 18);
            totNumWordsLabel.TabIndex = 5;
            totNumWordsLabel.Text = "Tot # Words";
            totNumWordsLabel.Click += totNumWordsLabel_Click;
            // 
            // submitfileBtn
            // 
            submitfileBtn.Enabled = false;
            submitfileBtn.Location = new Point(203, 242);
            submitfileBtn.Name = "submitfileBtn";
            submitfileBtn.Size = new Size(75, 23);
            submitfileBtn.TabIndex = 6;
            submitfileBtn.Text = "Submit";
            submitfileBtn.UseVisualStyleBackColor = true;
            submitfileBtn.Click += submitfileBtn_Click;
            // 
            // submitMsgNumBox
            // 
            submitMsgNumBox.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            submitMsgNumBox.Location = new Point(147, 360);
            submitMsgNumBox.Name = "submitMsgNumBox";
            submitMsgNumBox.Size = new Size(192, 27);
            submitMsgNumBox.TabIndex = 8;
            submitMsgNumBox.Text = "Reassemble Message";
            submitMsgNumBox.UseVisualStyleBackColor = true;
            // 
            // msgNumList
            // 
            msgNumList.Location = new Point(11, 360);
            msgNumList.Name = "msgNumList";
            msgNumList.Size = new Size(120, 27);
            msgNumList.TabIndex = 9;
            msgNumList.ValueChanged += msgNumList_ValueChanged;
            // 
            // fileInputBox
            // 
            fileInputBox.Location = new Point(12, 238);
            fileInputBox.Name = "fileInputBox";
            fileInputBox.PlaceholderText = "select your .txt file...";
            fileInputBox.Size = new Size(185, 27);
            fileInputBox.TabIndex = 10;
            fileInputBox.Click += fileInputBox_Click;
            fileInputBox.TextChanged += fileInputBox_TextChanged;
            fileInputBox.Enter += fileInputBox_Enter;
            fileInputBox.Leave += fileInputBox_Leave;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text Files (.txt)|.txt";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // totWordsTxtBox
            // 
            totWordsTxtBox.Location = new Point(469, 166);
            totWordsTxtBox.Name = "totWordsTxtBox";
            totWordsTxtBox.ReadOnly = true;
            totWordsTxtBox.Size = new Size(109, 27);
            totWordsTxtBox.TabIndex = 11;
            totWordsTxtBox.TextChanged += totWordsTxtBox_TextChanged;
            // 
            // totmsgsTxtBox
            // 
            totmsgsTxtBox.Location = new Point(469, 102);
            totmsgsTxtBox.Name = "totmsgsTxtBox";
            totmsgsTxtBox.ReadOnly = true;
            totmsgsTxtBox.Size = new Size(109, 27);
            totmsgsTxtBox.TabIndex = 12;
            totmsgsTxtBox.TextChanged += totmsgsTxtBox_TextChanged;
            // 
            // uniqWordFounLabel
            // 
            uniqWordFounLabel.AutoSize = true;
            uniqWordFounLabel.Location = new Point(760, 60);
            uniqWordFounLabel.Name = "uniqWordFounLabel";
            uniqWordFounLabel.Size = new Size(177, 18);
            uniqWordFounLabel.TabIndex = 13;
            uniqWordFounLabel.Text = "Unique Words Found";
            uniqWordFounLabel.Click += uniqWordFounLabel_Click;
            // 
            // ressembledMsgOutput
            // 
            ressembledMsgOutput.Location = new Point(12, 493);
            ressembledMsgOutput.Name = "ressembledMsgOutput";
            ressembledMsgOutput.ReadOnly = true;
            ressembledMsgOutput.Size = new Size(454, 27);
            ressembledMsgOutput.TabIndex = 14;
            ressembledMsgOutput.TextChanged += ressembledMsgOutput_TextChanged;
            // 
            // formheaderLabel
            // 
            formheaderLabel.AutoSize = true;
            formheaderLabel.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point);
            formheaderLabel.ForeColor = Color.SteelBlue;
            formheaderLabel.Location = new Point(147, 12);
            formheaderLabel.Name = "formheaderLabel";
            formheaderLabel.Size = new Size(225, 66);
            formheaderLabel.TabIndex = 15;
            formheaderLabel.Text = "Raz's Message \r\nMapping Scheme!";
            formheaderLabel.Click += formheaderLabel_Click;
            // 
            // duckPicture
            // 
            duckPicture.Image = (Image)resources.GetObject("duckPicture.Image");
            duckPicture.Location = new Point(12, 12);
            duckPicture.Name = "duckPicture";
            duckPicture.Size = new Size(129, 140);
            duckPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            duckPicture.TabIndex = 16;
            duckPicture.TabStop = false;
            duckPicture.Click += pictureBox1_Click;
            // 
            // duckyPicCaption
            // 
            duckyPicCaption.AutoSize = true;
            duckyPicCaption.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            duckyPicCaption.Location = new Point(21, 155);
            duckyPicCaption.Name = "duckyPicCaption";
            duckyPicCaption.Size = new Size(119, 12);
            duckyPicCaption.TabIndex = 17;
            duckyPicCaption.Text = "Frank (Ducky) Ganther";
            duckyPicCaption.Click += duckyPicCaption_Click;
            // 
            // numUniqueWordsLabel
            // 
            numUniqueWordsLabel.AutoSize = true;
            numUniqueWordsLabel.Location = new Point(469, 207);
            numUniqueWordsLabel.Name = "numUniqueWordsLabel";
            numUniqueWordsLabel.Size = new Size(141, 18);
            numUniqueWordsLabel.TabIndex = 18;
            numUniqueWordsLabel.Text = "# Unique Words";
            numUniqueWordsLabel.Click += label1_Click;
            // 
            // numUnqWrdsTxtBox
            // 
            numUnqWrdsTxtBox.Location = new Point(469, 228);
            numUnqWrdsTxtBox.Name = "numUnqWrdsTxtBox";
            numUnqWrdsTxtBox.ReadOnly = true;
            numUnqWrdsTxtBox.Size = new Size(109, 27);
            numUnqWrdsTxtBox.TabIndex = 19;
            numUnqWrdsTxtBox.TextChanged += numUnqWrdsTxtBox_TextChanged;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn.Location = new Point(11, 562);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(111, 30);
            exitBtn.TabIndex = 20;
            exitBtn.Text = "Exit Program";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // myForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 595);
            Controls.Add(exitBtn);
            Controls.Add(numUnqWrdsTxtBox);
            Controls.Add(numUniqueWordsLabel);
            Controls.Add(duckyPicCaption);
            Controls.Add(duckPicture);
            Controls.Add(formheaderLabel);
            Controls.Add(ressembledMsgOutput);
            Controls.Add(uniqWordFounLabel);
            Controls.Add(totmsgsTxtBox);
            Controls.Add(totWordsTxtBox);
            Controls.Add(fileInputBox);
            Controls.Add(msgNumList);
            Controls.Add(submitMsgNumBox);
            Controls.Add(submitfileBtn);
            Controls.Add(totNumWordsLabel);
            Controls.Add(totNumMsgsLabel);
            Controls.Add(selectMsgLabel);
            Controls.Add(reassmMsgLabel);
            Controls.Add(inputFileLabel);
            Controls.Add(listofUniqMsgBox);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(1026, 634);
            MinimumSize = new Size(1026, 634);
            Name = "myForm";
            Text = "Final Lab - Message Mapping";
            Load += myForm_Load;
            ((System.ComponentModel.ISupportInitialize)msgNumList).EndInit();
            ((System.ComponentModel.ISupportInitialize)duckPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listofUniqMsgBox;
        private Label inputFileLabel;
        private Label reassmMsgLabel;
        private Label selectMsgLabel;
        private Label totNumMsgsLabel;
        private Label totNumWordsLabel;
        private Button submitfileBtn;
        private Button submitMsgNumBox;
        private NumericUpDown msgNumList;
        private TextBox fileInputBox;
        private OpenFileDialog openFileDialog1;
        private TextBox totWordsTxtBox;
        private TextBox totmsgsTxtBox;
        private Label uniqWordFounLabel;
        private TextBox ressembledMsgOutput;
        private Label formheaderLabel;
        private PictureBox duckPicture;
        private Label duckyPicCaption;
        private Label numUniqueWordsLabel;
        private TextBox numUnqWrdsTxtBox;
        private Button exitBtn;
    }
}