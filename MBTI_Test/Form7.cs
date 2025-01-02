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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        #region Q19
        private void radioButton19_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 3;
        }

        private void radioButton19_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 3;
        }

        private void radioButton19_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 2;
        }

        private void radioButton19_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 2;
        }
        #endregion Q19

        #region Q20
        private void radioButton20_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 3;
        }

        private void radioButton20_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 3;
        }

        private void radioButton20_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 2;
        }

        private void radioButton20_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 2;
        }
        #endregion Q20

        private void button_PreviousPage7_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            ShowResult showResult = new ShowResult();
            showResult.Show();
            this.Hide();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}