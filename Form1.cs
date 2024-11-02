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
            liveshots--;
            lbllive.Text = liveshots.ToString();
            currentshot++;

            lblshotnumber.Text = currentshot.ToString();
            int templiveshots = liveshots - 1;
            tblive.Text = templiveshots.ToString();

        }

        private void btnblank_Click(object sender, EventArgs e)
        {
            blankshots--;
            lblblank.Text = blankshots.ToString();
            currentshot++;
            lblshotnumber.Text = currentshot.ToString();
            int tempblankshots = blankshots - 1;
            tbblank.Text = tempblankshots.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            liveshots = 0;
            blankshots = 0;
            shots = 0;
            currentshot = 0;
            tbblank.Text = String.Empty;
            lbllive.Text = String.Empty;
        }
    }
}
