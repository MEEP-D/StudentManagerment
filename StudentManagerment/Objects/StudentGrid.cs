using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class StudentGrid
	{
		public Guid Id { get; set; }
		public bool IsSelected { get; set; }
		public string DisplayName { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
		public string Faculty { get; set; }
		public string Status { get; set; }
		public int Number { get; set; }
		public string TrainingForm { get; set; }
	}
}

