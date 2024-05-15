using CefSharp;
using CefSharp.WinForms;
using System.Linq.Expressions;

namespace MintHTML
{
    public partial class Form1 : Form
    {
        string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string markfile;
        string htmlfile = "<h1>Welcome to MintHTML</h1><p>Open a markdown file and press \"Render preview\" to see the output here.</p>";
        string csssuffix = @"
div{
font-family: monospace;
background-color: #F3F3F3;
border: solid;
border-width: 1px
}
</style>
<ul style=""list-style-type:circle;"">";
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
                    try
                    {
                    // Header 1
                    if (line[1..2] == "# ")
                    {
                        line = "<h1>" + line[1..] + "</h1>";

                    }
                    // Header 2
                    else if (line[1..3] == "## ")
                    {
                        line = "<h2>" + line[1..] + "</h2>";

                    }
                    // Header 3
                    else if (line[1..4] == "### ")
                    {
                        line = "<h3>" + line[1..] + "</h3>";

                    }
                    // Header 4
                    else if (line[1..5] == "#### ")
                    {
                        line = "<h4>" + line[1..] + "</h4>";

                    }
                    // Header 5
                    else if (line[1..6] == "##### ")
                    {
                        line = "<h5>" + line[1..] + "</h5>";

                    }
                    // Header 6
                    else if (line[1..7] == "###### ")
                    {
                        line = "<h6>" + line[1..] + "</h6>";

                    }
                    // Bullet point
                    else if (line[1..2] == "* ")
                    {
                        line = "<li>" + line[1..] + "</li>";
                    }
                    else if (line[1..2] == "- ")
                    {
                        line = "<li>" + line[1..] + "</li>";
                    } } catch{}
                    // Code block
                    if (line.Contains("`"))
                    {
                        line = "<div>" + line[1..^1] + "</div>";
                    }
                    // Everything else (Possibly paragraph or HTML code)
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
            if (File.Exists(appdata + "/SweeZero/MintHTML/RootCache/lockfile"))
            {
                if (MessageBox.Show("There is another instance of MintHTML running. If there isn't, press Yes to try opening anyways.", "Cef Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        File.Delete(appdata + "/SweeZero/MintHTML/RootCache/lockfile");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Cef Error (fatal)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            var settings = new CefSettings()
            {
                RootCachePath = appdata + "/SweeZero/MintHTML/RootCache",
            };
            InitializeComponent();
            Cef.Initialize(settings);
            css = @"<style>
html{
font-family: sans-serif
}" + csssuffix;
            chromiumWebBrowser1.LoadHtml(css + htmlfile);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MintHTML is a simple Markdown converter and renderer made by SweeZero's founder \"Swee.\"", "About", MessageBoxButtons.OK);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saver.FileName = textBox2.Text.Split("\\").Last()[0..^3] + ".html";
            DialogResult result = Saver.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Do you want to keep the current CSS settings?", "Converter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    convert();
                    File.WriteAllText(Saver.FileName, css + htmlfile);
                }
                else
                {
                    convert();
                    File.WriteAllText(Saver.FileName, htmlfile);
                }
                MessageBox.Show("Save complete.", "Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chromiumWebBrowser1.LoadHtml(css + htmlfile);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke(new Action(() => progressBar1.Visible = chromiumWebBrowser1.IsLoading));
            this.Invoke(new Action(() => openDevToolsToolStripMenuItem.Enabled = !chromiumWebBrowser1.IsLoading));
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
