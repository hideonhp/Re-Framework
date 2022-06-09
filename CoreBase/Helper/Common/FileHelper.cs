using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_Framework.CoreBase.Helper.Common
{
    public static class FileHelper
    {
        public static Task<string> GetFilePath(string fileName)
        {
            string currentDirectory = System.IO.Path.GetFullPath(@"..\..\");
            string realPath = currentDirectory + "CoreBase\\Resources\\" + fileName;

            return Task.FromResult(realPath);
        }
        public static string GetFilePathSync(string fileName)
        {
            string currentDirectory = System.IO.Path.GetFullPath(@"..\..\");
            string realPath = currentDirectory + "CoreBase\\Resources\\" + fileName;

            return realPath;
        }
    }
}
