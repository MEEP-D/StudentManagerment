using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentManagerment.Models
{
	// Lớp quản lý kết nối database dùng mẫu Singleton
	public class DataProvider
	{
		// Biến static lưu trữ thể hiện duy nhất
		private static DataProvider instance;


		//  Thuộc tính để truy cập từ bên ngoài
		public static DataProvider Instance
		{
			get
			{
				// Nếu chưa có instance thì tạo mới
				if (instance == null)
					instance = new DataProvider();
				return instance;
			}
			private set { }
		}
		// Hàm khởi tạo private để ngăn tạo instance từ bên ngoài
		private DataProvider()
		{
			// Initialize the database context or any other resources here
			// For example:
			// this.context = new YourDbContext();
			//Khởi tạo kết nối
			Database = new ManagermentEnglishEntities1();
		}
		//  Thuộc tính chứa kết nối database
		public ManagermentEnglishEntities1 Database { get; set; }
	}
}
