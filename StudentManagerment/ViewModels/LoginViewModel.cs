using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Input;
using System.Windows.Threading;
using System.Threading.Tasks;

namespace StudentManagerment.ViewModels
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		// ===== Properties ===== //
		public string Username { get; set; }
		public string Password { get; set; }
		public string Gmail { get; set; }
		public string OTP { get; set; }
		public string OTPInput { get; set; }
		public string NewPassword { get; set; }
		public string ReNewPassword { get; set; }

		private string _timeCountDown;
		public string TimeCountDown
		{
			get => _timeCountDown;
			set { _timeCountDown = value; OnPropertyChanged(nameof(TimeCountDown)); }
		}

		public bool IsCodeSent { get; set; }

		// ===== Commands ===== //
		public ICommand GetOTPCommand { get; set; }
		public ICommand ConfirmCommand { get; set; }

		// ===== Constructor ===== //
		public LoginViewModel()
		{
			GetOTPCommand = new RelayCommand(async (obj) => await SendOTPAsync());
			ConfirmCommand = new RelayCommand((obj) => ConfirmOTP());
		}

		// ===== OTP Generation & Email ===== //
		private async Task SendOTPAsync()
		{
			if (string.IsNullOrWhiteSpace(Gmail) || !IsValidEmail(Gmail))
			{
				Show("Gmail không hợp lệ!");
				return;
			}

			OTP = new Random().Next(100000, 999999).ToString(); // Random 6 số

			try
			{
				var body = $"<h2>Mã OTP của bạn là: <b>{OTP}</b></h2>";
				var message = new MailMessage("ducduong.tektra@gmail.com", Gmail)
				{
					Subject = "Mã OTP - Khôi phục mật khẩu",
					Body = body,
					IsBodyHtml = true
				};

				var smtp = new SmtpClient("smtp.gmail.com", 587)
				{
					Credentials = new NetworkCredential("ducduong.tektra@gmail.com", "MẬT_KHẨU_ỨNG_DỤNG_GMAIL"),
					EnableSsl = true
				};

				await smtp.SendMailAsync(message);
				StartCountdown();
				Show("Gửi mã OTP thành công!");
			}
			catch
			{
				Show("Không thể gửi mã OTP. Kiểm tra kết nối hoặc Gmail.");
			}
		}

		// ===== Countdown Timer ===== //
		private void StartCountdown()
		{
			IsCodeSent = true;
			int seconds = 60;
			DispatcherTimer timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
			timer.Tick += (s, e) =>
			{
				seconds--;
				TimeCountDown = $"{seconds} giây";
				if (seconds == 0)
				{
					timer.Stop();
					TimeCountDown = null;
				}
			};
			timer.Start();
		}

		// ===== OTP Confirmation ===== //
		public void ConfirmOTP()
		{
			if (OTPInput != OTP)
			{
				Show("Mã OTP không chính xác!");
				return;
			}

			if (string.IsNullOrWhiteSpace(NewPassword) || NewPassword != ReNewPassword)
			{
				Show("Mật khẩu không khớp!");
				return;
			}

			// Cập nhật mật khẩu (giả lập)
			Show("Đặt lại mật khẩu thành công!");
			Clear();
		}

		// ===== Helpers ===== //
		public bool IsValidEmail(string email)
		{
			try { return new MailAddress(email).Address == email; }
			catch { return false; }
		}

		public void Show(string message)
		{
			System.Windows.MessageBox.Show(message);
		}

		public void Clear()
		{
			OTP = OTPInput = NewPassword = ReNewPassword = Gmail = Password = Username = null;
			TimeCountDown = null;
		}

		// ===== INotifyPropertyChanged ===== //
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string name) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	// ===== Simple RelayCommand class ===== //
	public class RelayCommand : ICommand
	{
		private readonly Action<object> _execute;
		private readonly Predicate<object> _canExecute;
		public event EventHandler CanExecuteChanged;

		public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
		{
			_execute = execute; _canExecute = canExecute;
		}

		public bool CanExecute(object parameter) => _canExecute == null || _canExecute(parameter);
		public void Execute(object parameter) => _execute(parameter);
	}
}
