using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StudentManagerment.ViewModels
{
	// BaseViewModel giúp thông báo cho giao diện người dùng khi dữ liệu thay đổi
	public class BaseViewModel : INotifyPropertyChanged
	{
		// Sự kiện này được gọi khi một thuộc tính bị thay đổi giá trị
		public event PropertyChangedEventHandler PropertyChanged;

		// Phương thức gọi sự kiện PropertyChanged để báo cho UI cập nhật lại
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			// Nếu có ai đang lắng nghe sự kiện, thì phát đi thông báo tên thuộc tính đã thay đổi
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
