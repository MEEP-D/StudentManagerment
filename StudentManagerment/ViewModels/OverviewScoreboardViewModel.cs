using System;

namespace StudentManagerment.ViewModels
{
    public class OverviewScoreboardViewModel
    {
        public string GPAColor { get; set; }
        public string TrainingColor { get; set; }
        public string CreditColor { get; set; }

        public string PercentGPA { get; set; }
        public string PercentTraining { get; set; }
        public string PercentCredit { get; set; }

        public string DisplayName { get; set; }

        public double GPA { get; set; }
        public double Training { get; set; }
        public double Credit { get; set; }

        private string GetColor(int percent)
        {
            if (percent >= 90) return "#008613";
            if (percent >= 80) return "#008600";
            if (percent >= 65) return "#ffe5ff00";
            if (percent >= 50) return "#d44100";
            return "#d50000";
        }

        private int GetPercent(double current, double total)
        {
            return (int)(current / total * 100);
        }

        public OverviewScoreboardViewModel(double gpa, double training, int credit, string name)
        {
            int gpaPercent = GetPercent(gpa, 10);
            int trainingPercent = GetPercent(training, 100);
            int creditPercent = GetPercent(credit, 130);

            GPAColor = GetColor(gpaPercent);
            TrainingColor = GetColor(trainingPercent);
            CreditColor = GetColor(creditPercent);

            PercentGPA = gpaPercent.ToString();
            PercentTraining = trainingPercent.ToString();
            PercentCredit = creditPercent.ToString();

            GPA = gpa;
            Training = training;
            Credit = credit;
            DisplayName = name;
        }
    }
}
