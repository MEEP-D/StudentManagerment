using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace StudentManagerment.Utils
{
	// Đánh dấu đây là converter chuyển đổi dữ liệu từ kiểu này sang kiểu khác
	[ValueConversion(typeof(string), typeof(string))]
	public class RatioConverter : MarkupExtension, IValueConverter
	{
		// Dùng singleton (tạo 1 instance duy nhất)
		public static RatioConverter _instance;

		public RatioConverter() { }

		// Phương thức Convert: chuyển đổi giá trị đầu vào (value) theo tỷ lệ (parameter)
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// Chuyển đổi value (ví dụ: chiều cao màn hình) sang số
			double inputValue = System.Convert.ToDouble(value);

			// Chuyển đổi parameter (ví dụ: '0.84') sang số với định dạng văn hóa quốc tế (sử dụng dấu chấm)
			double ratio = System.Convert.ToDouble(parameter, CultureInfo.InvariantCulture);

			// Nhân với 90.0 / 84.0 để scale lại kích thước cho khớp giao diện thiết kế (nếu cần)
			double result = inputValue * ratio * 90.0 / 84.0;

			// Trả về kết quả dưới dạng chuỗi (không có phần thập phân)
			return result.ToString("G0", CultureInfo.InvariantCulture);
		}

		// Phương thức ConvertBack không dùng (1 chiều)
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException(); // Không hỗ trợ chuyển ngược lại
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return _instance ?? (_instance = new RatioConverter());
		}
	}
}

		
