namespace KeyQuest
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listBoxDatabase = new System.Windows.Forms.ListBox();
            this.listBoxDat = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.numQuestCount = new System.Windows.Forms.NumericUpDown();
            this.numKey = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelHR = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioKey = new System.Windows.Forms.RadioButton();
            this.radioUrgent = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuestCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Load mhfdat.bin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save as new dat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(132, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(252, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Up";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(372, 41);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "Down";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBoxDatabase
            // 
            this.listBoxDatabase.FormattingEnabled = true;
            this.listBoxDatabase.ItemHeight = 15;
            this.listBoxDatabase.Location = new System.Drawing.Point(12, 116);
            this.listBoxDatabase.Name = "listBoxDatabase";
            this.listBoxDatabase.Size = new System.Drawing.Size(264, 529);
            this.listBoxDatabase.TabIndex = 8;
            this.listBoxDatabase.SelectedIndexChanged += new System.EventHandler(this.listBoxDatabase_SelectedIndexChanged);
            // 
            // listBoxDat
            // 
            this.listBoxDat.FormattingEnabled = true;
            this.listBoxDat.ItemHeight = 15;
            this.listBoxDat.Location = new System.Drawing.Point(286, 161);
            this.listBoxDat.Name = "listBoxDat";
            this.listBoxDat.Size = new System.Drawing.Size(277, 484);
            this.listBoxDat.TabIndex = 9;
            this.listBoxDat.SelectedIndexChanged += new System.EventHandler(this.listBoxDat_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 87);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(264, 23);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Controls.Add(this.tabPage14);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.Controls.Add(this.tabPage16);
            this.tabControl1.Location = new System.Drawing.Point(282, 87);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(285, 39);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 11);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HR1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 11);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HR2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(277, 11);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HR3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(277, 11);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "HR4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(277, 11);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "HR5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(277, 11);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "HR6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(277, 11);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "G1";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(277, 11);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "G2";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(277, 11);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "G3";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 24);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(277, 11);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "G4";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 24);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(277, 11);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "G5";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 24);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(277, 11);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "G6";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 24);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(277, 11);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "G7";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 24);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(277, 11);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "G8";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 24);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(277, 11);
            this.tabPage15.TabIndex = 14;
            this.tabPage15.Text = "G9";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Location = new System.Drawing.Point(4, 24);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(277, 11);
            this.tabPage16.TabIndex = 15;
            this.tabPage16.Text = "G10";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // numQuestCount
            // 
            this.numQuestCount.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numQuestCount.Location = new System.Drawing.Point(430, 132);
            this.numQuestCount.Name = "numQuestCount";
            this.numQuestCount.ReadOnly = true;
            this.numQuestCount.Size = new System.Drawing.Size(120, 23);
            this.numQuestCount.TabIndex = 10;
            // 
            // numKey
            // 
            this.numKey.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numKey.Location = new System.Drawing.Point(850, 16);
            this.numKey.Name = "numKey";
            this.numKey.ReadOnly = true;
            this.numKey.Size = new System.Drawing.Size(56, 23);
            this.numKey.TabIndex = 12;
            this.numKey.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(912, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "/63";
            this.label17.Visible = false;
            // 
            // labelHR
            // 
            this.labelHR.AutoSize = true;
            this.labelHR.Location = new System.Drawing.Point(623, 87);
            this.labelHR.Name = "labelHR";
            this.labelHR.Size = new System.Drawing.Size(38, 15);
            this.labelHR.TabIndex = 15;
            this.labelHR.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(370, 36);
            this.textBox1.TabIndex = 14;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(623, 111);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(38, 15);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "label1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(573, 188);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(370, 36);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 230);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(370, 36);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(573, 272);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(370, 36);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(573, 314);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(370, 36);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(573, 356);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(370, 36);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(573, 398);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(370, 36);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(573, 440);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(370, 201);
            this.textBox8.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Location = new System.Drawing.Point(14, 6);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(54, 19);
            this.radioNone.TabIndex = 27;
            this.radioNone.TabStop = true;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            this.radioNone.CheckedChanged += new System.EventHandler(this.radioNone_CheckedChanged);
            // 
            // radioKey
            // 
            this.radioKey.AutoSize = true;
            this.radioKey.Location = new System.Drawing.Point(74, 6);
            this.radioKey.Name = "radioKey";
            this.radioKey.Size = new System.Drawing.Size(44, 19);
            this.radioKey.TabIndex = 28;
            this.radioKey.TabStop = true;
            this.radioKey.Text = "Key";
            this.radioKey.UseVisualStyleBackColor = true;
            this.radioKey.CheckedChanged += new System.EventHandler(this.radioKey_CheckedChanged);
            // 
            // radioUrgent
            // 
            this.radioUrgent.AutoSize = true;
            this.radioUrgent.Location = new System.Drawing.Point(124, 6);
            this.radioUrgent.Name = "radioUrgent";
            this.radioUrgent.Size = new System.Drawing.Size(61, 19);
            this.radioUrgent.TabIndex = 29;
            this.radioUrgent.TabStop = true;
            this.radioUrgent.Text = "Urgent";
            this.radioUrgent.UseVisualStyleBackColor = true;
            this.radioUrgent.CheckedChanged += new System.EventHandler(this.radioUrgent_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "HR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioNone);
            this.panel1.Controls.Add(this.radioKey);
            this.panel1.Controls.Add(this.radioUrgent);
            this.panel1.Location = new System.Drawing.Point(721, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(669, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 81);
            this.label1.TabIndex = 33;
            this.label1.Text = "HR1 = 1\r\nHR2 = 2~30\r\nHR3 = 31~50\r\nHR4 = 51 ~99\r\nHR5,6 = 100~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numQuestCount);
            this.Controls.Add(this.listBoxDat);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelHR);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.numKey);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxDatabase);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "KeyQuset";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuestCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ListBox listBoxDatabase;
        private ListBox listBoxDat;
        private TextBox textBoxSearch;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown numQuestCount;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private TabPage tabPage15;
        private NumericUpDown numKey;
        private Label label17;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabPage tabPage16;
        private Label labelHR;
        private TextBox textBox1;
        private Label labelID;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private OpenFileDialog openFileDialog1;
        private RadioButton radioNone;
        private RadioButton radioKey;
        private RadioButton radioUrgent;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label1;
    }
}