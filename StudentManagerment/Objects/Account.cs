using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class Account
	{
		public string UserName { get; set; }
		public string PassWord { get; set; }

		public Account(string userName, string passWord)
		{
			UserName = userName;
			PassWord = passWord;
		}
	}
}
