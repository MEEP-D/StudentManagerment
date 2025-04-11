using StudentManagerment.Objects;
using System.Collections.ObjectModel;

namespace StudentManagerment.ViewModels
{
	public class LayoutViewModel : BaseViewModel
	{
		// ViewModel chính đang hiển thị (nội dung ở giữa màn hình)
		private object _contentViewModel;
		public object ContentViewModel
		{
			get => _contentViewModel;
			set
			{
				_contentViewModel = value;
				OnPropertyChanged(); // thông báo UI cập nhật
			}
		}

		// ViewModel của thanh bên phải (nếu có)
		private object _rightSideBar;
		public object RightSideBar
		{
			get => _rightSideBar;
			set
			{
				_rightSideBar = value;
				OnPropertyChanged();
			}
		}

		// Xác định layout này có phải cửa sổ chính hay không
		private bool _isMainWindow;
		public bool IsMainWindow
		{
			get => _isMainWindow;
			set
			{
				_isMainWindow = value;
				OnPropertyChanged();
			}
		}

		// Danh sách các mục điều hướng (menu bên trái)
		private ObservableCollection<NavigationItem> _navigationItems;
		public ObservableCollection<NavigationItem> NavigationItems
		{
			get => _navigationItems;
			set => _navigationItems = value;
		}
	}
}
