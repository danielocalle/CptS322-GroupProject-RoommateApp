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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(186, 577);
            panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            PnlNav.BackColor = Color.FromArgb(0, 126, 249);
            PnlNav.Location = new Point(0, 193);
            PnlNav.Name = "PnlNav";
            PnlNav.Size = new Size(3, 100);
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
            btnSettings.Location = new Point(0, 521);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(186, 56);
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
            btnProfile.Location = new Point(0, 328);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(186, 56);
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
            btnMatches.Location = new Point(0, 272);
            btnMatches.Name = "btnMatches";
            btnMatches.Size = new Size(186, 56);
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
            btnMessages.Location = new Point(0, 216);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(186, 56);
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
            btnDashboard.Location = new Point(0, 160);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(186, 56);
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
            panel2.Size = new Size(186, 160);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(158, 161, 178);
            label2.Location = new Point(0, 128);
            label2.Name = "label2";
            label2.Size = new Size(186, 13);
            label2.TabIndex = 2;
            label2.Text = "Extra User Info";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 126, 249);
            label1.Location = new Point(0, 98);
            label1.Name = "label1";
            label1.Size = new Size(186, 16);
            label1.TabIndex = 1;
            label1.Text = "John Doe";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 63);
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
            btnExit.Location = new Point(903, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 48);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
