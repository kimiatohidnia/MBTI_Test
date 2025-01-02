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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        #region Q07
        private void radioButton7_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 3;
        }

        private void radioButton7_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 3;
        }

        private void radioButton7_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.TScore += 2;
        }

        private void radioButton7_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.FScore += 2;
        }
        #endregion Q07

        #region Q08
        private void radioButton8_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 3;
        }

        private void radioButton8_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 3;
        }

        private void radioButton8_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.JScore += 1;
            Score.PScore += 2;
        }

        private void radioButton8_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.PScore += 2;
        }
        #endregion Q08

        #region Q09
        private void radioButton9_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 3;
        }

        private void radioButton9_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 3;
        }

        private void radioButton9_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 1;
            Score.EScore += 1;
        }

        private void radioButton9_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 2;
        }
        #endregion Q09

        private void button_PreviousPage3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button_NextPage3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}