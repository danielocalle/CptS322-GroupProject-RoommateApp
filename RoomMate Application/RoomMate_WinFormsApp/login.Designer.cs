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
            btnExit = new Button();
            mainpanel.SuspendLayout();
            registerpanel.SuspendLayout();
            forgotpasswordpanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(registerbutton);
            mainpanel.Controls.Add(forgotbutton);
            mainpanel.Controls.Add(loginbutton);
            mainpanel.Controls.Add(passwordtext);
            mainpanel.Controls.Add(passwordlabel);
            mainpanel.Controls.Add(usernametext);
            mainpanel.Controls.Add(usernamelabel);
            mainpanel.Controls.Add(introlabel);
            mainpanel.Location = new Point(23, 35);
            mainpanel.Margin = new Padding(2);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(872, 485);
            mainpanel.TabIndex = 0;
            // 
            // registerbutton
            // 
            registerbutton.BackColor = Color.White;
            registerbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbutton.Location = new Point(61, 422);
            registerbutton.Margin = new Padding(2);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(160, 32);
            registerbutton.TabIndex = 7;
            registerbutton.Text = "Register";
            registerbutton.UseVisualStyleBackColor = false;
            registerbutton.Click += registerbutton_Click;
            // 
            // forgotbutton
            // 
            forgotbutton.BackColor = Color.White;
            forgotbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotbutton.Location = new Point(61, 294);
            forgotbutton.Margin = new Padding(2);
            forgotbutton.Name = "forgotbutton";
            forgotbutton.Size = new Size(160, 34);
            forgotbutton.TabIndex = 6;
            forgotbutton.Text = "Forgot password";
            forgotbutton.UseVisualStyleBackColor = false;
            forgotbutton.Click += forgotbutton_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.White;
            loginbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(252, 294);
            loginbutton.Margin = new Padding(2);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(78, 34);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // passwordtext
            // 
            passwordtext.BackColor = SystemColors.Window;
            passwordtext.Cursor = Cursors.IBeam;
            passwordtext.Location = new Point(61, 226);
            passwordtext.Margin = new Padding(2);
            passwordtext.Name = "passwordtext";
            passwordtext.PasswordChar = '*';
            passwordtext.Size = new Size(271, 23);
            passwordtext.TabIndex = 4;
            // 
            // passwordlabel
            // 
            passwordlabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            passwordlabel.Location = new Point(61, 190);
            passwordlabel.Margin = new Padding(2, 0, 2, 0);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(175, 23);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Password:";
            // 
            // usernametext
            // 
            usernametext.BackColor = SystemColors.Window;
            usernametext.Cursor = Cursors.IBeam;
            usernametext.Location = new Point(61, 146);
            usernametext.Margin = new Padding(2);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(271, 23);
            usernametext.TabIndex = 2;
            // 
            // usernamelabel
            // 
            usernamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            usernamelabel.Location = new Point(61, 110);
            usernamelabel.Margin = new Padding(2, 0, 2, 0);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(175, 23);
            usernamelabel.TabIndex = 1;
            usernamelabel.Text = "Username:";
            // 
            // introlabel
            // 
            introlabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            introlabel.Location = new Point(165, 26);
            introlabel.Margin = new Padding(2, 0, 2, 0);
            introlabel.Name = "introlabel";
            introlabel.Size = new Size(560, 44);
            introlabel.TabIndex = 0;
            introlabel.Text = "Roommate Matching Application";
            introlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // registerpanel
            // 
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
            registerpanel.Location = new Point(21, 34);
            registerpanel.Margin = new Padding(2);
            registerpanel.Name = "registerpanel";
            registerpanel.Size = new Size(874, 485);
            registerpanel.TabIndex = 8;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.White;
            backbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbutton.Location = new Point(768, 431);
            backbutton.Margin = new Padding(2);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(84, 38);
            backbutton.TabIndex = 22;
            backbutton.Text = "Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(61, 381);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(271, 23);
            textBox4.TabIndex = 21;
            // 
            // recoverylabel
            // 
            recoverylabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            recoverylabel.Location = new Point(61, 349);
            recoverylabel.Margin = new Padding(2, 0, 2, 0);
            recoverylabel.Name = "recoverylabel";
            recoverylabel.Size = new Size(391, 23);
            recoverylabel.TabIndex = 20;
            recoverylabel.Text = "What was the name of your first pet:";
            // 
            // passwordregistertext
            // 
            passwordregistertext.BackColor = SystemColors.Window;
            passwordregistertext.Cursor = Cursors.IBeam;
            passwordregistertext.Location = new Point(61, 316);
            passwordregistertext.Margin = new Padding(2);
            passwordregistertext.Name = "passwordregistertext";
            passwordregistertext.Size = new Size(271, 23);
            passwordregistertext.TabIndex = 19;
            // 
            // newpasswordlabel
            // 
            newpasswordlabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            newpasswordlabel.Location = new Point(61, 283);
            newpasswordlabel.Margin = new Padding(2, 0, 2, 0);
            newpasswordlabel.Name = "newpasswordlabel";
            newpasswordlabel.Size = new Size(175, 23);
            newpasswordlabel.TabIndex = 18;
            newpasswordlabel.Text = "Password:";
            // 
            // usernameregistertext
            // 
            usernameregistertext.BackColor = SystemColors.Window;
            usernameregistertext.Cursor = Cursors.IBeam;
            usernameregistertext.Location = new Point(61, 253);
            usernameregistertext.Margin = new Padding(2);
            usernameregistertext.Name = "usernameregistertext";
            usernameregistertext.Size = new Size(271, 23);
            usernameregistertext.TabIndex = 17;
            // 
            // usernameregister
            // 
            usernameregister.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            usernameregister.Location = new Point(61, 223);
            usernameregister.Margin = new Padding(2, 0, 2, 0);
            usernameregister.Name = "usernameregister";
            usernameregister.Size = new Size(175, 23);
            usernameregister.TabIndex = 16;
            usernameregister.Text = "Username:";
            // 
            // createaccbutton
            // 
            createaccbutton.BackColor = Color.White;
            createaccbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createaccbutton.Location = new Point(111, 431);
            createaccbutton.Margin = new Padding(2);
            createaccbutton.Name = "createaccbutton";
            createaccbutton.Size = new Size(160, 36);
            createaccbutton.TabIndex = 15;
            createaccbutton.Text = "Register";
            createaccbutton.UseVisualStyleBackColor = false;
            createaccbutton.Click += createaccbutton_Click;
            // 
            // lastnametext
            // 
            lastnametext.BackColor = SystemColors.Window;
            lastnametext.Cursor = Cursors.IBeam;
            lastnametext.Location = new Point(61, 188);
            lastnametext.Margin = new Padding(2);
            lastnametext.Name = "lastnametext";
            lastnametext.Size = new Size(271, 23);
            lastnametext.TabIndex = 12;
            // 
            // lastnamelabel
            // 
            lastnamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lastnamelabel.Location = new Point(61, 155);
            lastnamelabel.Margin = new Padding(2, 0, 2, 0);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(175, 23);
            lastnamelabel.TabIndex = 11;
            lastnamelabel.Text = "Last name:";
            // 
            // nametext
            // 
            nametext.BackColor = SystemColors.Window;
            nametext.Cursor = Cursors.IBeam;
            nametext.Location = new Point(61, 125);
            nametext.Margin = new Padding(2);
            nametext.Name = "nametext";
            nametext.Size = new Size(271, 23);
            nametext.TabIndex = 10;
            // 
            // namelabel
            // 
            namelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            namelabel.Location = new Point(61, 95);
            namelabel.Margin = new Padding(2, 0, 2, 0);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(175, 23);
            namelabel.TabIndex = 9;
            namelabel.Text = "First name:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(165, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(560, 45);
            label3.TabIndex = 8;
            label3.Text = "Roommate Matching Application";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // forgotpasswordpanel
            // 
            forgotpasswordpanel.Controls.Add(textBox2);
            forgotpasswordpanel.Controls.Add(label2);
            forgotpasswordpanel.Controls.Add(backbuttonforgot);
            forgotpasswordpanel.Controls.Add(savebutton);
            forgotpasswordpanel.Controls.Add(textBox1);
            forgotpasswordpanel.Controls.Add(label1);
            forgotpasswordpanel.Controls.Add(forgotusernametext);
            forgotpasswordpanel.Controls.Add(forgotusernamelabel);
            forgotpasswordpanel.Controls.Add(label4);
            forgotpasswordpanel.Location = new Point(23, 32);
            forgotpasswordpanel.Margin = new Padding(2);
            forgotpasswordpanel.Name = "forgotpasswordpanel";
            forgotpasswordpanel.Size = new Size(872, 485);
            forgotpasswordpanel.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(61, 269);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 23);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.Location = new Point(61, 239);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 14;
            label2.Text = "New password:";
            // 
            // backbuttonforgot
            // 
            backbuttonforgot.BackColor = Color.White;
            backbuttonforgot.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbuttonforgot.Location = new Point(752, 433);
            backbuttonforgot.Margin = new Padding(2);
            backbuttonforgot.Name = "backbuttonforgot";
            backbuttonforgot.Size = new Size(98, 36);
            backbuttonforgot.TabIndex = 13;
            backbuttonforgot.Text = "Back";
            backbuttonforgot.UseVisualStyleBackColor = false;
            backbuttonforgot.Click += backbuttonforgot_Click;
            // 
            // savebutton
            // 
            savebutton.BackColor = Color.White;
            savebutton.DialogResult = DialogResult.Cancel;
            savebutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebutton.Location = new Point(250, 325);
            savebutton.Margin = new Padding(2);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(78, 35);
            savebutton.TabIndex = 12;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(61, 207);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 23);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(61, 171);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 23);
            label1.TabIndex = 10;
            label1.Text = "What was the name of your first pet?";
            // 
            // forgotusernametext
            // 
            forgotusernametext.BackColor = SystemColors.Window;
            forgotusernametext.Cursor = Cursors.IBeam;
            forgotusernametext.Location = new Point(61, 139);
            forgotusernametext.Margin = new Padding(2);
            forgotusernametext.Name = "forgotusernametext";
            forgotusernametext.Size = new Size(271, 23);
            forgotusernametext.TabIndex = 9;
            // 
            // forgotusernamelabel
            // 
            forgotusernamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            forgotusernamelabel.Location = new Point(61, 110);
            forgotusernamelabel.Margin = new Padding(2, 0, 2, 0);
            forgotusernamelabel.Name = "forgotusernamelabel";
            forgotusernamelabel.Size = new Size(175, 23);
            forgotusernamelabel.TabIndex = 8;
            forgotusernamelabel.Text = "Username:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(560, 47);
            label4.TabIndex = 7;
            label4.Text = "Roommate Matching Application";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.White;
            btnExit.Image = Properties.Resources.exit2;
            btnExit.Location = new Point(900, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 48);
            btnExit.TabIndex = 9;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(btnExit);
            Controls.Add(mainpanel);
            Controls.Add(registerpanel);
            Controls.Add(forgotpasswordpanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
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
        private Button btnExit;
    }
}