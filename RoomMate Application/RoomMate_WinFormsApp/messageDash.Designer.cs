using System.Runtime.InteropServices;

namespace RoomMate_WinFormsApp
{
    partial class messageDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messageDash));
            panel1 = new Panel();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            progressBar1 = new ProgressBar();
            splitContainer1 = new SplitContainer();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            panel6 = new Panel();
            label12 = new Label();
            panel5 = new Panel();
            label11 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            panel7 = new Panel();
            label8 = new Label();
            imageList1 = new ImageList(components);
            notifyIcon1 = new NotifyIcon(components);
            panel8 = new Panel();
            label15 = new Label();
            button3 = new Button();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 962);
            panel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = Properties.Resources.home2;
            btnDashboard.Location = new Point(0, 267);
            btnDashboard.Margin = new Padding(4, 5, 4, 5);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(266, 93);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 267);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(0, 213);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(266, 22);
            label2.TabIndex = 2;
            label2.Text = "Extra User Info";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(0, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 27);
            label1.TabIndex = 1;
            label1.Text = "John Doe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 37);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = Properties.Resources.exit2;
            btnExit.Location = new Point(1290, 0);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(69, 80);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(1349, 267);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(10, 124);
            progressBar1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(272, 267);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.AutoScroll = true;
            splitContainer1.Panel1.BackColor = Color.FromArgb(46, 51, 73);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(pictureBox5);
            splitContainer1.Panel1.Controls.Add(pictureBox6);
            splitContainer1.Panel1.Controls.Add(pictureBox4);
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.ForeColor = Color.Black;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.Controls.Add(richTextBox1);
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Panel2.Controls.Add(panel7);
            splitContainer1.Panel2.ForeColor = Color.Black;
            splitContainer1.Size = new Size(1068, 910);
            splitContainer1.SplitterDistance = 219;
            splitContainer1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 126, 249);
            label7.Location = new Point(97, 406);
            label7.Name = "label7";
            label7.Size = new Size(119, 93);
            label7.TabIndex = 8;
            label7.Text = "Gru (Sample Contact #5)";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 126, 249);
            label6.Location = new Point(97, 303);
            label6.Name = "label6";
            label6.Size = new Size(119, 93);
            label6.TabIndex = 7;
            label6.Text = "Fanta (Sample Contact #4)";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 126, 249);
            label5.Location = new Point(97, 202);
            label5.Name = "label5";
            label5.Size = new Size(119, 93);
            label5.TabIndex = 6;
            label5.Text = "Chicken (Sample Contact #3)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 126, 249);
            label4.Location = new Point(97, 103);
            label4.Name = "label4";
            label4.Size = new Size(119, 93);
            label4.TabIndex = 5;
            label4.Text = "Caseoh (Sample Contact #2)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 126, 249);
            label3.Location = new Point(97, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 93);
            label3.TabIndex = 0;
            label3.Text = "Bebe (Sample Contact #1)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.GruPFP;
            pictureBox5.Location = new Point(0, 404);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(95, 95);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.FantaPFP;
            pictureBox6.Location = new Point(0, 303);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(95, 95);
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.ChickenPFP;
            pictureBox4.Location = new Point(0, 202);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(95, 95);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.CaseohPFP;
            pictureBox3.Location = new Point(0, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(95, 95);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.BebePFP;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(95, 95);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(842, 499);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            richTextBox1.Click += hideRichTextBox;
            richTextBox1.Enter += hideRichTextBox;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(46, 51, 73);
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label12);
            panel6.ForeColor = Color.Black;
            panel6.Location = new Point(3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(839, 95);
            panel6.TabIndex = 8;
            panel6.Click += messagePanelClick;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(158, 161, 178);
            label12.Location = new Point(206, 7);
            label12.Name = "label12";
            label12.Size = new Size(333, 77);
            label12.TabIndex = 13;
            label12.Text = "Message preview...";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            label12.Click += messagePanelClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(46, 51, 73);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label11);
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(3, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(839, 95);
            panel5.TabIndex = 7;
            panel5.Click += messagePanelClick;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(158, 161, 178);
            label11.Location = new Point(236, 10);
            label11.Name = "label11";
            label11.Size = new Size(303, 72);
            label11.TabIndex = 12;
            label11.Text = "Message preview...";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += messagePanelClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(46, 51, 73);
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label10);
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(3, 202);
            panel4.Name = "panel4";
            panel4.Size = new Size(839, 95);
            panel4.TabIndex = 6;
            panel4.Click += messagePanelClick;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(158, 161, 178);
            label10.Location = new Point(209, 9);
            label10.Name = "label10";
            label10.Size = new Size(319, 70);
            label10.TabIndex = 11;
            label10.Text = "Message preview...";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += messagePanelClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(46, 51, 73);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label9);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(3, 303);
            panel3.Name = "panel3";
            panel3.Size = new Size(839, 95);
            panel3.TabIndex = 5;
            panel3.Click += messagePanelClick;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(158, 161, 178);
            label9.Location = new Point(209, 7);
            label9.Name = "label9";
            label9.Size = new Size(345, 75);
            label9.TabIndex = 10;
            label9.Text = "Message preview...";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += messagePanelClick;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(46, 51, 73);
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label8);
            panel7.ForeColor = Color.Black;
            panel7.Location = new Point(3, 404);
            panel7.Name = "panel7";
            panel7.Size = new Size(839, 95);
            panel7.TabIndex = 4;
            panel7.Click += messagePanelClick;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(158, 161, 178);
            label8.Location = new Point(209, 11);
            label8.Name = "label8";
            label8.Size = new Size(330, 71);
            label8.TabIndex = 9;
            label8.Text = "Message preview...";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += messagePanelClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "BebePFP.jpg");
            imageList1.Images.SetKeyName(1, "CaseohPFP.jpg");
            imageList1.Images.SetKeyName(2, "ChickenPFP.jpg");
            imageList1.Images.SetKeyName(3, "FantaPFP.jpg");
            imageList1.Images.SetKeyName(4, "GruPFP.png");
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(label15);
            panel8.Controls.Add(button3);
            panel8.ForeColor = Color.Transparent;
            panel8.Location = new Point(272, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1026, 80);
            panel8.TabIndex = 4;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(158, 161, 178);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(943, 77);
            label15.TabIndex = 14;
            label15.Text = "More buttons (will be added later)...";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(46, 51, 73);
            button3.BackgroundImage = Properties.Resources.notification;
            button3.ForeColor = Color.FromArgb(46, 51, 73);
            button3.Location = new Point(946, 0);
            button3.Name = "button3";
            button3.Size = new Size(80, 80);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += notifClick;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(158, 161, 178);
            label13.Location = new Point(272, 84);
            label13.Name = "label13";
            label13.Size = new Size(618, 151);
            label13.TabIndex = 14;
            label13.Text = "MESSAGES";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = Color.FromArgb(46, 51, 73);
            label14.Font = new Font("Segoe UI", 5F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(1218, 81);
            label14.Name = "label14";
            label14.Size = new Size(80, 152);
            label14.TabIndex = 3;
            label14.Text = "Sample notifications...";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            label14.Visible = false;
            // 
            // messageDash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1359, 962);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panel8);
            Controls.Add(splitContainer1);
            Controls.Add(progressBar1);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "messageDash";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "messageDash";
            Load += messageDash_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnDashboard;
        private Button btnExit;

        private Button currentButton;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public messageDash()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            currentButton = btnDashboard;
            ActivateButton(btnDashboard);
        }

        private void messageDash_Load(object sender, EventArgs e)
        {
            btnDashboard.Focus();
        }

        private void ActivateButton(Button button)
        {
            if (currentButton != null)
            {
                DeactivateButton(currentButton);
            }

            currentButton = button;
            //PnlNav.Height = button.Height;
            //PnlNav.Top = button.Top;
            //PnlNav.Left = button.Left;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void DeactivateButton(Button button)
        {
            button.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(btnDashboard);
        }

        //private void btnMessages_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(btnMessages);
        //}

        //private void btnMatches_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(btnMatches);
        //}

        //private void btnProfile_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(btnProfile);
        //}

        //private void btnSettings_Click(object sender, EventArgs e)
        //{
        //    ActivateButton(btnSettings);
        //}

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnDashboard);
        }

        private void hideRichTextBox(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }

        private void notifClick(object sender, EventArgs e)
        {
            if (label14.Visible == true)
            {
                label14.Visible = false;
            }
            else
            {
                label14.Visible = true;
            }
        }

        private void messagePanelClick(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }

        //private void btnMessages_Leave(object sender, EventArgs e)
        //{
        //    DeactivateButton(btnMessages);
        //}

        //private void btnMatches_Leave(object sender, EventArgs e)
        //{
        //    DeactivateButton(btnMatches);
        //}

        //private void btnProfile_Leave(object sender, EventArgs e)
        //{
        //    DeactivateButton(btnProfile);
        //}

        //private void btnSettings_Leave(object sender, EventArgs e)
        //{
        //    DeactivateButton(btnSettings);
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ProgressBar progressBar1;
        private SplitContainer splitContainer1;
        private ImageList imageList1;
        private NotifyIcon notifyIcon1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel7;
        private Panel panel8;
        private Label label3;
        private Label label5;
        private Label label4;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label13;
        private Button button3;
        private Label label14;
        private Label label15;
        private RichTextBox richTextBox1;
    }
}