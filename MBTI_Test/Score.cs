using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBTI_Test
{
    public static class Score
    {
        public static int EScore { get; set; }
        public static int IScore { get; set; }
        public static int SScore { get; set; }
        public static int NScore { get; set; }
        public static int TScore { get; set; }
        public static int FScore { get; set; }
        public static int JScore { get; set; }
        public static int PScore { get; set; }

        public static int AnsweredQuestions { get; set; } = 0;
        public static int TotalQuestions { get; set; } = 20;

        //public static void UpdateProgressBar()
        //{
        //    int progress = (int)((float)AnsweredQuestions / TotalQuestions * 100);
        //    //progressBarTotal.Value = progress;
        //}
        public static string GetPersonalityType()
        {
            string Personality = "";

            if (EScore > IScore)
                Personality += 'E';
            else
                Personality += 'I';

            if (SScore > NScore)
                Personality += 'S';
            else
                Personality += 'N';

            if (TScore > FScore)
                Personality += 'T';
            else
                Personality += 'F';

            if (PScore > JScore)
                Personality += 'P';
            else
                Personality += 'J';

            if (((EScore < 1) && (IScore < 1)) || ((SScore < 1) && (NScore < 1)) || ((TScore < 1) && (FScore < 1)) || ((PScore < 1) && (JScore < 1)))
                Personality = "به همه سوالات پاسخ ندادید";

            return Personality;
        }
    }
}
