using Newtonsoft.Json.Linq;
using StudentManagement.Utils;
using StudentManagerment.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment.Service
{
	public class ImageUploader
	{
		private static ImageUploader s_instance;

		public static ImageUploader Instance => s_instance ?? (s_instance = new ImageUploader());

		private HttpClient _client;

		private const string UrlUpload = "https://api.imgbb.com/1/upload";
		private const string Token = "56bbead55b86d43ad653ff417501d819";

		public ImageUploader()
		{
			_client = new HttpClient();
		}

		public async Task<string> UploadAsync(string file)
		{
			MultipartFormDataContent form = new MultipartFormDataContent();
			form.Add(new ByteArrayContent(File.ReadAllBytes(file)), "image", VietnameseStringNormalizer.Instance.Normalize(Path.GetFileName(file)));
			form.Add(new StringContent(Token), "key");
			var response = await _client.PostAsync(UrlUpload, form);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				JObject json = JObject.Parse(content);
				return (string)json["data"]["url"];
			}
			return null;
		}
	}
}
