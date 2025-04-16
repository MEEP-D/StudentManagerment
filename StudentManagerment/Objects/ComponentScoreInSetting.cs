using StudentManagerment.ViewModels;
using System;

namespace StudentManagerment.Objects
{
	public class ComponentScoreInSetting : BaseViewModel
	{
		public Guid Id { get; set; }                    // ID của thành phần điểm
		public Guid? IdSubjectClass { get; set; }
		private string _displayName;
		private double? _percent;
		// ID của lớp học phần (có thể null)
		public string DisplayName { get => _displayName; set { _displayName = value; OnPropertyChanged(); } }         // Tên hiển thị (ví dụ: "Giữa kỳ", "Cuối kỳ")
		public double? Percent { get => _percent; set { _percent = value; OnPropertyChanged(); } }            // Phần trăm điểm (ví dụ: 40%, 60%)
	}
}
