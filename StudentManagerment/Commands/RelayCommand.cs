using System;
using System.Windows.Input;

namespace StudentManagement.Commands
{
	// RelayCommand giúp bạn gán logic cho các nút bấm trong giao diện (WPF)
	public class RelayCommand<T> : ICommand
	{
		// Hàm để thực hiện khi người dùng bấm nút
		private readonly Action<T> _execute;

		// Hàm để kiểm tra có cho phép bấm nút không
		private readonly Predicate<T> _canExecute;

		// Hàm khởi tạo: nhận 2 tham số là điều kiện và hành động
		public RelayCommand(Predicate<T> canExecute, Action<T> execute)
		{
			_canExecute = canExecute;
			_execute = execute ?? throw new ArgumentNullException(nameof(execute));
		}

		// Hàm kiểm tra xem có thể thực hiện lệnh không
		public bool CanExecute(object parameter)
		{
			if (_canExecute == null)
				return true;

			return _canExecute((T)parameter);
		}

		// Hàm thực hiện lệnh
		public void Execute(object parameter)
		{
			_execute((T)parameter);
		}

		// Sự kiện giúp cập nhật lại giao diện (Enable/Disable nút)
		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
	}
}
