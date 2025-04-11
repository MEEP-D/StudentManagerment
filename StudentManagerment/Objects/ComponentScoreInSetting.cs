using System;

namespace StudentManagement.Objects
{
	public class ComponentScoreInSetting
	{
		public Guid Id { get; set; }                    // ID của thành phần điểm
		public Guid? IdSubjectClass { get; set; }       // ID của lớp học phần (có thể null)
		public string DisplayName { get; set; }         // Tên hiển thị (ví dụ: "Giữa kỳ", "Cuối kỳ")
		public double? Percent { get; set; }            // Phần trăm điểm (ví dụ: 40%, 60%)
	}
}
