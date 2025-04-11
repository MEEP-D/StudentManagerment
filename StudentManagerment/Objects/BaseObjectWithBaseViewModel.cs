using StudentManagerment.ViewModels;
using System.Reflection;

namespace StudentManagerment.Objects
{
	/// <summary>
	/// Lớp cơ sở mở rộng từ BaseViewModel để gọi OnPropertyChanged cho tất cả thuộc tính
	/// </summary>
	public class BaseObjectWithBaseViewModel : BaseViewModel
	{
		/// <summary>
		/// Gọi OnPropertyChanged cho tất cả thuộc tính hiện có trong class này
		/// </summary>
		public void RunOnPropertyChanged()
		{
			var properties = GetType().GetProperties();

			foreach (PropertyInfo prop in properties)
			{
				// Kiểm tra nếu property có thể đọc
				if (prop.CanRead)
				{
					OnPropertyChanged(prop.Name);
				}
			}
		}
	}
}
