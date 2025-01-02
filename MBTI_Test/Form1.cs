using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBTI_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Q01
        private void radioButton1_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 2;
        }

        private void radioButton1_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 1;
            Score.IScore += 1;
        }

        private void radioButton1_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 2;
        }

        private void radioButton1_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 3;
        }
        #endregion Q01

        #region Q02
        private void radioButton2_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 3;
        }

        private void radioButton2_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.SScore += 2;
        }

        private void radioButton2_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 2;
        }

        private void radioButton2_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.NScore += 3;
        }
        #endregion Q02

        #region Q03
        private void radioButton3_1_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 3;
        }

        private void radioButton3_2_CheckedChanged(object sender, EventArgs e)
        {
            Score.EScore += 1;
            Score.IScore += 1;
        }

        private void radioButton3_3_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 2;
        }

        private void radioButton3_4_CheckedChanged(object sender, EventArgs e)
        {
            Score.IScore += 3;
        }
        #endregion Q03

        private void button_NextPage1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}