using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class StudentDetailScore
	{
		// ID của bảng điểm chi tiết
		public Guid Id { get; set; }

		// ID của sinh viên
		public Guid? IdStudent { get; set; }

		// ID của điểm thành phần (VD: giữa kỳ, cuối kỳ)
		public Guid? IdComponentScore { get; set; }

		// ID của lớp học phần
		public Guid? IdSubjectClass { get; set; }

		// Điểm số cụ thể
		public double? Score { get; set; }

		// Tên điểm thành phần (VD: "Điểm giữa kỳ")
		public string DisplayName { get; set; }

		// Tỷ lệ phần trăm điểm (VD: 30% cho giữa kỳ)
		public double? Percent { get; set; }
	}
}
