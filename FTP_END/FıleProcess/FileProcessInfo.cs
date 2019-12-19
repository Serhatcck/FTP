using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTP_END.FıleProcess
{
    public class FileProcessInfo : FileProcessInterface
    {
        string fileName;
        FileInfo fileInfo;
        
        
        public FileProcessInfo(string fileName)
        {
            this.fileName = fileName;
        }
        public byte [] GetInfo()
        {

            
            fileInfo = new FileInfo(fileName);

            byte [] byteInfo = File.ReadAllBytes(fileInfo.ToString());
            
            
            return byteInfo.ToArray();
            
        }

       
    }
}
