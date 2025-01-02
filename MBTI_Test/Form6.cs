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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        #region Q16
        private void radioButton16_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 3;
        }

        private void radioButton16_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 3;
        }

        private void radioButton16_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 2;
            Score.IScore += 2;
        }

        private void radioButton16_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 2;
        }
        #endregion Q16

        #region Q17
        private void radioButton17_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 3;
        }

        private void radioButton17_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 3;
        }

        private void radioButton17_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 2;
            Score.PScore += 1;
        }

        private void radioButton17_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 2;
        }
        #endregion Q17

        #region Q18
        private void radioButton18_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 3;
        }

        private void radioButton18_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 3;
        }

        private void radioButton18_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 2;
        }

        private void radioButton18_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 2;
        }
        #endregion Q18

        private void button_PreviousPage6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button_NextPage6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
