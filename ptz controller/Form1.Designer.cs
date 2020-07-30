namespace ptz_controller
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DeltaLabel = new System.Windows.Forms.Label();
            this.TotalDeltaLabel = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.rcvbuf = new System.Windows.Forms.Label();
            this.right_position = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "open port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "close port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.rcvbuf.Location = new System.Drawing.Point(1017, 332);
            this.rcvbuf.Name = "rcvbuf";
            this.rcvbuf.Size = new System.Drawing.Size(52, 20);
            this.rcvbuf.TabIndex = 9;
            this.rcvbuf.Text = "rcvbuf";
            this.rcvbuf.Click += new System.EventHandler(this.rcvbuf_Click);
            // 
            // right_position
            // 
            this.right_position.AutoSize = true;
            this.right_position.Location = new System.Drawing.Point(758, 385);
            this.right_position.Name = "right_position";
            this.right_position.Size = new System.Drawing.Size(104, 20);
            this.right_position.TabIndex = 10;
            this.right_position.Text = "right_position";
            this.right_position.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 762);
            this.Controls.Add(this.right_position);
            this.Controls.Add(this.rcvbuf);
            this.Controls.Add(this.down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.TotalDeltaLabel);
            this.Controls.Add(this.DeltaLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label DeltaLabel;
        private System.Windows.Forms.Label TotalDeltaLabel;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Label rcvbuf;
        private System.Windows.Forms.Label right_position;
    }
}

