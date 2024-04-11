namespace LibraryQR.Logic;

public class Book
{
    private string PicturePath { get; set; }
    private string QRPath { get; set; }

    public Book(string picturePath, string qrPath)
    {
        PicturePath = picturePath;
        QRPath = qrPath;
    }
}