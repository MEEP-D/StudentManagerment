using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagerment.Models;
using StudentManagerment.ViewModels;

namespace StudentManagerment.Objects
{
	public class ScheduleItem : BaseViewModel
	{
		public Guid Id { get; set; }
		public int Start { get; set; } // Tiết bắt đầu (0-9)
		public int Span { get; set; }  // Số tiết học liên tiếp
		public int Day { get; set; }   // Thứ trong tuần (0: Thứ Hai, ..., 6: Chủ nhật)
		public string SubjectClassCode { get; set; } // Mã lớp học phần
		public string SubjectName { get; set; }      // Tên môn học
		public string Count { get; set; }            // Số lượng SV
		public string StartDate { get; set; }        // Ngày bắt đầu
		public string EndDate { get; set; }          // Ngày kết thúc
		public string TeacherName { get; set; }      // Tên giảng viên
		public bool IsTemp { get; set; }             // Có phải lịch tạm thời?
		public bool IsConflict { get; set; }         // Có trùng lịch không?
		public int Type { get; set; }                // Loại lịch
		public bool IsDetail { get; set; }           // Hiển thị chi tiết?

		public ScheduleItem(SubjectClass a, bool isTemp = false, bool isConflict = false, int type = 0, bool isDetail = true)
		{
			this.Id = a.Id;
			string temp = a.Period.Replace("10", "A");
			this.Span = temp.Length;
			if (temp[0] == 'A')
				this.Start = 9;
			else
				this.Start = Convert.ToInt32(temp[0] - '0') - 1;
			List<string> DaysofWeek = new List<string>() { "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy", "Chủ nhật" };
			Day = (int)a.WeekDay;
			this.SubjectClassCode = a.Code;
			this.SubjectName = a.Subject.DisplayName;
			this.Count = a.NumberOfStudents.ToString();
			this.StartDate = String.Format("{0:dd/MM/yyyy}", a.StartDate);
			this.EndDate = String.Format("{0:dd/MM/yyyy}", a.EndDate);
			if (a.Teacher.Count == 0)
				TeacherName = "Chưa có";
			else
				this.TeacherName = a.Teacher.FirstOrDefault()?.Users?.DisplayName;
			IsTemp = isTemp;
			IsConflict = isConflict;
			Type = type;
			IsDetail = isDetail;
		}
	}
}
