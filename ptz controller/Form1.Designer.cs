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
            this.setmotorpositions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "rotate left";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(626, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "rotate right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // DeltaLabel
            // 
            this.DeltaLabel.AutoSize = true;
            this.DeltaLabel.Location = new System.Drawing.Point(827, 332);
            this.DeltaLabel.Name = "DeltaLabel";
            this.DeltaLabel.Size = new System.Drawing.Size(86, 20);
            this.DeltaLabel.TabIndex = 5;
            this.DeltaLabel.Text = "DeltaLabel";
            this.DeltaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalDeltaLabel
            // 
            this.TotalDeltaLabel.AutoSize = true;
            this.TotalDeltaLabel.Location = new System.Drawing.Point(827, 361);
            this.TotalDeltaLabel.Name = "TotalDeltaLabel";
            this.TotalDeltaLabel.Size = new System.Drawing.Size(121, 20);
            this.TotalDeltaLabel.TabIndex = 6;
            this.TotalDeltaLabel.Text = "TotalDeltaLabel";
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(514, 287);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(112, 45);
            this.Up.TabIndex = 7;
            this.Up.Text = "up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(514, 453);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(111, 49);
            this.down.TabIndex = 8;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // rcvbuf
            // 
            this.rcvbuf.AutoSize = true;
            this.rcvbuf.Location = new System.Drawing.Point(196, 59);
            this.rcvbuf.Name = "rcvbuf";
            this.rcvbuf.Size = new System.Drawing.Size(48, 20);
            this.rcvbuf.TabIndex = 9;
            this.rcvbuf.Text = "0 0 0 ";
            this.rcvbuf.Click += new System.EventHandler(this.rcvbuf_Click);
            // 
            // x_position
            // 
            this.x_position.AutoSize = true;
            this.x_position.Location = new System.Drawing.Point(758, 385);
            this.x_position.Name = "x_position";
            this.x_position.Size = new System.Drawing.Size(80, 20);
            this.x_position.TabIndex = 10;
            this.x_position.Text = "x_position";
            this.x_position.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // store1
            // 
            this.store1.Location = new System.Drawing.Point(55, 99);
            this.store1.Name = "store1";
            this.store1.Size = new System.Drawing.Size(74, 38);
            this.store1.TabIndex = 11;
            this.store1.Text = "store1";
            this.store1.UseVisualStyleBackColor = true;
            this.store1.Click += new System.EventHandler(this.store1_Click);
            // 
            // store2
            // 
            this.store2.Location = new System.Drawing.Point(55, 143);
            this.store2.Name = "store2";
            this.store2.Size = new System.Drawing.Size(74, 38);
            this.store2.TabIndex = 13;
            this.store2.Text = "store2";
            this.store2.UseVisualStyleBackColor = true;
            this.store2.Click += new System.EventHandler(this.store2_Click);
            // 
            // store3
            // 
            this.store3.Location = new System.Drawing.Point(55, 187);
            this.store3.Name = "store3";
            this.store3.Size = new System.Drawing.Size(74, 38);
            this.store3.TabIndex = 14;
            this.store3.Text = "store3";
            this.store3.UseVisualStyleBackColor = true;
            this.store3.Click += new System.EventHandler(this.store3_Click);
            // 
            // store4
            // 
            this.store4.Location = new System.Drawing.Point(55, 231);
            this.store4.Name = "store4";
            this.store4.Size = new System.Drawing.Size(74, 38);
            this.store4.TabIndex = 15;
            this.store4.Text = "store4";
            this.store4.UseVisualStyleBackColor = true;
            this.store4.Click += new System.EventHandler(this.store4_Click);
            // 
            // recall4
            // 
            this.recall4.Location = new System.Drawing.Point(255, 231);
            this.recall4.Name = "recall4";
            this.recall4.Size = new System.Drawing.Size(74, 38);
            this.recall4.TabIndex = 19;
            this.recall4.Text = "recall4";
            this.recall4.UseVisualStyleBackColor = true;
            // 
            // recall3
            // 
            this.recall3.Location = new System.Drawing.Point(255, 187);
            this.recall3.Name = "recall3";
            this.recall3.Size = new System.Drawing.Size(74, 38);
            this.recall3.TabIndex = 18;
            this.recall3.Text = "recall3";
            this.recall3.UseVisualStyleBackColor = true;
            // 
            // recall2
            // 
            this.recall2.Location = new System.Drawing.Point(255, 143);
            this.recall2.Name = "recall2";
            this.recall2.Size = new System.Drawing.Size(74, 38);
            this.recall2.TabIndex = 17;
            this.recall2.Text = "recall2";
            this.recall2.UseVisualStyleBackColor = true;
            // 
            // recall1
            // 
            this.recall1.Location = new System.Drawing.Point(255, 99);
            this.recall1.Name = "recall1";
            this.recall1.Size = new System.Drawing.Size(74, 38);
            this.recall1.TabIndex = 16;
            this.recall1.Text = "recall1";
            this.recall1.UseVisualStyleBackColor = true;
            // 
            // fave1
            // 
            this.fave1.AutoSize = true;
            this.fave1.Location = new System.Drawing.Point(163, 108);
            this.fave1.Name = "fave1";
            this.fave1.Size = new System.Drawing.Size(44, 20);
            this.fave1.TabIndex = 20;
            this.fave1.Text = "0 0 0";
            this.fave1.Click += new System.EventHandler(this.fave1_Click_2);
            // 
            // fave2
            // 
            this.fave2.AutoSize = true;
            this.fave2.Location = new System.Drawing.Point(163, 152);
            this.fave2.Name = "fave2";
            this.fave2.Size = new System.Drawing.Size(44, 20);
            this.fave2.TabIndex = 21;
            this.fave2.Text = "0 0 0";
            this.fave2.Click += new System.EventHandler(this.fave2_Click);
            // 
            // fave3
            // 
            this.fave3.AutoSize = true;
            this.fave3.Location = new System.Drawing.Point(163, 196);
            this.fave3.Name = "fave3";
            this.fave3.Size = new System.Drawing.Size(44, 20);
            this.fave3.TabIndex = 22;
            this.fave3.Text = "0 0 0";
            // 
            // fave4
            // 
            this.fave4.AutoSize = true;
            this.fave4.Location = new System.Drawing.Point(163, 240);
            this.fave4.Name = "fave4";
            this.fave4.Size = new System.Drawing.Size(44, 20);
            this.fave4.TabIndex = 23;
            this.fave4.Text = "0 0 0";
            // 
            // motorPositions
            // 
            this.motorPositions.Location = new System.Drawing.Point(19, 38);
            this.motorPositions.Name = "motorPositions";
            this.motorPositions.Size = new System.Drawing.Size(152, 41);
            this.motorPositions.TabIndex = 25;
            this.motorPositions.Text = "motor positions";
            this.motorPositions.UseVisualStyleBackColor = true;
            this.motorPositions.Click += new System.EventHandler(this.motorPositions_Click);
            // 
            // playseq1
            // 
            this.playseq1.Location = new System.Drawing.Point(1053, 548);
            this.playseq1.Name = "playseq1";
            this.playseq1.Size = new System.Drawing.Size(113, 60);
            this.playseq1.TabIndex = 26;
            this.playseq1.Text = "play sequence1";
            this.playseq1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "open port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "close port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // portinfo
            // 
            this.portinfo.AutoSize = true;
            this.portinfo.Location = new System.Drawing.Point(196, 59);
            this.portinfo.Name = "portinfo";
            this.portinfo.Size = new System.Drawing.Size(88, 20);
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
            this.groupBox1.Location = new System.Drawing.Point(1053, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 205);
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
            this.groupBox2.Location = new System.Drawing.Point(1053, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 293);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Positions";
            // 
            // setmotorpositions
            // 
            this.setmotorpositions.Location = new System.Drawing.Point(706, 88);
            this.setmotorpositions.Name = "setmotorpositions";
            this.setmotorpositions.Size = new System.Drawing.Size(176, 74);
            this.setmotorpositions.TabIndex = 29;
            this.setmotorpositions.Text = "test set motor pos";
            this.setmotorpositions.UseVisualStyleBackColor = true;
            this.setmotorpositions.Click += new System.EventHandler(this.setmotorpositions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 762);
            this.Controls.Add(this.setmotorpositions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playseq1);
            this.Controls.Add(this.x_position);
            this.Controls.Add(this.down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.TotalDeltaLabel);
            this.Controls.Add(this.DeltaLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button setmotorpositions;
    }
}

