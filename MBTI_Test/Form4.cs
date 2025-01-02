using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBTI_Test
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        #region Q10
        private void radioButton10_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 3;
        }

        private void radioButton10_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 2;
        }

        private void radioButton10_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 3;
        }

        private void radioButton10_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 2;
        }
        #endregion Q10

        #region Q11
        private void radioButton11_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 3;
        }

        private void radioButton11_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 3;
        }

        private void radioButton11_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 2;
        }

        private void radioButton11_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 2;
        }
        #endregion Q11

        #region Q12
        private void radioButton12_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 3;
        }

        private void radioButton12_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 3;
        }

        private void radioButton12_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 2;
            Score.PScore += 1;
        }

        private void radioButton12_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 2;
        }
        #endregion Q12

        private void button_PreviousPage4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button_NextPage4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}