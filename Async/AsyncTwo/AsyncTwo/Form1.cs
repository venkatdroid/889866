using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacters()
        {

            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\venki\\source\\handson\\Async\\AwaitAsync\\Data.txt"))
            {

                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);


            }

            return count;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            label1.Text = "Processing.Please Wait ...";
            int count = await task;
            label1.Text = count.ToString() + " Chars in File";

        }
    }
}
