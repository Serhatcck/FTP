using FTP_END.FıleProcess;

public class FileProcessCreater
{
    public enum SecimType
    {
        GetInfo,
        GetHeader,
    }

    public FileProcessInterface Secim(SecimType secim, string fileName)
    {
        if (secim == SecimType.GetHeader)
        {
            return new FileProcessHeader(fileName);

        }
        else if (secim == SecimType.GetInfo)
        {
            return new FileProcessInfo(fileName);
        }

        return null;
    }
}