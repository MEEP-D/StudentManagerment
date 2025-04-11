using StudentManagerment.Models;
using StudentManagerment.Service;
using StudentManagerment.Services;
using StudentManagerment.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class UserCard : BaseObjectWithBaseViewModel, IBaseCard
	{
		// Các thuộc tính chính
		public Guid? ID { get; set; }
		public string DisplayName { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public string Faculty { get; set; }
		public string Role { get; set; }
		public int STT { get; set; }
		public string Training { get; set; }
		public bool IsSelected { get; set; }

		// Constructor mặc định
		public UserCard() { }

		// Constructor khởi tạo đầy đủ
		public UserCard(string role, string name, Guid? id, string email, string gender, string faculty, string training)
		{
			ID = id;
			DisplayName = name;
			Email = email;
			Gender = gender;
			Faculty = faculty;
			Role = role;
			Training = training;
		}

		// Constructor từ đối tượng Student
		public UserCard(Student student)
		{
			ID = student.IdUsers;
			DisplayName = UserServices.Instance.GetDisplayNameById(ID.Value);
			Role = "Sinh viên";
		}

		// Constructor từ đối tượng Teacher
		public UserCard(Teacher teacher)
		{
			ID = teacher.IdUsers;
			DisplayName = UserServices.Instance.GetDisplayNameById(ID.Value);
			Role = "Giáo viên";
		}

		// Constructor từ đối tượng Admin
		public UserCard(Admin admin)
		{
			ID = admin.IdUsers;
			DisplayName = UserServices.Instance.GetDisplayNameById(ID.Value);
			Role = "Admin";
		}
	}
}
