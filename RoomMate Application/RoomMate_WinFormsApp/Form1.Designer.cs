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
            requestbutton = new Button();
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
            messages = new TableLayoutPanel();
            contacts = new Label();
            panelLabel = new Label();
            settings = new PictureBox();
            contactScroll = new VScrollBar();
            contactHolder = new TableLayoutPanel();
            chat = new Button();
            pfp = new PictureBox();
            name = new Label();
            notifications = new PictureBox();
            add = new PictureBox();
            search = new PictureBox();
            searchBar = new TextBox();
            notificationList = new CheckedListBox();
            contactMessages = new Panel();
            messageControls = new Panel();
            send = new PictureBox();
            messageEditor = new RichTextBox();
            textMessageViewer = new Panel();
            MatchesPanel1 = new Panel();
            SelectedUsersPreferences = new CheckedListBox();
            SelectedUsersPrefsLabel = new Label();
            SelectedUsersTextBio = new TextBox();
            SelectedUserslabel = new Label();
            refreshList = new Button();
            label3 = new Label();
            listBox1 = new ListBox();
            rightPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ProfilePanel.SuspendLayout();
            messages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settings).BeginInit();
            contactHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pfp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)notifications).BeginInit();
            ((System.ComponentModel.ISupportInitialize)add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search).BeginInit();
            contactMessages.SuspendLayout();
            messageControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)send).BeginInit();
            MatchesPanel1.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(requestbutton);
            panel1.Controls.Add(PnlNav);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnMatches);
            panel1.Controls.Add(btnMessages);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 770);
            panel1.TabIndex = 0;
            // 
            // requestbutton
            // 
            requestbutton.Location = new Point(60, 635);
            requestbutton.Margin = new Padding(2, 2, 2, 2);
            requestbutton.Name = "requestbutton";
            requestbutton.Size = new Size(90, 27);
            requestbutton.TabIndex = 3;
            requestbutton.Text = "request";
            requestbutton.UseVisualStyleBackColor = true;
            requestbutton.Click += requestbutton_Click;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(0, 126, 249);
            PnlNav.Location = new Point(0, 258);
            PnlNav.Margin = new Padding(3, 4, 3, 4);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 134);
            PnlNav.TabIndex = 2;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Ravie", 9.75F, FontStyle.Bold);
            btnSettings.ForeColor = Color.FromArgb(0, 126, 249);
            btnSettings.Image = Properties.Resources.settings;
            btnSettings.Location = new Point(0, 696);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(209, 74);
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
            btnProfile.Font = new Font("Ravie", 9.75F, FontStyle.Bold);
            btnProfile.ForeColor = Color.FromArgb(0, 126, 249);
            btnProfile.Image = Properties.Resources.profile;
            btnProfile.Location = new Point(0, 436);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(209, 74);
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
            btnMatches.Font = new Font("Ravie", 9.75F, FontStyle.Bold);
            btnMatches.ForeColor = Color.FromArgb(0, 126, 249);
            btnMatches.Image = Properties.Resources.matches;
            btnMatches.Location = new Point(0, 362);
            btnMatches.Margin = new Padding(3, 4, 3, 4);
            btnMatches.Name = "btnMatches";
            btnMatches.Size = new Size(209, 74);
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
            btnMessages.Font = new Font("Ravie", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMessages.ForeColor = Color.FromArgb(0, 126, 249);
            btnMessages.Image = Properties.Resources.messages;
            btnMessages.Location = new Point(0, 288);
            btnMessages.Margin = new Padding(3, 4, 3, 4);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(209, 74);
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
            btnDashboard.Font = new Font("Ravie", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(0, 126, 249);
            btnDashboard.Image = Properties.Resources.home2;
            btnDashboard.Location = new Point(0, 214);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(209, 74);
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
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 214);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("MV Boli", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(0, 170);
            label2.Name = "label2";
            label2.Size = new Size(213, 18);
            label2.TabIndex = 2;
            label2.Text = "Extra User Info";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Bodoni MT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(0, 130);
            label1.Name = "label1";
            label1.Size = new Size(213, 22);
            label1.TabIndex = 1;
            label1.Text = "John Doe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 30);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            ProfilePanel.Dock = DockStyle.Fill;
            ProfilePanel.Location = new Point(0, 0);
            ProfilePanel.Margin = new Padding(0);
            ProfilePanel.Name = "ProfilePanel";
            ProfilePanel.Size = new Size(867, 770);
            ProfilePanel.TabIndex = 2;
            ProfilePanel.Visible = false;
            // 
            // profilePageLabel
            // 
            profilePageLabel.Font = new Font("Segoe UI", 22F);
            profilePageLabel.ForeColor = SystemColors.Control;
            profilePageLabel.Location = new Point(33, 38);
            profilePageLabel.Name = "profilePageLabel";
            profilePageLabel.Size = new Size(232, 74);
            profilePageLabel.TabIndex = 27;
            profilePageLabel.Text = "Profile page";
            // 
            // savePrefbutton1
            // 
            savePrefbutton1.FlatStyle = FlatStyle.Flat;
            savePrefbutton1.ForeColor = SystemColors.Control;
            savePrefbutton1.Location = new Point(530, 682);
            savePrefbutton1.Margin = new Padding(3, 2, 3, 2);
            savePrefbutton1.Name = "savePrefbutton1";
            savePrefbutton1.Size = new Size(242, 50);
            savePrefbutton1.TabIndex = 26;
            savePrefbutton1.Text = "Save preferences";
            savePrefbutton1.UseVisualStyleBackColor = true;
            savePrefbutton1.Click += savePrefbutton1_Click;
            // 
            // yesButton6
            // 
            yesButton6.FlatStyle = FlatStyle.Flat;
            yesButton6.ForeColor = SystemColors.Control;
            yesButton6.Location = new Point(542, 578);
            yesButton6.Margin = new Padding(3, 2, 3, 2);
            yesButton6.Name = "yesButton6";
            yesButton6.Size = new Size(104, 30);
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
            yesButton5.Location = new Point(542, 466);
            yesButton5.Margin = new Padding(3, 2, 3, 2);
            yesButton5.Name = "yesButton5";
            yesButton5.Size = new Size(104, 30);
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
            yesButton4.Location = new Point(542, 368);
            yesButton4.Margin = new Padding(3, 2, 3, 2);
            yesButton4.Name = "yesButton4";
            yesButton4.Size = new Size(104, 30);
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
            noButton6.Location = new Point(669, 578);
            noButton6.Margin = new Padding(3, 2, 3, 2);
            noButton6.Name = "noButton6";
            noButton6.Size = new Size(104, 30);
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
            noButton5.Location = new Point(669, 466);
            noButton5.Margin = new Padding(3, 2, 3, 2);
            noButton5.Name = "noButton5";
            noButton5.Size = new Size(104, 30);
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
            noButton4.Location = new Point(669, 368);
            noButton4.Margin = new Padding(3, 2, 3, 2);
            noButton4.Name = "noButton4";
            noButton4.Size = new Size(104, 30);
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
            noButton3.Location = new Point(669, 296);
            noButton3.Margin = new Padding(3, 2, 3, 2);
            noButton3.Name = "noButton3";
            noButton3.Size = new Size(104, 30);
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
            yesButton3.Location = new Point(542, 296);
            yesButton3.Margin = new Padding(3, 2, 3, 2);
            yesButton3.Name = "yesButton3";
            yesButton3.Size = new Size(104, 30);
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
            noButton2.Location = new Point(669, 214);
            noButton2.Margin = new Padding(3, 2, 3, 2);
            noButton2.Name = "noButton2";
            noButton2.Size = new Size(104, 30);
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
            yesButton2.Location = new Point(542, 214);
            yesButton2.Margin = new Padding(3, 2, 3, 2);
            yesButton2.Name = "yesButton2";
            yesButton2.Size = new Size(104, 30);
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
            noButton1.Location = new Point(669, 130);
            noButton1.Margin = new Padding(3, 2, 3, 2);
            noButton1.Name = "noButton1";
            noButton1.Size = new Size(104, 30);
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
            yesButton1.Location = new Point(542, 130);
            yesButton1.Margin = new Padding(3, 2, 3, 2);
            yesButton1.Name = "yesButton1";
            yesButton1.Size = new Size(104, 30);
            yesButton1.TabIndex = 14;
            yesButton1.Tag = "quiet";
            yesButton1.Text = "Yes";
            yesButton1.UseVisualStyleBackColor = true;
            yesButton1.Click += yesButtonHandler_Click;
            // 
            // q6
            // 
            q6.ForeColor = SystemColors.ButtonShadow;
            q6.Location = new Point(542, 518);
            q6.Name = "q6";
            q6.Size = new Size(285, 46);
            q6.TabIndex = 13;
            q6.Text = "Do you prefer a roommate who keeps the common areas very tidy?";
            // 
            // q5
            // 
            q5.ForeColor = SystemColors.ButtonShadow;
            q5.Location = new Point(543, 410);
            q5.Name = "q5";
            q5.Size = new Size(299, 54);
            q5.TabIndex = 12;
            q5.Text = "Do you expect to spend a lot of time with your roommate socially?";
            // 
            // q4
            // 
            q4.AutoSize = true;
            q4.ForeColor = SystemColors.ButtonShadow;
            q4.Location = new Point(543, 336);
            q4.Name = "q4";
            q4.Size = new Size(265, 20);
            q4.TabIndex = 11;
            q4.Text = "Do you stay up late on a regular basis?";
            // 
            // q3
            // 
            q3.AutoSize = true;
            q3.ForeColor = SystemColors.ButtonShadow;
            q3.Location = new Point(542, 260);
            q3.Name = "q3";
            q3.Size = new Size(155, 20);
            q3.TabIndex = 10;
            q3.Text = "Are you an early riser?";
            // 
            // q2
            // 
            q2.ForeColor = SystemColors.ButtonShadow;
            q2.Location = new Point(542, 178);
            q2.Name = "q2";
            q2.Size = new Size(299, 30);
            q2.TabIndex = 9;
            q2.Text = "Are you okay with having pets in the apartment?";
            // 
            // q1
            // 
            q1.AutoSize = true;
            q1.ForeColor = SystemColors.ButtonShadow;
            q1.Location = new Point(542, 92);
            q1.Name = "q1";
            q1.Size = new Size(285, 20);
            q1.TabIndex = 8;
            q1.Text = "Do you prefer a quiet living environment?";
            // 
            // Question6label
            // 
            Question6label.AutoSize = true;
            Question6label.Font = new Font("Segoe UI", 12F);
            Question6label.ForeColor = SystemColors.ButtonFace;
            Question6label.Location = new Point(434, 510);
            Question6label.Name = "Question6label";
            Question6label.Size = new Size(111, 28);
            Question6label.TabIndex = 7;
            Question6label.Text = "Question 6:";
            // 
            // Question5label
            // 
            Question5label.AutoSize = true;
            Question5label.Font = new Font("Segoe UI", 12F);
            Question5label.ForeColor = SystemColors.ButtonFace;
            Question5label.Location = new Point(434, 402);
            Question5label.Name = "Question5label";
            Question5label.Size = new Size(111, 28);
            Question5label.TabIndex = 6;
            Question5label.Text = "Question 5:";
            // 
            // Question4label
            // 
            Question4label.AutoSize = true;
            Question4label.Font = new Font("Segoe UI", 12F);
            Question4label.ForeColor = SystemColors.ButtonFace;
            Question4label.Location = new Point(434, 328);
            Question4label.Name = "Question4label";
            Question4label.Size = new Size(111, 28);
            Question4label.TabIndex = 5;
            Question4label.Text = "Question 4:";
            // 
            // Question3label
            // 
            Question3label.AutoSize = true;
            Question3label.Font = new Font("Segoe UI", 12F);
            Question3label.ForeColor = SystemColors.ButtonFace;
            Question3label.Location = new Point(434, 254);
            Question3label.Name = "Question3label";
            Question3label.Size = new Size(111, 28);
            Question3label.TabIndex = 4;
            Question3label.Text = "Question 3:";
            // 
            // Question2label
            // 
            Question2label.AutoSize = true;
            Question2label.Font = new Font("Segoe UI", 12F);
            Question2label.ForeColor = SystemColors.ButtonFace;
            Question2label.Location = new Point(434, 170);
            Question2label.Name = "Question2label";
            Question2label.Size = new Size(111, 28);
            Question2label.TabIndex = 3;
            Question2label.Text = "Question 2:";
            // 
            // Question1label
            // 
            Question1label.AutoSize = true;
            Question1label.Font = new Font("Segoe UI", 12F);
            Question1label.ForeColor = SystemColors.ButtonFace;
            Question1label.Location = new Point(434, 86);
            Question1label.Name = "Question1label";
            Question1label.Size = new Size(111, 28);
            Question1label.TabIndex = 2;
            Question1label.Text = "Question 1:";
            // 
            // AboutMelabel
            // 
            AboutMelabel.AutoSize = true;
            AboutMelabel.Font = new Font("Segoe UI", 12F);
            AboutMelabel.ForeColor = SystemColors.Control;
            AboutMelabel.Location = new Point(33, 170);
            AboutMelabel.Name = "AboutMelabel";
            AboutMelabel.Size = new Size(99, 28);
            AboutMelabel.TabIndex = 1;
            AboutMelabel.Text = "About me";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 214);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Write something about yourself...";
            textBox1.Size = new Size(361, 516);
            textBox1.TabIndex = 0;
            // 
            // messages
            // 
            messages.ColumnCount = 7;
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.1500549F));
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9132652F));
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.8418369F));
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            messages.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 78F));
            messages.Controls.Add(contacts, 0, 1);
            messages.Controls.Add(panelLabel, 0, 0);
            messages.Controls.Add(settings, 6, 0);
            messages.Controls.Add(contactScroll, 1, 2);
            messages.Controls.Add(contactHolder, 0, 2);
            messages.Controls.Add(notifications, 5, 0);
            messages.Controls.Add(add, 4, 0);
            messages.Controls.Add(search, 3, 0);
            messages.Controls.Add(searchBar, 2, 0);
            messages.Controls.Add(notificationList, 4, 1);
            messages.Dock = DockStyle.Fill;
            messages.Location = new Point(0, 0);
            messages.Margin = new Padding(2, 2, 2, 2);
            messages.Name = "messages";
            messages.RowCount = 3;
            messages.RowStyles.Add(new RowStyle(SizeType.Percent, 44.23077F));
            messages.RowStyles.Add(new RowStyle(SizeType.Percent, 55.76923F));
            messages.RowStyles.Add(new RowStyle(SizeType.Absolute, 602F));
            messages.RowStyles.Add(new RowStyle(SizeType.Absolute, 354F));
            messages.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            messages.Size = new Size(867, 770);
            messages.TabIndex = 28;
            messages.Visible = false;
            // 
            // contacts
            // 
            contacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contacts.Font = new Font("Ravie", 15F);
            contacts.Location = new Point(8, 82);
            contacts.Margin = new Padding(8, 8, 8, 8);
            contacts.Name = "contacts";
            contacts.Size = new Size(367, 77);
            contacts.TabIndex = 9;
            contacts.Text = "Contacts";
            contacts.TextAlign = ContentAlignment.BottomCenter;
            // 
            // panelLabel
            // 
            panelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelLabel.Font = new Font("Ravie", 20F);
            panelLabel.Location = new Point(8, 8);
            panelLabel.Margin = new Padding(8, 8, 8, 8);
            panelLabel.Name = "panelLabel";
            panelLabel.Size = new Size(367, 58);
            panelLabel.TabIndex = 0;
            panelLabel.Text = "MESSAGES";
            panelLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // settings
            // 
            settings.Image = Properties.Resources.settingsIcon;
            settings.Location = new Point(789, 2);
            settings.Margin = new Padding(2, 2, 2, 2);
            settings.Name = "settings";
            settings.Size = new Size(66, 68);
            settings.SizeMode = PictureBoxSizeMode.Zoom;
            settings.TabIndex = 5;
            settings.TabStop = false;
            // 
            // contactScroll
            // 
            contactScroll.Location = new Point(383, 167);
            contactScroll.Name = "contactScroll";
            contactScroll.Size = new Size(27, 602);
            contactScroll.TabIndex = 11;
            // 
            // contactHolder
            // 
            contactHolder.ColumnCount = 2;
            contactHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.1203327F));
            contactHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.87967F));
            contactHolder.Controls.Add(chat, 1, 0);
            contactHolder.Controls.Add(pfp, 0, 0);
            contactHolder.Controls.Add(name, 0, 1);
            contactHolder.Location = new Point(2, 169);
            contactHolder.Margin = new Padding(2, 2, 2, 2);
            contactHolder.Name = "contactHolder";
            contactHolder.RowCount = 2;
            contactHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 60.5150223F));
            contactHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 39.4849777F));
            contactHolder.Size = new Size(1, 186);
            contactHolder.TabIndex = 12;
            // 
            // chat
            // 
            chat.Dock = DockStyle.Top;
            chat.Location = new Point(2, 2);
            chat.Margin = new Padding(2, 2, 2, 2);
            chat.Name = "chat";
            contactHolder.SetRowSpan(chat, 2);
            chat.Size = new Size(1, 134);
            chat.TabIndex = 2;
            chat.UseVisualStyleBackColor = true;
            chat.Click += chat_Click;
            // 
            // pfp
            // 
            pfp.Anchor = AnchorStyles.None;
            pfp.Image = Properties.Resources.parteek;
            pfp.Location = new Point(2, 8);
            pfp.Margin = new Padding(2, 2, 2, 2);
            pfp.Name = "pfp";
            pfp.Size = new Size(1, 96);
            pfp.SizeMode = PictureBoxSizeMode.StretchImage;
            pfp.TabIndex = 0;
            pfp.TabStop = false;
            // 
            // name
            // 
            name.Dock = DockStyle.Top;
            name.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = SystemColors.Control;
            name.Location = new Point(2, 112);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(1, 22);
            name.TabIndex = 1;
            name.Text = "Parteek";
            name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // notifications
            // 
            notifications.Image = Properties.Resources.notificationsResized;
            notifications.Location = new Point(718, 2);
            notifications.Margin = new Padding(2, 2, 2, 2);
            notifications.Name = "notifications";
            notifications.Size = new Size(65, 68);
            notifications.SizeMode = PictureBoxSizeMode.Zoom;
            notifications.TabIndex = 4;
            notifications.TabStop = false;
            notifications.Click += notifications_Click;
            // 
            // add
            // 
            add.Image = Properties.Resources.plus1;
            add.Location = new Point(647, 2);
            add.Margin = new Padding(2, 2, 2, 2);
            add.Name = "add";
            add.Size = new Size(65, 68);
            add.SizeMode = PictureBoxSizeMode.Zoom;
            add.TabIndex = 6;
            add.TabStop = false;
            add.Click += add_Click;
            // 
            // search
            // 
            search.Image = Properties.Resources.searchIcon;
            search.Location = new Point(581, 2);
            search.Margin = new Padding(2, 2, 2, 2);
            search.Name = "search";
            search.Size = new Size(1, 68);
            search.SizeMode = PictureBoxSizeMode.Zoom;
            search.TabIndex = 3;
            search.TabStop = false;
            search.Click += search_Click;
            // 
            // searchBar
            // 
            searchBar.Anchor = AnchorStyles.None;
            searchBar.Location = new Point(495, 23);
            searchBar.Margin = new Padding(2, 2, 2, 2);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(2, 27);
            searchBar.TabIndex = 13;
            searchBar.Visible = false;
            // 
            // notificationList
            // 
            messages.SetColumnSpan(notificationList, 3);
            notificationList.FormattingEnabled = true;
            notificationList.Location = new Point(647, 76);
            notificationList.Margin = new Padding(2, 2, 2, 2);
            notificationList.Name = "notificationList";
            messages.SetRowSpan(notificationList, 2);
            notificationList.Size = new Size(213, 664);
            notificationList.TabIndex = 14;
            notificationList.Visible = false;
            // 
            // contactMessages
            // 
            contactMessages.AutoScroll = true;
            contactMessages.Controls.Add(messageControls);
            contactMessages.Controls.Add(textMessageViewer);
            contactMessages.Location = new Point(214, 380);
            contactMessages.Margin = new Padding(2, 2, 2, 2);
            contactMessages.Name = "contactMessages";
            contactMessages.Size = new Size(822, 390);
            contactMessages.TabIndex = 10;
            contactMessages.Visible = false;
            // 
            // messageControls
            // 
            messageControls.Controls.Add(send);
            messageControls.Controls.Add(messageEditor);
            messageControls.Dock = DockStyle.Bottom;
            messageControls.Location = new Point(0, 264);
            messageControls.Margin = new Padding(2, 2, 2, 2);
            messageControls.Name = "messageControls";
            messageControls.Size = new Size(822, 126);
            messageControls.TabIndex = 15;
            // 
            // send
            // 
            send.Image = Properties.Resources.sendSymbol;
            send.Location = new Point(694, -2);
            send.Margin = new Padding(2, 2, 2, 2);
            send.Name = "send";
            send.Size = new Size(128, 128);
            send.TabIndex = 1;
            send.TabStop = false;
            send.Click += send_Click;
            // 
            // messageEditor
            // 
            messageEditor.Location = new Point(0, 0);
            messageEditor.Margin = new Padding(2, 2, 2, 2);
            messageEditor.Name = "messageEditor";
            messageEditor.Size = new Size(695, 130);
            messageEditor.TabIndex = 0;
            messageEditor.Text = "";
            // 
            // textMessageViewer
            // 
            textMessageViewer.AutoScroll = true;
            textMessageViewer.Location = new Point(0, 0);
            textMessageViewer.Margin = new Padding(2, 2, 2, 2);
            textMessageViewer.Name = "textMessageViewer";
            textMessageViewer.Size = new Size(819, 258);
            textMessageViewer.TabIndex = 15;
            // 
            // MatchesPanel1
            // 
            MatchesPanel1.Controls.Add(SelectedUsersPreferences);
            MatchesPanel1.Controls.Add(SelectedUsersPrefsLabel);
            MatchesPanel1.Controls.Add(SelectedUsersTextBio);
            MatchesPanel1.Controls.Add(SelectedUserslabel);
            MatchesPanel1.Controls.Add(refreshList);
            MatchesPanel1.Controls.Add(label3);
            MatchesPanel1.Controls.Add(listBox1);
            MatchesPanel1.Dock = DockStyle.Fill;
            MatchesPanel1.Location = new Point(0, 0);
            MatchesPanel1.Margin = new Padding(3, 2, 3, 2);
            MatchesPanel1.Name = "MatchesPanel1";
            MatchesPanel1.Size = new Size(867, 770);
            MatchesPanel1.TabIndex = 28;
            // 
            // SelectedUsersPreferences
            // 
            SelectedUsersPreferences.FormattingEnabled = true;
            SelectedUsersPreferences.Items.AddRange(new object[] { "Prefer a quiet living environment?", "Okay with having pets?", "Is an early riser?", "Stays up late on a regular basis?", "Wants to spend a lot of time with you socially?", "Wants keeps the common area very tidy?" });
            SelectedUsersPreferences.Location = new Point(412, 463);
            SelectedUsersPreferences.Margin = new Padding(2, 2, 2, 2);
            SelectedUsersPreferences.Name = "SelectedUsersPreferences";
            SelectedUsersPreferences.Size = new Size(361, 180);
            SelectedUsersPreferences.TabIndex = 6;
            SelectedUsersPreferences.SelectedIndexChanged += SelectedUsersPreferences_SelectedIndexChanged;
            // 
            // SelectedUsersPrefsLabel
            // 
            SelectedUsersPrefsLabel.Font = new Font("Segoe UI", 14F);
            SelectedUsersPrefsLabel.Location = new Point(434, 430);
            SelectedUsersPrefsLabel.Margin = new Padding(2, 0, 2, 0);
            SelectedUsersPrefsLabel.Name = "SelectedUsersPrefsLabel";
            SelectedUsersPrefsLabel.Size = new Size(313, 28);
            SelectedUsersPrefsLabel.TabIndex = 5;
            SelectedUsersPrefsLabel.Text = "Selected users Preferences";
            SelectedUsersPrefsLabel.Click += SelectedUsersPrefsLabel_Click;
            // 
            // SelectedUsersTextBio
            // 
            SelectedUsersTextBio.Location = new Point(33, 463);
            SelectedUsersTextBio.Margin = new Padding(2, 2, 2, 2);
            SelectedUsersTextBio.Multiline = true;
            SelectedUsersTextBio.Name = "SelectedUsersTextBio";
            SelectedUsersTextBio.ReadOnly = true;
            SelectedUsersTextBio.Size = new Size(342, 180);
            SelectedUsersTextBio.TabIndex = 4;
            SelectedUsersTextBio.TextChanged += SelectedUsersTextBio_TextChanged;
            // 
            // SelectedUserslabel
            // 
            SelectedUserslabel.Font = new Font("Segoe UI", 14F);
            SelectedUserslabel.Location = new Point(94, 430);
            SelectedUserslabel.Margin = new Padding(2, 0, 2, 0);
            SelectedUserslabel.Name = "SelectedUserslabel";
            SelectedUserslabel.Size = new Size(232, 46);
            SelectedUserslabel.TabIndex = 3;
            SelectedUserslabel.Text = "Selected users bio";
            SelectedUserslabel.Click += SelectedUserslabel_Click;
            // 
            // refreshList
            // 
            refreshList.Location = new Point(519, 98);
            refreshList.Margin = new Padding(3, 2, 3, 2);
            refreshList.Name = "refreshList";
            refreshList.Size = new Size(123, 70);
            refreshList.TabIndex = 2;
            refreshList.Text = "Refresh list";
            refreshList.UseVisualStyleBackColor = true;
            refreshList.Click += refreshList_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(301, 100);
            label3.Name = "label3";
            label3.Size = new Size(235, 58);
            label3.TabIndex = 1;
            label3.Text = "list of user";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(165, 178);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 244);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(MatchesPanel1);
            rightPanel.Controls.Add(messages);
            rightPanel.Controls.Add(ProfilePanel);
            rightPanel.Dock = DockStyle.Right;
            rightPanel.Location = new Point(220, 0);
            rightPanel.Margin = new Padding(3, 4, 3, 4);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(867, 770);
            rightPanel.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1087, 770);
            Controls.Add(panel1);
            Controls.Add(rightPanel);
            Controls.Add(contactMessages);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomMate";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ProfilePanel.ResumeLayout(false);
            ProfilePanel.PerformLayout();
            messages.ResumeLayout(false);
            messages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settings).EndInit();
            contactHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pfp).EndInit();
            ((System.ComponentModel.ISupportInitialize)notifications).EndInit();
            ((System.ComponentModel.ISupportInitialize)add).EndInit();
            ((System.ComponentModel.ISupportInitialize)search).EndInit();
            contactMessages.ResumeLayout(false);
            messageControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)send).EndInit();
            MatchesPanel1.ResumeLayout(false);
            MatchesPanel1.PerformLayout();
            rightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Dictionary<int, Label> sentMessages = new Dictionary<int, Label>();
        private int sentMessageCounter = 0;

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
        private Button noButton5;
        private Button noButton4;
        private Button noButton3;
        private Button yesButton3;
        private Button savePrefbutton1;
        private Label profilePageLabel;
        private Button noButton6;
        private TableLayoutPanel messages;
        private Label panelLabel;
        private PictureBox search;
        private PictureBox notifications;
        private PictureBox settings;
        private PictureBox add;
        private PictureBox pfp;
        private Label name;
        private Label contacts;
        private Panel contactMessages;
        private RichTextBox messageEditor;
        private PictureBox send;
        private VScrollBar contactScroll;
        private Button chat;
        private TableLayoutPanel contactHolder;
        private TextBox searchBar;
        private CheckedListBox notificationList;
        private Panel messageControls;
        private Panel textMessageViewer;
        private Panel MatchesPanel1;
        private Label label3;
        private ListBox listBox1;
        private Button refreshList;
        private Panel rightPanel;
        private TextBox SelectedUsersTextBio;
        private Label SelectedUserslabel;
        private Label SelectedUsersPrefsLabel;
        private CheckedListBox SelectedUsersPreferences;
        private Button requestbutton;
    }
}
