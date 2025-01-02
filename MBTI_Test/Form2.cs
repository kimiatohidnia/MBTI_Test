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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        #region Q04
        private void radioButton4_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 3;
        }

        private void radioButton4_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 3;
        }

        private void radioButton4_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 2;
        }

        private void radioButton4_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 2;
        }
        #endregion Q04

        #region Q05
        private void radioButton5_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 3;
        }

        private void radioButton5_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 2;
        }

        private void radioButton5_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 3;
        }

        private void radioButton5_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 2;
        }

        #endregion Q05

        #region Q06
        private void radioButton6_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 3;
        }

        private void radioButton6_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 3;
        }

        private void radioButton6_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 2;
        }

        private void radioButton6_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 2;
        }
        #endregion Q06

        private void button_PreviousPage2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button_NextPage2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}