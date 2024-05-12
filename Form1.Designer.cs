namespace MintHTML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            renderToolStripMenuItem = new ToolStripMenuItem();
            fontFamilyToolStripMenuItem = new ToolStripMenuItem();
            serifToolStripMenuItem = new ToolStripMenuItem();
            sansSerifToolStripMenuItem = new ToolStripMenuItem();
            forceMonospaceToolStripMenuItem = new ToolStripMenuItem();
            Opener = new OpenFileDialog();
            Saver = new SaveFileDialog();
            groupBox4 = new GroupBox();
            chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            button4 = new Button();
            progressBar1 = new ProgressBar();
            button3 = new Button();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 67);
            panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(401, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(399, 67);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Input file";
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(3, 42);
            button2.Name = "button2";
            button2.Size = new Size(393, 22);
            button2.TabIndex = 3;
            button2.Text = "Select file";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(3, 19);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Type path or select file below. ";
            textBox2.Size = new Size(393, 23);
            textBox2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 67);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output file";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(3, 42);
            button1.Name = "button1";
            button1.Size = new Size(395, 22);
            button1.TabIndex = 1;
            button1.Text = "Select path";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(3, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Type path or select path below. ";
            textBox1.Size = new Size(395, 23);
            textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, renderToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // renderToolStripMenuItem
            // 
            renderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontFamilyToolStripMenuItem });
            renderToolStripMenuItem.Name = "renderToolStripMenuItem";
            renderToolStripMenuItem.Size = new Size(56, 20);
            renderToolStripMenuItem.Text = "Render";
            // 
            // fontFamilyToolStripMenuItem
            // 
            fontFamilyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serifToolStripMenuItem, sansSerifToolStripMenuItem, forceMonospaceToolStripMenuItem });
            fontFamilyToolStripMenuItem.Name = "fontFamilyToolStripMenuItem";
            fontFamilyToolStripMenuItem.Size = new Size(136, 22);
            fontFamilyToolStripMenuItem.Text = "Font Family";
            // 
            // serifToolStripMenuItem
            // 
            serifToolStripMenuItem.Name = "serifToolStripMenuItem";
            serifToolStripMenuItem.Size = new Size(176, 22);
            serifToolStripMenuItem.Text = "Serif";
            // 
            // sansSerifToolStripMenuItem
            // 
            sansSerifToolStripMenuItem.Checked = true;
            sansSerifToolStripMenuItem.CheckState = CheckState.Checked;
            sansSerifToolStripMenuItem.Name = "sansSerifToolStripMenuItem";
            sansSerifToolStripMenuItem.Size = new Size(176, 22);
            sansSerifToolStripMenuItem.Text = "(Default) Sans serif";
            // 
            // forceMonospaceToolStripMenuItem
            // 
            forceMonospaceToolStripMenuItem.Name = "forceMonospaceToolStripMenuItem";
            forceMonospaceToolStripMenuItem.Size = new Size(176, 22);
            forceMonospaceToolStripMenuItem.Text = "(Force) Monospace";
            // 
            // Opener
            // 
            Opener.DefaultExt = "md";
            Opener.Filter = "Markdown files|*.md|All files|*.*";
            Opener.SupportMultiDottedExtensions = true;
            // 
            // Saver
            // 
            Saver.CheckPathExists = false;
            Saver.DefaultExt = "html";
            Saver.Filter = "HTML websites|*.html|All files|*.*";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(progressBar1);
            groupBox4.Controls.Add(chromiumWebBrowser1);
            groupBox4.Controls.Add(button4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 91);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(800, 401);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Preview";
            // 
            // chromiumWebBrowser1
            // 
            chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            chromiumWebBrowser1.Dock = DockStyle.Fill;
            chromiumWebBrowser1.Location = new Point(3, 42);
            chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            chromiumWebBrowser1.Size = new Size(794, 356);
            chromiumWebBrowser1.TabIndex = 0;
            chromiumWebBrowser1.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(3, 19);
            button4.Name = "button4";
            button4.Size = new Size(794, 23);
            button4.TabIndex = 1;
            button4.Text = "Render preview";
            button4.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(3, 42);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(794, 2);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Bottom;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(0, 469);
            button3.Name = "button3";
            button3.Size = new Size(800, 23);
            button3.TabIndex = 4;
            button3.Text = "Convert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(button3);
            Controls.Add(groupBox4);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(633, 531);
            Name = "Form1";
            Text = "MintHTML";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button1;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox textBox2;
        private OpenFileDialog Opener;
        private SaveFileDialog Saver;
        private GroupBox groupBox4;
        private Button button3;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private Button button4;
        private ToolStripMenuItem renderToolStripMenuItem;
        private ToolStripMenuItem fontFamilyToolStripMenuItem;
        private ToolStripMenuItem serifToolStripMenuItem;
        private ToolStripMenuItem sansSerifToolStripMenuItem;
        private ToolStripMenuItem forceMonospaceToolStripMenuItem;
        private ProgressBar progressBar1;
    }
}
