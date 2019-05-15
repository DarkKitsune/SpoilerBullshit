using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpoilerBullshit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            var joined = string.Concat(InputTextBox.Text.Select(c => $"||{c}||"));
            var lines = new string[(joined.Length / 990 + 1) * 2];
            var len = joined.Length / 990 + 1;
            for (var i = 0; i < len; i++)
            {
                lines[i * 2 + 1] = "";
                lines[i * 2] = joined.Substring(0, Math.Min(990, joined.Length));
                joined = joined.Substring(Math.Min(990, joined.Length));
            }
            OutputTextBox.Lines = lines;
        }
    }
}
