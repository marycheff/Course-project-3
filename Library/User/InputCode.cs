using System;
using System.Windows.Forms;

namespace Library
{

    public partial class InputCode : Form
    {
        public string InputedCode { get; private set; }
        public string ExpectedCode { get; private set; }
        public bool CodesMatch { get; private set; }
        public InputCode(string expectedCode)
        {
            ExpectedCode = expectedCode;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InputedCode = textBox1.Text.Trim();
            if (ExpectedCode == InputedCode)
            {
                MessageBox.Show("Коды совпадают");
                CodesMatch = true;
                Close();
            }
            else
            {
                MessageBox.Show("Коды  НЕ совпадают");
                CodesMatch = false;
                Close();
            }
        }
    }
}
