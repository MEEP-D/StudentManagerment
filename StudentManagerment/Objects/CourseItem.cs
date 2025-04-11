//using StudentManagement.Services;
//using StudentManagerment.Models;
//using System;
//using System.Collections.ObjectModel;
//using StudentManagement.Models;
//using System.Linq;
//using System.Runtime.InteropServices.ComTypes;

//namespace StudentManagement.Objects
//{
//	public class CourseItem : Models.SubjectClass
//	{
//		private bool _isSelected;
//		public bool IsSelected
//		{
//			get => _isSelected;
//			set
//			{
//				// Nếu có xung đột hoặc không hợp lệ thì không cho chọn
//				if (value && (IsConflict || !IsValidSubject))
//					_isSelected = false;
//				else
//					_isSelected = value;

//				OnPropertyChanged();
//			}
//		}

//		private bool _isConflict;
//		public bool IsConflict
//		{
//			get => _isConflict;
//			set { _isConflict = value; OnPropertyChanged(); }
//		}

//		private bool _isValidSubject;
//		public bool IsValidSubject
//		{
//			get => _isValidSubject;
//			set { _isValidSubject = value; OnPropertyChanged(); }
//		}

//		private Teacher _mainTeacher;
//		public Teacher MainTeacher
//		{
//			get => _mainTeacher;
//			set { _mainTeacher = value; OnPropertyChanged(); }
//		}

//		// Constructor: tạo CourseItem từ SubjectClass
//		public CourseItem(SubjectClass subject, bool isSelected = false, bool isConflict = false, bool isValidSubject = false)
//		{
//			// Copy dữ liệu từ SubjectClass
//			Id = subject.Id;
//			Teachers = subject.Teachers;
//			Semester = subject.Semester;
//			IdSemester = subject.IdSemester;
//			Subject = subject.Subject;
//			IdSubject = subject.IdSubject;
//			StartDate = subject.StartDate;
//			EndDate = subject.EndDate;
//			Period = subject.Period;
//			WeekDay = subject.WeekDay;
//			Code = subject.Code;
//			TrainingForm = subject.TrainingForm;
//			IdTrainingForm = subject.IdTrainingForm;
//			NumberOfStudents = subject.NumberOfStudents;
//			MaxNumberOfStudents = subject.MaxNumberOfStudents;
//			IdThumbnail = subject.IdThumbnail;
//			DatabaseImageTable = subject.DatabaseImageTable;

//			IsSelected = isSelected;
//			IsConflict = isConflict;
//			IsValidSubject = isValidSubject;
//			MainTeacher = Teachers.FirstOrDefault();
//		}

//		// Chuyển CourseItem thành SubjectClass
//		public SubjectClass ToSubjectClass()
//		{
//			var result = new SubjectClass
//			{
//				Id = Id,
//				Teachers = Teachers,
//				Semester = Semester,
//				Subject = Subject,
//				StartDate = StartDate,
//				EndDate = EndDate,
//				Period = Period,
//				WeekDay = WeekDay,
//				Code = Code,
//				TrainingForm = TrainingForm,
//				NumberOfStudents = NumberOfStudents,
//				MaxNumberOfStudents = MaxNumberOfStudents,
//				DatabaseImageTable = DatabaseImageTable
//			};
//			SubjectClassServices.Instance.UpdateIds(result);
//			return result;
//		}

//		// Tạo danh sách CourseItem từ danh sách SubjectClass
//		public static ObservableCollection<CourseItem> FromSubjectList(ObservableCollection<SubjectClass> subjects)
//		{
//			var result = new ObservableCollection<CourseItem>();
//			foreach (var subject in subjects)
//				result.Add(new CourseItem(subject));
//			return result;
//		}

//		// Chuyển danh sách CourseItem thành SubjectClass
//		public static ObservableCollection<SubjectClass> ToSubjectList(ObservableCollection<CourseItem> courses)
//		{
//			var result = new ObservableCollection<SubjectClass>();
//			foreach (var course in courses)
//				result.Add(course.ToSubjectClass());
//			return result;
//		}

//		// Kiểm tra có trùng tiết học không
//		public static bool HasConflict(ObservableCollection<CourseItem> courseList, CourseItem newCourse)
//		{
//			foreach (var course in courseList)
//			{
//				if (course.WeekDay == newCourse.WeekDay)
//				{
//					foreach (var period in course.Period)
//					{
//						if (newCourse.Period.Contains(period))
//							return true;
//					}
//				}
//			}
//			return false;
//		}

//		// Kiểm tra đã đăng ký cùng môn chưa
//		public static bool IsSameSubject(ObservableCollection<CourseItem> courseList, CourseItem newCourse)
//		{
//			return courseList.Any(c => c.Subject.Id == newCourse.Subject.Id);
//		}

//		// So sánh hai lớp học có giống nhau không
//		public bool IsSameAs(SubjectClass other)
//		{
//			return Teachers.FirstOrDefault() == other.Teachers.FirstOrDefault()
//			&& Semester == other.Semester
//				&& Subject == other.Subject
//				&& StartDate?.Date == other.StartDate?.Date
//				&& EndDate?.Date == other.EndDate?.Date
//				&& Period == other.Period
//				&& WeekDay == other.WeekDay
//				&& Code == other.Code
//				&& TrainingForm == other.TrainingForm
//				&& MaxNumberOfStudents == other.MaxNumberOfStudents
//				&& IdThumbnail == other.IdThumbnail
//				&& DatabaseImageTable == other.DatabaseImageTable;
//		}
//	}
//}
