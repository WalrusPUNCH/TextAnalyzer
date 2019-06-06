using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class Form2 : Form
    {
        public Form2(SortedList<string, int> FirstText, SortedList<string, int> SecondText)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            foreach (KeyValuePair<string, int> kvp in FirstText)
            {
                if (!String.IsNullOrEmpty(kvp.Key))
                    FirstTextGridView.Rows.Add(kvp.Key, kvp.Value);
            }
            foreach (KeyValuePair<string, int> kvp in SecondText)
            {
                if (!String.IsNullOrEmpty(kvp.Key))
                    SecondTextGridView.Rows.Add(kvp.Key, kvp.Value);

            }

        }
    }
}
