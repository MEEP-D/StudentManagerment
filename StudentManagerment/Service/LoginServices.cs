
using StudentManagerment.Models;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace StudentManagement.Services
{
	public class LoginServices
	{
		// Sự kiện khi đăng nhập thành công sẽ cập nhật người dùng hiện tại
		public class LoginEvent : EventArgs
		{
			public Users User { get; set; }

			public LoginEvent(Users user)
			{
				User = user;
			}
		}

		// Đăng ký sự kiện cập nhật người dùng hiện tại
		private static event EventHandler<LoginEvent> _updateCurrentUser;
		public static event EventHandler<LoginEvent> UpdateCurrentUser
		{
			add => _updateCurrentUser += value;
			remove => _updateCurrentUser -= value;
		}

		private static LoginServices instance;
		public static LoginServices Instance => instance ?? (instance = new LoginServices());

		public static Users CurrentUser { get; set; }

		public static string RememberedAccountFilePath = "D:\\accountMan.txt";

		public int CountPeriodTodayOfUser;

		private ManagermentEnglishEntities1 db = DataProvider.Instance.Database;

		private LoginServices() { }

		/// <summary>
		/// Kiểm tra tài khoản và mật khẩu có đúng không
		/// </summary>
		//public bool IsUserAuthentic(string username, string password)
		//{
		//	string encryptedPassword = SHA256Cryptography.Instance.EncryptString(password);

		//	return db.Users.Any(user => user.Username == username && user.Password == encryptedPassword);
		//}

		/// <summary>
		/// Thực hiện đăng nhập và gán người dùng hiện tại
		/// </summary>
		//public void Login(string username)
		//{
		//	Users user = UserServices.Instance.FindUserByUsername(username);
		//	CurrentUser = user;

		//	_updateCurrentUser?.Invoke(this, new LoginEvent(user));
		//}

		/// <summary>
		/// Mã hóa Base64
		/// </summary>
		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		/// <summary>
		/// Mã hóa bằng MD5
		/// </summary>
		public static string MD5Hash(string input)
		{
			using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
			{
				byte[] hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
				StringBuilder sb = new StringBuilder();
				foreach (byte b in hashBytes)
					sb.Append(b.ToString("x2"));
				return sb.ToString();
			}
		}

		/// <summary>
		/// Mã hóa AES với chuỗi khóa truyền vào
		/// </summary>
		public static string Encrypt(string input, string hash)
		{
			byte[] data = Encoding.UTF8.GetBytes(input);
			byte[] key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(hash));
			byte[] iv = key;

			using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider
			{
				Key = key,
				IV = iv,
				Mode = CipherMode.CFB,
				Padding = PaddingMode.PKCS7
			})
			{
				ICryptoTransform encryptor = aes.CreateEncryptor();
				byte[] encrypted = encryptor.TransformFinalBlock(data, 0, data.Length);
				return Convert.ToBase64String(encrypted);
			}
		}

		/// <summary>
		/// Giải mã AES với chuỗi khóa truyền vào
		/// </summary>
		public static string Decrypt(string input, string hash)
		{
			byte[] data = Convert.FromBase64String(input);
			byte[] key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(hash));
			byte[] iv = key;

			using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider
			{
				Key = key,
				IV = iv,
				Mode = CipherMode.CFB,
				Padding = PaddingMode.PKCS7
			})
			{
				ICryptoTransform decryptor = aes.CreateDecryptor();
				byte[] decrypted = decryptor.TransformFinalBlock(data, 0, data.Length);
				return Encoding.UTF8.GetString(decrypted);
			}
		}
	}
}
