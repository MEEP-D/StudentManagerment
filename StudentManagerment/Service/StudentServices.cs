using Microsoft.VisualBasic.ApplicationServices;
using StudentManagerment.Models;
using StudentManagement.Objects;
using StudentManagerment.Utils;
using StudentManagerment.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Service
{
	public class StudentServices
	{
		private static StudentServices s_instance;

		public static StudentServices Instance => s_instance ?? (s_instance = new StudentServices());

		public StudentServices() { }

		#region Convert

		public StudentGrid ConvertStudentToStudentGrid(Student student, int number = 0)
		{
			return new StudentGrid()
			{
				Id = student.Id,
				Number = number,
				DisplayName = student.Users.DisplayName,
				Email = student.Users.Email,
				Faculty = student.Faculty.DisplayName,
				TrainingForm = student.TrainingForm.DisplayName,
				Username = student.Users.Username,
				Status = student.Users.Online == true ? "Trực tuyến" : "Ngoại tuyến"
			};
		}

		#endregion


		public Student GetFirstStudent()
		{
			return DataProvider.Instance.Database.Student.FirstOrDefault();
		}

		public DbSet<Student> LoadStudentList()
		{
			return DataProvider.Instance.Database.Student;
		}

		public Student FindStudentByStudentId(Guid idStudent)
		{
			Student a = DataProvider.Instance.Database.Student.Where(studentItem => studentItem.Id == idStudent).FirstOrDefault();
			return a;
		}

		public Student FindStudentByUserId(Guid idUser)
		{
			Student a = DataProvider.Instance.Database.Student.Where(studentItem => studentItem.IdUsers == idUser).FirstOrDefault();
			return a;
		}

		public bool SaveStudentToDatabase(Student student)
		{
			try
			{
				Student savedStudent = FindStudentByStudentId(student.Id);

				if (savedStudent == null)
				{
					DataProvider.Instance.Database.Student.Add(student);
				}
				else
				{
					//savedFaculty = (faculty.ShallowCopy() as Faculty);
					Reflection.CopyProperties(student, savedStudent);
				}
				DataProvider.Instance.Database.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}

		}
		public Student GetStudentbyUser(User user)
		{
			return DataProvider.Instance.Database.Student.FirstOrDefault(student => student.IdUsers == user.Id);
		}


	}
}
