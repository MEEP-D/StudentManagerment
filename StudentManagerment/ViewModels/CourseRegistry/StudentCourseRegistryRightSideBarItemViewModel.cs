﻿using StudentManagerment.Models;
using StudentManagerment.Objects;
using StudentManagerment.Models;
using StudentManagerment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentManagerment.ViewModels.StudentCourseRegistryRightSideBarViewModel;

namespace StudentManagement.ViewModels
{
	public class StudentCourseRegistryRightSideBarItemViewModel : BaseViewModel
	{
		public CourseItem CurrentItem { get => _currentItem; set => _currentItem = value; }
		public string TeacherName { get => _teacherName; set { _teacherName = value; OnPropertyChanged(); } }

		private CourseItem _currentItem;

		private string _teacherName;
		public StudentCourseRegistryRightSideBarItemViewModel()
		{
			CurrentItem = null;
			TeacherName = null;
		}

		public StudentCourseRegistryRightSideBarItemViewModel(CourseItem item)
		{
			CurrentItem = item;
			Teacher teacher = CurrentItem.Teachers.FirstOrDefault();
			TeacherName = (teacher == null) ? null : teacher.Users.DisplayName;
		}
	}
}
