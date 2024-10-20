using System.Runtime.InteropServices;

namespace RoomMate_WinFormsApp
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            currentButton = btnDashboard;
         
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
            ProfilePanel.Visible = false;
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMessages);
            ProfilePanel.Visible = false;
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            ActivateButton(btnMatches);
            ProfilePanel.Visible = false;

        }

        // this is what im working on
        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfilePanel.Visible = true;
            ActivateButton(btnProfile);
            
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

        }

        private void btnProfile_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnProfile);
            // ProfilePanel.Visible = false;
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            DeactivateButton(btnSettings);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void ProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_3(object sender, EventArgs e)
        {

        }

        private void Question3label_Click(object sender, EventArgs e)
        {

        }

        private void SetQuestionsToDefault()
        {
            // question 1 
            yesButton1.BackColor = default(Color);
            noButton1.BackColor = default(Color);

            // question 2
            yesButton2.BackColor = default(Color);
            noButton2.BackColor = default(Color);

            // question 3
            yesButton3.BackColor = default(Color);
            noButton3.BackColor = default(Color);

            //question 4
            yesButton4.BackColor = default(Color);
            noButton4.BackColor = default(Color);
            // question 5
            yesButton5.BackColor = default(Color);
            noButton5.BackColor = default(Color);
            //question 6
            yesButton6.BackColor = default(Color);
            noButton6.BackColor = default(Color);


        }


        // yes button to question 1
        private void yesbutton1_Click(object sender, EventArgs e)
        {
            
            yesButton1.BackColor = Color.Green;
            noButton1.BackColor = default(Color);
        }

        // no button to question 1
        private void nobutton1_Click(object sender, EventArgs e)
        {
            noButton1.BackColor = Color.Red;
            yesButton1.BackColor = default(Color);
        }

        // yes button to question 2
        private void yesButton2_Click(object sender, EventArgs e)
        {
            yesButton2.BackColor = Color.Green;
            noButton2.BackColor = default(Color);
        }

        // no button to question 2
        private void noButton2_Click(object sender, EventArgs e)
        {
            noButton2.BackColor = Color.Red;
            yesButton2.BackColor = default(Color);
        }

        // yes button to question 3
        private void yesButton3_Click(object sender, EventArgs e)
        {
            yesButton3.BackColor = Color.Green;
            noButton3.BackColor = default(Color);
        }

        // no button to question 3
        private void noButton3_Click(object sender, EventArgs e)
        {
            noButton3.BackColor = Color.Red;
            yesButton3.BackColor = default(Color);
        }

        // yes button to question 4
        private void yesButton4_Click(object sender, EventArgs e)
        {
            yesButton4.BackColor = Color.Green;
            noButton4.BackColor = default(Color);
        }

        // no button to question 4
        private void noButton4_Click(object sender, EventArgs e)
        {
            noButton4.BackColor = Color.Red;
            yesButton4.BackColor = default(Color);
        }

        // yes button to question 5
        private void yesButton5_Click(object sender, EventArgs e)
        {
            yesButton5.BackColor = Color.Green;
            noButton5.BackColor = default(Color);
        }

        // no button to question 5
        private void noButton5_Click(object sender, EventArgs e)
        {
            noButton5.BackColor = Color.Red;
            yesButton5.BackColor = default(Color);
        }

        // yes button to question 6
        private void yesButton6_Click(object sender, EventArgs e)
        {
            yesButton6.BackColor = Color.Green;
            noButton6.BackColor = default(Color);
        }

        // no button to question 6
        private void noButton6_Click(object sender, EventArgs e)
        {
            noButton6.BackColor = Color.Red;
            yesButton6.BackColor = default(Color);
        }

        // set all the question buttons back to default
        private void clearPrefbutton1_Click(object sender, EventArgs e)
        {
            SetQuestionsToDefault();
        }
    }
}
