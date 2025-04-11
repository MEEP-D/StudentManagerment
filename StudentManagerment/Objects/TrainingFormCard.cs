using System;
using System.Collections.ObjectModel;
using StudentManagerment.Models;
using StudentManagerment.Services;

namespace StudentManagerment.Objects
{
	public class TrainingFormCard
	{
		public Guid Id { get; set; }
		public string DisplayName { get; set; }
		public int NumberOfFaculties { get; set; }
		public int NumberOfStudents { get; set; }
		public bool IsDeleted { get; set; }
		public ObservableCollection<Faculty> TrainingFormsOfFacultyList { get; set; }

		public TrainingFormCard()
		{
			Id = Guid.NewGuid();
			TrainingFormsOfFacultyList = new ObservableCollection<Faculty>();
		}

		public TrainingFormCard(Guid id, string displayName, int numberOfFaculties, int numberOfStudents)
		{
			Id = id;
			DisplayName = displayName;
			NumberOfFaculties = numberOfFaculties;
			NumberOfStudents = numberOfStudents;

			//var tempTrainingForm = TrainingFormServices.Instance.FindTrainingFormByTrainingFormId(Id);
			//TrainingFormsOfFacultyList = new ObservableCollection<Faculty>(
			//	Faculty_TrainingFormServices.Instance.LoadFacultyByTrainingForm(tempTrainingForm));
		}
	}
}
