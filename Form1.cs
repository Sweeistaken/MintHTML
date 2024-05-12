using CefSharp;
using CefSharp.WinForms;

namespace MintHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MintHTML is a simple Markdown converter and renderer made by SweeZero.", "About", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opener.ShowDialog();
            textBox2.Text = Opener.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saver.ShowDialog();
            textBox1.Text = Saver.FileName;

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.LoadHtml("<style>html{font-family: sans-serif}</style><h1>MintHTML</h1><p>Open a markdown file and press \"Render preview\" to see the output here.</p>");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
