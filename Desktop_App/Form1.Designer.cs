namespace Desktop_App
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Sun", "" }, -1, SystemColors.MenuHighlight, Color.Empty, null);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Light" }, -1, SystemColors.MenuHighlight, Color.Empty, null);
            ListViewItem listViewItem3 = new ListViewItem("Moon");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            dateTimePicker1 = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox2 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            button12 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkedListBox1 = new CheckedListBox();
            colorDialog1 = new ColorDialog();
            comboBox1 = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            domainUpDown1 = new DomainUpDown();
            errorProvider1 = new ErrorProvider(components);
            fileSystemWatcher1 = new FileSystemWatcher();
            flowLayoutPanel1 = new FlowLayoutPanel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            fontDialog1 = new FontDialog();
            groupBox1 = new GroupBox();
            helpProvider1 = new HelpProvider();
            hScrollBar1 = new HScrollBar();
            imageList1 = new ImageList(components);
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            listBox1 = new ListBox();
            listView1 = new ListView();
            maskedTextBox1 = new MaskedTextBox();
            notifyIcon1 = new NotifyIcon(components);
            numericUpDown2 = new NumericUpDown();
            openFileDialog1 = new OpenFileDialog();
            pageSetupDialog1 = new PageSetupDialog();
            pictureBox1 = new PictureBox();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewControl1 = new PrintPreviewControl();
            printPreviewDialog1 = new PrintPreviewDialog();
            process1 = new System.Diagnostics.Process();
            progressBar1 = new ProgressBar();
            propertyGrid1 = new PropertyGrid();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            richTextBox2 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            splitContainer1 = new SplitContainer();
            statusStrip1 = new StatusStrip();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox3 = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            toolStripContainer1 = new ToolStripContainer();
            toolTip1 = new ToolTip(components);
            treeView1 = new TreeView();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 30);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(82, 138);
            button2.Name = "button2";
            button2.Size = new Size(68, 50);
            button2.TabIndex = 4;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(156, 138);
            button3.Name = "button3";
            button3.Size = new Size(68, 50);
            button3.TabIndex = 5;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(8, 194);
            button4.Name = "button4";
            button4.Size = new Size(68, 50);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(8, 138);
            button1.Name = "button1";
            button1.Size = new Size(68, 50);
            button1.TabIndex = 7;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(82, 194);
            button5.Name = "button5";
            button5.Size = new Size(68, 50);
            button5.TabIndex = 8;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(156, 194);
            button6.Name = "button6";
            button6.Size = new Size(68, 50);
            button6.TabIndex = 9;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(8, 250);
            button7.Name = "button7";
            button7.Size = new Size(68, 48);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(82, 250);
            button8.Name = "button8";
            button8.Size = new Size(68, 48);
            button8.TabIndex = 11;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(156, 250);
            button9.Name = "button9";
            button9.Size = new Size(68, 48);
            button9.TabIndex = 12;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(230, 196);
            button10.Name = "button10";
            button10.Size = new Size(78, 48);
            button10.TabIndex = 14;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(230, 250);
            button11.Name = "button11";
            button11.Size = new Size(78, 48);
            button11.TabIndex = 15;
            button11.Text = "=";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(8, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 30);
            dateTimePicker1.TabIndex = 16;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 30);
            textBox2.TabIndex = 17;
            textBox2.Text = "1";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // bindingSource1
            // 
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // button12
            // 
            button12.Location = new Point(1003, 10);
            button12.Name = "button12";
            button12.Size = new Size(109, 33);
            button12.TabIndex = 19;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1003, 42);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 27);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(1003, 75);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 27);
            checkBox2.TabIndex = 21;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(1003, 108);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(112, 27);
            checkBox3.TabIndex = 22;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Book", "Pen", "Paper", "Pencil", "Rubber", "Sharpner" });
            checkedListBox1.Location = new Point(800, 7);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(129, 154);
            checkedListBox1.TabIndex = 23;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.DarkKhaki;
            colorDialog1.FullOpen = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1003, 176);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 31);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(23, 23);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1003, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 59;
            dataGridView1.Size = new Size(129, 52);
            dataGridView1.TabIndex = 26;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(1003, 295);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(174, 30);
            domainUpDown1.TabIndex = 27;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            fileSystemWatcher1.Changed += fileSystemWatcher1_Changed;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1003, 351);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(174, 33);
            flowLayoutPanel1.TabIndex = 28;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Location = new Point(1003, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 56);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(1063, 486);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(116, 36);
            hScrollBar1.TabIndex = 30;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(1063, 525);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 30);
            numericUpDown1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1063, 567);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 32;
            label1.Text = "Heading Level";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(64, 64, 0);
            linkLabel1.Location = new Point(1063, 590);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(86, 23);
            linkLabel1.TabIndex = 33;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Click Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Item One", "Item Two", "Item Three", "Item Four", "Item Five" });
            listBox1.Location = new Point(1057, 620);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 119);
            listBox1.TabIndex = 34;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(1056, 745);
            listView1.Name = "listView1";
            listView1.Size = new Size(175, 140);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 35;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(800, 165);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(145, 30);
            maskedTextBox1.TabIndex = 36;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Key Board\r\nMouse\r\nCharger";
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(800, 204);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(174, 30);
            numericUpDown2.TabIndex = 39;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(796, 254);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 72);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Location = new Point(796, 334);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(145, 145);
            printPreviewControl1.TabIndex = 41;
            printPreviewControl1.Click += printPreviewControl1_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(0, 0, 192);
            progressBar1.Cursor = Cursors.SizeAll;
            progressBar1.ForeColor = Color.Cyan;
            progressBar1.Location = new Point(858, 512);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(145, 33);
            progressBar1.TabIndex = 42;
            progressBar1.Click += progressBar1_Click;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(856, 567);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(188, 188);
            propertyGrid1.TabIndex = 43;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(858, 771);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 27);
            radioButton1.TabIndex = 44;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(856, 813);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(131, 27);
            radioButton2.TabIndex = 45;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(623, 7);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(145, 76);
            richTextBox2.TabIndex = 46;
            richTextBox2.Text = "Black\nWhite\nBlue";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(623, 97);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(148, 64);
            splitContainer1.SplitterDistance = 35;
            splitContainer1.TabIndex = 47;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(23, 23);
            statusStrip1.Location = new Point(0, 877);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1276, 22);
            statusStrip1.TabIndex = 50;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(612, 181);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(182, 145);
            tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(174, 109);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(174, 109);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Location = new Point(500, 334);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(290, 145);
            tableLayoutPanel1.TabIndex = 52;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(8, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 30);
            textBox3.TabIndex = 53;
            textBox3.Text = "Using Time:";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(217, 228);
            toolStripContainer1.ContentPanel.Load += toolStripContainer1_ContentPanel_Load;
            toolStripContainer1.Location = new Point(560, 525);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(217, 253);
            toolStripContainer1.TabIndex = 56;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(347, 554);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(175, 140);
            treeView1.TabIndex = 57;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(856, 672);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(36, 168);
            vScrollBar1.TabIndex = 58;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 899);
            Controls.Add(vScrollBar1);
            Controls.Add(treeView1);
            Controls.Add(toolStripContainer1);
            Controls.Add(textBox3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Controls.Add(richTextBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(propertyGrid1);
            Controls.Add(progressBar1);
            Controls.Add(printPreviewControl1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(maskedTextBox1);
            Controls.Add(listView1);
            Controls.Add(listBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(hScrollBar1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(domainUpDown1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button12);
            Controls.Add(textBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource bindingSource1;
        private Button button12;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckedListBox checkedListBox1;
        private ColorDialog colorDialog1;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private DomainUpDown domainUpDown1;
        private ErrorProvider errorProvider1;
        private FileSystemWatcher fileSystemWatcher1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FolderBrowserDialog folderBrowserDialog1;
        private FontDialog fontDialog1;
        private GroupBox groupBox1;
        private HScrollBar hScrollBar1;
        private HelpProvider helpProvider1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private ImageList imageList1;
        private LinkLabel linkLabel1;
        private ListBox listBox1;
        private ListView listView1;
        private MaskedTextBox maskedTextBox1;
        private NotifyIcon notifyIcon1;
        private NumericUpDown numericUpDown2;
        private OpenFileDialog openFileDialog1;
        private PageSetupDialog pageSetupDialog1;
        private PrintPreviewControl printPreviewControl1;
        private PictureBox pictureBox1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ProgressBar progressBar1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Diagnostics.Process process1;
        private RichTextBox richTextBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private PropertyGrid propertyGrid1;
        private SaveFileDialog saveFileDialog1;
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox3;
        private ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Timer timer2;
        private VScrollBar vScrollBar1;
        private TreeView treeView1;
        private ToolTip toolTip1;
    }
}
