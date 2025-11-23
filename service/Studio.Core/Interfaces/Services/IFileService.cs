using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Studio.Core.Interfaces.Services
{
        public interface IFileService
        {
            Task<bool> DeleteFileAsync(string filePath);
            Task<byte[]> GetFileAsync(string filePath);
            string GetFileUrl(string filePath);
        }
    }
