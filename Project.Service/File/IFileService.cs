using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Service.File
{
    public interface IFileService
    {
        string UpLoadFile(IFormFile file);
        void DeleteFile(string filename);
        Task<bool> UploadFile1(IFormFile file);
    }
}
