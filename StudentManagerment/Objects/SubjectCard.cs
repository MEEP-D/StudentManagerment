using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class SubjectCard
	{
		public Guid Id { get; set; }
		public string DisplayName { get; set; }
		public int? Credit { get; set; }
		public string Code { get; set; }
		public string Describe { get; set; }
		public bool IsDeleted { get; set; }

		public SubjectCard()
		{
			Id = Guid.NewGuid();
		}

		public SubjectCard(Guid id, string displayName, int? credit, string code, string describe = "Chưa có mô tả", bool isDeleted = false)
		{
			Id = id;
			DisplayName = displayName;
			Credit = credit;
			Code = code;
			Describe = describe;
			IsDeleted = isDeleted;
		}
	}
}
