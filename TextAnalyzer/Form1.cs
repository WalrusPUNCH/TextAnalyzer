using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class Main : Form
    {
        string[] FirstFilePathArray;
        string[] SecondFilePathArray;
        int CurrentFirstIndex;
        int CurrentSecondIndex;
        List<int[]> indexes = new List<int[]>();
        int PastaLength;
        public Main()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;
            FirstFilePathBox.ReadOnly = true;
            SecondFilePathBox.ReadOnly = true;
            openFileDialog1.Multiselect = true;
            openFileDialog2.Multiselect = true;
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files(*.*)| *.*";
            openFileDialog2.Filter = "Text files (*.txt)|*.txt|All files(*.*)| *.*";

        }

        private void ChooseFirstButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            List<string> _files = new List<string>();
            foreach (string file in openFileDialog1.FileNames)
                _files.Add(file);
            FirstFilePathArray = _files.ToArray();           
            richTextBox1.Text = Parser.GetRawText(FirstFilePathArray[0]);
            FirstFilePathBox.Text = FirstFilePathArray[0];
            CurrentFirstIndex = 0;
        }

        private void ChooseSecondButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            List<string> _files = new List<string>();
            foreach (string file in openFileDialog2.FileNames)
                _files.Add(file);
            SecondFilePathArray = _files.ToArray();
            richTextBox2.Text = Parser.GetRawText(SecondFilePathArray[SecondFilePathArray.Length-1]);
            CurrentSecondIndex = SecondFilePathArray.Length - 1;
            SecondFilePathBox.Text = SecondFilePathArray[SecondFilePathArray.Length - 1];

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            
            PastaLength = 0;
            int previous_finish = 0;
            int counter = 0;
            string previous_string = " ";
            Color[] ColorArray = new Color[] { Color.Purple, Color.Red, Color.Green, Color.RoyalBlue, Color.Yellow,  Color.Magenta };
            string[] FFArrayOfWords = Parser.ParseFirstFile(FirstFilePathBox.Text);
            string SFText = Parser.ParseSecondFile(SecondFilePathBox.Text);

            for (int i = 2; i < FFArrayOfWords.Length; i++)
            {
                string test_string = (FFArrayOfWords[i - 2] + " " + FFArrayOfWords[i - 1] + " " + FFArrayOfWords[i]);
                int[] result = Algorithms.search(test_string, SFText);

                if (result.Length > 0)
                {
                    foreach (int j in result)
                    {
                        try
                        {
                            int my1stPosition = richTextBox1.Find(test_string, j, System.Windows.Forms.RichTextBoxFinds.None);
                            int my2stPosition = richTextBox2.Find(test_string, j, System.Windows.Forms.RichTextBoxFinds.None);

                            if (my1stPosition != -1)
                                richTextBox1.SelectionStart = my1stPosition;
                            if (my2stPosition != -1)
                                richTextBox2.SelectionStart = my2stPosition;
                            richTextBox1.SelectionLength = test_string.Length;
                            richTextBox2.SelectionLength = test_string.Length;

                            if (my1stPosition > previous_finish)
                            {
                                counter++;
                            }
                            Color CustomColor = ColorArray[counter % ColorArray.Length];
                            PastaLength += (test_string.Length - Algorithms.LongestCommonSubstring(previous_string, test_string));

                            richTextBox1.SelectionColor = CustomColor;
                            richTextBox1.Text.Split();

                            richTextBox2.SelectionColor = CustomColor;
                            richTextBox2.Text.Split();

                            previous_finish = my1stPosition + test_string.Length;
                            previous_string = test_string;
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            return;
                        }
                    }
                     

                }
            }
            double PercentOfPasta = ((double)PastaLength*100.0)/SFText.Count();
            if (PercentOfPasta >= 98.0)
                PercentOfPasta = 100.0;
            MessageBox.Show($"{PercentOfPasta} %", "Відсоток плагіату");
            
        }




        private void FirstLeftButton_Click(object sender, EventArgs e)
        {
            if (CurrentFirstIndex - 1 >= 0)
            {
                CurrentFirstIndex--;
                ChangesOnForm(1);
                
            }
        }

        private void FirstRightButton_Click(object sender, EventArgs e)
        {
            if (CurrentFirstIndex + 1 <= FirstFilePathArray.Length-1)
            {
                CurrentFirstIndex++;
                ChangesOnForm(1);
            }
        }

        private void SecondLeftButton_Click(object sender, EventArgs e)
        {
            if (CurrentSecondIndex - 1 >= 0)
            {
                CurrentSecondIndex--;
                ChangesOnForm(2);
            }
        }

        private void SecondRightButton_Click(object sender, EventArgs e)
        {
            if (CurrentSecondIndex + 1 <= SecondFilePathArray.Length - 1)
            {
                CurrentSecondIndex++;
                ChangesOnForm(2);
            }
        }

        private void ChangesOnForm(int num_of_text)
        {
            if (num_of_text == 1)
            {
                richTextBox1.Text = Parser.GetRawText(FirstFilePathArray[CurrentFirstIndex]);
                FirstFilePathBox.Text = FirstFilePathArray[CurrentFirstIndex];
                
            }
            else if (num_of_text == 2)
            {
                richTextBox2.Text = Parser.GetRawText(SecondFilePathArray[CurrentSecondIndex]);
                SecondFilePathBox.Text = SecondFilePathArray[CurrentSecondIndex];
                
            }

            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.Text.Split();
            richTextBox2.SelectAll();
            richTextBox2.SelectionColor = Color.Black;
            richTextBox2.Text.Split();

        }

        private void CountWordsButton_Click(object sender, EventArgs e)
        {
            SortedList<string, int> WordsAmountList1 = Algorithms.CountWordsPlease(Parser.ParseSecondFile(FirstFilePathBox.Text));
            SortedList<string, int> WordsAmountList2 = Algorithms.CountWordsPlease(Parser.ParseSecondFile(SecondFilePathBox.Text));

           
            Form2 new_window = new Form2(WordsAmountList1, WordsAmountList2);
            new_window.Show();
        }
    }
}
