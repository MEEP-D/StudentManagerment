using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using Application = System.Windows.Application;


namespace StudentManagerment
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>7
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		public static NotifyIcon Notify = new NotifyIcon()
		{
			Visible = true,
			Text = "Stuman - Hệ thống quản lý đào tạo",
			Icon = new System.Drawing.Icon(Application.GetResourceStream(new Uri("pack://application:,,,/Iconka.ico")).Stream),
		};
		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Notify.Dispose();
		}
	}
}
