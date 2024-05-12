using CefSharp;
using CefSharp.WinForms;

namespace MintHTML
{
    public partial class Form1 : Form
    {
        string markfile;
        string htmlfile = "<h1>Welcome to MintHTML</h1><p>Open a markdown file and press \"Render preview\" to see the output here.</p>";
        string csssuffix = @"
div{
font-family: monospace;
background-color: #F3F3F3;
border: solid;
border-width: 1px
}
</style>";
        string css;
        // Custom functions
        private void convert()
        {
            htmlfile = "";
            using (StringReader reader = new StringReader(markfile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("# "))
                    {
                        line = "<h1>" + line[1..] + "</h1>";

                    }
                    else if (line.Contains("`"))
                    {
                        line = "<div>" + line[1..^1] + "</div>";
                    }
                    else
                    {
                        line = line + "<br>";
                    }
                    htmlfile += line;
                }
            }
        }
        // Custom functions end
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
            if (textBox2.Text.Length > 0)
            {
                markfile = File.ReadAllText(textBox2.Text);
                convert();
                chromiumWebBrowser1.LoadHtml(css + htmlfile);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            css = @"<style>
html{
font-family: sans-serif
}" + csssuffix;
            chromiumWebBrowser1.LoadHtml(css + htmlfile);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke(new Action(() => progressBar1.Visible = chromiumWebBrowser1.IsLoading));
        }

        private void openDevToolsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            chromiumWebBrowser1.ShowDevTools();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                markfile = File.ReadAllText(textBox2.Text);
                convert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            chromiumWebBrowser1.LoadHtml(css + htmlfile);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = textBox2.Text.Length > 0;
            button4.Enabled = textBox2.Text.Length > 0;
        }

        private void serifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            css = @"<style>
html{
font-family: serif
}" + csssuffix;
            sansSerifToolStripMenuItem.Checked = false;
            forceMonospaceToolStripMenuItem.Checked = false;
            serifToolStripMenuItem.Checked = true;
            chromiumWebBrowser1.LoadHtml(css + htmlfile);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void sansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            css = @"<style>
html{
font-family: sans-serif
}" + csssuffix;
            sansSerifToolStripMenuItem.Checked = true;
            forceMonospaceToolStripMenuItem.Checked = false;
            serifToolStripMenuItem.Checked = false;
            chromiumWebBrowser1.LoadHtml(css + htmlfile);
        }

        private void forceMonospaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            css = @"<style>
html{
font-family: monospace
}" + csssuffix;
            sansSerifToolStripMenuItem.Checked = false;
            forceMonospaceToolStripMenuItem.Checked = true;
            serifToolStripMenuItem.Checked = false;
            chromiumWebBrowser1.LoadHtml(css + htmlfile);
        }
    }
}
