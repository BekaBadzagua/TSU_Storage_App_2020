using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace StorageApp.Helper
{
    public static class FileTools
    {
        public static string UploadFile(IFormFile file, IHostingEnvironment env)
        {
            string path = "";
            try
            {
                if (file != null && file.Length > 0)
                {
                    var name = Path.GetFileNameWithoutExtension(file.FileName);
                    var ext = Path.GetExtension(file.FileName);
                    var fileIndex = GenerateFileIndex();
                    CheckAndCreateDirectory($"Uploads/{fileIndex}", env);
                    name = FileVersionCheckAndUpdate(name, $"Uploads/{fileIndex}", ext, env);

                    var uploadPath = Path.Combine(env.WebRootPath, "Uploads", fileIndex + name + ext);
                    path = Path.Combine("/Uploads", fileIndex + name + ext);
                    using (var stream = File.Create(uploadPath))
                    {
                        file.CopyTo(stream);
                    }
                }
                return path;

            }
            catch (Exception)
            {
                return path;
            }
        }

        public static void DeleteFile(string path, IHostingEnvironment env)
        {
            if (File.Exists(Path.Combine(env.WebRootPath, path)))
                File.Delete(Path.Combine(env.WebRootPath, path));
        }

        private static string GenerateFileIndex()
        {
            return DateTime.Now.Year + "/" + DateTime.Now.Month + "/";
        }
        private static void CheckAndCreateDirectory(string path, IHostingEnvironment env)
        {
            bool exist = Directory.Exists(Path.Combine(env.WebRootPath, path));
            if (!exist)
                Directory.CreateDirectory(Path.Combine(env.WebRootPath, path));
        }
        private static string FileVersionCheckAndUpdate(string fileName, string path, string ext, IHostingEnvironment env)
        {
            int count = 1;
            string newFileName = fileName;
            string newPath = Path.Combine(path, fileName + ext);
            while (File.Exists(Path.Combine(env.WebRootPath, newPath)))
            {
                newFileName = string.Format("{0}({1} )", fileName, count++);
                newPath = Path.Combine(path, newFileName, ext);
            }
            return newFileName;
        }
    }
}
