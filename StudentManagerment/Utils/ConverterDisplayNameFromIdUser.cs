﻿using StudentManagement.Services;
using StudentManagerment.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace StudentManagerment.Utils
{
	public class ConverterDisplayNameFromIdUser : MarkupExtension, IValueConverter
	{
		private static ConverterDisplayNameFromIdUser _instance;

		public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return UserServices.Instance.GetDisplayNameById((Guid)value);
		}

		public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new System.NotImplementedException();
		}
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return _instance ?? (_instance = new ConverterDisplayNameFromIdUser());
		}
	}
}
