namespace Desktop_App
{
    public partial class Form1 : Form
    {
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sum = Convert.ToInt32(textBox1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = (sum + Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToInt32(textBox2.Text) + 1).ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
