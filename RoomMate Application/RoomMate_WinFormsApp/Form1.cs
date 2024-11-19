using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using RoommateAppLibrary;

namespace RoomMate_WinFormsApp
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Preferences UserPreferences = new Preferences();
        List<UserInfoWithInt> rankingUsers = new List<UserInfoWithInt>();

        private AccountLoginInfo loggedInUser;

        public Form1()
        {
            InitializeComponent();

            currentButton = btnDashboard;
            ActivateButton(btnDashboard);
            ProfilePanel.Visible = false;
            MatchesPanel1.Visible = false;
        }

        public void PassAccountInfoFromLogin(AccountLoginInfo loginInfo)
        {
            this.loggedInUser = loginInfo;
            this.label1.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
            this.label2.Text = loggedInUser.Username;
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
            openMessages(sender, e);
            ProfilePanel.Visible = false;
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMatches);
            ShowPanel(MatchesPanel1);
        }

        // this is what im working on
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(btnProfile);
            ShowPanel(ProfilePanel);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(btnSettings);
            ProfilePanel.Visible = false;
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
            //MatchesPanel1.Visible = false;
        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnProfile);
            //ProfilePanel.Visible = false;
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

            // display the chosen panel
            displayThisPanel.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void openMessages(object sender, EventArgs e)
        {
            var messageForm = new messageDash();
            messageForm.Show();
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

        // set all the question buttons back to default
        private void savePrefbutton1_Click(object sender, EventArgs e)
        {
            if (AreAllQuestionsAnswered(UserPreferences))
            {
                MessageBox.Show("All preferences have been saved!.");
                UserInfo userPref = new UserInfo(loggedInUser, UserPreferences, textBox1.Text);
                UserInfoWithInt user = new(userPref, 0);
                SQLiteDataAccess.SavePreferences(user);
                // these bottom function get the list of users in the database then rank them
                //List<UserInfoWithInt> allUsers = SQLiteDataAccess.GetListOfUsers();
                //List<UserInfoWithInt> rankingUsers = RoommateApp.RankUsers(allUsers, loggedInUser.Username);
            }
            else
            {
                MessageBox.Show("Please answer all questions before saving.");
            }
        }

        public static void DisplayRankedUsers(string loggedInUsername, ListBox listBox)
        {
            // Get the list of all users
            List<UserInfoWithInt> allUsers = SQLiteDataAccess.GetListOfUsers();

            // Rank users  excludes the loggin in user
            List<UserInfoWithInt> rankedUsers = RoommateApp.RankUsers(allUsers, loggedInUsername);

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
    }
}
