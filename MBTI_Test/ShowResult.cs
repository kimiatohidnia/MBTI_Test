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
    public partial class ShowResult : Form
    {
        public ShowResult()
        {
            InitializeComponent();
        }

        private void ShowResult_Load(object sender, EventArgs e)
        {
            string PersonalityType = Score.GetPersonalityType();
            label_result.Text = PersonalityType;

            ShowResultImage(PersonalityType);

            switch (PersonalityType)
            {
                case "INTJ":
                    this.BackColor = Color.FromArgb(128, 0, 128);
                    break;
                case "INTP":
                    this.BackColor = Color.FromArgb(135, 206, 235);
                    break;
                case "ENTJ":
                    this.BackColor = Color.FromArgb(139, 0, 0);
                    break;
                case "ENTP":
                    this.BackColor = Color.FromArgb(255, 165, 0);
                    break;
                case "INFJ":
                    this.BackColor = Color.FromArgb(0, 128, 0);
                    break;
                case "INFP":
                    this.BackColor = Color.FromArgb(144, 238, 144);
                    break;
                case "ENFJ":
                    this.BackColor = Color.FromArgb(255, 223, 0);
                    break;
                case "ENFP":
                    this.BackColor = Color.FromArgb(255, 105, 180);
                    break;
                case "ISTJ":
                    this.BackColor = Color.FromArgb(169, 169, 169);
                    break;
                case "ISFJ":
                    this.BackColor = Color.FromArgb(102, 205, 170);
                    break;
                case "ESTJ":
                    this.BackColor = Color.FromArgb(178, 34, 34);
                    break;
                case "ESFJ":
                    this.BackColor = Color.FromArgb(288, 182, 193);
                    break;
                case "ISTP":
                    this.BackColor = Color.FromArgb(70, 130, 180);
                    break;
                case "ISFP":
                    this.BackColor = Color.FromArgb(0, 255, 255);
                    break;
                case "ESTP":
                    this.BackColor = Color.FromArgb(255, 69, 0);
                    break;
                case "ESFP":
                    this.BackColor = Color.FromArgb(255, 215, 0);
                    break;
            }
        }

        private void ShowResultImage(string personality)
        {
            string imagePath = $"./Image/{personality}.png";
            if (System.IO.File.Exists(imagePath))
            {
                pictureBoxResult.ImageLocation = imagePath;
            }  
        }
        private void ShowResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
