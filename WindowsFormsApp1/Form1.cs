using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 @class = new Class1();

        private void button1_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text;
            @class.TestString(str);
            richTextBox1.Focus();
            int i = @class.Synbol_Number();
            richTextBox1.SelectionStart = i;
            label6.Text = @class.GetError();
            label7.Text = @class.GetResult();
            foreach (string id in @class.ID)
            {
                listBox2.Items.Add(id);
            }
            foreach (string cons in @class.Constants)
            {
                listBox1.Items.Add(cons);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
