using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrisbeeGolf
{
    public partial class Form1 : Form
    {

        int score = 0;

        int parStatus = 0;

        private Hole hole1 = new Hole();
        private Hole hole2 = new Hole();
        private Hole hole3 = new Hole();
        private Hole hole4 = new Hole();
        private Hole hole5 = new Hole();
        private Hole hole6 = new Hole();
        private Hole hole7 = new Hole();
        private Hole hole8 = new Hole();
        private Hole hole9 = new Hole();
        private Hole hole10 = new Hole();
        private Hole hole11 = new Hole();
        private Hole hole12 = new Hole();
        private Hole hole13 = new Hole();
        private Hole hole14 = new Hole();
        private Hole hole15 = new Hole();
        private Hole hole16 = new Hole();
        private Hole hole17 = new Hole();
        private Hole hole18 = new Hole();

        public Form1()
        {
            InitializeComponent();

            nudHole1.Controls[0].Visible = false;
            nudHole2.Controls[0].Visible = false;
            nudHole3.Controls[0].Visible = false;
            nudHole4.Controls[0].Visible = false;
            nudHole5.Controls[0].Visible = false;
            nudHole6.Controls[0].Visible = false;
            nudHole7.Controls[0].Visible = false;
            nudHole8.Controls[0].Visible = false;
            nudHole9.Controls[0].Visible = false;
            nudHole10.Controls[0].Visible = false;
            nudHole11.Controls[0].Visible = false;
            nudHole12.Controls[0].Visible = false;
            nudHole13.Controls[0].Visible = false;
            nudHole14.Controls[0].Visible = false;
            nudHole15.Controls[0].Visible = false;
            nudHole16.Controls[0].Visible = false;
            nudHole17.Controls[0].Visible = false;
            nudHole18.Controls[0].Visible = false;

        }

        private void cboHoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            score = 0;
            parStatus = 0;
            lblScore.Text = score.ToString();

            nudHole1.Value = 0;
            nudHole2.Value = 0;
            nudHole3.Value = 0;
            nudHole4.Value = 0;
            nudHole5.Value = 0;
            nudHole6.Value = 0;
            nudHole7.Value = 0;
            nudHole8.Value = 0;
            nudHole9.Value = 0;
            nudHole10.Value = 0;
            nudHole11.Value = 0;
            nudHole12.Value = 0;
            nudHole13.Value = 0;
            nudHole14.Value = 0;
            nudHole15.Value = 0;
            nudHole16.Value = 0;
            nudHole17.Value = 0;
            nudHole18.Value = 0;

            int selectedHoles = cboHoles.SelectedIndex;
            if (selectedHoles == 0)
            {
                // Input
                nudHole1.Visible = true;
                nudHole2.Visible = true;
                nudHole3.Visible = true;
                nudHole4.Visible = true;
                nudHole5.Visible = true;
                nudHole6.Visible = true;
                nudHole7.Visible = true;
                nudHole8.Visible = true;
                nudHole9.Visible = true;

                nudHole10.Visible = false;
                nudHole11.Visible = false;
                nudHole12.Visible = false;
                nudHole13.Visible = false;
                nudHole14.Visible = false;
                nudHole15.Visible = false;
                nudHole16.Visible = false;
                nudHole17.Visible = false;
                nudHole18.Visible = false;
                // Par of hole
                lblHole1.Visible = true;
                lblHole2.Visible = true;
                lblHole3.Visible = true;
                lblHole4.Visible = true;
                lblHole5.Visible = true;
                lblHole6.Visible = true;
                lblHole7.Visible = true;
                lblHole8.Visible = true;
                lblHole9.Visible = true;

                lblHole10.Visible = false;
                lblHole11.Visible = false;
                lblHole12.Visible = false;
                lblHole13.Visible = false;
                lblHole14.Visible = false;
                lblHole15.Visible = false;
                lblHole16.Visible = false;
                lblHole17.Visible = false;
                lblHole18.Visible = false;
                // Hole Number
                lblHole1T.Visible = true;
                lblHole2T.Visible = true;
                lblHole3T.Visible = true;
                lblHole4T.Visible = true;
                lblHole5T.Visible = true;
                lblHole6T.Visible = true;
                lblHole7T.Visible = true;
                lblHole8T.Visible = true;
                lblHole9T.Visible = true;

                lblHole10T.Visible = false;
                lblHole11T.Visible = false;
                lblHole12T.Visible = false;
                lblHole13T.Visible = false;
                lblHole14T.Visible = false;
                lblHole15T.Visible = false;
                lblHole16T.Visible = false;
                lblHole17T.Visible = false;
                lblHole18T.Visible = false;
            }

            if (selectedHoles == 1)
            {
                // Input
                nudHole1.Visible = false;
                nudHole2.Visible = false;
                nudHole3.Visible = false;
                nudHole4.Visible = false;
                nudHole5.Visible = false;
                nudHole6.Visible = false;
                nudHole7.Visible = false;
                nudHole8.Visible = false;
                nudHole9.Visible = false;

                nudHole10.Visible = true;
                nudHole11.Visible = true;
                nudHole12.Visible = true;
                nudHole13.Visible = true;
                nudHole14.Visible = true;
                nudHole15.Visible = true;
                nudHole16.Visible = true;
                nudHole17.Visible = true;
                nudHole18.Visible = true;
                // Par of hole
                lblHole1.Visible = false;
                lblHole2.Visible = false;
                lblHole3.Visible = false;
                lblHole4.Visible = false;
                lblHole5.Visible = false;
                lblHole6.Visible = false;
                lblHole7.Visible = false;
                lblHole8.Visible = false;
                lblHole9.Visible = false;

                lblHole10.Visible = true;
                lblHole11.Visible = true;
                lblHole12.Visible = true;
                lblHole13.Visible = true;
                lblHole14.Visible = true;
                lblHole15.Visible = true;
                lblHole16.Visible = true;
                lblHole17.Visible = true;
                lblHole18.Visible = true;
                // Hole Number
                lblHole1T.Visible = false;
                lblHole2T.Visible = false;
                lblHole3T.Visible = false;
                lblHole4T.Visible = false;
                lblHole5T.Visible = false;
                lblHole6T.Visible = false;
                lblHole7T.Visible = false;
                lblHole8T.Visible = false;
                lblHole9T.Visible = false;

                lblHole10T.Visible = true;
                lblHole11T.Visible = true;
                lblHole12T.Visible = true;
                lblHole13T.Visible = true;
                lblHole14T.Visible = true;
                lblHole15T.Visible = true;
                lblHole16T.Visible = true;
                lblHole17T.Visible = true;
                lblHole18T.Visible = true;
            }

            if (selectedHoles == 2)
            {
                // Score hole for user
                nudHole1.Visible = true;
                nudHole2.Visible = true;
                nudHole3.Visible = true;
                nudHole4.Visible = true;
                nudHole5.Visible = true;
                nudHole6.Visible = true;
                nudHole7.Visible = true;
                nudHole8.Visible = true;
                nudHole9.Visible = true;

                nudHole10.Visible = true;
                nudHole11.Visible = true;
                nudHole12.Visible = true;
                nudHole13.Visible = true;
                nudHole14.Visible = true;
                nudHole15.Visible = true;
                nudHole16.Visible = true;
                nudHole17.Visible = true;
                nudHole18.Visible = true;
                // Shows the par of the hole
                lblHole1.Visible = true;
                lblHole2.Visible = true;
                lblHole3.Visible = true;
                lblHole4.Visible = true;
                lblHole5.Visible = true;
                lblHole6.Visible = true;
                lblHole7.Visible = true;
                lblHole8.Visible = true;
                lblHole9.Visible = true;

                lblHole10.Visible = true;
                lblHole11.Visible = true;
                lblHole12.Visible = true;
                lblHole13.Visible = true;
                lblHole14.Visible = true;
                lblHole15.Visible = true;
                lblHole16.Visible = true;
                lblHole17.Visible = true;
                lblHole18.Visible = true;
                // The Hole Number
                lblHole1T.Visible = true;
                lblHole2T.Visible = true;
                lblHole3T.Visible = true;
                lblHole4T.Visible = true;
                lblHole5T.Visible = true;
                lblHole6T.Visible = true;
                lblHole7T.Visible = true;
                lblHole8T.Visible = true;
                lblHole9T.Visible = true;

                lblHole10T.Visible = true;
                lblHole11T.Visible = true;
                lblHole12T.Visible = true;
                lblHole13T.Visible = true;
                lblHole14T.Visible = true;
                lblHole15T.Visible = true;
                lblHole16T.Visible = true;
                lblHole17T.Visible = true;
                lblHole18T.Visible = true;

            }
        }

        private void nudHole1_ValueChanged(object sender, EventArgs e)
        {
            hole1.setScore(Convert.ToInt32(nudHole1.Value));
            if (nudHole1.Value != 0)
            {
                hole1.setNonZero(true);
            }
            else
            {
                hole1.setNonZero(false);

            }
            totalScore();
            currentPar();
        }

        private void nudHole2_ValueChanged(object sender, EventArgs e)
        {
            hole2.setScore(Convert.ToInt32(nudHole2.Value));
            if (nudHole2.Value != 0)
            {
                hole2.setNonZero(true);
            }
            else
            {
                hole2.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole3_ValueChanged(object sender, EventArgs e)
        {
            hole3.setScore(Convert.ToInt32(nudHole3.Value));
            if (nudHole3.Value != 0)
            {
                hole3.setNonZero(true);
            }
            else
            {
                hole3.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole4_ValueChanged(object sender, EventArgs e)
        {
            hole4.setScore(Convert.ToInt32(nudHole4.Value));
            if (nudHole4.Value != 0)
            {
                hole4.setNonZero(true);
            }
            else
            {
                hole4.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole5_ValueChanged(object sender, EventArgs e)
        {
            hole5.setScore(Convert.ToInt32(nudHole5.Value));
            if (nudHole5.Value != 0)
            {
                hole5.setNonZero(true);
            }
            else
            {
                hole5.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole6_ValueChanged(object sender, EventArgs e)
        {
            hole6.setScore(Convert.ToInt32(nudHole6.Value));
            if (nudHole6.Value != 0)
            {
                hole6.setNonZero(true);
            }
            else
            {
                hole6.setNonZero(false);
            }
            totalScore();
            currentPar();
        }
        private void nudHole7_ValueChanged(object sender, EventArgs e)
        {
            hole7.setScore(Convert.ToInt32(nudHole7.Value));
            if (nudHole7.Value != 0)
            {
                hole7.setNonZero(true);
            }
            else
            {
                hole7.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole8_ValueChanged(object sender, EventArgs e)
        {
            hole8.setScore(Convert.ToInt32(nudHole8.Value));
            if (nudHole8.Value != 0)
            {
                hole8.setNonZero(true);
            }
            else
            {
                hole8.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole9_ValueChanged(object sender, EventArgs e)
        {
            hole9.setScore(Convert.ToInt32(nudHole9.Value));
            if (nudHole9.Value != 0)
            {
                hole9.setNonZero(true);
            }
            else
            {
                hole9.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole10_ValueChanged(object sender, EventArgs e)
        {
            hole10.setScore(Convert.ToInt32(nudHole10.Value));
            if (nudHole10.Value != 0)
            {
                hole10.setNonZero(true);
            }
            else
            {
                hole10.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole11_ValueChanged(object sender, EventArgs e)
        {
            hole11.setScore(Convert.ToInt32(nudHole11.Value));
            if (nudHole11.Value != 0)
            {
                hole11.setNonZero(true);
            }
            else
            {
                hole11.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole12_ValueChanged(object sender, EventArgs e)
        {
            hole12.setScore(Convert.ToInt32(nudHole12.Value));
            if (nudHole12.Value != 0)
            {
                hole12.setNonZero(true);
            }
            else
            {
                hole12.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole13_ValueChanged(object sender, EventArgs e)
        {
            hole13.setScore(Convert.ToInt32(nudHole13.Value));
            if (nudHole13.Value != 0)
            {
                hole13.setNonZero(true);
            }
            else
            {
                hole13.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole14_ValueChanged(object sender, EventArgs e)
        {
            hole14.setScore(Convert.ToInt32(nudHole14.Value));
            if (nudHole14.Value != 0)
            {
                hole14.setNonZero(true);
            }
            else
            {
                hole14.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole15_ValueChanged(object sender, EventArgs e)
        {
            hole15.setScore(Convert.ToInt32(nudHole15.Value));
            if (nudHole15.Value != 0)
            {
                hole15.setNonZero(true);
            }
            else
            {
                hole15.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole16_ValueChanged(object sender, EventArgs e)
        {
            hole16.setScore(Convert.ToInt32(nudHole16.Value));
            if (nudHole16.Value != 0)
            {
                hole16.setNonZero(true);
            }
            else
            {
                hole16.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole17_ValueChanged(object sender, EventArgs e)
        {
            hole17.setScore(Convert.ToInt32(nudHole17.Value));
            if (nudHole17.Value != 0)
            {
                hole17.setNonZero(true);
            }
            else
            {
                hole17.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void nudHole18_ValueChanged(object sender, EventArgs e)
        {
            hole18.setScore(Convert.ToInt32(nudHole18.Value));
            if (nudHole18.Value != 0)
            {
                hole18.setNonZero(true);
            }
            else
            {
                hole18.setNonZero(false);
            }
            totalScore();
            currentPar();
        }

        private void totalScore()
        {
            if (cboHoles.SelectedIndex == 0)
            {
                score = hole1.getScore() + hole2.getScore() + hole3.getScore() + hole4.getScore() + hole5.getScore()
                    + hole6.getScore() + hole7.getScore() + hole8.getScore() + hole9.getScore();
            }
            else if (cboHoles.SelectedIndex == 1)
            {
                score = hole10.getScore() + hole11.getScore() + hole12.getScore() + hole13.getScore() + hole14.getScore()
                    + hole15.getScore() + hole16.getScore() + hole17.getScore() + hole18.getScore();
            }
            else
            {
                score = hole1.getScore() + hole2.getScore() + hole3.getScore() + hole4.getScore() + hole5.getScore()
                    + hole6.getScore() + hole7.getScore() + hole8.getScore() + hole9.getScore() +
                    hole10.getScore() + hole11.getScore() + hole12.getScore() + hole13.getScore() + hole14.getScore()
                    + hole15.getScore() + hole16.getScore() + hole17.getScore() + hole18.getScore();
            }

            lblScore.Text = score.ToString();
        }

        private void currentPar()
        {
            List<Hole> holes = new List<Hole> { hole1, hole2, hole3, hole4, hole5, hole6, hole7, hole8, hole9, hole10, hole11, hole12, hole13, hole14, hole15, hole16, hole17, hole18 };
            parStatus = 0;
            foreach (Hole current in holes)
            {
                if (current.getNonZero())
                {
                    parStatus += current.getParChange();
                }
            }
            if (parStatus > 0)
            {
                lblPar.Text = "+" + parStatus.ToString();
            }
            else
            {
                lblPar.Text = parStatus.ToString();
            }

        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHoles.Visible = true;
            cboHoles.Visible = true;

            int selectedCourse = cboCourse.SelectedIndex;
            if (selectedCourse == 0)
            {
                hole1.setPar(3);
                hole2.setPar(3);
                hole3.setPar(3);
                hole4.setPar(3);
                hole5.setPar(3);
                hole6.setPar(3);
                hole7.setPar(7);
                hole8.setPar(3);
                hole9.setPar(3);
                hole10.setPar(3);
                hole11.setPar(3);
                hole12.setPar(3);
                hole13.setPar(3);
                hole14.setPar(3);
                hole15.setPar(3);
                hole16.setPar(16);
                hole17.setPar(3);
                hole18.setPar(3);
            }

            lblHole1.Text = "Par " + hole1.getPar();
            lblHole2.Text = "Par " + hole2.getPar();
            lblHole3.Text = "Par " + hole3.getPar();
            lblHole4.Text = "Par " + hole4.getPar();
            lblHole5.Text = "Par " + hole5.getPar();
            lblHole6.Text = "Par " + hole6.getPar();
            lblHole7.Text = "Par " + hole7.getPar();
            lblHole8.Text = "Par " + hole8.getPar();
            lblHole9.Text = "Par " + hole9.getPar();
            lblHole10.Text = "Par " + hole10.getPar();
            lblHole11.Text = "Par " + hole11.getPar();
            lblHole12.Text = "Par " + hole12.getPar();
            lblHole13.Text = "Par " + hole13.getPar();
            lblHole14.Text = "Par " + hole14.getPar();
            lblHole15.Text = "Par " + hole15.getPar();
            lblHole16.Text = "Par " + hole16.getPar();
            lblHole17.Text = "Par " + hole17.getPar();
            lblHole18.Text = "Par " + hole18.getPar();


        }
    }
}
