using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.ObjectModel;

namespace StudentManagerment.Objects
{
	public class SemesterDataGrid
	{
		// ID học kỳ
		public Guid IdSemester { get; set; }

		// Tên học kỳ (VD: "Học kỳ 1", "Spring 2024")
		public string DisplayName { get; set; }

		// Khóa học hoặc niên khóa (VD: "K2021")
		public string Batch { get; set; }

		// Điểm trung bình học kỳ (GPA)
		public double GPA { get; set; }

		// Tổng điểm rèn luyện
		public int TotalTrainingScore { get; set; }

		// Danh sách điểm các môn học
		public ObservableCollection<ScoreDataGrid> CurrentScore { get; set; }

		// Danh sách điểm rèn luyện
		public ObservableCollection<TrainingScoreDataGrid> CurrentTrainingScore { get; set; }

		// Constructor khởi tạo đầy đủ
		public SemesterDataGrid(Guid idSemester, string displayName, string batch, double gpa, int totalTrainingScore,
			ObservableCollection<ScoreDataGrid> currentScore, ObservableCollection<TrainingScoreDataGrid> currentTrainingScore)
		{
			IdSemester = idSemester;
			DisplayName = displayName;
			Batch = batch;
			GPA = gpa;
			TotalTrainingScore = totalTrainingScore;
			CurrentScore = currentScore;
			CurrentTrainingScore = currentTrainingScore;
		}
	}
}
