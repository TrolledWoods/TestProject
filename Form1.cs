using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("This is the nicest program ever!!!");

            Console.WriteLine("This might be a nice change to the program");

            Console.WriteLine("Hello World");
            Console.WriteLine("Text");
            Console.WriteLine("More Text");
            Console.WriteLine("Lorem ipsum");
        }
    }
}
