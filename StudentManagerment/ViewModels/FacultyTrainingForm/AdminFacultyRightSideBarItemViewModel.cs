﻿using StudentManagerment.Objects;
using StudentManagerment.Objects;
using StudentManagerment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentManagerment.ViewModels.AdminFacultyTrainingFormViewModel;

namespace StudentManagerment.ViewModels
{
	public class AdminFacultyRightSideBarItemViewModel : BaseViewModel
	{
		public FacultyCard CurrentCard { get => _currentCard; set => _currentCard = value; }
		private FacultyCard _currentCard;

		public AdminFacultyRightSideBarItemViewModel()
		{
			CurrentCard = null;
		}

		public AdminFacultyRightSideBarItemViewModel(FacultyCard card)
		{
			CurrentCard = card;
		}
	}
}
