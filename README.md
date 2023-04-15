# RH_MyMM
![finallmmprojectpic](https://user-images.githubusercontent.com/71193841/232182843-ce4e2987-99bf-4be3-9cc3-2a7f163c4c6c.png)
•	The purpose of this lab is to store text messages in an efficient method.  
o	The goal is to not store the same word twice, from all of the messages.
o	Consider using arrays, arraylists, or lists.
•	Student’s have the choice of languages: C, Python, or Java.
•	This program can be a Windows or Console app.  A description of the window will be supplied.
•	In your program, create a comment header, at the top of the document, stating information about this lab.  Include:
o	Your name
o	CmpSc472, Final Lab
o	One- line description of the lab

Program Requirements
1.	Whatever language used, name the project/class “CmpSc472_MsgMapping”.
2.	Input: The messages will come from a text file.  Create your own text file with messages.
a.	I will use my own text file to grade your lab.
b.	This text file will contain at a minimum of 20 messages.
c.	Read each message, one line at a time.
d.	Messages shall contain status information about a specific topic/theme.
e.	Choose a them for our msgs, and write msgs where words are repeated.
i.	The alarm is set.
ii.	The alarm is disabled.
iii.	Emergency switch is disabled.
3.	Processing
a.	Part1: Reading in the messages.
i.	Read messages from the text file.  Ask the user to input the name of the text file.
ii.	Parse the string and store each word into an array, list, array, etc.
iii.	You will probably need supporting arrays/lists that keep track of (1) The words position in the array, (2) The # of words in a message, and (3) The position of the words for each message.
iv.	This part is finished when all messages have all of the words stored into the arrays/lists, with supporting info in other arrays/lists.
v.	At the end of this part, display . . .
1.	The number of unique words found, and stored
2.	The actual words.
3.	Display this info in a where all of the words don’t scroll off the screen.
b.	Part 2: Retrieving a message.
i.	After messages are read in, the user will ask to enter the message number they wish to retrieve.
ii.	Validate the number.  It must be between 1 and the max messages stored.
iii.	If valid, retrieve all of the words that comprise that message.
iv.	Put the message back together and display the message.
v.	Loop and ask for different messages until user s finished.
4.	Windows App Option
a.	After Part 1, the Windows app will display
i.	The file used to read in the text messages.
ii.	Show a count of the number of messages read in.
iii.	Show a count, and all of the different words read in.
b.	Part 2, 
i.	The message user wants to display.
ii.	The re-assembled message requested.

Deliverables
•	Submit the appropriate file, or compressed folder, based on the programming language and IDE you used.
•	You can submit your message text file, as well, but I have my own file to test with.

If you decide to makes a windows app for this lab, the window below might be a good design for your window.
 
