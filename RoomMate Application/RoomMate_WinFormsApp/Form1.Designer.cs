namespace RoomMate_WinFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            PnlNav = new Panel();
            btnSettings = new Button();
            btnProfile = new Button();
            btnMatches = new Button();
            btnMessages = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            ProfilePanel = new Panel();
            profilePageLabel = new Label();
            savePrefbutton1 = new Button();
            yesButton6 = new Button();
            yesButton5 = new Button();
            yesButton4 = new Button();
            noButton6 = new Button();
            noButton5 = new Button();
            noButton4 = new Button();
            noButton3 = new Button();
            yesButton3 = new Button();
            noButton2 = new Button();
            yesButton2 = new Button();
            noButton1 = new Button();
            yesButton1 = new Button();
            q6 = new Label();
            q5 = new Label();
            q4 = new Label();
            q3 = new Label();
            q2 = new Label();
            q1 = new Label();
            Question6label = new Label();
            Question5label = new Label();
            Question4label = new Label();
            Question3label = new Label();
            Question2label = new Label();
            Question1label = new Label();
            AboutMelabel = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ProfilePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnMatches);
            panel1.Controls.Add(btnMessages);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 962);
            panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(0, 126, 249);
            PnlNav.Location = new Point(0, 322);
            PnlNav.Margin = new Padding(4, 5, 4, 5);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(4, 167);
            PnlNav.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(0, 869);
            btnSettings.Margin = new Padding(4, 5, 4, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(266, 93);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            btnSettings.Leave += btnSettings_Leave;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.FromArgb(0, 126, 249);
            btnProfile.Image = Properties.Resources.profile;
            btnProfile.Location = new Point(0, 546);
            btnProfile.Margin = new Padding(4, 5, 4, 5);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(266, 93);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            btnProfile.Leave += btnProfile_Leave;
            // 
            // btnMatches
            // 
            btnMatches.Dock = DockStyle.Top;
            btnMatches.FlatAppearance.BorderSize = 0;
            btnMatches.FlatStyle = FlatStyle.Flat;
            btnMatches.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMatches.ForeColor = Color.FromArgb(0, 126, 249);
            btnMatches.Image = Properties.Resources.matches;
            btnMatches.Location = new Point(0, 453);
            btnMatches.Margin = new Padding(4, 5, 4, 5);
            btnMatches.Name = "btnMatches";
            btnMatches.Size = new Size(266, 93);
            btnMatches.TabIndex = 1;
            btnMatches.Text = "Matches";
            btnMatches.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMatches.UseVisualStyleBackColor = true;
            btnMatches.Click += btnMatches_Click;
            btnMatches.Leave += btnMatches_Leave;
            // 
            // btnMessages
            // 
            btnMessages.Dock = DockStyle.Top;
            btnMessages.FlatAppearance.BorderSize = 0;
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMessages.ForeColor = Color.FromArgb(0, 126, 249);
            btnMessages.Image = Properties.Resources.messages;
            btnMessages.Location = new Point(0, 360);
            btnMessages.Margin = new Padding(4, 5, 4, 5);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(266, 93);
            btnMessages.TabIndex = 1;
            btnMessages.Text = "Messages";
            btnMessages.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMessages.UseVisualStyleBackColor = true;
            btnMessages.Click += btnMessages_Click;
            btnMessages.Leave += btnMessages_Leave;
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
            panel2.Margin = new Padding(4, 5, 4, 5);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            // ProfilePanel
            // 
            ProfilePanel.Controls.Add(profilePageLabel);
            ProfilePanel.Controls.Add(savePrefbutton1);
            ProfilePanel.Controls.Add(yesButton6);
            ProfilePanel.Controls.Add(yesButton5);
            ProfilePanel.Controls.Add(yesButton4);
            ProfilePanel.Controls.Add(noButton6);
            ProfilePanel.Controls.Add(noButton5);
            ProfilePanel.Controls.Add(noButton4);
            ProfilePanel.Controls.Add(noButton3);
            ProfilePanel.Controls.Add(yesButton3);
            ProfilePanel.Controls.Add(noButton2);
            ProfilePanel.Controls.Add(yesButton2);
            ProfilePanel.Controls.Add(noButton1);
            ProfilePanel.Controls.Add(yesButton1);
            ProfilePanel.Controls.Add(q6);
            ProfilePanel.Controls.Add(q5);
            ProfilePanel.Controls.Add(q4);
            ProfilePanel.Controls.Add(q3);
            ProfilePanel.Controls.Add(q2);
            ProfilePanel.Controls.Add(q1);
            ProfilePanel.Controls.Add(Question6label);
            ProfilePanel.Controls.Add(Question5label);
            ProfilePanel.Controls.Add(Question4label);
            ProfilePanel.Controls.Add(Question3label);
            ProfilePanel.Controls.Add(Question2label);
            ProfilePanel.Controls.Add(Question1label);
            ProfilePanel.Controls.Add(AboutMelabel);
            ProfilePanel.Controls.Add(textBox1);
            ProfilePanel.Location = new Point(274, 73);
            ProfilePanel.Margin = new Padding(4, 3, 4, 3);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(1070, 873);
            ProfilePanel.TabIndex = 2;
            // 
            // profilePageLabel
            // 
            profilePageLabel.Font = new Font("Segoe UI", 22F);
            profilePageLabel.ForeColor = SystemColors.Control;
            profilePageLabel.Location = new Point(374, 0);
            profilePageLabel.Margin = new Padding(4, 0, 4, 0);
            profilePageLabel.Name = "profilePageLabel";
            profilePageLabel.Size = new Size(290, 93);
            profilePageLabel.TabIndex = 27;
            profilePageLabel.Text = "Profile page";
            // 
            // savePrefbutton1
            // 
            savePrefbutton1.FlatStyle = FlatStyle.Flat;
            savePrefbutton1.ForeColor = SystemColors.Control;
            savePrefbutton1.Location = new Point(660, 97);
            savePrefbutton1.Margin = new Padding(4, 3, 4, 3);
            savePrefbutton1.Name = "savePrefbutton1";
            savePrefbutton1.Size = new Size(289, 37);
            savePrefbutton1.TabIndex = 26;
            savePrefbutton1.Text = "Save preferences";
            savePrefbutton1.UseVisualStyleBackColor = true;
            savePrefbutton1.Click += savePrefbutton1_Click;
            // 
            // yesButton6
            // 
            yesButton6.FlatStyle = FlatStyle.Flat;
            yesButton6.ForeColor = SystemColors.Control;
            yesButton6.Location = new Point(660, 753);
            yesButton6.Margin = new Padding(4, 3, 4, 3);
            yesButton6.Name = "yesButton6";
            yesButton6.Size = new Size(130, 37);
            yesButton6.TabIndex = 25;
            yesButton6.Tag = "tidy";
            yesButton6.Text = "Yes";
            yesButton6.UseVisualStyleBackColor = true;
            yesButton6.Click += yesButtonHandler_Click;
            // 
            // yesButton5
            // 
            yesButton5.FlatStyle = FlatStyle.Flat;
            yesButton5.ForeColor = SystemColors.Control;
            yesButton5.Location = new Point(660, 613);
            yesButton5.Margin = new Padding(4, 3, 4, 3);
            yesButton5.Name = "yesButton5";
            yesButton5.Size = new Size(130, 37);
            yesButton5.TabIndex = 24;
            yesButton5.Tag = "social";
            yesButton5.Text = "Yes";
            yesButton5.UseVisualStyleBackColor = true;
            yesButton5.Click += yesButtonHandler_Click;
            // 
            // yesButton4
            // 
            yesButton4.FlatStyle = FlatStyle.Flat;
            yesButton4.ForeColor = SystemColors.Control;
            yesButton4.Location = new Point(660, 490);
            yesButton4.Margin = new Padding(4, 3, 4, 3);
            yesButton4.Name = "yesButton4";
            yesButton4.Size = new Size(130, 37);
            yesButton4.TabIndex = 23;
            yesButton4.Tag = "late";
            yesButton4.Text = "Yes";
            yesButton4.UseVisualStyleBackColor = true;
            yesButton4.Click += yesButtonHandler_Click;
            // 
            // noButton6
            // 
            noButton6.FlatStyle = FlatStyle.Flat;
            noButton6.ForeColor = SystemColors.Control;
            noButton6.Location = new Point(819, 753);
            noButton6.Margin = new Padding(4, 3, 4, 3);
            noButton6.Name = "noButton6";
            noButton6.Size = new Size(130, 37);
            noButton6.TabIndex = 22;
            noButton6.Tag = "tidy";
            noButton6.Text = "No";
            noButton6.UseVisualStyleBackColor = true;
            noButton6.Click += noButtonHandler_Click;
            // 
            // noButton5
            // 
            noButton5.FlatStyle = FlatStyle.Flat;
            noButton5.ForeColor = SystemColors.Control;
            noButton5.Location = new Point(819, 613);
            noButton5.Margin = new Padding(4, 3, 4, 3);
            noButton5.Name = "noButton5";
            noButton5.Size = new Size(130, 37);
            noButton5.TabIndex = 21;
            noButton5.Tag = "social";
            noButton5.Text = "No";
            noButton5.UseVisualStyleBackColor = true;
            noButton5.Click += noButtonHandler_Click;
            // 
            // noButton4
            // 
            noButton4.FlatStyle = FlatStyle.Flat;
            noButton4.ForeColor = SystemColors.Control;
            noButton4.Location = new Point(819, 490);
            noButton4.Margin = new Padding(4, 3, 4, 3);
            noButton4.Name = "noButton4";
            noButton4.Size = new Size(130, 37);
            noButton4.TabIndex = 20;
            noButton4.Tag = "late";
            noButton4.Text = "No";
            noButton4.UseVisualStyleBackColor = true;
            noButton4.Click += noButtonHandler_Click;
            // 
            // noButton3
            // 
            noButton3.FlatStyle = FlatStyle.Flat;
            noButton3.ForeColor = SystemColors.Control;
            noButton3.Location = new Point(819, 400);
            noButton3.Margin = new Padding(4, 3, 4, 3);
            noButton3.Name = "noButton3";
            noButton3.Size = new Size(130, 37);
            noButton3.TabIndex = 19;
            noButton3.Tag = "early";
            noButton3.Text = "No";
            noButton3.UseVisualStyleBackColor = true;
            noButton3.Click += noButtonHandler_Click;
            // 
            // yesButton3
            // 
            yesButton3.FlatStyle = FlatStyle.Flat;
            yesButton3.ForeColor = SystemColors.Control;
            yesButton3.Location = new Point(660, 400);
            yesButton3.Margin = new Padding(4, 3, 4, 3);
            yesButton3.Name = "yesButton3";
            yesButton3.Size = new Size(130, 37);
            yesButton3.TabIndex = 18;
            yesButton3.Tag = "early";
            yesButton3.Text = "Yes";
            yesButton3.UseVisualStyleBackColor = true;
            yesButton3.Click += yesButtonHandler_Click;
            // 
            // noButton2
            // 
            noButton2.FlatStyle = FlatStyle.Flat;
            noButton2.ForeColor = SystemColors.Control;
            noButton2.Location = new Point(819, 307);
            noButton2.Margin = new Padding(4, 3, 4, 3);
            noButton2.Name = "noButton2";
            noButton2.Size = new Size(130, 37);
            noButton2.TabIndex = 17;
            noButton2.Tag = "pets";
            noButton2.Text = "No";
            noButton2.UseVisualStyleBackColor = true;
            noButton2.Click += noButtonHandler_Click;
            // 
            // yesButton2
            // 
            yesButton2.FlatStyle = FlatStyle.Flat;
            yesButton2.ForeColor = SystemColors.Control;
            yesButton2.Location = new Point(660, 307);
            yesButton2.Margin = new Padding(4, 3, 4, 3);
            yesButton2.Name = "yesButton2";
            yesButton2.Size = new Size(130, 37);
            yesButton2.TabIndex = 16;
            yesButton2.Tag = "pets";
            yesButton2.Text = "Yes";
            yesButton2.UseVisualStyleBackColor = true;
            yesButton2.Click += yesButtonHandler_Click;
            // 
            // noButton1
            // 
            noButton1.FlatStyle = FlatStyle.Flat;
            noButton1.ForeColor = SystemColors.Control;
            noButton1.Location = new Point(819, 192);
            noButton1.Margin = new Padding(4, 3, 4, 3);
            noButton1.Name = "noButton1";
            noButton1.Size = new Size(130, 37);
            noButton1.TabIndex = 15;
            noButton1.Tag = "quiet";
            noButton1.Text = "No";
            noButton1.UseVisualStyleBackColor = true;
            noButton1.Click += noButtonHandler_Click;
            // 
            // yesButton1
            // 
            yesButton1.FlatStyle = FlatStyle.Flat;
            yesButton1.ForeColor = SystemColors.Control;
            yesButton1.Location = new Point(660, 192);
            yesButton1.Margin = new Padding(4, 3, 4, 3);
            yesButton1.Name = "yesButton1";
            yesButton1.Size = new Size(130, 37);
            yesButton1.TabIndex = 14;
            yesButton1.Tag = "quiet";
            yesButton1.Text = "Yes";
            yesButton1.UseVisualStyleBackColor = true;
            yesButton1.Click += yesButtonHandler_Click;
            // 
            // q6
            // 
            q6.ForeColor = SystemColors.ButtonShadow;
            q6.Location = new Point(660, 677);
            q6.Margin = new Padding(4, 0, 4, 0);
            q6.Name = "q6";
            q6.Size = new Size(356, 57);
            q6.TabIndex = 13;
            q6.Text = "Do you prefer a roommate who keeps the common areas very tidy?";
            // 
            // q5
            // 
            q5.ForeColor = SystemColors.ButtonShadow;
            q5.Location = new Point(661, 543);
            q5.Margin = new Padding(4, 0, 4, 0);
            q5.Name = "q5";
            q5.Size = new Size(374, 67);
            q5.TabIndex = 12;
            q5.Text = "Do you expect to spend a lot of time with your roommate socially?";
            // 
            // q4
            // 
            q4.AutoSize = true;
            q4.ForeColor = SystemColors.ButtonShadow;
            q4.Location = new Point(661, 450);
            q4.Margin = new Padding(4, 0, 4, 0);
            q4.Name = "q4";
            q4.Size = new Size(320, 25);
            q4.TabIndex = 11;
            q4.Text = "Do you stay up late on a regular basis?";
            // 
            // q3
            // 
            q3.AutoSize = true;
            q3.ForeColor = SystemColors.ButtonShadow;
            q3.Location = new Point(660, 355);
            q3.Margin = new Padding(4, 0, 4, 0);
            q3.Name = "q3";
            q3.Size = new Size(186, 25);
            q3.TabIndex = 10;
            q3.Text = "Are you an early riser?";
            // 
            // q2
            // 
            q2.ForeColor = SystemColors.ButtonShadow;
            q2.Location = new Point(660, 240);
            q2.Margin = new Padding(4, 0, 4, 0);
            q2.Name = "q2";
            q2.Size = new Size(374, 57);
            q2.TabIndex = 9;
            q2.Text = "Are you okay with having pets in the apartment?";
            // 
            // q1
            // 
            q1.AutoSize = true;
            q1.ForeColor = SystemColors.ButtonShadow;
            q1.Location = new Point(660, 145);
            q1.Margin = new Padding(4, 0, 4, 0);
            q1.Name = "q1";
            q1.Size = new Size(342, 25);
            q1.TabIndex = 8;
            q1.Text = "Do you prefer a quiet living environment?";
            // 
            // Question6label
            // 
            Question6label.AutoSize = true;
            Question6label.Font = new Font("Segoe UI", 12F);
            Question6label.ForeColor = SystemColors.ButtonFace;
            Question6label.Location = new Point(526, 667);
            Question6label.Margin = new Padding(4, 0, 4, 0);
            Question6label.Name = "Question6label";
            Question6label.Size = new Size(136, 32);
            Question6label.TabIndex = 7;
            Question6label.Text = "Question 6:";
            // 
            // Question5label
            // 
            Question5label.AutoSize = true;
            Question5label.Font = new Font("Segoe UI", 12F);
            Question5label.ForeColor = SystemColors.ButtonFace;
            Question5label.Location = new Point(526, 533);
            Question5label.Margin = new Padding(4, 0, 4, 0);
            Question5label.Name = "Question5label";
            Question5label.Size = new Size(136, 32);
            Question5label.TabIndex = 6;
            Question5label.Text = "Question 5:";
            // 
            // Question4label
            // 
            Question4label.AutoSize = true;
            Question4label.Font = new Font("Segoe UI", 12F);
            Question4label.ForeColor = SystemColors.ButtonFace;
            Question4label.Location = new Point(526, 440);
            Question4label.Margin = new Padding(4, 0, 4, 0);
            Question4label.Name = "Question4label";
            Question4label.Size = new Size(136, 32);
            Question4label.TabIndex = 5;
            Question4label.Text = "Question 4:";
            // 
            // Question3label
            // 
            Question3label.AutoSize = true;
            Question3label.Font = new Font("Segoe UI", 12F);
            Question3label.ForeColor = SystemColors.ButtonFace;
            Question3label.Location = new Point(526, 347);
            Question3label.Margin = new Padding(4, 0, 4, 0);
            Question3label.Name = "Question3label";
            Question3label.Size = new Size(136, 32);
            Question3label.TabIndex = 4;
            Question3label.Text = "Question 3:";
            // 
            // Question2label
            // 
            Question2label.AutoSize = true;
            Question2label.Font = new Font("Segoe UI", 12F);
            Question2label.ForeColor = SystemColors.ButtonFace;
            Question2label.Location = new Point(526, 232);
            Question2label.Margin = new Padding(4, 0, 4, 0);
            Question2label.Name = "Question2label";
            Question2label.Size = new Size(136, 32);
            Question2label.TabIndex = 3;
            Question2label.Text = "Question 2:";
            // 
            // Question1label
            // 
            Question1label.AutoSize = true;
            Question1label.Font = new Font("Segoe UI", 12F);
            Question1label.ForeColor = SystemColors.ButtonFace;
            Question1label.Location = new Point(526, 137);
            Question1label.Margin = new Padding(4, 0, 4, 0);
            Question1label.Name = "Question1label";
            Question1label.Size = new Size(136, 32);
            Question1label.TabIndex = 2;
            Question1label.Text = "Question 1:";
            // 
            // AboutMelabel
            // 
            AboutMelabel.AutoSize = true;
            AboutMelabel.Font = new Font("Segoe UI", 12F);
            AboutMelabel.ForeColor = SystemColors.Control;
            AboutMelabel.Location = new Point(213, 135);
            AboutMelabel.Margin = new Padding(4, 0, 4, 0);
            AboutMelabel.Name = "AboutMelabel";
            AboutMelabel.Size = new Size(120, 32);
            AboutMelabel.TabIndex = 1;
            AboutMelabel.Text = "About me";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 232);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 557);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1359, 962);
            Controls.Add(btnExit);
            Controls.Add(ProfilePanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnDashboard;
        private Button btnSettings;
        private Button btnProfile;
        private Button btnMatches;
        private Button btnMessages;
        private Panel PnlNav;
        private Button btnExit;
        private Panel ProfilePanel;
        private TextBox textBox1;
        private Label AboutMelabel;
        private Label Question1label;
        private Label Question4label;
        private Label Question3label;
        private Label Question2label;
        private Label Question5label;
        private Label Question6label;
        private Label q2;
        private Label q1;
        private Label q3;
        private Label q6;
        private Label q5;
        private Label q4;
        private Button yesButton1;
        private Button noButton1;
        private Button noButton2;
        private Button yesButton2;
        private Button yesButton6;
        private Button yesButton5;
        private Button yesButton4;
        private Button noButton6;
        private Button noButton5;
        private Button noButton4;
        private Button noButton3;
        private Button yesButton3;
        private Button savePrefbutton1;
        private Label profilePageLabel;
    }
}
