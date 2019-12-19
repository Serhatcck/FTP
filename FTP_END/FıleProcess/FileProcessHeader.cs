using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FTP_END.FıleProcess
{
    public class FileProcessHeader:FileProcessInterface
    {
        string fileName;
        FileInfo fileInfo;
        string fileNameandSize;
        byte[] info;
        

        public FileProcessHeader(string fileName)
        {
            this.fileName = fileName;
            
        }
        
        public byte[] GetInfo()
        {

            fileInfo = new FileInfo(fileName);

            fileNameandSize = "Header*"+fileInfo.Length.ToString() + "*" + fileInfo.Name + "*" ;
            
            info = Encoding.ASCII.GetBytes(fileNameandSize);
            
            return info;
        }


    }
}
