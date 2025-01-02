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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        #region Q13
        private void radioButton13_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 3;
        }

        private void radioButton13_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 2;
        }

        private void radioButton13_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 3;
        }

        private void radioButton13_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 2;
        }
        #endregion Q13

        #region Q14
        private void radioButton14_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 3;
        }

        private void radioButton14_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 3;
        }

        private void radioButton14_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 2;
        }

        private void radioButton14_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 2;
        }
        #endregion Q14

        #region Q15
        private void radioButton15_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 3;
        }

        private void radioButton15_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 3;
        }

        private void radioButton15_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 2;
        }

        private void radioButton15_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 2;
        }
        #endregion Q15

        private void button_PreviousPage5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button_NextPage5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}