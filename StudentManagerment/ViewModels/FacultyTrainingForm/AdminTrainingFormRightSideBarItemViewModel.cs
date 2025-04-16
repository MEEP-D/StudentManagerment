using StudentManagerment.Objects;
using StudentManagerment.Objects;
using StudentManagerment.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.ViewModels
{
	public class AdminTrainingFormRightSideBarItemViewModel : BaseViewModel
	{
		public TrainingFormCard CurrentCard { get => _currentCard; set => _currentCard = value; }
		private TrainingFormCard _currentCard;

		public AdminTrainingFormRightSideBarItemViewModel()
		{
			CurrentCard = null;
		}

		public AdminTrainingFormRightSideBarItemViewModel(TrainingFormCard card)
		{
			CurrentCard = card;
		}
	}
}
