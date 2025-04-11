using System;
using System.Reflection;

namespace StudentManagerment.Objects
{
	// Giao diện chung cho các thẻ (card)
	public interface IBaseCard
	{
	}

	// Hàm mở rộng cho IBaseCard
	public static class BaseCardExtensions
	{
		/// <summary>
		/// Sao chép giá trị các thuộc tính từ anotherCard sang card
		/// </summary>
		public static void CopyCardInfo(this IBaseCard card, IBaseCard anotherCard)
		{
			if (card == null || anotherCard == null) return;

			var properties = card.GetType().GetProperties();

			foreach (PropertyInfo prop in properties)
			{
				if (prop.CanRead && prop.CanWrite)
				{
					var value = prop.GetValue(anotherCard);
					prop.SetValue(card, value);
				}
			}
		}
	}
}
