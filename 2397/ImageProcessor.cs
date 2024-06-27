using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

/// <summary> Represents the possible actions on images. </summary>
static class ImageProcessor
{
    /// <summary>Inverts the colors on the images contained in the array <paramref name="filenames"/>.</summary>
    /// <param name="filenames">Array of path to the images.</param>
    public static void Inverse(string[] filenames) => Parallel.ForEach(filenames, InvertColors);

    /* Inverts the colors of the image. */
    private static void InvertColors(string filename)
    {
        const string basePath = "images/";
        string baseName = Path.GetFileNameWithoutExtension(filename);
        string extension = Path.GetExtension(filename);

        using (Bitmap image = new Bitmap(Path.Combine(basePath, baseName + extension)))
        {
            int height = image.Height;
            BitmapData imageData = image.LockBits(new Rectangle(0, 0, image.Width, height), ImageLockMode.ReadWrite, image.PixelFormat);
            int stride = imageData.Stride;

            byte[] pixels = new byte[stride * height];
            int imageLength = pixels.Length;

            /* Copies all the integers from the image to the new array to modify them */
            Marshal.Copy(imageData.Scan0, pixels, 0, imageLength);

            /* Inverts the pixels */
            for (int i = 0; i < imageLength; i += 4)
            {
                pixels[i] ^= 0xFF;
                pixels[i + 1] ^= 0xFF;
                pixels[i + 2] ^= 0xFF;
            }

            /* Returns all the new integers to the bitmap to create the new image */
            Marshal.Copy(pixels, 0, imageData.Scan0, imageLength);
            image.UnlockBits(imageData);

            image.Save($"{baseName}_inverse{extension}");
        }
    }

    /// <summary>Converts a set of images to grayscale.</summary>
    /// <param name="filenames">Array of path to the images to converts.</param>
    public static void Grayscale(string[] filenames) => Parallel.ForEach(filenames, GrayscaleConvert);

    private static void GrayscaleConvert(string filename)
    {
        const string basePath = "images/";
        string baseName = Path.GetFileNameWithoutExtension(filename);
        string extension = Path.GetExtension(filename);

        using (Bitmap originalImage = new Bitmap(Path.Combine(basePath, baseName + extension)))
        {
            int width = originalImage.Width;
            int height = originalImage.Height;
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(grayscaleImage))
            {
                ColorMatrix grayscaleCoefficient = new ColorMatrix(
                new float[][]
                {
                    new float[] {.3f, .3f, .3f, 0, 0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                });
                using (ImageAttributes attributes = new ImageAttributes())
                {
                    attributes.SetColorMatrix(grayscaleCoefficient);
                    graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                    0, 0, originalImage.Width, originalImage.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            grayscaleImage.Save($"{baseName}_grayscale{extension}");
        }
    }
}
