using StudentManagerment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace StudentManagerment.Services
{
	public class UserServices
	{
		// Biến lưu trữ duy nhất một instance của UserServices
		private static UserServices _instance;

		// Thuộc tính để truy cập instance từ bên ngoài
		public static UserServices Instance
		{
			get
			{
				// Nếu chưa có instance thì tạo mới
				if (_instance == null)
				{
					_instance = new UserServices();
				}
				return _instance;
			}
		}

		// Constructor riêng tư để ngăn việc tạo instance từ bên ngoài
		private UserServices() { }

		// Lấy thông tin người dùng đầu tiên trong database
		public Users GetFirstUser()
		{
			return DataProvider.Instance.Database.Users.FirstOrDefault();
		}

		// Tìm người dùng bằng ID
		public Users GetUserById(Guid id)
		{
			return DataProvider.Instance.Database.Users.FirstOrDefault(u => u.Id == id);
		}

		// Tìm người dùng bằng tên đăng nhập
		public Users FindUserByUsername(string username)
		{
			return DataProvider.Instance.Database.Users.FirstOrDefault(u => u.Username == username);
		}

		//  Lấy tên hiển thị của người dùng theo ID
		public string GetDisplayName(Guid userId)
		{
			Users user = GetUserById(userId);
			return user?.DisplayName; // Trả về null nếu không tìm thấy user
		}
		public string GetDisplayNameById(Guid id)
		{
			var user = GetUserById(id);
			return user.DisplayName;
		}

		// Lấy ảnh đại diện của người dùng theo ID
		public string GetUserAvatar(Guid userId)
		{
			Users user = GetUserById(userId);
			return user?.DatabaseImageTable?.Image;
		}

		// Tìm người dùng bằng email
		public List<Users> FindUsersByEmail(string email)
		{
			return DataProvider.Instance.Database.Users
				.Where(u => u.Email == email)
				.ToList();
		}

		//  Kiểm tra xem email đã được sử dụng chưa
		public bool IsEmailUsed(string email)
		{
			return DataProvider.Instance.Database.Users.Any(u => u.Email == email);
		}

		// Kiểm tra xem người dùng có phải admin không
		public bool IsAdmin(Guid userId)
		{
			Users user = GetUserById(userId);
			return user?.UserRole?.Role?.Contains("Admin") ?? false;
		}

		//  Lưu thông tin người dùng vào database
		public bool SaveUser(Users user)
		{
			try
			{
				DataProvider.Instance.Database.Users.AddOrUpdate(user);
				DataProvider.Instance.Database.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		// Thay đổi mật khẩu cho người dùng hiện tại
		public bool ChangePassword(string newPassword, Users user)
		{
			if (user == null) return false;

			user.Password = (newPassword);
			DataProvider.Instance.Database.SaveChanges();
			return true;
		}

		//  Kiểm tra đăng nhập
		public bool ValidateLogin(string username, string password)
		{
			// Mã hóa mật khẩu nhập vào để so sánh
			string encryptedPassword = (password);

			return DataProvider.Instance.Database.Users
				.Any(u => u.Username == username && u.Password == encryptedPassword);
		}
	}
}