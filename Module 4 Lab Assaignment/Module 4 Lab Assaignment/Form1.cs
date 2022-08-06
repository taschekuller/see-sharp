using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_4_Lab_Assaignment
{
    public partial class frm_Main : Form

    {
        

        public frm_Main()
        {
            InitializeComponent();

        }

        private void btn_labelCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //reading calculation
                double readingPV = double.Parse(txt_readingPV.Text);
                double readingH = double.Parse(txt_readingH.Text);
                double readingUP = double.Parse(txt_readingUP.Text);

                var readingScore = (readingPV + readingH) / readingUP;

                double readingScoreINFO = Math.Round(readingScore, 2);

                lbl_readingINFO.ForeColor = Color.Blue;
                lbl_readingINFO.Text = "Your readings score is : " + readingScoreINFO.ToString();

                
            }
            catch
            {
                lbl_readingINFO.Text = "Invalid entries in Reading box!";
                lbl_readingINFO.ForeColor = Color.IndianRed;
            }
            try
            {
                //discussion calculation
                double discussionQ = double.Parse(txt_discussionQ.Text);
                double discussionC = double.Parse(txt_discussionC.Text);
                double discussionUP = double.Parse(txt_discussionUP.Text);

                var discussionScore = (discussionQ + discussionC) / discussionUP;

                double disucssionScoreINFO = Math.Round(discussionScore, 2);

                lbl_discussionINFO.ForeColor = Color.Blue;
                lbl_discussionINFO.Text = "Your discussion score is : " + disucssionScoreINFO.ToString();
            }
            catch
            {
                lbl_discussionINFO.Text = "Invalid entries in Discussion box!";
                lbl_discussionINFO.ForeColor = Color.IndianRed;
            }
            try
            {
                //video calculation
                double videoAMW = double.Parse(txt_videoAMW.Text);
                double videoPP = double.Parse(txt_videoPP.Text);
                double videoMS = double.Parse(txt_videoMS.Text);

                var videoScore = (videoAMW + videoPP) / videoMS;

                double videoScoreINFO = Math.Round(videoScore, 2);

                lbl_videoINFO.ForeColor = Color.Blue;
                lbl_videoINFO.Text = "Your video score is : " + videoScoreINFO.ToString();


            }
            catch
            {
                lbl_videoINFO.Text = "Invalid entries in Video box!";
                lbl_videoINFO.ForeColor = Color.IndianRed;
            }
            try
            {
                //quiz calculation
                double quizFQ = double.Parse(txt_quizFQ.Text);
                double quizQS = double.Parse(txt_quizQS.Text);
                double quizA = double.Parse(txt_quizA.Text);

                var quizScore = (quizFQ + quizQS) / quizA;

                double quizScoreINFO = Math.Round(quizScore, 2);

                lbl_quizINFO.ForeColor = Color.Blue;
                lbl_quizINFO.Text = "Your quiz score is : " + quizScoreINFO.ToString();
               


            }
            catch
            {
                lbl_quizINFO.Text = "Invalid entries in Quiz box!";
                lbl_quizINFO.ForeColor = Color.IndianRed;
            }

            //general calculation
            double mainINFO = readingScoreMain + disucssionScoreINFO + videoScoreINFO + quizScoreINFO;
            lbl_mainINFO.ForeColor = Color.Blue;
            lbl_mainINFO.Text = "Your general engagement score is : " + mainINFO.ToString();
        }
    }
}
