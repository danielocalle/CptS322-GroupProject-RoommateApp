namespace RoomMate_WinFormsApp
{
    partial class login
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
            mainpanel = new Panel();
            registerbutton = new Button();
            forgotbutton = new Button();
            loginbutton = new Button();
            passwordtext = new TextBox();
            passwordlabel = new Label();
            usernametext = new TextBox();
            usernamelabel = new Label();
            introlabel = new Label();
            registerpanel = new Panel();
            backbutton = new Button();
            textBox4 = new TextBox();
            recoverylabel = new Label();
            passwordregistertext = new TextBox();
            newpasswordlabel = new Label();
            usernameregistertext = new TextBox();
            usernameregister = new Label();
            createaccbutton = new Button();
            lastnametext = new TextBox();
            lastnamelabel = new Label();
            nametext = new TextBox();
            namelabel = new Label();
            label3 = new Label();
            forgotpasswordpanel = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            backbuttonforgot = new Button();
            savebutton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            forgotusernametext = new TextBox();
            forgotusernamelabel = new Label();
            label4 = new Label();
            mainpanel.SuspendLayout();
            registerpanel.SuspendLayout();
            forgotpasswordpanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = SystemColors.ControlLight;
            mainpanel.Controls.Add(registerbutton);
            mainpanel.Controls.Add(forgotbutton);
            mainpanel.Controls.Add(loginbutton);
            mainpanel.Controls.Add(passwordtext);
            mainpanel.Controls.Add(passwordlabel);
            mainpanel.Controls.Add(usernametext);
            mainpanel.Controls.Add(usernamelabel);
            mainpanel.Controls.Add(introlabel);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1359, 962);
            mainpanel.TabIndex = 0;
            // 
            // registerbutton
            // 
            registerbutton.Anchor = AnchorStyles.None;
            registerbutton.AutoSize = true;
            registerbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerbutton.BackColor = Color.White;
            registerbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbutton.Location = new Point(486, 730);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(113, 40);
            registerbutton.TabIndex = 7;
            registerbutton.Text = "Register";
            registerbutton.UseVisualStyleBackColor = false;
            registerbutton.Click += registerbutton_Click;
            // 
            // forgotbutton
            // 
            forgotbutton.Anchor = AnchorStyles.None;
            forgotbutton.AutoSize = true;
            forgotbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            forgotbutton.BackColor = Color.White;
            forgotbutton.FlatAppearance.BorderColor = Color.Black;
            forgotbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotbutton.Location = new Point(486, 593);
            forgotbutton.Name = "forgotbutton";
            forgotbutton.Size = new Size(207, 40);
            forgotbutton.TabIndex = 6;
            forgotbutton.Text = "Forgot password";
            forgotbutton.UseVisualStyleBackColor = false;
            forgotbutton.Click += forgotbutton_Click;
            // 
            // loginbutton
            // 
            loginbutton.Anchor = AnchorStyles.None;
            loginbutton.AutoSize = true;
            loginbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginbutton.BackColor = Color.White;
            loginbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(786, 593);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(84, 40);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // passwordtext
            // 
            passwordtext.Anchor = AnchorStyles.None;
            passwordtext.BackColor = SystemColors.Window;
            passwordtext.Cursor = Cursors.IBeam;
            passwordtext.Location = new Point(486, 480);
            passwordtext.Name = "passwordtext";
            passwordtext.PasswordChar = '*';
            passwordtext.Size = new Size(385, 31);
            passwordtext.TabIndex = 4;
            // 
            // passwordlabel
            // 
            passwordlabel.Anchor = AnchorStyles.None;
            passwordlabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            passwordlabel.ForeColor = SystemColors.ControlText;
            passwordlabel.Location = new Point(486, 420);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(250, 38);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Password:";
            // 
            // usernametext
            // 
            usernametext.Anchor = AnchorStyles.None;
            usernametext.BackColor = SystemColors.Window;
            usernametext.Cursor = Cursors.IBeam;
            usernametext.Location = new Point(486, 347);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(385, 31);
            usernametext.TabIndex = 2;
            // 
            // usernamelabel
            // 
            usernamelabel.Anchor = AnchorStyles.None;
            usernamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            usernamelabel.ForeColor = SystemColors.ControlText;
            usernamelabel.Location = new Point(486, 287);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(250, 38);
            usernamelabel.TabIndex = 1;
            usernamelabel.Text = "Username:";
            // 
            // introlabel
            // 
            introlabel.Anchor = AnchorStyles.None;
            introlabel.BackColor = Color.Transparent;
            introlabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            introlabel.ForeColor = SystemColors.ControlText;
            introlabel.Location = new Point(289, 163);
            introlabel.Name = "introlabel";
            introlabel.Size = new Size(800, 73);
            introlabel.TabIndex = 0;
            introlabel.Text = "Roommate Matching Application";
            introlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // registerpanel
            // 
            registerpanel.BackColor = SystemColors.ControlLight;
            registerpanel.Controls.Add(backbutton);
            registerpanel.Controls.Add(textBox4);
            registerpanel.Controls.Add(recoverylabel);
            registerpanel.Controls.Add(passwordregistertext);
            registerpanel.Controls.Add(newpasswordlabel);
            registerpanel.Controls.Add(usernameregistertext);
            registerpanel.Controls.Add(usernameregister);
            registerpanel.Controls.Add(createaccbutton);
            registerpanel.Controls.Add(lastnametext);
            registerpanel.Controls.Add(lastnamelabel);
            registerpanel.Controls.Add(nametext);
            registerpanel.Controls.Add(namelabel);
            registerpanel.Controls.Add(label3);
            registerpanel.Dock = DockStyle.Fill;
            registerpanel.Location = new Point(0, 0);
            registerpanel.Name = "registerpanel";
            registerpanel.Size = new Size(1359, 962);
            registerpanel.TabIndex = 8;
            // 
            // backbutton
            // 
            backbutton.Anchor = AnchorStyles.None;
            backbutton.AutoSize = true;
            backbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backbutton.BackColor = Color.White;
            backbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbutton.Location = new Point(797, 787);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(74, 40);
            backbutton.TabIndex = 22;
            backbutton.Text = "Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Window;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(486, 682);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(385, 31);
            textBox4.TabIndex = 21;
            // 
            // recoverylabel
            // 
            recoverylabel.Anchor = AnchorStyles.None;
            recoverylabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            recoverylabel.Location = new Point(486, 628);
            recoverylabel.Name = "recoverylabel";
            recoverylabel.Size = new Size(559, 38);
            recoverylabel.TabIndex = 20;
            recoverylabel.Text = "What was the name of your first pet:";
            // 
            // passwordregistertext
            // 
            passwordregistertext.Anchor = AnchorStyles.None;
            passwordregistertext.BackColor = SystemColors.Window;
            passwordregistertext.Cursor = Cursors.IBeam;
            passwordregistertext.Location = new Point(486, 573);
            passwordregistertext.Name = "passwordregistertext";
            passwordregistertext.Size = new Size(385, 31);
            passwordregistertext.TabIndex = 19;
            // 
            // newpasswordlabel
            // 
            newpasswordlabel.Anchor = AnchorStyles.None;
            newpasswordlabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            newpasswordlabel.Location = new Point(486, 518);
            newpasswordlabel.Name = "newpasswordlabel";
            newpasswordlabel.Size = new Size(250, 38);
            newpasswordlabel.TabIndex = 18;
            newpasswordlabel.Text = "Password:";
            // 
            // usernameregistertext
            // 
            usernameregistertext.Anchor = AnchorStyles.None;
            usernameregistertext.BackColor = SystemColors.Window;
            usernameregistertext.Cursor = Cursors.IBeam;
            usernameregistertext.Location = new Point(486, 468);
            usernameregistertext.Name = "usernameregistertext";
            usernameregistertext.Size = new Size(385, 31);
            usernameregistertext.TabIndex = 17;
            // 
            // usernameregister
            // 
            usernameregister.Anchor = AnchorStyles.None;
            usernameregister.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            usernameregister.Location = new Point(486, 418);
            usernameregister.Name = "usernameregister";
            usernameregister.Size = new Size(250, 38);
            usernameregister.TabIndex = 16;
            usernameregister.Text = "Username:";
            // 
            // createaccbutton
            // 
            createaccbutton.Anchor = AnchorStyles.None;
            createaccbutton.AutoSize = true;
            createaccbutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createaccbutton.BackColor = Color.White;
            createaccbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createaccbutton.Location = new Point(486, 787);
            createaccbutton.Name = "createaccbutton";
            createaccbutton.Size = new Size(113, 40);
            createaccbutton.TabIndex = 15;
            createaccbutton.Text = "Register";
            createaccbutton.UseVisualStyleBackColor = false;
            createaccbutton.Click += createaccbutton_Click;
            // 
            // lastnametext
            // 
            lastnametext.Anchor = AnchorStyles.None;
            lastnametext.BackColor = SystemColors.Window;
            lastnametext.Cursor = Cursors.IBeam;
            lastnametext.Location = new Point(486, 360);
            lastnametext.Name = "lastnametext";
            lastnametext.Size = new Size(385, 31);
            lastnametext.TabIndex = 12;
            // 
            // lastnamelabel
            // 
            lastnamelabel.Anchor = AnchorStyles.None;
            lastnamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lastnamelabel.Location = new Point(486, 305);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(250, 38);
            lastnamelabel.TabIndex = 11;
            lastnamelabel.Text = "Last name:";
            // 
            // nametext
            // 
            nametext.Anchor = AnchorStyles.None;
            nametext.BackColor = SystemColors.Window;
            nametext.Cursor = Cursors.IBeam;
            nametext.Location = new Point(486, 255);
            nametext.Name = "nametext";
            nametext.Size = new Size(385, 31);
            nametext.TabIndex = 10;
            // 
            // namelabel
            // 
            namelabel.Anchor = AnchorStyles.None;
            namelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            namelabel.Location = new Point(486, 205);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(250, 38);
            namelabel.TabIndex = 9;
            namelabel.Text = "First name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(276, 88);
            label3.Name = "label3";
            label3.Size = new Size(800, 75);
            label3.TabIndex = 8;
            label3.Text = "Register";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // forgotpasswordpanel
            // 
            forgotpasswordpanel.BackColor = SystemColors.ControlLight;
            forgotpasswordpanel.Controls.Add(textBox2);
            forgotpasswordpanel.Controls.Add(label2);
            forgotpasswordpanel.Controls.Add(backbuttonforgot);
            forgotpasswordpanel.Controls.Add(savebutton);
            forgotpasswordpanel.Controls.Add(textBox1);
            forgotpasswordpanel.Controls.Add(label1);
            forgotpasswordpanel.Controls.Add(forgotusernametext);
            forgotpasswordpanel.Controls.Add(forgotusernamelabel);
            forgotpasswordpanel.Controls.Add(label4);
            forgotpasswordpanel.Dock = DockStyle.Fill;
            forgotpasswordpanel.Location = new Point(0, 0);
            forgotpasswordpanel.Name = "forgotpasswordpanel";
            forgotpasswordpanel.Size = new Size(1359, 962);
            forgotpasswordpanel.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = SystemColors.Window;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(464, 552);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 31);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.Location = new Point(464, 502);
            label2.Name = "label2";
            label2.Size = new Size(250, 38);
            label2.TabIndex = 14;
            label2.Text = "New password:";
            // 
            // backbuttonforgot
            // 
            backbuttonforgot.Anchor = AnchorStyles.None;
            backbuttonforgot.AutoSize = true;
            backbuttonforgot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backbuttonforgot.BackColor = Color.White;
            backbuttonforgot.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbuttonforgot.Location = new Point(823, 672);
            backbuttonforgot.Name = "backbuttonforgot";
            backbuttonforgot.Size = new Size(74, 40);
            backbuttonforgot.TabIndex = 13;
            backbuttonforgot.Text = "Back";
            backbuttonforgot.UseVisualStyleBackColor = false;
            backbuttonforgot.Click += backbuttonforgot_Click;
            // 
            // savebutton
            // 
            savebutton.Anchor = AnchorStyles.None;
            savebutton.AutoSize = true;
            savebutton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            savebutton.BackColor = Color.White;
            savebutton.DialogResult = DialogResult.Cancel;
            savebutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebutton.Location = new Point(464, 670);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(73, 40);
            savebutton.TabIndex = 12;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = SystemColors.Window;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(464, 448);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 31);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(464, 397);
            label1.Name = "label1";
            label1.Size = new Size(554, 38);
            label1.TabIndex = 10;
            label1.Text = "What was the name of your first pet?";
            // 
            // forgotusernametext
            // 
            forgotusernametext.Anchor = AnchorStyles.None;
            forgotusernametext.BackColor = SystemColors.Window;
            forgotusernametext.Cursor = Cursors.IBeam;
            forgotusernametext.Location = new Point(464, 335);
            forgotusernametext.Name = "forgotusernametext";
            forgotusernametext.Size = new Size(433, 31);
            forgotusernametext.TabIndex = 9;
            // 
            // forgotusernamelabel
            // 
            forgotusernamelabel.Anchor = AnchorStyles.None;
            forgotusernamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            forgotusernamelabel.Location = new Point(464, 287);
            forgotusernamelabel.Name = "forgotusernamelabel";
            forgotusernamelabel.Size = new Size(250, 38);
            forgotusernamelabel.TabIndex = 8;
            forgotusernamelabel.Text = "Username:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(289, 173);
            label4.Name = "label4";
            label4.Size = new Size(800, 78);
            label4.TabIndex = 7;
            label4.Text = "Change Password";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1359, 962);
            Controls.Add(mainpanel);
            Controls.Add(registerpanel);
            Controls.Add(forgotpasswordpanel);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomMate Login Form";
            FormClosed += login_FormClosed;
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            registerpanel.ResumeLayout(false);
            registerpanel.PerformLayout();
            forgotpasswordpanel.ResumeLayout(false);
            forgotpasswordpanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Label introlabel;
        private TextBox usernametext;
        private Label usernamelabel;
        private TextBox passwordtext;
        private Label passwordlabel;
        private Button loginbutton;
        private Button registerbutton;
        private Button forgotbutton;
        private Panel registerpanel;
        private Button createaccbutton;
        private TextBox lastnametext;
        private Label lastnamelabel;
        private TextBox nametext;
        private Label namelabel;
        private Label label3;
        private TextBox passwordregistertext;
        private Label newpasswordlabel;
        private TextBox usernameregistertext;
        private Label usernameregister;
        private TextBox textBox4;
        private Label recoverylabel;
        private Button backbutton;
        private Panel forgotpasswordpanel;
        private Button backbuttonforgot;
        private Button savebutton;
        private TextBox textBox1;
        private Label label1;
        private TextBox forgotusernametext;
        private Label forgotusernamelabel;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
    }
}