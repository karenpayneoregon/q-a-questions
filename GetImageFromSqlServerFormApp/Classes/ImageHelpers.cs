using System.Drawing;

namespace GetImageFromSqlServerFormApp.Classes
{
    public class ImageHelpers
    {
        public static Image ByteArrayToImage(byte[] contents)
        {
            var converter = new ImageConverter();
            var image = (Image)converter.ConvertFrom(contents);

            return image;
        }

        public static byte[] ImageToByte(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}
