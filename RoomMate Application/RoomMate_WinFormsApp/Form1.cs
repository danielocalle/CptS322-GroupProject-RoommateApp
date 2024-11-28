using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RoommateAppLibrary;
using static RoommateAppLibrary.SQLiteDataAccess;

namespace RoomMate_WinFormsApp
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Preferences UserPreferences = new Preferences();
        private static IEnumerable<UserInfoWithInt> rankedUsers;

        private AccountLoginInfo loggedInUser;
        private UserInfo userInfo;

        private login loginForm;

        public Form1(login loginForm)
        {
            this.loginForm = loginForm;

            InitializeComponent();

            currentButton = btnDashboard;
            ActivateButton(btnDashboard);
            ProfilePanel.Visible = false;
            MatchesPanel1.Visible = false;
        }

        public void PassAccountInfoFromLogin(bool flag, AccountLoginInfo loginInfo)
        {
            this.loggedInUser = loginInfo;
            this.label1.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
            this.label2.Text = loggedInUser.Username;
            if (flag) this.LoadProfileInfoFromDB();
        }
        
        private void LoadProfileInfoFromDB()
        {
            this.userInfo = SQLiteDataAccess.GetUserInfo(loggedInUser);
            textBox1.Text = userInfo.aboutMe;
            this.LoadYesNoButtons(userInfo.prefs);
        }

        private void LoadYesNoButtons(Preferences preferences)
        {
            if (preferences.isQuiet.HasValue)
            {
                if ((bool)preferences.isQuiet) yesButton1.BackColor = Color.Green;
                else if (!(bool)preferences.isQuiet) noButton1.BackColor = Color.Red;
            }

            if (preferences.hasPets.HasValue)
            {
                if ((bool)preferences.hasPets) yesButton2.BackColor = Color.Green;
                else if (!(bool)preferences.hasPets) noButton2.BackColor = Color.Red;
            }

            if (preferences.earlyRiser.HasValue)
            {
                if ((bool)preferences.earlyRiser) yesButton3.BackColor = Color.Green;
                else if (!(bool)preferences.earlyRiser) noButton3.BackColor = Color.Red;
            }

            if (preferences.stayUpLate.HasValue)
            {
                if ((bool)preferences.stayUpLate) yesButton4.BackColor = Color.Green;
                else if (!(bool)preferences.stayUpLate) noButton4.BackColor = Color.Red;
            }

            if (preferences.spentTimeRoommate.HasValue)
            {
                if ((bool)preferences.spentTimeRoommate) yesButton5.BackColor = Color.Green;
                else if (!(bool)preferences.spentTimeRoommate) noButton5.BackColor = Color.Red;
            }

            if (preferences.CommonAreaTidy.HasValue)
            {
                if ((bool)preferences.CommonAreaTidy) yesButton6.BackColor = Color.Green;
                else if (!(bool)preferences.CommonAreaTidy) noButton6.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            PnlNav.Height = button.Height;
            PnlNav.Top = button.Top;
            PnlNav.Left = button.Left;
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

        private void btnMessages_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMessages);
            ShowPanel(messages);
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMatches);
            ShowPanel(MatchesPanel1);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProfile);
            ShowPanel(ProfilePanel);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSettings);
            ProfilePanel.Visible = false;
            messages.Visible = false;

            // Might refactor this button to be a refresh button instead of settings
            // since it is likely that we will remove settings as a button.
            //LoadProfileInfoFromDB();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnDashboard);
        }

        private void btnMessages_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnMessages);
        }

        private void btnMatches_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnMatches);
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnProfile);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnSettings);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPanel(Panel displayThisPanel)
        {
            // hide all other panels
            ProfilePanel.Visible = false;
            MatchesPanel1.Visible = false;
            messages.Visible = false;

            // display the chosen panel
            displayThisPanel.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void yesButtonHandler_Click(object sender, EventArgs e)
        {
            Button yes = (Button)sender;

            switch (yes.Tag)
            {
                case "quiet":
                    yesButton1.BackColor = Color.Green;
                    noButton1.BackColor = default(Color);
                    UserPreferences.isQuiet = true;
                    break;
                case "pets":
                    yesButton2.BackColor = Color.Green;
                    noButton2.BackColor = default(Color);
                    UserPreferences.hasPets = true;
                    break;
                case "early":
                    yesButton3.BackColor = Color.Green;
                    noButton3.BackColor = default(Color);
                    UserPreferences.earlyRiser = true;
                    break;
                case "late":
                    yesButton4.BackColor = Color.Green;
                    noButton4.BackColor = default(Color);
                    UserPreferences.stayUpLate = true;
                    break;
                case "social":
                    yesButton5.BackColor = Color.Green;
                    noButton5.BackColor = default(Color);
                    UserPreferences.spentTimeRoommate = true;
                    break;
                case "tidy":
                    yesButton6.BackColor = Color.Green;
                    noButton6.BackColor = default(Color);
                    UserPreferences.CommonAreaTidy = true;
                    break;
                default:
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                    break;
            }
        }

        private void noButtonHandler_Click(object sender, EventArgs e)
        {
            Button no = (Button)sender;

            switch (no.Tag)
            {
                case "quiet":
                    noButton1.BackColor = Color.Red;
                    yesButton1.BackColor = default(Color);
                    UserPreferences.isQuiet = false;
                    break;
                case "pets":
                    noButton2.BackColor = Color.Red;
                    yesButton2.BackColor = default(Color);
                    UserPreferences.hasPets = false;
                    break;
                case "early":
                    noButton3.BackColor = Color.Red;
                    yesButton3.BackColor = default(Color);
                    UserPreferences.earlyRiser = false;
                    break;
                case "late":
                    noButton4.BackColor = Color.Red;
                    yesButton4.BackColor = default(Color);
                    UserPreferences.stayUpLate = false;
                    break;
                case "social":
                    noButton5.BackColor = Color.Red;
                    yesButton5.BackColor = default(Color);
                    UserPreferences.spentTimeRoommate = false;
                    break;
                case "tidy":
                    noButton6.BackColor = Color.Red;
                    yesButton6.BackColor = default(Color);
                    UserPreferences.CommonAreaTidy = false;
                    break;
                default:
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
                    break;
            }
        }

        public bool AreAllQuestionsAnswered(Preferences preferences)
        {
            return preferences.isQuiet != null &&
                   preferences.hasPets != null &&
                   preferences.earlyRiser != null &&
                   preferences.stayUpLate != null &&
                   preferences.spentTimeRoommate != null &&
                   preferences.CommonAreaTidy != null;
        }

        private void savePrefbutton1_Click(object sender, EventArgs e)
        {
            if (AreAllQuestionsAnswered(UserPreferences))
            {
                MessageBox.Show("All preferences have been saved!.");
                UserInfo userPref = new UserInfo(loggedInUser, UserPreferences, textBox1.Text);
                UserInfoWithInt user = new(userPref, 0);
                SQLiteDataAccess.SavePreferences(user);
            }
            else
            {
                MessageBox.Show("Please answer all questions before saving.");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchBar.Visible == true)
            {
                searchBar.Visible = false;
            }
            else
            {
                searchBar.Visible = true;
            }
        }

        private void notifications_Click(object sender, EventArgs e)
        {
            if (notificationList.Visible == true)
            {
                notificationList.Visible = false;
            }
            else
            {
                notificationList.Visible = true;
            }
        }

        private void chat_Click(object sender, EventArgs e)
        {
            if (contactMessages.Visible == true)
            {
                contactMessages.Visible = false;
            }
            else
            {
                contactMessages.Visible = true;
                contactMessages.BringToFront();
                contactMessages.Dock = DockStyle.Bottom;
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            string message = messageEditor.Text;

            Label textBubble = new Label();

            textBubble.Text = message;
            textBubble.TextAlign = ContentAlignment.MiddleLeft;
            textBubble.AutoSize = true;
            textBubble.Padding = new Padding(10);
            textBubble.BackColor = Color.LightBlue;
            textBubble.Margin = new Padding(0, 2, 0, 2);

            int yOffset = 10;

            foreach (Control control in contactMessages.Controls)
            {
                yOffset += control.Height + control.Margin.Bottom;
            }

            textBubble.Location = new Point(10, yOffset);

            textMessageViewer.Controls.Add(textBubble);

            textMessageViewer.ScrollControlIntoView(textBubble);

            messageEditor.Clear();

            sentMessages.Add(sentMessageCounter++, textBubble);

            chat.Text = message;
        }

        public static void DisplayRankedUsers(string loggedInUsername, ListBox listBox)
        {
            // Get the list of all users
            List<UserInfoWithInt> allUsers = SQLiteDataAccess.GetListOfUsers();

            // Rank users  excludes the loggin in user
            rankedUsers = RoommateApp.RankUsers(allUsers, loggedInUsername);

            // Clear the ListBox
            listBox.Items.Clear();

            // Add each user to the ListBox
            int rank = 1;
            foreach (var user in rankedUsers)
            {
                string displayText = $"{rank}. {user.User.firstname} {user.User.lastname} - Score: {user.Score}";
                listBox.Items.Add(displayText);
                rank++;
            }
        }

        private void refreshList_Click(object sender, EventArgs e)
        {
            DisplayRankedUsers(loggedInUser.Username, listBox1);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedUsersTextBio.Clear();
            ClearCheckList();


            // turns selected item to a string
            string selectedUserTextDisplayed = listBox1.SelectedItem.ToString();

            // parse the string to get the users ranking 
            int selectedUsersRank = int.Parse(selectedUserTextDisplayed.Split('.')[0]);

            // turn the list of rankedUsers (of type UserWithAnInt) to a string
            var rankedUsersList = rankedUsers.ToList();

            // then use the user rank we parsed to then get the index of the selected user we're looking for in the list
            var selectedUser = rankedUsersList[selectedUsersRank - 1];

            // if we find the user in that list of users display the selected users bio in the textbox and preferences in the checkbox
            if (selectedUser != null)
            {
                SelectedUsersTextBio.Text = selectedUser.User.aboutMe;
                UpdatePreferencesCheckList(selectedUser.User.prefs);

            }
        }

        private void SelectedUsersTextBio_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectedUserslabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectedUsersPrefsLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectedUsersPreferences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePreferencesCheckList(Preferences preferences)
        {
            // this updates the checkbox
            SelectedUsersPreferences.SetItemChecked(0, preferences.isQuiet ?? false);
            SelectedUsersPreferences.SetItemChecked(1, preferences.hasPets ?? false);
            SelectedUsersPreferences.SetItemChecked(2, preferences.earlyRiser ?? false);
            SelectedUsersPreferences.SetItemChecked(3, preferences.stayUpLate ?? false);
            SelectedUsersPreferences.SetItemChecked(4, preferences.spentTimeRoommate ?? false);
            SelectedUsersPreferences.SetItemChecked(5, preferences.CommonAreaTidy ?? false);

        }

        private void ClearCheckList()
        {
            // this clears the checkbox
            for (int i = 0; i < SelectedUsersPreferences.Items.Count; i++)
            {
                SelectedUsersPreferences.SetItemChecked(i, false);
            }
        }

        private void requestbutton_Click(object sender, EventArgs e)
        {
            string senderUsername = "currentUsername";
            string receiverUsername = "selectedUser"; //this will be replaced after we click on the user that we wanna add 


            bool requestSent = RoommateService.SendRequest(senderUsername, receiverUsername);

            if (requestSent)
            {
                MessageBox.Show("Roommate request sent successfully!");
            }
            else
            {
                MessageBox.Show("Failed to send roommate request. It may already exist or there was an error.");
            }
        }
    }
}
