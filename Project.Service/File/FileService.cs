using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.File
{
    public class FileService : IFileService
    {
        private readonly IHostingEnvironment environment;
        public FileService(IHostingEnvironment environment)
        {
            this.environment = environment;
        }

        public void DeleteFile(string filename)
        {
            var filePath = Path.Combine(environment.ContentRootPath, "wwwroot", "img", filename);
            System.IO.File.Delete(filePath);
        }

        public string UpLoadFile(IFormFile file)
        {
            //var special=Guid.NewGuid().ToString();
            var fileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName())
                + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(environment.ContentRootPath, "wwwroot", "img", fileName);
            using var filestream = new FileStream(filePath, FileMode.Create);
             file.CopyToAsync(filestream);
            return fileName;
        }

        public async Task<bool> UploadFile1(IFormFile file)
        {
            string path = "";
            try
            {
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "wwwroot", "img"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}
