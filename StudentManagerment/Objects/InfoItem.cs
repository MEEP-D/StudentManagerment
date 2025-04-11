using System;
using System.Collections.ObjectModel;

namespace StudentManagerment.Objects
{
	public class InfoItem
	{
		public Guid Id { get; set; }
		public string LabelName { get; set; }     // Tên hiển thị (vd: "Họ tên")
		public int Type { get; set; }             // Loại control (vd: 0 - TextBox, 1 - ComboBox)
		public ObservableCollection<string> ItemSource { get; set; }  // Dữ liệu cho ComboBox
		public object Value { get; set; }         // Giá trị được nhập hoặc chọn
		public bool IsEnable { get; set; }        // Có cho chỉnh sửa không

		public InfoItem()
		{
			Id = Guid.NewGuid();
			IsEnable = true;
		}

		public InfoItem(Guid id, string labelName, int type, ObservableCollection<string> itemSource, object value, bool isEnable)
		{
			Id = id;
			LabelName = labelName;
			Type = type;
			ItemSource = itemSource;
			Value = value;
			IsEnable = isEnable;
		}
	}
}
