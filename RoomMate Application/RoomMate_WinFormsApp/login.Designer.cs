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
            mainpanel.Controls.Add(registerbutton);
            mainpanel.Controls.Add(forgotbutton);
            mainpanel.Controls.Add(loginbutton);
            mainpanel.Controls.Add(passwordtext);
            mainpanel.Controls.Add(passwordlabel);
            mainpanel.Controls.Add(usernametext);
            mainpanel.Controls.Add(usernamelabel);
            mainpanel.Controls.Add(introlabel);
            mainpanel.Location = new Point(33, 59);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1261, 808);
            mainpanel.TabIndex = 0;
            // 
            // registerbutton
            // 
            registerbutton.BackColor = Color.White;
            registerbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbutton.Location = new Point(87, 704);
            registerbutton.Name = "registerbutton";
            registerbutton.Size = new Size(228, 40);
            registerbutton.TabIndex = 7;
            registerbutton.Text = "Register";
            registerbutton.UseVisualStyleBackColor = false;
            registerbutton.Click += registerbutton_Click;
            // 
            // forgotbutton
            // 
            forgotbutton.BackColor = Color.White;
            forgotbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotbutton.Location = new Point(87, 490);
            forgotbutton.Name = "forgotbutton";
            forgotbutton.Size = new Size(228, 40);
            forgotbutton.TabIndex = 6;
            forgotbutton.Text = "Forgot password";
            forgotbutton.UseVisualStyleBackColor = false;
            forgotbutton.Click += forgotbutton_Click;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.White;
            loginbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbutton.Location = new Point(360, 490);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(112, 40);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // passwordtext
            // 
            passwordtext.BackColor = SystemColors.Window;
            passwordtext.Cursor = Cursors.IBeam;
            passwordtext.Location = new Point(87, 377);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(385, 31);
            passwordtext.TabIndex = 4;
            // 
            // passwordlabel
            // 
            passwordlabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            passwordlabel.Location = new Point(87, 317);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(250, 38);
            passwordlabel.TabIndex = 3;
            passwordlabel.Text = "Password:";
            // 
            // usernametext
            // 
            usernametext.BackColor = SystemColors.Window;
            usernametext.Cursor = Cursors.IBeam;
            usernametext.Location = new Point(87, 244);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(385, 31);
            usernametext.TabIndex = 2;
            // 
            // usernamelabel
            // 
            usernamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            usernamelabel.Location = new Point(87, 184);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(250, 38);
            usernamelabel.TabIndex = 1;
            usernamelabel.Text = "Username:";
            // 
            // introlabel
            // 
            introlabel.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            introlabel.Location = new Point(236, 44);
            introlabel.Name = "introlabel";
            introlabel.Size = new Size(800, 50);
            introlabel.TabIndex = 0;
            introlabel.Text = "Roommate Matching Application";
            introlabel.TextAlign = ContentAlignment.TopCenter;
            introlabel.Click += introlabel_Click;
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
            registerpanel.Location = new Point(30, 56);
            registerpanel.Name = "registerpanel";
            registerpanel.Size = new Size(1261, 808);
            registerpanel.TabIndex = 8;
            // 
            // backbutton
            // 
            backbutton.BackColor = Color.White;
            backbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbutton.Location = new Point(1097, 738);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(120, 40);
            backbutton.TabIndex = 22;
            backbutton.Text = "Back";
            backbutton.UseVisualStyleBackColor = false;
            backbutton.Click += backbutton_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Window;
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(87, 635);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(385, 31);
            textBox4.TabIndex = 21;
            // 
            // recoverylabel
            // 
            recoverylabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            recoverylabel.Location = new Point(87, 582);
            recoverylabel.Name = "recoverylabel";
            recoverylabel.Size = new Size(558, 38);
            recoverylabel.TabIndex = 20;
            recoverylabel.Text = "What was the name of your first pet:";
            // 
            // passwordregistertext
            // 
            passwordregistertext.BackColor = SystemColors.Window;
            passwordregistertext.Cursor = Cursors.IBeam;
            passwordregistertext.Location = new Point(87, 526);
            passwordregistertext.Name = "passwordregistertext";
            passwordregistertext.Size = new Size(385, 31);
            passwordregistertext.TabIndex = 19;
            passwordregistertext.TextChanged += textBox2_TextChanged;
            // 
            // newpasswordlabel
            // 
            newpasswordlabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            newpasswordlabel.Location = new Point(87, 471);
            newpasswordlabel.Name = "newpasswordlabel";
            newpasswordlabel.Size = new Size(250, 38);
            newpasswordlabel.TabIndex = 18;
            newpasswordlabel.Text = "Password:";
            // 
            // usernameregistertext
            // 
            usernameregistertext.BackColor = SystemColors.Window;
            usernameregistertext.Cursor = Cursors.IBeam;
            usernameregistertext.Location = new Point(87, 421);
            usernameregistertext.Name = "usernameregistertext";
            usernameregistertext.Size = new Size(385, 31);
            usernameregistertext.TabIndex = 17;
            // 
            // usernameregister
            // 
            usernameregister.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            usernameregister.Location = new Point(87, 371);
            usernameregister.Name = "usernameregister";
            usernameregister.Size = new Size(250, 38);
            usernameregister.TabIndex = 16;
            usernameregister.Text = "Username:";
            // 
            // createaccbutton
            // 
            createaccbutton.BackColor = Color.White;
            createaccbutton.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createaccbutton.Location = new Point(159, 718);
            createaccbutton.Name = "createaccbutton";
            createaccbutton.Size = new Size(228, 40);
            createaccbutton.TabIndex = 15;
            createaccbutton.Text = "Register";
            createaccbutton.UseVisualStyleBackColor = false;
            createaccbutton.Click += createaccbutton_Click;
            // 
            // lastnametext
            // 
            lastnametext.BackColor = SystemColors.Window;
            lastnametext.Cursor = Cursors.IBeam;
            lastnametext.Location = new Point(87, 313);
            lastnametext.Name = "lastnametext";
            lastnametext.Size = new Size(385, 31);
            lastnametext.TabIndex = 12;
            // 
            // lastnamelabel
            // 
            lastnamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            lastnamelabel.Location = new Point(87, 258);
            lastnamelabel.Name = "lastnamelabel";
            lastnamelabel.Size = new Size(250, 38);
            lastnamelabel.TabIndex = 11;
            lastnamelabel.Text = "Last name:";
            lastnamelabel.Click += label1_Click_1;
            // 
            // nametext
            // 
            nametext.BackColor = SystemColors.Window;
            nametext.Cursor = Cursors.IBeam;
            nametext.Location = new Point(87, 208);
            nametext.Name = "nametext";
            nametext.Size = new Size(385, 31);
            nametext.TabIndex = 10;
            // 
            // namelabel
            // 
            namelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            namelabel.Location = new Point(87, 158);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(250, 38);
            namelabel.TabIndex = 9;
            namelabel.Text = "First name:";
            namelabel.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 44);
            label3.Name = "label3";
            label3.Size = new Size(800, 50);
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
            forgotpasswordpanel.Location = new Point(33, 53);
            forgotpasswordpanel.Name = "forgotpasswordpanel";
            forgotpasswordpanel.Size = new Size(1261, 808);
            forgotpasswordpanel.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(87, 449);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 31);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label2.Location = new Point(87, 399);
            label2.Name = "label2";
            label2.Size = new Size(250, 38);
            label2.TabIndex = 14;
            label2.Text = "New password:";
            // 
            // backbuttonforgot
            // 
            backbuttonforgot.BackColor = Color.White;
            backbuttonforgot.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbuttonforgot.Location = new Point(1074, 721);
            backbuttonforgot.Name = "backbuttonforgot";
            backbuttonforgot.Size = new Size(140, 40);
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
            savebutton.Location = new Point(357, 542);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(112, 40);
            savebutton.TabIndex = 12;
            savebutton.Text = "Save";
            savebutton.UseVisualStyleBackColor = false;
            savebutton.Click += savebutton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(87, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 31);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(87, 285);
            label1.Name = "label1";
            label1.Size = new Size(555, 38);
            label1.TabIndex = 10;
            label1.Text = "What was the name of your first pet?";
            label1.Click += label1_Click;
            // 
            // forgotusernametext
            // 
            forgotusernametext.BackColor = SystemColors.Window;
            forgotusernametext.Cursor = Cursors.IBeam;
            forgotusernametext.Location = new Point(87, 231);
            forgotusernametext.Name = "forgotusernametext";
            forgotusernametext.Size = new Size(385, 31);
            forgotusernametext.TabIndex = 9;
            // 
            // forgotusernamelabel
            // 
            forgotusernamelabel.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            forgotusernamelabel.Location = new Point(87, 184);
            forgotusernamelabel.Name = "forgotusernamelabel";
            forgotusernamelabel.Size = new Size(250, 38);
            forgotusernamelabel.TabIndex = 8;
            forgotusernamelabel.Text = "Username:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(236, 44);
            label4.Name = "label4";
            label4.Size = new Size(800, 50);
            label4.TabIndex = 7;
            label4.Text = "Roommate Matching Application";
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
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
    }
}