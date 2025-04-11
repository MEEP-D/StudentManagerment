using StudentManagerment.ViewModels;
using System;

namespace StudentManagerment.Objects
{
	public class FileInfo : BaseViewModel
	{
		public Guid? Id { get; set; }
		public string Name { get; set; }
		public Guid? PublisherId { get; set; }
		public string Publisher { get; set; }
		public string Content { get; set; }
		public DateTime? UploadTime { get; set; }
		public long? Size { get; set; }
		public Guid? FolderId { get; set; }
		public string FolderName { get; set; }
		public Guid? IdSubjectClass { get; set; }

		public FileInfo() { }

		public FileInfo(Guid? id, string name, Guid? publisherId, string publisher, string content, DateTime? uploadTime, long? size, Guid? folderId, string folderName, Guid? idSubjectClass)
		{
			Id = id;
			Name = name;
			PublisherId = publisherId;
			Publisher = publisher;
			Content = content;
			UploadTime = uploadTime;
			Size = size;
			FolderId = folderId;
			FolderName = folderName;
			IdSubjectClass = idSubjectClass;
		}

		public FileInfo(FileInfo file)
		{
			Id = file.Id;
			Name = file.Name;
			PublisherId = file.PublisherId;
			Publisher = file.Publisher;
			Content = file.Content;
			UploadTime = file.UploadTime;
			Size = file.Size;
			FolderId = file.FolderId;
			FolderName = file.FolderName;
			IdSubjectClass = file.IdSubjectClass;
		}
	}
}
