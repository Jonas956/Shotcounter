using System.Security.Cryptography.X509Certificates;

namespace Shotcounter
{

    public partial class ShotCounter : Form
    {
        int liveshots = 0;
        int blankshots = 0;
        int shots = 0;
        int currentshot = 0;
        //Start Values
        public ShotCounter()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void tblive_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tblive.Text))
            {
                liveshots = 0;
            }
            else
            {

                if (int.TryParse(tblive.Text, out int value))
                {
                    liveshots = value;
                }
                else
                {

                    liveshots = 0;
                }
            }

            lbllive.Text = tblive.Text;


            shots = blankshots + liveshots;

            lblshots.Text = shots.ToString();



        }

        private void tbblank_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbblank.Text))
            {
                blankshots = 0;
            }
            else
            {

                if (int.TryParse(tbblank.Text, out int value))
                {
                    blankshots = value;
                }
                else
                {

                    blankshots = 0;
                }
            }

            lblblank.Text = tbblank.Text;


            shots = blankshots + liveshots;

            lblshots.Text = shots.ToString();



        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            if (liveshots > 0) // Check if there are liveshots left
            {
                liveshots--;
                lbllive.Text = liveshots.ToString();
                currentshot++;
                lblshotnumber.Text = currentshot.ToString();

                tblive.TextChanged -= tblive_TextChanged; // Temporarily remove the event handler
                tblive.Text = liveshots.ToString();
                tblive.TextChanged += tblive_TextChanged; // Reattach the event handler
            }

        }

        private void btnblank_Click(object sender, EventArgs e)
        {
            if (blankshots > 0) // Check if there are blankshots left
            {
                blankshots--;
                lblblank.Text = blankshots.ToString();
                currentshot++;
                lblshotnumber.Text = currentshot.ToString();

                tbblank.TextChanged -= tbblank_TextChanged; // Temporarily remove the event handler
                tbblank.Text = blankshots.ToString();
                tbblank.TextChanged += tbblank_TextChanged; // Reattach the event handler
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            liveshots = 0;
            blankshots = 0;
            shots = 0;
            currentshot = 0;

            tblive.Text = "0";
            tbblank.Text = "0";
            lbllive.Text = "0";
            lblblank.Text = "0";
            lblshotnumber.Text = "0";
            lblshots.Text = "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                pictureBox1.Visible = false;
            }

            else
            {
                 pictureBox1.Visible = true;
            }

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
           
        }
    }
}
