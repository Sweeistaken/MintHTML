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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openDevToolsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
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
            progressBar1 = new ProgressBar();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openDevToolsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openDevToolsToolStripMenuItem
            // 
            openDevToolsToolStripMenuItem.Enabled = false;
            openDevToolsToolStripMenuItem.Name = "openDevToolsToolStripMenuItem";
            openDevToolsToolStripMenuItem.Size = new Size(154, 22);
            openDevToolsToolStripMenuItem.Text = "Open DevTools";
            openDevToolsToolStripMenuItem.Click += openDevToolsToolStripMenuItem_Click_1;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(154, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            serifToolStripMenuItem.Click += serifToolStripMenuItem_Click;
            // 
            // sansSerifToolStripMenuItem
            // 
            sansSerifToolStripMenuItem.Checked = true;
            sansSerifToolStripMenuItem.CheckState = CheckState.Checked;
            sansSerifToolStripMenuItem.Name = "sansSerifToolStripMenuItem";
            sansSerifToolStripMenuItem.Size = new Size(176, 22);
            sansSerifToolStripMenuItem.Text = "(Default) Sans serif";
            sansSerifToolStripMenuItem.Click += sansSerifToolStripMenuItem_Click;
            // 
            // forceMonospaceToolStripMenuItem
            // 
            forceMonospaceToolStripMenuItem.Name = "forceMonospaceToolStripMenuItem";
            forceMonospaceToolStripMenuItem.Size = new Size(176, 22);
            forceMonospaceToolStripMenuItem.Text = "(Force) Monospace";
            forceMonospaceToolStripMenuItem.Click += forceMonospaceToolStripMenuItem_Click;
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
            groupBox4.Controls.Add(chromiumWebBrowser1);
            groupBox4.Controls.Add(progressBar1);
            groupBox4.Controls.Add(button4);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 91);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(800, 378);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Preview";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // chromiumWebBrowser1
            // 
            chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            chromiumWebBrowser1.Dock = DockStyle.Fill;
            chromiumWebBrowser1.Location = new Point(3, 47);
            chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            chromiumWebBrowser1.Size = new Size(794, 328);
            chromiumWebBrowser1.TabIndex = 3;
            chromiumWebBrowser1.LoadingStateChanged += chromiumWebBrowser1_LoadingStateChanged;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(3, 42);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(794, 5);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.Enabled = false;
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(3, 19);
            button4.Name = "button4";
            button4.Size = new Size(794, 23);
            button4.TabIndex = 1;
            button4.Text = "Render preview";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Bottom;
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(0, 469);
            button3.Name = "button3";
            button3.Size = new Size(800, 23);
            button3.TabIndex = 4;
            button3.Text = "Convert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(800, 67);
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
            button2.Size = new Size(794, 22);
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
            textBox2.Size = new Size(794, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(button3);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(633, 531);
            Name = "Form1";
            Text = "MintHTML";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog Opener;
        private SaveFileDialog Saver;
        private GroupBox groupBox4;
        private Button button3;
        private Button button4;
        private ToolStripMenuItem renderToolStripMenuItem;
        private ToolStripMenuItem fontFamilyToolStripMenuItem;
        private ToolStripMenuItem serifToolStripMenuItem;
        private ToolStripMenuItem sansSerifToolStripMenuItem;
        private ToolStripMenuItem forceMonospaceToolStripMenuItem;
        private ProgressBar progressBar1;
        private ToolStripMenuItem openDevToolsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox textBox2;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}
