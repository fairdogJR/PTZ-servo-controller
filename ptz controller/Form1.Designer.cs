﻿namespace ptz_controller
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DeltaLabel = new System.Windows.Forms.Label();
            this.TotalDeltaLabel = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.rcvbuf = new System.Windows.Forms.Label();
            this.x_position = new System.Windows.Forms.Label();
            this.store1 = new System.Windows.Forms.Button();
            this.store2 = new System.Windows.Forms.Button();
            this.store3 = new System.Windows.Forms.Button();
            this.store4 = new System.Windows.Forms.Button();
            this.recall4 = new System.Windows.Forms.Button();
            this.recall3 = new System.Windows.Forms.Button();
            this.recall2 = new System.Windows.Forms.Button();
            this.recall1 = new System.Windows.Forms.Button();
            this.fave1 = new System.Windows.Forms.Label();
            this.fave2 = new System.Windows.Forms.Label();
            this.fave3 = new System.Windows.Forms.Label();
            this.fave4 = new System.Windows.Forms.Label();
            this.motorPositions = new System.Windows.Forms.Button();
            this.playseq1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.portinfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.preset1 = new System.Windows.Forms.Button();
            this.preset2 = new System.Windows.Forms.Button();
            this.preset4 = new System.Windows.Forms.Button();
            this.preset3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.preset5 = new System.Windows.Forms.Button();
            this.upfaster = new System.Windows.Forms.Button();
            this.downfaster = new System.Windows.Forms.Button();
            this.rightfaster = new System.Windows.Forms.Button();
            this.leftfaster = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.wristdownfaster = new System.Windows.Forms.Button();
            this.wristupfaster = new System.Windows.Forms.Button();
            this.wristdown = new System.Windows.Forms.Button();
            this.wristup = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 30);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "rotate left";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "rotate right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // DeltaLabel
            // 
            this.DeltaLabel.AutoSize = true;
            this.DeltaLabel.Location = new System.Drawing.Point(611, 163);
            this.DeltaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeltaLabel.Name = "DeltaLabel";
            this.DeltaLabel.Size = new System.Drawing.Size(58, 13);
            this.DeltaLabel.TabIndex = 5;
            this.DeltaLabel.Text = "DeltaLabel";
            this.DeltaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalDeltaLabel
            // 
            this.TotalDeltaLabel.AutoSize = true;
            this.TotalDeltaLabel.Location = new System.Drawing.Point(611, 182);
            this.TotalDeltaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalDeltaLabel.Name = "TotalDeltaLabel";
            this.TotalDeltaLabel.Size = new System.Drawing.Size(82, 13);
            this.TotalDeltaLabel.TabIndex = 6;
            this.TotalDeltaLabel.Text = "TotalDeltaLabel";
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(129, 48);
            this.Up.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 29);
            this.Up.TabIndex = 7;
            this.Up.Text = "up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(129, 156);
            this.down.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(74, 32);
            this.down.TabIndex = 8;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // rcvbuf
            // 
            this.rcvbuf.AutoSize = true;
            this.rcvbuf.Location = new System.Drawing.Point(131, 38);
            this.rcvbuf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rcvbuf.Name = "rcvbuf";
            this.rcvbuf.Size = new System.Drawing.Size(74, 13);
            this.rcvbuf.TabIndex = 9;
            this.rcvbuf.Text = "Motor Position";
            this.rcvbuf.Click += new System.EventHandler(this.rcvbuf_Click);
            // 
            // x_position
            // 
            this.x_position.AutoSize = true;
            this.x_position.Location = new System.Drawing.Point(615, 213);
            this.x_position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x_position.Name = "x_position";
            this.x_position.Size = new System.Drawing.Size(54, 13);
            this.x_position.TabIndex = 10;
            this.x_position.Text = "x_position";
            this.x_position.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // store1
            // 
            this.store1.Location = new System.Drawing.Point(37, 64);
            this.store1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.store1.Name = "store1";
            this.store1.Size = new System.Drawing.Size(49, 25);
            this.store1.TabIndex = 11;
            this.store1.Text = "store1";
            this.store1.UseVisualStyleBackColor = true;
            this.store1.Click += new System.EventHandler(this.store1_Click);
            // 
            // store2
            // 
            this.store2.Location = new System.Drawing.Point(37, 93);
            this.store2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.store2.Name = "store2";
            this.store2.Size = new System.Drawing.Size(49, 25);
            this.store2.TabIndex = 13;
            this.store2.Text = "store2";
            this.store2.UseVisualStyleBackColor = true;
            this.store2.Click += new System.EventHandler(this.store2_Click);
            // 
            // store3
            // 
            this.store3.Location = new System.Drawing.Point(37, 122);
            this.store3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.store3.Name = "store3";
            this.store3.Size = new System.Drawing.Size(49, 25);
            this.store3.TabIndex = 14;
            this.store3.Text = "store3";
            this.store3.UseVisualStyleBackColor = true;
            this.store3.Click += new System.EventHandler(this.store3_Click);
            // 
            // store4
            // 
            this.store4.Location = new System.Drawing.Point(37, 150);
            this.store4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.store4.Name = "store4";
            this.store4.Size = new System.Drawing.Size(49, 25);
            this.store4.TabIndex = 15;
            this.store4.Text = "store4";
            this.store4.UseVisualStyleBackColor = true;
            this.store4.Click += new System.EventHandler(this.store4_Click);
            // 
            // recall4
            // 
            this.recall4.Location = new System.Drawing.Point(170, 150);
            this.recall4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recall4.Name = "recall4";
            this.recall4.Size = new System.Drawing.Size(49, 25);
            this.recall4.TabIndex = 19;
            this.recall4.Text = "recall4";
            this.recall4.UseVisualStyleBackColor = true;
            // 
            // recall3
            // 
            this.recall3.Location = new System.Drawing.Point(170, 122);
            this.recall3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recall3.Name = "recall3";
            this.recall3.Size = new System.Drawing.Size(49, 25);
            this.recall3.TabIndex = 18;
            this.recall3.Text = "recall3";
            this.recall3.UseVisualStyleBackColor = true;
            // 
            // recall2
            // 
            this.recall2.Location = new System.Drawing.Point(170, 93);
            this.recall2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recall2.Name = "recall2";
            this.recall2.Size = new System.Drawing.Size(49, 25);
            this.recall2.TabIndex = 17;
            this.recall2.Text = "recall2";
            this.recall2.UseVisualStyleBackColor = true;
            // 
            // recall1
            // 
            this.recall1.Location = new System.Drawing.Point(170, 64);
            this.recall1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recall1.Name = "recall1";
            this.recall1.Size = new System.Drawing.Size(49, 25);
            this.recall1.TabIndex = 16;
            this.recall1.Text = "recall1";
            this.recall1.UseVisualStyleBackColor = true;
            // 
            // fave1
            // 
            this.fave1.AutoSize = true;
            this.fave1.Location = new System.Drawing.Point(109, 70);
            this.fave1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fave1.Name = "fave1";
            this.fave1.Size = new System.Drawing.Size(31, 13);
            this.fave1.TabIndex = 20;
            this.fave1.Text = "0 0 0";
            this.fave1.Click += new System.EventHandler(this.fave1_Click_2);
            // 
            // fave2
            // 
            this.fave2.AutoSize = true;
            this.fave2.Location = new System.Drawing.Point(109, 99);
            this.fave2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fave2.Name = "fave2";
            this.fave2.Size = new System.Drawing.Size(31, 13);
            this.fave2.TabIndex = 21;
            this.fave2.Text = "0 0 0";
            this.fave2.Click += new System.EventHandler(this.fave2_Click);
            // 
            // fave3
            // 
            this.fave3.AutoSize = true;
            this.fave3.Location = new System.Drawing.Point(109, 127);
            this.fave3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fave3.Name = "fave3";
            this.fave3.Size = new System.Drawing.Size(31, 13);
            this.fave3.TabIndex = 22;
            this.fave3.Text = "0 0 0";
            // 
            // fave4
            // 
            this.fave4.AutoSize = true;
            this.fave4.Location = new System.Drawing.Point(109, 156);
            this.fave4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fave4.Name = "fave4";
            this.fave4.Size = new System.Drawing.Size(31, 13);
            this.fave4.TabIndex = 23;
            this.fave4.Text = "0 0 0";
            // 
            // motorPositions
            // 
            this.motorPositions.Location = new System.Drawing.Point(13, 25);
            this.motorPositions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.motorPositions.Name = "motorPositions";
            this.motorPositions.Size = new System.Drawing.Size(101, 27);
            this.motorPositions.TabIndex = 25;
            this.motorPositions.Text = "motor positions";
            this.motorPositions.UseVisualStyleBackColor = true;
            this.motorPositions.Click += new System.EventHandler(this.motorPositions_Click);
            // 
            // playseq1
            // 
            this.playseq1.Location = new System.Drawing.Point(702, 356);
            this.playseq1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playseq1.Name = "playseq1";
            this.playseq1.Size = new System.Drawing.Size(75, 39);
            this.playseq1.TabIndex = 26;
            this.playseq1.Text = "play sequence1";
            this.playseq1.UseVisualStyleBackColor = true;
            this.playseq1.Click += new System.EventHandler(this.playseq1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "open port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 86);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "close port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // portinfo
            // 
            this.portinfo.AutoSize = true;
            this.portinfo.Location = new System.Drawing.Point(131, 38);
            this.portinfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portinfo.Name = "portinfo";
            this.portinfo.Size = new System.Drawing.Size(60, 13);
            this.portinfo.TabIndex = 24;
            this.portinfo.Text = "Port closed";
            this.portinfo.Click += new System.EventHandler(this.portinfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.portinfo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(702, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(233, 133);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "connection";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.motorPositions);
            this.groupBox2.Controls.Add(this.fave4);
            this.groupBox2.Controls.Add(this.fave3);
            this.groupBox2.Controls.Add(this.fave2);
            this.groupBox2.Controls.Add(this.fave1);
            this.groupBox2.Controls.Add(this.recall4);
            this.groupBox2.Controls.Add(this.recall3);
            this.groupBox2.Controls.Add(this.recall2);
            this.groupBox2.Controls.Add(this.recall1);
            this.groupBox2.Controls.Add(this.store4);
            this.groupBox2.Controls.Add(this.store3);
            this.groupBox2.Controls.Add(this.store2);
            this.groupBox2.Controls.Add(this.store1);
            this.groupBox2.Controls.Add(this.rcvbuf);
            this.groupBox2.Location = new System.Drawing.Point(702, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(232, 190);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Positions";
            // 
            // preset1
            // 
            this.preset1.Location = new System.Drawing.Point(179, 19);
            this.preset1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preset1.Name = "preset1";
            this.preset1.Size = new System.Drawing.Size(70, 20);
            this.preset1.TabIndex = 29;
            this.preset1.Text = "zero pos";
            this.preset1.UseVisualStyleBackColor = true;
            this.preset1.Click += new System.EventHandler(this.preset1_Click);
            // 
            // preset2
            // 
            this.preset2.Location = new System.Drawing.Point(179, 46);
            this.preset2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preset2.Name = "preset2";
            this.preset2.Size = new System.Drawing.Size(70, 20);
            this.preset2.TabIndex = 30;
            this.preset2.Text = "preset2";
            this.preset2.UseVisualStyleBackColor = true;
            this.preset2.Click += new System.EventHandler(this.preset2_Click);
            // 
            // preset4
            // 
            this.preset4.Location = new System.Drawing.Point(179, 101);
            this.preset4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preset4.Name = "preset4";
            this.preset4.Size = new System.Drawing.Size(70, 20);
            this.preset4.TabIndex = 32;
            this.preset4.Text = "preset4";
            this.preset4.UseVisualStyleBackColor = true;
            this.preset4.Click += new System.EventHandler(this.preset4_Click);
            // 
            // preset3
            // 
            this.preset3.Location = new System.Drawing.Point(179, 73);
            this.preset3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preset3.Name = "preset3";
            this.preset3.Size = new System.Drawing.Size(70, 20);
            this.preset3.TabIndex = 31;
            this.preset3.Text = "preset3";
            this.preset3.UseVisualStyleBackColor = true;
            this.preset3.Click += new System.EventHandler(this.preset3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.preset5);
            this.groupBox3.Controls.Add(this.preset4);
            this.groupBox3.Controls.Add(this.preset3);
            this.groupBox3.Controls.Add(this.preset2);
            this.groupBox3.Controls.Add(this.preset1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(360, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(327, 133);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor Positions";
            // 
            // preset5
            // 
            this.preset5.Location = new System.Drawing.Point(253, 19);
            this.preset5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.preset5.Name = "preset5";
            this.preset5.Size = new System.Drawing.Size(70, 20);
            this.preset5.TabIndex = 33;
            this.preset5.Text = "preset5";
            this.preset5.UseVisualStyleBackColor = true;
            this.preset5.Click += new System.EventHandler(this.preset5_Click);
            // 
            // upfaster
            // 
            this.upfaster.Location = new System.Drawing.Point(149, 8);
            this.upfaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upfaster.Name = "upfaster";
            this.upfaster.Size = new System.Drawing.Size(41, 36);
            this.upfaster.TabIndex = 34;
            this.upfaster.Text = "up faster";
            this.upfaster.UseVisualStyleBackColor = true;
            this.upfaster.Click += new System.EventHandler(this.upfaster_Click);
            // 
            // downfaster
            // 
            this.downfaster.Location = new System.Drawing.Point(149, 192);
            this.downfaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downfaster.Name = "downfaster";
            this.downfaster.Size = new System.Drawing.Size(40, 36);
            this.downfaster.TabIndex = 35;
            this.downfaster.Text = "down faster";
            this.downfaster.UseVisualStyleBackColor = true;
            this.downfaster.Click += new System.EventHandler(this.downfaster_Click);
            // 
            // rightfaster
            // 
            this.rightfaster.Location = new System.Drawing.Point(284, 97);
            this.rightfaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightfaster.Name = "rightfaster";
            this.rightfaster.Size = new System.Drawing.Size(40, 36);
            this.rightfaster.TabIndex = 39;
            this.rightfaster.Text = "right faster";
            this.rightfaster.UseVisualStyleBackColor = true;
            this.rightfaster.Click += new System.EventHandler(this.rightfaster_Click);
            // 
            // leftfaster
            // 
            this.leftfaster.Location = new System.Drawing.Point(6, 97);
            this.leftfaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftfaster.Name = "leftfaster";
            this.leftfaster.Size = new System.Drawing.Size(41, 36);
            this.leftfaster.TabIndex = 38;
            this.leftfaster.Text = "left faster";
            this.leftfaster.UseVisualStyleBackColor = true;
            this.leftfaster.Click += new System.EventHandler(this.leftfaster_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(206, 99);
            this.right.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(74, 32);
            this.right.TabIndex = 37;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(51, 99);
            this.left.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 29);
            this.left.TabIndex = 36;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            this.left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.left_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Controls.Add(this.rightfaster);
            this.groupBox4.Controls.Add(this.leftfaster);
            this.groupBox4.Controls.Add(this.right);
            this.groupBox4.Controls.Add(this.left);
            this.groupBox4.Controls.Add(this.downfaster);
            this.groupBox4.Controls.Add(this.upfaster);
            this.groupBox4.Controls.Add(this.down);
            this.groupBox4.Controls.Add(this.Up);
            this.groupBox4.Location = new System.Drawing.Point(131, 163);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(328, 232);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "arm";
            // 
            // wristdownfaster
            // 
            this.wristdownfaster.Location = new System.Drawing.Point(7, 151);
            this.wristdownfaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wristdownfaster.Name = "wristdownfaster";
            this.wristdownfaster.Size = new System.Drawing.Size(74, 36);
            this.wristdownfaster.TabIndex = 43;
            this.wristdownfaster.Text = "down faster";
            this.wristdownfaster.UseVisualStyleBackColor = true;
            this.wristdownfaster.Click += new System.EventHandler(this.wristdownfaster_Click);
            // 
            // wristupfaster
            // 
            this.wristupfaster.Location = new System.Drawing.Point(7, 31);
            this.wristupfaster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wristupfaster.Name = "wristupfaster";
            this.wristupfaster.Size = new System.Drawing.Size(74, 36);
            this.wristupfaster.TabIndex = 42;
            this.wristupfaster.Text = "up faster";
            this.wristupfaster.UseVisualStyleBackColor = true;
            this.wristupfaster.Click += new System.EventHandler(this.wristupfaster_Click);
            // 
            // wristdown
            // 
            this.wristdown.Location = new System.Drawing.Point(7, 115);
            this.wristdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wristdown.Name = "wristdown";
            this.wristdown.Size = new System.Drawing.Size(74, 32);
            this.wristdown.TabIndex = 41;
            this.wristdown.Text = "down";
            this.wristdown.UseVisualStyleBackColor = true;
            this.wristdown.Click += new System.EventHandler(this.wristdown_Click);
            // 
            // wristup
            // 
            this.wristup.Location = new System.Drawing.Point(7, 70);
            this.wristup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wristup.Name = "wristup";
            this.wristup.Size = new System.Drawing.Size(75, 29);
            this.wristup.TabIndex = 40;
            this.wristup.Text = "up";
            this.wristup.UseVisualStyleBackColor = true;
            this.wristup.Click += new System.EventHandler(this.wristup_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox5.Controls.Add(this.wristdownfaster);
            this.groupBox5.Controls.Add(this.wristupfaster);
            this.groupBox5.Controls.Add(this.wristdown);
            this.groupBox5.Controls.Add(this.wristup);
            this.groupBox5.Location = new System.Drawing.Point(468, 172);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(98, 193);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "wrist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 495);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playseq1);
            this.Controls.Add(this.x_position);
            this.Controls.Add(this.TotalDeltaLabel);
            this.Controls.Add(this.DeltaLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
      //      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label DeltaLabel;
        private System.Windows.Forms.Label TotalDeltaLabel;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Label rcvbuf;
        private System.Windows.Forms.Label x_position;
        private System.Windows.Forms.Button store1;
        private System.Windows.Forms.Button store2;
        private System.Windows.Forms.Button store3;
        private System.Windows.Forms.Button store4;
        private System.Windows.Forms.Button recall4;
        private System.Windows.Forms.Button recall3;
        private System.Windows.Forms.Button recall2;
        private System.Windows.Forms.Button recall1;
        private System.Windows.Forms.Label fave1;
        private System.Windows.Forms.Label fave2;
        private System.Windows.Forms.Label fave3;
        private System.Windows.Forms.Label fave4;
        private System.Windows.Forms.Button motorPositions;
        private System.Windows.Forms.Button playseq1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label portinfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button preset1;
        private System.Windows.Forms.Button preset2;
        private System.Windows.Forms.Button preset4;
        private System.Windows.Forms.Button preset3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button upfaster;
        private System.Windows.Forms.Button downfaster;
        private System.Windows.Forms.Button rightfaster;
        private System.Windows.Forms.Button leftfaster;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button wristdownfaster;
        private System.Windows.Forms.Button wristupfaster;
        private System.Windows.Forms.Button wristdown;
        private System.Windows.Forms.Button wristup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button preset5;
    }
}

