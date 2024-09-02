using CefSharp;
using CefSharp.WinForms;
using Markdig;
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
        string logo = @"<svg
   width=""25mm""
   height=""25mm""
   viewBox=""0 0 100 100""
   version=""1.1""
   id=""svg1""
   inkscape:version=""1.4-beta (62f545ba5e, 2024-04-22)""
   sodipodi:docname=""MintHTML.svg""
   xmlns:inkscape=""http://www.inkscape.org/namespaces/inkscape""
   xmlns:sodipodi=""http://sodipodi.sourceforge.net/DTD/sodipodi-0.dtd""
   xmlns=""http://www.w3.org/2000/svg""
   xmlns:svg=""http://www.w3.org/2000/svg"">
  <sodipodi:namedview
     id=""namedview1""
     pagecolor=""#ffffff""
     bordercolor=""#eeeeee""
     borderopacity=""1""
     inkscape:showpageshadow=""0""
     inkscape:pageopacity=""0""
     inkscape:pagecheckerboard=""0""
     inkscape:deskcolor=""#000000""
     inkscape:document-units=""mm""
     inkscape:zoom=""4""
     inkscape:cx=""103.875""
     inkscape:cy=""62.75""
     inkscape:window-width=""1920""
     inkscape:window-height=""969""
     inkscape:window-x=""-8""
     inkscape:window-y=""32""
     inkscape:window-maximized=""1""
     inkscape:current-layer=""layer1"" />
  <defs
     id=""defs1"" />
  <g
     inkscape:label=""Layer 1""
     inkscape:groupmode=""layer""
     id=""layer1"">
    <rect
       style=""fill:#000000;stroke-width:0.264583""
       id=""rect2""
       width=""100""
       height=""100""
       x=""-3.469447e-15""
       y=""0""
       rx=""15"" />
    <rect
       style=""fill:#a9ffb3;fill-opacity:1;stroke-width:0.264583""
       id=""rect2-5""
       width=""95""
       height=""95""
       x=""2.5""
       y=""2.5""
       rx=""15"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.359317""
       id=""rect3""
       width=""125.33405""
       height=""2.4006279""
       x=""-50.757618""
       y=""68.408752""
       ry=""0""
       transform=""matrix(0.71804028,-0.69600155,0.58703792,0.80955944,0,0)"" />
    <path
       style=""fill:#4d4d4d;fill-opacity:1;stroke-width:0.264583""
       d=""M 5.7826335,7.833701 C 6.3249699,6.864898 9.9130817,4.0877928 12.74463,3.2592624 14.140112,2.850935 14.776554,2.6346609 16.170726,2.5869648 24.237887,2.3109785 34.282995,2.4943104 34.282995,2.4943104 l 47.894017,-0.053794 c 0,0 2.103274,-0.094764 4.793562,0.7235022 2.690287,0.8182666 4.610245,2.3732157 4.610245,2.3732157 L 4.4768191,89.971887 c 0,0 -0.9439073,-1.115203 -1.6752998,-4.441828 C 2.2958955,83.230308 2.2469734,78.535212 2.3240358,73.334688 2.4667087,63.706474 2.4719358,51.214123 2.5169141,39.38142 2.5526012,29.99301 1.76337,17.258266 2.6044871,14.256492 3.7339195,10.225781 4.8762045,9.4529015 5.7826335,7.833701 Z""
       id=""path4""
       sodipodi:nodetypes=""ssscczccsssss"" />
    <text
       xml:space=""preserve""
       style=""font-size:50.8px;text-align:start;writing-mode:lr-tb;direction:ltr;text-anchor:start;fill:#000000;fill-opacity:1;stroke-width:0.264583""
       x=""5.9868383""
       y=""43.311028""
       id=""text5""><tspan
         sodipodi:role=""line""
         id=""tspan5""
         style=""font-size:50.8px;stroke-width:0.264583;font-family:sans-serif""
         x=""5.9868383""
         y=""43.311028"">M</tspan></text>
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.359917""
       id=""rect5""
       width=""75.990959""
       height=""2.338608""
       x=""8.0448132""
       y=""47.333435"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.302091""
       id=""rect5-1""
       width=""53.534142""
       height=""2.338608""
       x=""30.97875""
       y=""65.140961"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.264583""
       id=""rect6""
       width=""2.2489583""
       height=""84.137497""
       x=""83.34375""
       y=""14.022917"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.173775""
       id=""rect7""
       width=""2.0579753""
       height=""46.397991""
       x=""90.660507""
       y=""18.650173""
       rx=""0.86274511"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.25979""
       id=""rect8""
       width=""2.5135417""
       height=""16.96315""
       x=""58.701504""
       y=""48.815624"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.264583""
       id=""rect9""
       width=""2.0112033""
       height=""8.0681992""
       x=""84.487999""
       y=""-36.118576""
       transform=""rotate(29.535744)""
       rx=""1.5"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.264583""
       id=""rect9-7""
       width=""2.0112033""
       height=""8.0681992""
       x=""-75.221031""
       y=""54.385345""
       transform=""matrix(-0.87004833,0.49296644,0.49296644,0.87004833,0,0)""
       rx=""1.5"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.264583""
       id=""rect9-2""
       width=""2.0112033""
       height=""8.0681992""
       x=""32.818661""
       y=""-126.69437""
       transform=""matrix(0.87004833,-0.49296644,-0.49296644,-0.87004833,0,0)""
       rx=""1.5"" />
    <rect
       style=""fill:#000000;fill-opacity:1;stroke-width:0.264583""
       id=""rect9-7-3""
       width=""2.0112033""
       height=""8.0681992""
       x=""-126.36137""
       y=""-36.49017""
       transform=""rotate(-150.46426)""
       rx=""1.5"" />
  </g>
</svg>
";
        string css;
        // Custom functions
        private void convert()
        {
            htmlfile = Markdown.ToHtml(markfile);
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
            htmlfile = "<center>" + logo + htmlfile;
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
