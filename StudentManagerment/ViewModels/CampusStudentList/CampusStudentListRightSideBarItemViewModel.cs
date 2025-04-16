using StudentManagerment.Objects;
using StudentManagerment.ViewModels.UserInfo;
using StudentManagerment.ViewModels.UserInfo;
using StudentManagerment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.ViewModels
{
	public class CampusStudentListRightSideBarItemViewModel : BaseViewModel
	{
		private ObservableCollection<InfoItemViewModel> _currentStudent;
		public ObservableCollection<InfoItemViewModel> CurrentStudent { get => _currentStudent; set => _currentStudent = value; }

		public CampusStudentListRightSideBarItemViewModel()
		{
			CurrentStudent = null;
		}

		public CampusStudentListRightSideBarItemViewModel(ObservableCollection<InfoItemViewModel> x)
		{
			CurrentStudent = x;
		}
	}
}
