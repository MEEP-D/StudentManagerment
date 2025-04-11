using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class ScoreDataGrid : BaseObjectWithBaseViewModel, IBaseCard
	{
		public int STT { get; set; }
		public Guid IdSubjectClass { get; set; }
		public string IDSubject { get; set; }        // Mã môn học
		public string Subject { get; set; }          // Tên môn học
		public string Credit { get; set; }           // Số tín chỉ
		public string NameTeacher { get; set; }      // Tên giảng viên
		public string Status { get; set; }           // Trạng thái (ví dụ: Hoàn thành)
		public string Semester { get; set; }         // Học kỳ

		public ScoreDataGrid(Guid id, string idSubject, string subject, string credit, string nameTeacher)
		{
			IdSubjectClass = id;
			IDSubject = idSubject;
			Subject = subject;
			Credit = credit;
			NameTeacher = nameTeacher;
			Status = "Hoàn thành"; // Mặc định
		}
	}
}
