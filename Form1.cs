namespace MintHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = radioButton1.Checked;
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
    }
}
