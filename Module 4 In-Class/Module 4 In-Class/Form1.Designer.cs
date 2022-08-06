namespace Module_4_In_Class
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_mainHeader = new System.Windows.Forms.Label();
            this.lbl_mc = new System.Windows.Forms.Label();
            this.txt_missedClasses = new System.Windows.Forms.TextBox();
            this.txt_avgQuizAttempt = new System.Windows.Forms.TextBox();
            this.lbl_qa = new System.Windows.Forms.Label();
            this.txt_avgQuizScore = new System.Windows.Forms.TextBox();
            this.lbl_qs = new System.Windows.Forms.Label();
            this.txt_discussionPosts = new System.Windows.Forms.TextBox();
            this.lbl_dp = new System.Windows.Forms.Label();
            this.txt_readingsMade = new System.Windows.Forms.TextBox();
            this.lbl_rm = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mainHeader
            // 
            this.lbl_mainHeader.AutoSize = true;
            this.lbl_mainHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mainHeader.Location = new System.Drawing.Point(153, 71);
            this.lbl_mainHeader.Name = "lbl_mainHeader";
            this.lbl_mainHeader.Size = new System.Drawing.Size(253, 21);
            this.lbl_mainHeader.TabIndex = 0;
            this.lbl_mainHeader.Text = "Student Engagement Calculator";
            // 
            // lbl_mc
            // 
            this.lbl_mc.AutoSize = true;
            this.lbl_mc.Location = new System.Drawing.Point(153, 141);
            this.lbl_mc.Name = "lbl_mc";
            this.lbl_mc.Size = new System.Drawing.Size(94, 15);
            this.lbl_mc.TabIndex = 1;
            this.lbl_mc.Text = "Missed Classes : ";
            // 
            // txt_missedClasses
            // 
            this.txt_missedClasses.Location = new System.Drawing.Point(313, 138);
            this.txt_missedClasses.Multiline = true;
            this.txt_missedClasses.Name = "txt_missedClasses";
            this.txt_missedClasses.Size = new System.Drawing.Size(189, 23);
            this.txt_missedClasses.TabIndex = 2;
            // 
            // txt_avgQuizAttempt
            // 
            this.txt_avgQuizAttempt.Location = new System.Drawing.Point(313, 176);
            this.txt_avgQuizAttempt.Multiline = true;
            this.txt_avgQuizAttempt.Name = "txt_avgQuizAttempt";
            this.txt_avgQuizAttempt.Size = new System.Drawing.Size(189, 23);
            this.txt_avgQuizAttempt.TabIndex = 4;
            // 
            // lbl_qa
            // 
            this.lbl_qa.AutoSize = true;
            this.lbl_qa.Location = new System.Drawing.Point(153, 179);
            this.lbl_qa.Name = "lbl_qa";
            this.lbl_qa.Size = new System.Drawing.Size(135, 15);
            this.lbl_qa.TabIndex = 3;
            this.lbl_qa.Text = "Average Quiz Attempts :";
            // 
            // txt_avgQuizScore
            // 
            this.txt_avgQuizScore.Location = new System.Drawing.Point(313, 214);
            this.txt_avgQuizScore.Multiline = true;
            this.txt_avgQuizScore.Name = "txt_avgQuizScore";
            this.txt_avgQuizScore.Size = new System.Drawing.Size(189, 23);
            this.txt_avgQuizScore.TabIndex = 6;
            // 
            // lbl_qs
            // 
            this.lbl_qs.AutoSize = true;
            this.lbl_qs.Location = new System.Drawing.Point(153, 217);
            this.lbl_qs.Name = "lbl_qs";
            this.lbl_qs.Size = new System.Drawing.Size(115, 15);
            this.lbl_qs.TabIndex = 5;
            this.lbl_qs.Text = "Average Quiz Score :";
            // 
            // txt_discussionPosts
            // 
            this.txt_discussionPosts.Location = new System.Drawing.Point(313, 252);
            this.txt_discussionPosts.Multiline = true;
            this.txt_discussionPosts.Name = "txt_discussionPosts";
            this.txt_discussionPosts.Size = new System.Drawing.Size(189, 23);
            this.txt_discussionPosts.TabIndex = 8;
            // 
            // lbl_dp
            // 
            this.lbl_dp.AutoSize = true;
            this.lbl_dp.Location = new System.Drawing.Point(153, 255);
            this.lbl_dp.Name = "lbl_dp";
            this.lbl_dp.Size = new System.Drawing.Size(100, 15);
            this.lbl_dp.TabIndex = 7;
            this.lbl_dp.Text = "Discussion Posts :";
            // 
            // txt_readingsMade
            // 
            this.txt_readingsMade.Location = new System.Drawing.Point(313, 290);
            this.txt_readingsMade.Multiline = true;
            this.txt_readingsMade.Name = "txt_readingsMade";
            this.txt_readingsMade.Size = new System.Drawing.Size(189, 23);
            this.txt_readingsMade.TabIndex = 10;
            // 
            // lbl_rm
            // 
            this.lbl_rm.AutoSize = true;
            this.lbl_rm.Location = new System.Drawing.Point(153, 293);
            this.lbl_rm.Name = "lbl_rm";
            this.lbl_rm.Size = new System.Drawing.Size(118, 15);
            this.lbl_rm.TabIndex = 9;
            this.lbl_rm.Text = "% of readings made :";
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_calculate.Location = new System.Drawing.Point(410, 358);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(92, 37);
            this.btn_calculate.TabIndex = 11;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 488);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_readingsMade);
            this.Controls.Add(this.lbl_rm);
            this.Controls.Add(this.txt_discussionPosts);
            this.Controls.Add(this.lbl_dp);
            this.Controls.Add(this.txt_avgQuizScore);
            this.Controls.Add(this.lbl_qs);
            this.Controls.Add(this.txt_avgQuizAttempt);
            this.Controls.Add(this.lbl_qa);
            this.Controls.Add(this.txt_missedClasses);
            this.Controls.Add(this.lbl_mc);
            this.Controls.Add(this.lbl_mainHeader);
            this.Name = "frm_Main";
            this.Text = "Numeric Variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mainHeader;
        private System.Windows.Forms.Label lbl_mc;
        private System.Windows.Forms.TextBox txt_missedClasses;
        private System.Windows.Forms.TextBox txt_avgQuizAttempt;
        private System.Windows.Forms.Label lbl_qa;
        private System.Windows.Forms.TextBox txt_avgQuizScore;
        private System.Windows.Forms.Label lbl_qs;
        private System.Windows.Forms.TextBox txt_discussionPosts;
        private System.Windows.Forms.Label lbl_dp;
        private System.Windows.Forms.TextBox txt_readingsMade;
        private System.Windows.Forms.Label lbl_rm;
        private System.Windows.Forms.Button btn_calculate;
    }
}
