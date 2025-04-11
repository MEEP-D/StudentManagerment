using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class DetailScoreItem { 
		public string DisplayName { get; set; }
		public string Percent { get; set; }
		public string Score { get; set; }

	public DetailScoreItem(string displayName, string percent, string score)
	{
		DisplayName = displayName;
		Percent = percent;
		Score = score;
	}
}
}
