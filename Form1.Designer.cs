namespace Shotcounter
{
    partial class ShotCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShotCounter));
            tblive = new TextBox();
            tbblank = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLive = new Button();
            btnblank = new Button();
            lbllive = new Label();
            lblblank = new Label();
            label5 = new Label();
            lblshotnumber = new Label();
            btnReset = new Button();
            label3 = new Label();
            lblshots = new Label();
            label4 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tblive
            // 
            tblive.Location = new Point(63, 58);
            tblive.Name = "tblive";
            tblive.Size = new Size(114, 23);
            tblive.TabIndex = 0;
            tblive.TextChanged += tblive_TextChanged;
            // 
            // tbblank
            // 
            tbblank.Location = new Point(275, 58);
            tbblank.Name = "tbblank";
            tbblank.Size = new Size(122, 23);
            tbblank.TabIndex = 1;
            tbblank.TextChanged += tbblank_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 35);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 2;
            label1.Text = "Live";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 39);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Blank";
            // 
            // btnLive
            // 
            btnLive.Location = new Point(63, 132);
            btnLive.Name = "btnLive";
            btnLive.Size = new Size(104, 23);
            btnLive.TabIndex = 4;
            btnLive.Text = "Live Shot!";
            btnLive.UseVisualStyleBackColor = true;
            btnLive.Click += btnLive_Click;
            // 
            // btnblank
            // 
            btnblank.Location = new Point(276, 132);
            btnblank.Name = "btnblank";
            btnblank.Size = new Size(121, 23);
            btnblank.TabIndex = 5;
            btnblank.Text = "Blank Shot!";
            btnblank.UseVisualStyleBackColor = true;
            btnblank.Click += btnblank_Click;
            // 
            // lbllive
            // 
            lbllive.AutoSize = true;
            lbllive.Location = new Point(139, 93);
            lbllive.Name = "lbllive";
            lbllive.Size = new Size(13, 15);
            lbllive.TabIndex = 6;
            lbllive.Text = "0";
            // 
            // lblblank
            // 
            lblblank.AutoSize = true;
            lblblank.Location = new Point(348, 93);
            lblblank.Name = "lblblank";
            lblblank.Size = new Size(13, 15);
            lblblank.TabIndex = 7;
            lblblank.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 191);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 8;
            label5.Text = "Shot Number";
            // 
            // lblshotnumber
            // 
            lblshotnumber.AutoSize = true;
            lblshotnumber.Location = new Point(147, 191);
            lblshotnumber.Name = "lblshotnumber";
            lblshotnumber.Size = new Size(13, 15);
            lblshotnumber.TabIndex = 9;
            lblshotnumber.Text = "0";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(63, 231);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset!";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 23);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 11;
            label3.Text = "Total Shots:";
            // 
            // lblshots
            // 
            lblshots.AutoSize = true;
            lblshots.Location = new Point(239, 23);
            lblshots.Name = "lblshots";
            lblshots.Size = new Size(13, 15);
            lblshots.TabIndex = 12;
            lblshots.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 93);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 13;
            label4.Text = "Liveshots:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 93);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 14;
            label6.Text = "Blankshots:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ubt8oial2hvc1;
            pictureBox1.Location = new Point(239, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 183);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // ShotCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(435, 355);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lblshots);
            Controls.Add(label3);
            Controls.Add(btnReset);
            Controls.Add(lblshotnumber);
            Controls.Add(label5);
            Controls.Add(lblblank);
            Controls.Add(lbllive);
            Controls.Add(btnblank);
            Controls.Add(btnLive);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbblank);
            Controls.Add(tblive);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShotCounter";
            Text = "ShotCounter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tblive;
        private TextBox tbblank;
        private Label label1;
        private Label label2;
        private Button btnLive;
        private Button btnblank;
        private Label lbllive;
        private Label lblblank;
        private Label label5;
        private Label lblshotnumber;
        private Button btnReset;
        private Label label3;
        private Label lblshots;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
