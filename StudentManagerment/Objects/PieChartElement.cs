using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Objects
{
	public class PieChartElement
	{
		public float Percentage { get; set; }     // Phần trăm (ví dụ: 25.5)
		public string Title { get; set; }         // Tiêu đề của phần biểu đồ
		//public Brush ColorBrush { get; set; }     // Màu sắc hiển thị

		//public PieChartElement(float percentage, string title, Brush colorBrush)
		//{
		//	Percentage = percentage;
		//	Title = title;
		//	ColorBrush = colorBrush;
		//}

		public PieChartElement() { }
	}
}
