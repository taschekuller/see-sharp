using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_4_In_Class
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                int mc = int.Parse(txt_missedClasses.Text);
                double rm = double.Parse(txt_readingsMade.Text);
                double qa = double.Parse(txt_avgQuizAttempt.Text);
                double qs = double.Parse(txt_avgQuizScore.Text);
                int dp = int.Parse(txt_discussionPosts.Text);

                //calculation 
                double numerator = rm * 60 + qa * 10 + qs * 15 + dp * 15;
                double denominator = mc * 100;

                double engagementLevel = numerator / denominator;
                MessageBox.Show(engagementLevel.ToString(), "Engagement Level");
            }
            catch (Exception ex)
            {
                //error box
                StringBuilder sb_error = new StringBuilder();
                sb_error.AppendLine("Please enter a valid numeric value in all fields.");
                sb_error.AppendLine();
                sb_error.AppendLine("More Info:");
                sb_error.AppendLine(ex.Message);

                MessageBox.Show(sb_error.ToString());

            }
       
    }
    }
}
