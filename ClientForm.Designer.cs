namespace App
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            progressBar1 = new ProgressBar();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            richTextBox2 = new RichTextBox();
            textBox3 = new TextBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            checkedListBox1 = new CheckedListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            webView22 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            bindingSource1 = new BindingSource(components);
            process1 = new System.Diagnostics.Process();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox4);
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(checkedListBox1);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(webView21);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 154);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(195, 39);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Domain";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Bottom;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { ".com", ".com.br", ".nl", ".es", ".fr", ".it" });
            comboBox1.Location = new Point(3, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 23);
            comboBox1.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(progressBar1);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 193);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(195, 46);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "0%";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(3, 19);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(189, 24);
            progressBar1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 117);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(3, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(189, 95);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(200, 100);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(richTextBox2);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(checkBox2);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.ForeColor = Color.FromArgb(0, 0, 0, 1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(192, 72);
            tabPage1.TabIndex = 0;
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(54, 28);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1245, 20);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(54, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 23);
            textBox3.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 26);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(42, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Set";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(44, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Get";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(192, 72);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "01";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(192, 72);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "02";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Bottom;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(0, 356);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(195, 94);
            checkedListBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(101, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "HomeRoom";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Room";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(webView22);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 450);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // webView22
            // 
            webView22.AllowExternalDrop = true;
            webView22.CreationProperties = null;
            webView22.DefaultBackgroundColor = Color.White;
            webView22.Dock = DockStyle.Fill;
            webView22.Location = new Point(0, 0);
            webView22.Name = "webView22";
            webView22.Size = new Size(601, 450);
            webView22.TabIndex = 0;
            webView22.ZoomFactor = 1D;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Fill;
            webView21.Location = new Point(0, 0);
            webView21.Name = "webView21";
            webView21.Size = new Size(601, 450);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "ClientForm";
            Text = "HabboClient";
            Load += ClientForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView22).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private BindingSource bindingSource1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView22;
        private GroupBox groupBox3;
        private ProgressBar progressBar1;
        private RichTextBox richTextBox2;
        private TextBox textBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private System.Diagnostics.Process process1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
        private Panel panel2;
        private System.Windows.Forms.Timer timer1;
    }
}