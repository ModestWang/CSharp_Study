using QRCoder;
using System.Drawing;

namespace QR
{
    internal class MyQRCode
    {
        public static void CreateQRCode(string info, string name)
        {
            Image image;
            using (QRCodeGenerator qrGenerator = new())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode
                    (info, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap bitmap = qrCode.GetGraphic
                    (20, Color.Black, Color.White, true);
                image = Image.FromHbitmap(bitmap.GetHbitmap());
                image.Save(filename: @$"../../.././output/{name}.jpg");
            }
            Console.WriteLine($"QRCode: {name} Created Successflly!");
        }
    }
}